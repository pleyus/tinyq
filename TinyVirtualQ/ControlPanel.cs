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
            BlackScreen = new Form2();
        }

        public Form2 BlackScreen;

        private void UpdateScreens(object sender, EventArgs e)
        {
            combo_screens.Items.Clear();
            if(Screen.AllScreens.Length > 1)
            {
                combo_screens.Items.Add("(Selecciona)");
            }
            else
            {
                combo_screens.Items.Add("(No hay pantallas)");
                combo_screens.Enabled = false;
                return;
            }

            foreach (Screen s in Screen.AllScreens)
                if( !s.Primary )
                    combo_screens.Items.Add(s.DeviceName);

        }
    }
}
