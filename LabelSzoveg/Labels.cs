using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelSzoveg
{
    public partial class Labels : Form
    {
        public Labels()
        {
            InitializeComponent();
        }

        private void Labels_Load(object sender, EventArgs e)
        {
            lbl_full.Text = "Kattints a képernyőn valahova";
        }

        private void lbl_full_Click(object sender, EventArgs e)
        {

        }

        private void lbl_full_MouseClick(object sender, MouseEventArgs e)
        {
            // Hanyadik oszlopba kattintottunk
            int o = (int)e.X / (lbl_full.Width / 3);
            // Hanyadik sorba kattintottunk
            int s = (int)e.Y / (lbl_full.Height / 3);
            switch (s * 3 + o)
            {
                case 0: lbl_full.TextAlign = ContentAlignment.TopLeft; break;
                case 1: lbl_full.TextAlign = ContentAlignment.TopCenter; break;
                case 2: lbl_full.TextAlign = ContentAlignment.TopRight; break;
                case 3: lbl_full.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: lbl_full.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: lbl_full.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: lbl_full.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: lbl_full.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: lbl_full.TextAlign = ContentAlignment.BottomRight; break;
            }
        }
    }
}
