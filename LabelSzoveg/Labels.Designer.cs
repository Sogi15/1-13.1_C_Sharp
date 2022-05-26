
namespace LabelSzoveg
{
    partial class Labels
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
            this.lbl_full = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_full
            // 
            this.lbl_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_full.Location = new System.Drawing.Point(0, 0);
            this.lbl_full.Name = "lbl_full";
            this.lbl_full.Size = new System.Drawing.Size(800, 450);
            this.lbl_full.TabIndex = 0;
            this.lbl_full.Text = "label1";
            this.lbl_full.Click += new System.EventHandler(this.lbl_full_Click);
            this.lbl_full.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_full_MouseClick);
            // 
            // Labels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_full);
            this.Name = "Labels";
            this.Text = "Label Szöveg megadása";
            this.Load += new System.EventHandler(this.Labels_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_full;
    }
}

