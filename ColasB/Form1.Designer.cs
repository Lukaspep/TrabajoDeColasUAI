using System;

namespace ColasB
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMujer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxHombre = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolarMujer = new System.Windows.Forms.Button();
            this.btnDesencolarHombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cola Femenina";
            // 
            // listBoxMujer
            // 
            this.listBoxMujer.FormattingEnabled = true;
            this.listBoxMujer.Location = new System.Drawing.Point(12, 41);
            this.listBoxMujer.Name = "listBoxMujer";
            this.listBoxMujer.Size = new System.Drawing.Size(213, 186);
            this.listBoxMujer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cola Masculina";
            // 
            // listBoxHombre
            // 
            this.listBoxHombre.FormattingEnabled = true;
            this.listBoxHombre.Location = new System.Drawing.Point(13, 261);
            this.listBoxHombre.Name = "listBoxHombre";
            this.listBoxHombre.Size = new System.Drawing.Size(212, 186);
            this.listBoxHombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nadadores";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(421, 232);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(93, 31);
            this.btnEncolar.TabIndex = 6;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesencolarMujer
            // 
            this.btnDesencolarMujer.Location = new System.Drawing.Point(266, 135);
            this.btnDesencolarMujer.Name = "btnDesencolarMujer";
            this.btnDesencolarMujer.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolarMujer.TabIndex = 7;
            this.btnDesencolarMujer.Text = "Desencolar";
            this.btnDesencolarMujer.UseVisualStyleBackColor = true;
            this.btnDesencolarMujer.Click += new System.EventHandler(this.btnDesencolarMujer_Click);
            // 
            // btnDesencolarHombre
            // 
            this.btnDesencolarHombre.Location = new System.Drawing.Point(266, 341);
            this.btnDesencolarHombre.Name = "btnDesencolarHombre";
            this.btnDesencolarHombre.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolarHombre.TabIndex = 8;
            this.btnDesencolarHombre.Text = "Desencolar";
            this.btnDesencolarHombre.UseVisualStyleBackColor = true;
            this.btnDesencolarHombre.Click += new System.EventHandler(this.btnDesencolarHombre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesencolarHombre);
            this.Controls.Add(this.btnDesencolarMujer);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxHombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMujer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMujer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxHombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolarMujer;
        private System.Windows.Forms.Button btnDesencolarHombre;
        private EventHandler listBoxHombre_SelectedIndexChanged;
    }
}

