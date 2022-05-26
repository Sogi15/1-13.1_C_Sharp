using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeForm
{
    public partial class Date : Form
    {
        int ev = 0, honap = 0, nap = 0, ora = 0, perc = 0, masodperc = 0;

        private void btn_ujcucc_Click(object sender, EventArgs e)
        {
            dtp_naptar.Value = dtp_naptar.Value.AddYears((int)nud_ev.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddMonths((int)nud_honap.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddDays((int)nud_nap.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddHours((int)nud_ora.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddMinutes((int)nud_perc.Value);
            idotfrissit();
            dtp_naptar.Value = dtp_naptar.Value.AddSeconds((int)nud_masodperc.Value);
            lbl_gomb.Text = String.Format("{0}.", dtp_naptar.Value);
        }

        public Date()
        {
            InitializeComponent();
        }

        private void Date_Load(object sender, EventArgs e)
        {
            idotfrissit();
            nud_honap.Maximum = 12 - dtp_naptar.Value.Month;
            nud_nap.Maximum = 31 - dtp_naptar.Value.Day;
            nud_ora.Maximum = 23 - dtp_naptar.Value.Hour;
            nud_perc.Maximum = 59 - dtp_naptar.Value.Minute;
            nud_masodperc.Maximum = 59 - dtp_naptar.Value.Second;
        }

        private void btn_gomb_Click(object sender, EventArgs e)
        {
            ev = Convert.ToInt32(nud_ev.Value + dtp_naptar.Value.Year);
            honap = Convert.ToInt32(nud_honap.Value + dtp_naptar.Value.Month);
            nap = Convert.ToInt32(nud_nap.Value + dtp_naptar.Value.Day);
            ora = Convert.ToInt32(nud_ora.Value + dtp_naptar.Value.Hour);
            perc = Convert.ToInt32(nud_perc.Value + dtp_naptar.Value.Minute);
            masodperc = Convert.ToInt32(nud_masodperc.Value + dtp_naptar.Value.Second);
            idotfrissit();
            lbl_gomb.Text = String.Format("{0}.{1}.{2}. {3}:{4}:{5}", ev,honap,nap,ora,perc,masodperc);
        }
        private void idotfrissit()
        {
            mtb_perces.Text = String.Format("{0}:{1}:{2}", dtp_naptar.Value.Hour, dtp_naptar.Value.Minute, dtp_naptar.Value.Second);
        }
    }
}
