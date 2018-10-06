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
    public partial class Logos : Form
    {
        public Logos()
        {
            InitializeComponent();
            SizeChanged += Ajustar;
        }

        public void Ajustar(object sender = null, EventArgs e = null)
        {
            int x = (Width / 2) - 120;
            int y = (Height / 2) - 100;
            logo.Location = new Point(x, y);
        }
    }
}
