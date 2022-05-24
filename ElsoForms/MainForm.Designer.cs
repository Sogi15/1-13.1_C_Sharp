
namespace ElsoForms
{
    partial class MainForm
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
            this.btn_oke = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_oke
            // 
            this.btn_oke.BackColor = System.Drawing.Color.White;
            this.btn_oke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_oke.ForeColor = System.Drawing.Color.Black;
            this.btn_oke.Location = new System.Drawing.Point(38, 438);
            this.btn_oke.Name = "btn_oke";
            this.btn_oke.Size = new System.Drawing.Size(140, 30);
            this.btn_oke.TabIndex = 0;
            this.btn_oke.Text = "Ez egy gomb (Oké)";
            this.btn_oke.UseVisualStyleBackColor = false;
            this.btn_oke.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(824, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_oke);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "C# Első Formom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_oke;
        private System.Windows.Forms.Button button1;
    }
}

