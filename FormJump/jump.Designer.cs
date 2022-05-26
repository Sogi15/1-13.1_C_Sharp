
namespace FormJump
{
    partial class jump
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
            this.btn_balfel = new System.Windows.Forms.Button();
            this.btn_jobbfel = new System.Windows.Forms.Button();
            this.btn_jobble = new System.Windows.Forms.Button();
            this.btn_balle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_balfel
            // 
            this.btn_balfel.BackColor = System.Drawing.Color.Teal;
            this.btn_balfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_balfel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_balfel.Location = new System.Drawing.Point(12, 12);
            this.btn_balfel.Name = "btn_balfel";
            this.btn_balfel.Size = new System.Drawing.Size(100, 50);
            this.btn_balfel.TabIndex = 0;
            this.btn_balfel.Text = "Balra Fel";
            this.btn_balfel.UseVisualStyleBackColor = false;
            this.btn_balfel.Click += new System.EventHandler(this.btn_balfel_Click);
            // 
            // btn_jobbfel
            // 
            this.btn_jobbfel.BackColor = System.Drawing.Color.Teal;
            this.btn_jobbfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_jobbfel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_jobbfel.Location = new System.Drawing.Point(688, 12);
            this.btn_jobbfel.Name = "btn_jobbfel";
            this.btn_jobbfel.Size = new System.Drawing.Size(100, 50);
            this.btn_jobbfel.TabIndex = 1;
            this.btn_jobbfel.Text = "Jobbra Fel";
            this.btn_jobbfel.UseVisualStyleBackColor = false;
            this.btn_jobbfel.Click += new System.EventHandler(this.btn_jobbfel_Click);
            // 
            // btn_jobble
            // 
            this.btn_jobble.BackColor = System.Drawing.Color.Teal;
            this.btn_jobble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_jobble.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_jobble.Location = new System.Drawing.Point(688, 388);
            this.btn_jobble.Name = "btn_jobble";
            this.btn_jobble.Size = new System.Drawing.Size(100, 50);
            this.btn_jobble.TabIndex = 2;
            this.btn_jobble.Text = "Jobbra Le";
            this.btn_jobble.UseVisualStyleBackColor = false;
            this.btn_jobble.Click += new System.EventHandler(this.btn_jobble_Click);
            // 
            // btn_balle
            // 
            this.btn_balle.BackColor = System.Drawing.Color.Teal;
            this.btn_balle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_balle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_balle.Location = new System.Drawing.Point(12, 388);
            this.btn_balle.Name = "btn_balle";
            this.btn_balle.Size = new System.Drawing.Size(100, 50);
            this.btn_balle.TabIndex = 3;
            this.btn_balle.Text = "Balra Le";
            this.btn_balle.UseVisualStyleBackColor = false;
            this.btn_balle.Click += new System.EventHandler(this.btn_balle_Click);
            // 
            // jump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_balle);
            this.Controls.Add(this.btn_jobble);
            this.Controls.Add(this.btn_jobbfel);
            this.Controls.Add(this.btn_balfel);
            this.Name = "jump";
            this.Text = "FormJump (A Form a sarkokba ugrik)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_balfel;
        private System.Windows.Forms.Button btn_jobbfel;
        private System.Windows.Forms.Button btn_jobble;
        private System.Windows.Forms.Button btn_balle;
    }
}

