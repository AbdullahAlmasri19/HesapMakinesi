
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonCik = new System.Windows.Forms.Button();
            this.buttonCarp = new System.Windows.Forms.Button();
            this.buttonBol = new System.Windows.Forms.Button();
            this.textBoxSayi2 = new System.Windows.Forms.TextBox();
            this.textBoxSayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonTop
            // 
            this.buttonTop.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTop.Location = new System.Drawing.Point(42, 127);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(89, 35);
            this.buttonTop.TabIndex = 0;
            this.buttonTop.Text = "Topla";
            this.buttonTop.UseVisualStyleBackColor = false;
            this.buttonTop.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCik
            // 
            this.buttonCik.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCik.Location = new System.Drawing.Point(137, 127);
            this.buttonCik.Name = "buttonCik";
            this.buttonCik.Size = new System.Drawing.Size(89, 35);
            this.buttonCik.TabIndex = 1;
            this.buttonCik.Text = "Cikar";
            this.buttonCik.UseVisualStyleBackColor = false;
            this.buttonCik.Click += new System.EventHandler(this.buttonCik_Click);
            // 
            // buttonCarp
            // 
            this.buttonCarp.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCarp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCarp.Location = new System.Drawing.Point(42, 168);
            this.buttonCarp.Name = "buttonCarp";
            this.buttonCarp.Size = new System.Drawing.Size(89, 35);
            this.buttonCarp.TabIndex = 2;
            this.buttonCarp.Text = "Carp";
            this.buttonCarp.UseVisualStyleBackColor = false;
            this.buttonCarp.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBol
            // 
            this.buttonBol.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBol.Location = new System.Drawing.Point(137, 168);
            this.buttonBol.Name = "buttonBol";
            this.buttonBol.Size = new System.Drawing.Size(89, 35);
            this.buttonBol.TabIndex = 3;
            this.buttonBol.Text = "Bol";
            this.buttonBol.UseVisualStyleBackColor = false;
            this.buttonBol.Click += new System.EventHandler(this.buttonBol_Click);
            // 
            // textBoxSayi2
            // 
            this.textBoxSayi2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSayi2.Location = new System.Drawing.Point(103, 82);
            this.textBoxSayi2.Name = "textBoxSayi2";
            this.textBoxSayi2.Size = new System.Drawing.Size(55, 23);
            this.textBoxSayi2.TabIndex = 4;
            this.textBoxSayi2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSayi1
            // 
            this.textBoxSayi1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSayi1.Location = new System.Drawing.Point(42, 82);
            this.textBoxSayi1.Name = "textBoxSayi1";
            this.textBoxSayi1.Size = new System.Drawing.Size(55, 23);
            this.textBoxSayi1.TabIndex = 5;
            this.textBoxSayi1.TextChanged += new System.EventHandler(this.textBoxSayi1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "1.Sayi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "2.Sayi";
            // 
            // textBoxSon
            // 
            this.textBoxSon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSon.Location = new System.Drawing.Point(164, 82);
            this.textBoxSon.Name = "textBoxSon";
            this.textBoxSon.ReadOnly = true;
            this.textBoxSon.Size = new System.Drawing.Size(55, 23);
            this.textBoxSon.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(164, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(265, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSayi1);
            this.Controls.Add(this.textBoxSayi2);
            this.Controls.Add(this.buttonBol);
            this.Controls.Add(this.buttonCarp);
            this.Controls.Add(this.buttonCik);
            this.Controls.Add(this.buttonTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonCik;
        private System.Windows.Forms.Button buttonCarp;
        private System.Windows.Forms.Button buttonBol;
        private System.Windows.Forms.TextBox textBoxSayi2;
        private System.Windows.Forms.TextBox textBoxSayi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

