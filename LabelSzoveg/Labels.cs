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
        }
    }
}
