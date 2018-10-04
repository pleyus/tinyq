using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        public void UpdateImage(object o, EventArgs e)
        {
            if(o == TimerProyector)
            {
                if(LOGO_SCREEN_P.TopMost)
                    pic_screen_proyectar.Image = 
                pic_screen_proyectar.Image = null;
            }
        }
        public Image GetImage(BlackScreen Objeto)
        {
            Bitmap img = new Bitmap(Objeto.Width, Objeto.Height);
            Objeto.DrawToBitmap(img, Objeto.ClientRectangle);
            return img;
        }
        public Image GetImage(Logos Objeto)
        {
            Bitmap img = new Bitmap(Objeto.Width, Objeto.Height);
            Objeto.DrawToBitmap(img, Objeto.ClientRectangle);
            return img;
        }

        public Timer TimerProyector;

        public BlackScreen BK_SCREEN; // BlackScreen
        public Logos LOGO_SCREEN_P; //  Logos de la proyección
        public Logos LOGO_SCREEN_M; //  Logos del Moderador

        private void UpdateScreens(object sender, EventArgs e)
        {
            ComboBox C = sender == button_update_proyectar
                ? combo_screens_proyectar
                : null;

            C.Items.Clear();
            if(Screen.AllScreens.Length > 0)
                C.Items.Add("(Selecciona)");

            else
            {
                C.Items.Add("(No hay pantallas)");
                C.Enabled = false;
                return;
            }

            foreach (Screen s in Screen.AllScreens)
                //if( !s.Primary )
                    C.Items.Add(s.DeviceName);

            if (C.Items.Count > 0)
                C.SelectedIndex = 0;

        }
        
        private void Proyectar(object o, EventArgs e)
        {
            foreach( Screen S in Screen.AllScreens )
            {
                if( S.DeviceName == combo_screens_proyectar.SelectedItem.ToString() )
                {
                    int x = S.WorkingArea.X;
                    int y = S.WorkingArea.Y;
                    int w = S.WorkingArea.Width;
                    int h = S.WorkingArea.Height;

                    int i = combo_mostrar_proyectar.SelectedIndex;
                    BK_SCREEN.TopMost = false;
                    LOGO_SCREEN_P.TopMost = false;

                    //  Si se va a proyectar el Concurso
                    if(i == 2)
                    {
                        return;
                    }
                    else if( i == 0 )
                    {
                        BK_SCREEN.Width = 200;
                        BK_SCREEN.Height = 400;
                        BK_SCREEN.Location = new Point(x, y);
                        BK_SCREEN.TopMost = true;
                        BK_SCREEN.Show();
                        pic_screen_proyectar.Image = GetImage(BK_SCREEN);
                        return;
                    }
                    else if( i == 1 )
                    {
                        LOGO_SCREEN_P.Width = 500;
                        LOGO_SCREEN_P.Height = 600;
                        LOGO_SCREEN_P.Location = new Point(x, y);
                        LOGO_SCREEN_P.TopMost = true;
                        LOGO_SCREEN_P.Show();
                        LOGO_SCREEN_P.Ajustar();
                        pic_screen_proyectar.Image = GetImage(LOGO_SCREEN_P);
                        return;
                    }
                    else
                        MessageBox.Show(this, "No se que quieres proyectar, algo anda mal",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            MessageBox.Show(this, "No se encontró el dispositivo para enviar la imagen",
                "Pantalla desconocida", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void onLoad(object sender, EventArgs e)
        {
            TimerProyector = new Timer();
            TimerProyector.Interval = 1000;
            TimerProyector.Tick += UpdateImage;

            //  Cargamos las pantallas
            UpdateScreens(button_update_proyectar, null);

            BK_SCREEN = new BlackScreen();
            BK_SCREEN.Show();
            BK_SCREEN.Size = new Size(1, 1);
            BK_SCREEN.Location = new Point(0, 0);
            BK_SCREEN.Hide();

            LOGO_SCREEN_P = new Logos();
            LOGO_SCREEN_P.Show();
            LOGO_SCREEN_P.Size = new Size(1, 1);
            LOGO_SCREEN_P.Location = new Point(0, 0);
            LOGO_SCREEN_P.Hide();
        }

        private void Detener(object sender, EventArgs e)
        {
            if( sender == button_quitar_proyectar)
            {
                BK_SCREEN.TopMost = false;
                BK_SCREEN.Hide();

                LOGO_SCREEN_P.TopMost = false;
                LOGO_SCREEN_P.Hide();

                pic_screen_proyectar.Image = null;
            }
        }
    }
}
