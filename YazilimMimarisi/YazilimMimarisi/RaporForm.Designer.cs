
namespace YazilimMimarisi
{
    partial class RaporForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yazilimMimairsiDataSet = new YazilimMimarisi.YazilimMimairsiDataSet();
            this.yazilimMimairsiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.MailtextBox = new System.Windows.Forms.TextBox();
            this.RaporAlbutton = new System.Windows.Forms.Button();
            this.RezGetirbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.yazilimMimairsiDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 99);
            this.dataGridView1.TabIndex = 0;
            // 
            // yazilimMimairsiDataSet
            // 
            this.yazilimMimairsiDataSet.DataSetName = "YazilimMimairsiDataSet";
            this.yazilimMimairsiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazilimMimairsiDataSetBindingSource
            // 
            this.yazilimMimairsiDataSetBindingSource.DataSource = this.yazilimMimairsiDataSet;
            this.yazilimMimairsiDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervasyon yaptığınız mail adresinizi giriniz:";
            // 
            // MailtextBox
            // 
            this.MailtextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MailtextBox.Location = new System.Drawing.Point(522, 124);
            this.MailtextBox.Name = "MailtextBox";
            this.MailtextBox.Size = new System.Drawing.Size(431, 26);
            this.MailtextBox.TabIndex = 2;
            // 
            // RaporAlbutton
            // 
            this.RaporAlbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RaporAlbutton.Location = new System.Drawing.Point(547, 352);
            this.RaporAlbutton.Name = "RaporAlbutton";
            this.RaporAlbutton.Size = new System.Drawing.Size(186, 65);
            this.RaporAlbutton.TabIndex = 3;
            this.RaporAlbutton.Text = "RAPOR AL";
            this.RaporAlbutton.UseVisualStyleBackColor = false;
            // 
            // RezGetirbutton
            // 
            this.RezGetirbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RezGetirbutton.Location = new System.Drawing.Point(990, 121);
            this.RezGetirbutton.Name = "RezGetirbutton";
            this.RezGetirbutton.Size = new System.Drawing.Size(218, 32);
            this.RezGetirbutton.TabIndex = 4;
            this.RezGetirbutton.Text = "Rezervasyon Bilgilerini Getir";
            this.RezGetirbutton.UseVisualStyleBackColor = false;
            this.RezGetirbutton.Click += new System.EventHandler(this.RezGetirbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(27, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RezGetirbutton);
            this.Controls.Add(this.RaporAlbutton);
            this.Controls.Add(this.MailtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource yazilimMimairsiDataSetBindingSource;
        private YazilimMimairsiDataSet yazilimMimairsiDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MailtextBox;
        private System.Windows.Forms.Button RaporAlbutton;
        private System.Windows.Forms.Button RezGetirbutton;
        private System.Windows.Forms.Button button1;
    }
}