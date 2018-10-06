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

        ScreenController PROYECTOR;
        ScreenController MONITOR;

        
        
        public Image GetImage(Logos Objeto)
        {
            Bitmap img = new Bitmap(Objeto.Width, Objeto.Height);
            Objeto.DrawToBitmap(img, Objeto.ClientRectangle);
            return img;
        }

        public Timer TimerProyector;
        
        

        private void onLoad(object sender, EventArgs e)
        {
            PROYECTOR = new ScreenController();
            PROYECTOR.SetComponent(MasterPictureScreen, MasterComboScreens, MasterButtonUpdate);
            PROYECTOR.SetComponent(MasterTextMessage, MasterButtonMessage, MasterButtonClear);
            PROYECTOR.SetMasterSwitches(MasterButtonStatus, MasterButtonLogo, MasterButtonGame);
        }

        private void Detener(object sender, EventArgs e)
        {
            
        }
    }
}
