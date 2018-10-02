using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            T = new Timer();
            T.Tick += new EventHandler(T_Tick);
            T.Interval = 100;
            butError.Enabled = false;
            butOk.Enabled = false;
        }
        #region Clases Especiales API

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };
        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
        }

        public class ApiKey
        {
            [DllImport("user32.dll")]
            private static extern short GetAsyncKeyState(Keys Key);

            TextBox Texto = new TextBox();
            int Max = 0;
            Timer CheckKey;

            public ApiKey(TextBox Contenedor)
            {
                Texto = Contenedor;
                CheckKey = new Timer();
                CheckKey.Interval = 10;
                CheckKey.Tick += new EventHandler(CheckKey_Tick);
                Max = 20;
            }
            void CheckKey_Tick(object sender, EventArgs e)
            {
                foreach (Keys K in Enum.GetValues(typeof(Keys)))
                    if (GetAsyncKeyState(K) == -32767)
                    {
                        string Key = Enum.GetName(typeof(Keys), K);
                        Texto.Text += Key;
                    }
            }
            #region Propiedades
            public Boolean Habilitado
            {
                get { return CheckKey.Enabled; }
                set { CheckKey.Enabled = value; }
            }
            public int MaxLengthBuffer
            {
                get { return Max; }
                set { Max = value; }
            }
            #endregion
        }

        #endregion

        int currentTime = 0;
        int maxTime = 5000;
        void T_Tick(object sender, EventArgs e)
        {
            if (currentTime < maxTime)
            {
                currentTime += 100;
                progressBar.Value = percent(currentTime, maxTime);
                f2.progressBar1.Value = percent(currentTime, maxTime);
            }
            else
            {
                T.Enabled = false;
                currentTime = 0;
                butError_Click(null, null);
            }
        }
        int percent(int curr, int max)
        {
            return (curr * 100) / max;
        }
        TextBox MonitoStr = new TextBox();
        Form2 f2;
        Timer T;
        ApiKey Monitor;
        private void ApiCheck(object sender, EventArgs e)
        {
            if (MonitoStr.Text != "")
            {
                switch (MonitoStr.Text)
                {
                    case "Home":
                        if(butNew.Enabled)
                            button4_Click(null, null);
                        break;
                    case "Prior":
                        if (butStart.Enabled)
                        button1_Click(null, null);
                        break;
                    case "PageDown":
                        if(butOk.Enabled)
                            butOk_Click(null, null);
                        break;
                    case "End":
                        if(butError.Enabled)
                            butError_Click(null, null);
                        break;
                    case "ControlKey":
                        button5_Click(null, null);
                        break;
                }
                MonitoStr.Text = "";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MonitoStr.TextChanged += new EventHandler(ApiCheck);
            Monitor = new ApiKey(MonitoStr);
            Monitor.Habilitado = true;
            f2 = new Form2();
            f2.progressBar1.Visible = false;
            f2.picActionImage.Visible = false;
            f2.picClock.Visible = false;
            f2.Owner = this;
            f2.Show();
            butStart.Enabled = false;
            butOk.Enabled = false;
            butError.Enabled = false;
        }

        bool normalBorder = true;
        //Boton de Borde
        private void button5_Click(object sender, EventArgs e)
        {
            f2.FormBorderStyle = (normalBorder ? System.Windows.Forms.FormBorderStyle.None : System.Windows.Forms.FormBorderStyle.Fixed3D);
            normalBorder = !normalBorder;
        }

        //Boton Nuevo
        private void button4_Click(object sender, EventArgs e)
        {
            f2.picActionImage.Image = Resource1.Question;
            f2.progressBar1.Visible = false;
            f2.picClock.Visible = false;
            f2.picActionImage.Visible = true;
            progressBar.Value = 0;
            f2.progressBar1.Value = 0;
            currentTime = 0;
            butStart.Enabled = true;
            butError.Enabled = false;
            butOk.Enabled = false;
            T.Enabled = false;
        }

        //Boton Iniciar
        private void button1_Click(object sender, EventArgs e)
        {
            if (butStart.Text == "Iniciar")
            {
                progressBar.Value = 0;
                f2.progressBar1.Value = 0;
                f2.picClock.Visible = true;
                f2.progressBar1.Visible = true;
                f2.picActionImage.Visible = false;
                butOk.Enabled = false;
                butError.Enabled = false;
                butNew.Enabled = false;
                maxTime = (int)txtTime.Value * 1000;
                T.Enabled = true;
                butStart.Text = "Detener";
            }
            else
            {
                f2.picClock.Visible = false;
                f2.progressBar1.Visible = false;
                f2.picActionImage.Image = Resource1.loading_squares;
                butOk.Enabled = true;
                butError.Enabled = true;
                f2.picActionImage.Visible = true;
                T.Enabled = false;
                currentTime = 0;
                butStart.Text = "Iniciar";
                butStart.Enabled = false;
                butNew.Enabled = false;
            }

        }

        //Boton OK
        private void butOk_Click(object sender, EventArgs e)
        {
            f2.picActionImage.Image = Resource1._OK;
            butNew.Enabled = true;
            butOk.Enabled = false;
            butError.Enabled = false;
            f2.picActionImage.Visible = true;
            f2.picClock.Visible = false;
            f2.progressBar1.Visible = false;
            SoundPlayer sp = new SoundPlayer(Resource1.Ok);
            sp.Play();
        }
        //Boton Error
        private void butError_Click(object sender, EventArgs e)
        {
            f2.picActionImage.Image = Resource1._NO;
            f2.picActionImage.Visible = true;
            butNew.Enabled = true;
            butOk.Enabled = false;
            butError.Enabled = false;
            f2.picClock.Visible = false;
            f2.progressBar1.Visible = false;
            SoundPlayer sp = new SoundPlayer(Resource1.Error);
            sp.Play();
            butStart.Text = "Iniciar";
            progressBar.Value = 0;
            f2.progressBar1.Value = 0;
        }
    }
}
