using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParticleNetwork1
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(255, 30, 30, 30);
            ForeColor = Color.White;
            buttonOK.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void Width_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                buttonOK.PerformClick();
        }
    }
}