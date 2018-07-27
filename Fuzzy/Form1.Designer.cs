namespace Fuzzy
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
            this.inputTinggi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBerat = new System.Windows.Forms.TextBox();
            this.btnCekKesehatan = new System.Windows.Forms.Button();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTinggi
            // 
            this.inputTinggi.Location = new System.Drawing.Point(21, 166);
            this.inputTinggi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTinggi.Name = "inputTinggi";
            this.inputTinggi.Size = new System.Drawing.Size(117, 22);
            this.inputTinggi.TabIndex = 1;
            this.inputTinggi.TextChanged += new System.EventHandler(this.inputTinggi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Berat Badan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tinggi Badan";
            // 
            // inputBerat
            // 
            this.inputBerat.Location = new System.Drawing.Point(20, 234);
            this.inputBerat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBerat.Name = "inputBerat";
            this.inputBerat.Size = new System.Drawing.Size(117, 22);
            this.inputBerat.TabIndex = 11;
            // 
            // btnCekKesehatan
            // 
            this.btnCekKesehatan.Location = new System.Drawing.Point(21, 288);
            this.btnCekKesehatan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCekKesehatan.Name = "btnCekKesehatan";
            this.btnCekKesehatan.Size = new System.Drawing.Size(119, 32);
            this.btnCekKesehatan.TabIndex = 14;
            this.btnCekKesehatan.Text = "Cek Kesehatan";
            this.btnCekKesehatan.UseVisualStyleBackColor = true;
            this.btnCekKesehatan.Click += new System.EventHandler(this.btnCekKesehatan_Click);
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(231, 123);
            this.textBoxresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxresult.Multiline = true;
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.Size = new System.Drawing.Size(355, 342);
            this.textBoxresult.TabIndex = 15;
            this.textBoxresult.TextChanged += new System.EventHandler(this.textBoxresult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 35);
            this.label1.TabIndex = 40;
            this.label1.Text = "LOGIKA FUZZY -- EVALUASI TINGKAT KESEHATAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxresult);
            this.Controls.Add(this.btnCekKesehatan);
            this.Controls.Add(this.inputBerat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputTinggi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Logika Fuzzy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTinggi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputBerat;
        private System.Windows.Forms.Button btnCekKesehatan;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.Label label1;
    }
}

