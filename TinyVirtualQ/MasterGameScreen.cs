using System;
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
        public MasterGameScreen()
        {
            InitializeComponent();
        }
        Timer T;
        int miliseconds = 0;
        int current_miliseconds = 0;
        int pix = 1;

        public void Put(Question[] Preguntas, Player Jugador)
        {
            //  Si Viene el nombre de la persona lo ponemos
            if (Jugador.Firstname != "")
            {
                LabelName.Visible = PictureUser.Visible = true;

                LabelName.Text = Jugador.Firstname;
                PictureUser.BackgroundImage = File.Exists(Jugador.PictureFilename)
                    ? Image.FromFile(Jugador.PictureFilename)
                    : Resource1.user_base_icon;
            }
            else
            {
                //  Si no, lo ocultamos
                LabelName.Visible = PictureUser.Visible = false;
            }

            // Llenamos la lista de preguntas
            FillList(Preguntas);

            //  Ocultamos el estado
            PictureProgressContainer.Visible = PictureProgressBar.Visible = PictureState.Visible = T.Enabled = false;
        }
        public void FillList(Question[] Preguntas)
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
                    LabelCategory.Text = P.Category;
                }

                ListQuestions.Items.Add(It);
            }

            LabelQuestionsNum.Text = "Preguntas: " + Preguntas.Length;
            LabelCorrectNum.Text = "Aciertos: " + corrects;
        }
        public void Run(int Seconds = 5)
        {
            miliseconds = Seconds * 1000;
            current_miliseconds = 0;
            pix = 590 / (miliseconds / 100);

            //  Reseteamos
            PictureState.Image = Resource1.white_clock;
            PictureProgressBar.Width = 0;

            //  Mostramos el tiempo y empezamos...
            PictureProgressContainer.Visible =
                PictureProgressBar.Visible =
                    PictureState.Visible =
                        T.Enabled = true;
        }
        public void Wait()
        {
            T.Enabled = false;
            PictureState.Image = Resource1.loading;
        }
        public void Wrong()
        {
            T.Enabled = false;
            PictureState.Image = Resource1.wrong;
            SetAnswer(false);
        }
        public void Correct()
        {
            T.Enabled = false;
            PictureState.Image = Resource1.correct;
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
        }
        void Animate(object s, EventArgs e)
        {

            if (current_miliseconds > miliseconds)
                Wrong();
            else
            {
                PictureProgressBar.Width += pix;
                current_miliseconds += T.Interval;
            }

        }
    }
}
