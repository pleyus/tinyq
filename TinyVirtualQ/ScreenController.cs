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
            SlaveGameScreen SLAVE_GAME;
            MasterGameScreen MASTER_GAME;

        Question[] QuestionBank;

        public ScreenController(Question[] QB)
        {
            QuestionBank = QB;
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

            SLAVE_GAME = new SlaveGameScreen(QuestionBank.Length);
            SLAVE_GAME.Show();
            SLAVE_GAME.Size = new Size(1, 1);
            SLAVE_GAME.Location = new Point(0, 0);
            SLAVE_GAME.Hide();

            MASTER_GAME = new MasterGameScreen(QuestionBank.Length);
            MASTER_GAME.Show();
            MASTER_GAME.Size = new Size(1, 1);
            MASTER_GAME.Location = new Point(0, 0);
            MASTER_GAME.Hide();
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
            Message.KeyUp += SendMsg;
        }
        void SendMsg(object o, object e)
        {
            if (o == Message)
                if (((KeyEventArgs)e).KeyCode != Keys.Enter)
                    return;

            if (Message.Text.Trim() != "")
                MASTER_GAME.ShowMessage(Message.Text.Trim());
            else
                ClearMsg(null, null);

            Message.Text = "";
        }
        void ClearMsg(object o, EventArgs e)
        {
            MASTER_GAME.RemoveMessage();
        }

        public void SetMasterSwitches(Button StatusButton, Button LogosButton, Button GameButton)
        {
            if(SwitchBlackScreen != null)
            {
                MessageBox.Show("Este controlador ya ha sido ajustado como Slave, no se puede poner como maestro.", "Conflicto de controladores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SwitchStatusScreen = StatusButton;
            SwitchLogoScreen = LogosButton;
            SwitchGameScreen = GameButton;

            SwitchStatusScreen.Click += Switch;
            SwitchLogoScreen.Click += Switch;
            SwitchGameScreen.Click += Switch;
        }
        public void SetSlaveSwitches(Button BlackScreen, Button LogosButton, Button GameButton)
        {
            if (SwitchStatusScreen != null)
            {
                MessageBox.Show("Este controlador ya ha sido ajustado como Master, no se puede poner como esclavo.", "Conflicto de controladores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SwitchBlackScreen = BlackScreen;
            SwitchLogoScreen = LogosButton;
            SwitchGameScreen = GameButton;

            SwitchBlackScreen.Click += Switch;
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

                    //  Le quitamo a todos el topmost
                    BK_SCREEN.TopMost   = false;
                    LOGO.TopMost        = false;
                    SLAVE_GAME.TopMost  = false;
                    MASTER_GAME.TopMost = false;

                    //  Checamos que va a hacer
                    if (s == SwitchBlackScreen)
                    {
                        BK_SCREEN.Width = w;
                        BK_SCREEN.Height = h;
                        BK_SCREEN.Location = new Point(x, y);
                        BK_SCREEN.TopMost = true;
                        BK_SCREEN.Show();
                        SetImage(BK_SCREEN);
                    }
                    else if (s == SwitchLogoScreen)
                    {
                        LOGO.Width = w;
                        LOGO.Height = h;
                        LOGO.Location = new Point(x, y);
                        LOGO.TopMost = true;
                        LOGO.Show();
                        SetImage(LOGO);
                    }
                    else if (s == SwitchGameScreen)
                    {
                        //  Si no es null, entonces es el esclavo
                        if (SwitchBlackScreen != null)
                        {
                            SLAVE_GAME.Width = w;
                            SLAVE_GAME.Height = h;
                            SLAVE_GAME.Location = new Point(x, y);
                            SLAVE_GAME.TopMost = true;
                            SLAVE_GAME.Show();
                            SetImage(SLAVE_GAME);
                        }
                        //  Si no, es master
                        else
                        {
                            MASTER_GAME.Width = w;
                            MASTER_GAME.Height = h;
                            MASTER_GAME.Location = new Point(x, y);
                            MASTER_GAME.TopMost = true;
                            MASTER_GAME.Show();
                            SetImage(MASTER_GAME);
                        }
                    }

                    else
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
                if (o == MASTER_GAME)
                    MASTER_GAME.DrawToBitmap(img, C.ClientRectangle);
                if (o == SLAVE_GAME)
                    SLAVE_GAME.DrawToBitmap(img, C.ClientRectangle);

                Thumbnail.Image = img;
            }
        }
        public bool IS_READY { get { return MASTER_GAME.IsReady | SLAVE_GAME.IsReady; } }

        public void Run()
        {
            if(MASTER_GAME.IsReady)
                MASTER_GAME.Run();
            if (SLAVE_GAME.IsReady)
                SLAVE_GAME.Run();
        }
        public void Put(Player ThePlayer, Round Round)
        {
            MASTER_GAME.Put(ThePlayer, Round);
            SLAVE_GAME.Put(ThePlayer, Round);
        }
        public void Wait()
        {
            MASTER_GAME.Wait();
            SLAVE_GAME.Wait();
        }
        public void Correct()
        {
            MASTER_GAME.Correct();
            SLAVE_GAME.Correct();
        }
        public void Wrong()
        {
            MASTER_GAME.Wrong();
            SLAVE_GAME.Wrong();
        }
    }
}
