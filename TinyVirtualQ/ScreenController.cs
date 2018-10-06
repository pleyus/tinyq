using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace TinyVirtualQ
{
    class ScreenController
    {
        //  Elementos de selección de pantalla
            PictureBox Thumbnail;
            ComboBox ScreenSelection;
            Button UpdateButton;

        //  Botones de acción
        Button SwitchBlackScreen;    // Solo para slave
        Button SwitchStatusScreen;   // Solo para master
        Button SwitchLogoScreen;
        Button SwitchGameScreen;

        //  Elementos del envio de mensaje
            TextBox Message;
            Button SendMessage;
            Button ClearMessage;

        //  Formularios de pantalla
        BlackScreen BK_SCREEN;
        Logos LOGO;

        public ScreenController()
        {
            InitScreenForms();
        }

        void InitScreenForms()
        {
            BK_SCREEN = new BlackScreen();
            BK_SCREEN.Show();
            BK_SCREEN.Size = new Size(1, 1);
            BK_SCREEN.Location = new Point(0, 0);
            BK_SCREEN.Hide();

            LOGO = new Logos();
            LOGO.Show();
            LOGO.Size = new Size(1, 1);
            LOGO.Location = new Point(0, 0);
            LOGO.Hide();
        }

        /// <summary>
        /// Screen Selection Component
        /// </summary>
        /// <param name="thumbnail">Caja de imagen en donde se pondrá la vista previa del elemento que se esta mostrando</param>
        /// <param name="screenSelection">Lista en la cual se ponen las pantallas disponibles</param>
        /// <param name="updateButton">Boton para actualizar la lista de pantallas</param>
        public void SetComponent(PictureBox thumbnail, ComboBox screenSelection, Button updateButton)
        {
            Thumbnail = thumbnail;
            ScreenSelection = screenSelection;
            UpdateButton = updateButton;

            UpdateButton.Click += UpdateScreens;

            UpdateScreens();
        }
        private void UpdateScreens(object sender = null, EventArgs e = null)
        {
            ScreenSelection.Items.Clear();

            if (Screen.AllScreens.Length < 1)
            {
                ScreenSelection.Items.Add("(No hay pantallas)");
                ScreenSelection.Enabled = false;
                return;
            }

            foreach (Screen s in Screen.AllScreens)
                if (!s.Primary)
                    ScreenSelection.Items.Add(s.DeviceName);

            if (ScreenSelection.Items.Count > 0)
                ScreenSelection.SelectedIndex = 0;

        }

        /// <summary>
        /// Screen Message Sender
        /// </summary>
        /// <param name="message">El textbox en el cual estará el mensaje</param>
        /// <param name="sendMessage">Boton para enviar mensaje</param>
        /// <param name="clearMessage">Boton para eliminar el mensaje</param>
        public void SetComponent(TextBox message, Button sendMessage, Button clearMessage)
        {
            Message = message;
            SendMessage = sendMessage;
            ClearMessage = clearMessage;

            SendMessage.Click += SendMsg;
            ClearMessage.Click += ClearMsg;
        }
        void SendMsg(object o, EventArgs e)
        {

        }
        void ClearMsg(object o, EventArgs e)
        {

        }

        public void SetMasterSwitches(Button StatusButton, Button LogosButton, Button GameButton)
        {
            SwitchStatusScreen = StatusButton;
            SwitchLogoScreen = LogosButton;
            SwitchGameScreen = GameButton;

            SwitchStatusScreen.Click += Switch;
            SwitchLogoScreen.Click += Switch;
            SwitchGameScreen.Click += Switch;
        }
        void Switch(object s, EventArgs e)
        {
            foreach (Screen S in Screen.AllScreens)
            {
                if (S.DeviceName == ScreenSelection.Text)
                {
                    int x = S.WorkingArea.X;
                    int y = S.WorkingArea.Y;
                    int w = S.Bounds.Width;
                    int h = S.Bounds.Height;

                    int i = -1;

                    if (s == SwitchBlackScreen)
                        i = 0;
                    if (s == SwitchLogoScreen)
                        i = 1;

                    if (!SetItemOnScreen(i, x, y, w, h))
                        MessageBox.Show("No se que quieres proyectar, algo anda mal",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("No se encontró el dispositivo para enviar la imagen",
                "Pantalla desconocida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        Bitmap img;
        void SetImage(object o)
        {
            if (o == BK_SCREEN)
                Thumbnail.Image = null;
            else
            {
                Control C = ((Control)o);
                img = new Bitmap(C.Width, C.Height);

                if (o == LOGO)
                    LOGO.DrawToBitmap(img, C.ClientRectangle);

                Thumbnail.Image = img;
            }
        }

        bool SetItemOnScreen(int index, int x, int y, int w, int h)
        {
            bool ret = false;
            //  Le quitamo a todos el topmost
            BK_SCREEN.TopMost = false;
            LOGO.TopMost = false;

            switch(index)
            {
                case 0:
                    BK_SCREEN.Width = w;
                    BK_SCREEN.Height = h;
                    BK_SCREEN.Location = new Point(x, y);
                    BK_SCREEN.TopMost = true;
                    BK_SCREEN.Show();
                    SetImage(BK_SCREEN);
                    ret = true;
                    break;
                    
                case 1:
                    LOGO.Width = w;
                    LOGO.Height = h;
                    LOGO.Location = new Point(x, y);
                    LOGO.TopMost = true;
                    LOGO.Show();
                    SetImage(LOGO);
                    ret = true;
                    break;
            }
            return ret;
                
        }

    }
}
