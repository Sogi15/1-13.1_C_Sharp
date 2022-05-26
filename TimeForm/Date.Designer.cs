
namespace TimeForm
{
    partial class Date
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_naptar = new System.Windows.Forms.DateTimePicker();
            this.mtb_perces = new System.Windows.Forms.MaskedTextBox();
            this.btn_gomb = new System.Windows.Forms.Button();
            this.lbl_gomb = new System.Windows.Forms.Label();
            this.nud_ev = new System.Windows.Forms.NumericUpDown();
            this.nud_honap = new System.Windows.Forms.NumericUpDown();
            this.nud_nap = new System.Windows.Forms.NumericUpDown();
            this.nud_masodperc = new System.Windows.Forms.NumericUpDown();
            this.nud_perc = new System.Windows.Forms.NumericUpDown();
            this.nud_ora = new System.Windows.Forms.NumericUpDown();
            this.btn_ujcucc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_honap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_masodperc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_perc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ora)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_naptar
            // 
            this.dtp_naptar.Location = new System.Drawing.Point(84, 51);
            this.dtp_naptar.Name = "dtp_naptar";
            this.dtp_naptar.Size = new System.Drawing.Size(200, 20);
            this.dtp_naptar.TabIndex = 0;
            this.dtp_naptar.Value = new System.DateTime(2022, 5, 26, 11, 25, 55, 0);
            // 
            // mtb_perces
            // 
            this.mtb_perces.Location = new System.Drawing.Point(301, 51);
            this.mtb_perces.Name = "mtb_perces";
            this.mtb_perces.Size = new System.Drawing.Size(100, 20);
            this.mtb_perces.TabIndex = 1;
            // 
            // btn_gomb
            // 
            this.btn_gomb.Location = new System.Drawing.Point(84, 176);
            this.btn_gomb.Name = "btn_gomb";
            this.btn_gomb.Size = new System.Drawing.Size(179, 66);
            this.btn_gomb.TabIndex = 2;
            this.btn_gomb.Text = "button1";
            this.btn_gomb.UseVisualStyleBackColor = true;
            this.btn_gomb.Click += new System.EventHandler(this.btn_gomb_Click);
            // 
            // lbl_gomb
            // 
            this.lbl_gomb.AutoSize = true;
            this.lbl_gomb.Location = new System.Drawing.Point(84, 283);
            this.lbl_gomb.Name = "lbl_gomb";
            this.lbl_gomb.Size = new System.Drawing.Size(35, 13);
            this.lbl_gomb.TabIndex = 3;
            this.lbl_gomb.Text = "label1";
            // 
            // nud_ev
            // 
            this.nud_ev.Location = new System.Drawing.Point(84, 106);
            this.nud_ev.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_ev.Name = "nud_ev";
            this.nud_ev.Size = new System.Drawing.Size(39, 20);
            this.nud_ev.TabIndex = 4;
            // 
            // nud_honap
            // 
            this.nud_honap.Location = new System.Drawing.Point(140, 106);
            this.nud_honap.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_honap.Name = "nud_honap";
            this.nud_honap.Size = new System.Drawing.Size(39, 20);
            this.nud_honap.TabIndex = 6;
            // 
            // nud_nap
            // 
            this.nud_nap.Location = new System.Drawing.Point(194, 106);
            this.nud_nap.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud_nap.Name = "nud_nap";
            this.nud_nap.Size = new System.Drawing.Size(39, 20);
            this.nud_nap.TabIndex = 7;
            // 
            // nud_masodperc
            // 
            this.nud_masodperc.Location = new System.Drawing.Point(380, 106);
            this.nud_masodperc.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_masodperc.Name = "nud_masodperc";
            this.nud_masodperc.Size = new System.Drawing.Size(39, 20);
            this.nud_masodperc.TabIndex = 10;
            // 
            // nud_perc
            // 
            this.nud_perc.Location = new System.Drawing.Point(326, 106);
            this.nud_perc.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_perc.Name = "nud_perc";
            this.nud_perc.Size = new System.Drawing.Size(39, 20);
            this.nud_perc.TabIndex = 9;
            // 
            // nud_ora
            // 
            this.nud_ora.Location = new System.Drawing.Point(270, 106);
            this.nud_ora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_ora.Name = "nud_ora";
            this.nud_ora.Size = new System.Drawing.Size(39, 20);
            this.nud_ora.TabIndex = 8;
            // 
            // btn_ujcucc
            // 
            this.btn_ujcucc.Location = new System.Drawing.Point(326, 176);
            this.btn_ujcucc.Name = "btn_ujcucc";
            this.btn_ujcucc.Size = new System.Drawing.Size(172, 66);
            this.btn_ujcucc.TabIndex = 11;
            this.btn_ujcucc.Text = "button2";
            this.btn_ujcucc.UseVisualStyleBackColor = true;
            this.btn_ujcucc.Click += new System.EventHandler(this.btn_ujcucc_Click);
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ujcucc);
            this.Controls.Add(this.nud_masodperc);
            this.Controls.Add(this.nud_perc);
            this.Controls.Add(this.nud_ora);
            this.Controls.Add(this.nud_nap);
            this.Controls.Add(this.nud_honap);
            this.Controls.Add(this.nud_ev);
            this.Controls.Add(this.lbl_gomb);
            this.Controls.Add(this.btn_gomb);
            this.Controls.Add(this.mtb_perces);
            this.Controls.Add(this.dtp_naptar);
            this.Name = "Date";
            this.Text = "Idő Form";
            this.Load += new System.EventHandler(this.Date_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_honap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_masodperc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_perc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_naptar;
        private System.Windows.Forms.MaskedTextBox mtb_perces;
        private System.Windows.Forms.Button btn_gomb;
        private System.Windows.Forms.Label lbl_gomb;
        private System.Windows.Forms.NumericUpDown nud_ev;
        private System.Windows.Forms.NumericUpDown nud_honap;
        private System.Windows.Forms.NumericUpDown nud_nap;
        private System.Windows.Forms.NumericUpDown nud_masodperc;
        private System.Windows.Forms.NumericUpDown nud_perc;
        private System.Windows.Forms.NumericUpDown nud_ora;
        private System.Windows.Forms.Button btn_ujcucc;
    }
}

