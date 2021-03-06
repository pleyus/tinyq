﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public partial class MasterGameScreen : Form
    {
        public MasterGameScreen(int BancoPreguntas)
        {
            InitializeComponent();
            banco_preguntas = BancoPreguntas;
            IsReady = false;
        }
        Round CurrentRound;
        Timer T;
        int miliseconds = 0;
        int current_miliseconds = 0;
        int pix = 1;
        int banco_preguntas = 0;

        public bool IsReady { get; set; }

        public void Put(Player Jugador, Round Round)
        {
            CurrentRound = Round;
            //  Si Viene el nombre de la persona lo ponemos
            if (Jugador.Firstname != "")
            {
                LabelName.Visible = PictureUser.Visible = true;

                LabelName.Text = Jugador.Firstname + " " + Jugador.Lastname;

                string filename = Application.StartupPath + "\\pics\\" + Jugador.PictureFilename;
                PictureUser.BackgroundImage = File.Exists(filename)
                    ? Image.FromFile(filename)
                    : Res.user_base_icon;
            }
            else
            {
                //  Si no, lo ocultamos
                LabelName.Visible = PictureUser.Visible = false;
            }

            // Llenamos la lista de preguntas
            FillList(Jugador.Questions);

            //  Ocultamos el estado
            PictureProgressContainer.Visible = PictureProgressBar.Visible = PictureState.Visible = T.Enabled = false;

            IsReady = true;
        }
        public void FillList(List<Question> Preguntas)
        {
            ListQuestions.Items.Clear();
            int corrects = 0;

            foreach (Question P in Preguntas)
            {
                ListViewItem It = new ListViewItem();

                It.Text = P.Text;
                It.SubItems.Add(P.Category);

                It.SubItems.Add(
                    P.Result == Question.QuestionResult.Correct
                        ? "Correcto"
                        : (P.Result == Question.QuestionResult.Wrong
                            ? "ERROR"
                            : "...")
                );

                //  Como sabemos que la pregunta que no tiene respuesta es la actual, la asignamos
                if(P.Result == Question.QuestionResult.None)
                {
                    LabelQuestion.Text = P.Text;
                    LabelCategory.Text = P.Category.ToUpper();
                    LabelAnswer.Text = P.Answer;
                }

                ListQuestions.Items.Add(It);
            }

            LabelQuestionsNum.Text = "Preguntas: " + Preguntas.Count + " / " + CurrentRound.QuestionsByPlayer;
            LabelCorrectNum.Text = "Aciertos: " + corrects;
        }
        public void Run(int Seconds = 5)
        {
            miliseconds = Seconds * 1000;
            current_miliseconds = 0;
            pix = 590 / (miliseconds / 100);

            //  Reseteamos
            PictureState.Image = Res.white_clock;
            PictureProgressBar.Width = 0;

            //  Mostramos el tiempo y empezamos...
            PictureProgressContainer.Visible =
                PictureProgressBar.Visible =
                    PictureState.Visible =
                        T.Enabled = true;

            IsReady = false;
        }
        public void ShowMessage(string message)
        {
            LabelMessage.Text = message;
            LabelMessage.Visible = true;
        }
        public void RemoveMessage()
        {
            LabelMessage.Text = "";
            LabelMessage.Visible = false;
        }
        public void Wait()
        {
            IsReady = false;
            T.Enabled = false;
            PictureState.Image = Res.loading;
        }
        public void Wrong()
        {
            IsReady = false;
            T.Enabled = false;
            PictureState.Image = Res.wrong;
            SetAnswer(false);
        }
        public void Correct()
        {
            IsReady = false;
            T.Enabled = false;
            PictureState.Image = Res.correct;
            SetAnswer(true);
        }
        void SetAnswer(bool correct)
        {
            int c = correct ? 1 : 0;
            for(int i = 0; i < ListQuestions.Items.Count; i++)
            {
                string res = ListQuestions.Items[i].SubItems[2].Text;
                if (res == "...")
                    ListQuestions.Items[i].SubItems[2].Text = correct ? "Correcto" : "ERROR";
                else if (res == "Correcto")
                    c++;
            }
            LabelCorrectNum.Text = "Aciertos: " + c;
        }
        void Init(object sender, EventArgs e)
        {
            T = new Timer();
            T.Interval = 100;
            T.Tick += Animate;

            LabelName.Text = "Jugadores listos.";
            PictureUser.Visible = false;

            LabelQuestionsNum.Text = "Banco: " + banco_preguntas + " preguntas almacenadas";
            LabelCorrectNum.Text = "";

            LabelCategory.Text = "En espera";
            LabelQuestion.Text = "Questy-ON es un sistema desarrollado para gestionar juegos de preguntas y respuestas.";

            LabelMessage.Visible = false;

            PictureProgressContainer.Visible = false;
            PictureProgressBar.Visible = false;
            PictureState.Visible = false;
        }
        void Animate(object s, EventArgs e)
        {

            if (PictureProgressBar.Width > 590)
                Wait();
            else
            {
                PictureProgressBar.Width += pix;
                current_miliseconds += T.Interval;
            }

        }
    }
}
