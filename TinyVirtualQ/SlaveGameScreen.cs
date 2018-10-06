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
        public SlaveGameScreen()
        {
            InitializeComponent();
        }

        Timer T;
        int miliseconds = 0;
        int current_miliseconds = 0;
        int pix = 1;

        public void Put(string Question, string Category, string Name = "", string Picture = "")
        {
            //  Asignamos la pregunta y su categoría
            LabelCategory.Text = Category;
            LabelQuestion.Text = Question;

            //  Si Viene el nombre de la persona lo ponemos
            if(Name != "")
            {
                LabelName.Visible = PictureUser.Visible = true;

                LabelName.Text = Name;
                PictureUser.BackgroundImage = File.Exists(Picture) 
                    ? Image.FromFile(Picture) 
                    : Resource1.user_base_icon;
            }
            else
            {
                //  Si no, lo ocultamos
                LabelName.Visible = PictureUser.Visible = false;
            }

            //  Ocultamos el estado
            PictureProgressContainer.Visible = PictureProgressBar.Visible = PictureState.Visible = T.Enabled = false;
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
        }
        public void Correct()
        {
            T.Enabled = false;
            PictureState.Image = Resource1.correct;
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
