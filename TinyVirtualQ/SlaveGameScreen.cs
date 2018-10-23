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
    public partial class SlaveGameScreen : Form
    {
        public SlaveGameScreen(int banco_preguntas)
        {
            InitializeComponent();
            BancoPreguntas = banco_preguntas;
        }

        Timer T;
        Round CurrentRound;
        int miliseconds = 0;
        int current_miliseconds = 0;
        int pix = 1;
        int BancoPreguntas = 0;
        public bool IsReady { get; set; }

        public void Put(Player Jugador, Round Round, string roundName)
        {
            CurrentRound = Round;
            //  Asignamos la pregunta y su categoría
            LabelCategory.Text = Question.Current(Jugador.Questions).Category.ToUpper();
            LabelQuestion.Text = Question.Current(Jugador.Questions).Text;

            LabelRoundName.Text = roundName;

            //  Si Viene el nombre de la persona lo ponemos
            if(Jugador.Firstname != "")
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

            //  Ocultamos el estado
            PictureProgressContainer.Visible = PictureProgressBar.Visible = PictureState.Visible = T.Enabled = false;

            LabelQuestionN.Text = Round.QuestionsByPlayer + "º pregunta";

            IsReady = true;
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
        public void Wait()
        {
            T.Enabled = false;
            PictureState.Image = Res.loading;
            IsReady = false;
        }
        public void Wrong()
        {
            T.Enabled = false;
            IsReady = false;
            PictureState.Image = Res.wrong;
        }
        public void Correct()
        {
            T.Enabled = false;
            IsReady = false;
            PictureState.Image = Res.correct;
        }

        void Init(object sender, EventArgs e)
        {
            T = new Timer();
            T.Interval = 100;
            T.Tick += Animate;

            LabelName.Visible = 
                PictureUser.Visible = 
                    PictureProgressContainer.Visible = 
                        PictureProgressBar.Visible = 
                            PictureState.Visible = 
                                T.Enabled= false;

            LabelCategory.Text = "En espera...";
            LabelQuestion.Text = "Bienvenido a Questy-ON ¿Estas listo?";

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
