
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
            this.yazilimMimairsiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimMimairsiDataSet = new YazilimMimarisi.YazilimMimairsiDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.MailtextBox = new System.Windows.Forms.TextBox();
            this.RaporAlbutton = new System.Windows.Forms.Button();
            this.RezGetirbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(932, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // yazilimMimairsiDataSetBindingSource
            // 
            this.yazilimMimairsiDataSetBindingSource.DataSource = this.yazilimMimairsiDataSet;
            this.yazilimMimairsiDataSetBindingSource.Position = 0;
            // 
            // yazilimMimairsiDataSet
            // 
            this.yazilimMimairsiDataSet.DataSetName = "YazilimMimairsiDataSet";
            this.yazilimMimairsiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervasyon yaptığınız mail adresinizi giriniz:";
            // 
            // MailtextBox
            // 
            this.MailtextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MailtextBox.Location = new System.Drawing.Point(406, 99);
            this.MailtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MailtextBox.Name = "MailtextBox";
            this.MailtextBox.Size = new System.Drawing.Size(336, 24);
            this.MailtextBox.TabIndex = 2;
            this.MailtextBox.TextChanged += new System.EventHandler(this.MailtextBox_TextChanged);
            // 
            // RaporAlbutton
            // 
            this.RaporAlbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RaporAlbutton.Location = new System.Drawing.Point(124, 406);
            this.RaporAlbutton.Margin = new System.Windows.Forms.Padding(2);
            this.RaporAlbutton.Name = "RaporAlbutton";
            this.RaporAlbutton.Size = new System.Drawing.Size(145, 52);
            this.RaporAlbutton.TabIndex = 3;
            this.RaporAlbutton.Text = "RAPOR XML AL";
            this.RaporAlbutton.UseVisualStyleBackColor = false;
            this.RaporAlbutton.Click += new System.EventHandler(this.RaporAlbutton_Click);
            // 
            // RezGetirbutton
            // 
            this.RezGetirbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RezGetirbutton.Location = new System.Drawing.Point(770, 97);
            this.RezGetirbutton.Margin = new System.Windows.Forms.Padding(2);
            this.RezGetirbutton.Name = "RezGetirbutton";
            this.RezGetirbutton.Size = new System.Drawing.Size(170, 26);
            this.RezGetirbutton.TabIndex = 4;
            this.RezGetirbutton.Text = "Rezervasyon Bilgilerini Getir";
            this.RezGetirbutton.UseVisualStyleBackColor = false;
            this.RezGetirbutton.Click += new System.EventHandler(this.RezGetirbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(21, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "RAPOR JSON AL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(746, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "RAPOR HTML AL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RezGetirbutton);
            this.Controls.Add(this.RaporAlbutton);
            this.Controls.Add(this.MailtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimMimairsiDataSet)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}