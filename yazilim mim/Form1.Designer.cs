
namespace yazilim_mim
{
    partial class Form1
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
            this.UcakCadir = new System.Windows.Forms.RadioButton();
            this.OtobusCadir = new System.Windows.Forms.RadioButton();
            this.UcakOtel = new System.Windows.Forms.RadioButton();
            this.OtobusOtel = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UcakCadir
            // 
            this.UcakCadir.AutoSize = true;
            this.UcakCadir.Location = new System.Drawing.Point(634, 244);
            this.UcakCadir.Name = "UcakCadir";
            this.UcakCadir.Size = new System.Drawing.Size(95, 21);
            this.UcakCadir.TabIndex = 0;
            this.UcakCadir.TabStop = true;
            this.UcakCadir.Text = "Uçak-Çadır";
            this.UcakCadir.UseVisualStyleBackColor = true;
            // 
            // OtobusCadir
            // 
            this.OtobusCadir.AutoSize = true;
            this.OtobusCadir.Location = new System.Drawing.Point(426, 244);
            this.OtobusCadir.Name = "OtobusCadir";
            this.OtobusCadir.Size = new System.Drawing.Size(110, 21);
            this.OtobusCadir.TabIndex = 1;
            this.OtobusCadir.TabStop = true;
            this.OtobusCadir.Text = "Otobüs-Çadır";
            this.OtobusCadir.UseVisualStyleBackColor = true;
            this.OtobusCadir.CheckedChanged += new System.EventHandler(this.OtobusCadir_CheckedChanged);
            // 
            // UcakOtel
            // 
            this.UcakOtel.AutoSize = true;
            this.UcakOtel.Location = new System.Drawing.Point(267, 244);
            this.UcakOtel.Name = "UcakOtel";
            this.UcakOtel.Size = new System.Drawing.Size(88, 21);
            this.UcakOtel.TabIndex = 2;
            this.UcakOtel.TabStop = true;
            this.UcakOtel.Text = "Uçak-Otel";
            this.UcakOtel.UseVisualStyleBackColor = true;
            // 
            // OtobusOtel
            // 
            this.OtobusOtel.AutoSize = true;
            this.OtobusOtel.Location = new System.Drawing.Point(126, 244);
            this.OtobusOtel.Name = "OtobusOtel";
            this.OtobusOtel.Size = new System.Drawing.Size(103, 21);
            this.OtobusOtel.TabIndex = 3;
            this.OtobusOtel.TabStop = true;
            this.OtobusOtel.Text = "Otobüs-Otel";
            this.OtobusOtel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OtobusOtel);
            this.Controls.Add(this.UcakOtel);
            this.Controls.Add(this.OtobusCadir);
            this.Controls.Add(this.UcakCadir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton UcakCadir;
        private System.Windows.Forms.RadioButton OtobusCadir;
        private System.Windows.Forms.RadioButton UcakOtel;
        private System.Windows.Forms.RadioButton OtobusOtel;
        private System.Windows.Forms.Button button1;
    }
}

