namespace DotnetCoreCryptography
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
            btnAES = new Button();
            txtData = new TextBox();
            label1 = new Label();
            btnEncryptionRsa = new Button();
            SuspendLayout();
            // 
            // btnAES
            // 
            btnAES.Location = new Point(165, 229);
            btnAES.Name = "btnAES";
            btnAES.Size = new Size(202, 34);
            btnAES.TabIndex = 0;
            btnAES.Text = "Encryption with AES";
            btnAES.UseVisualStyleBackColor = true;
            btnAES.Click += btnAES_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(290, 144);
            txtData.Name = "txtData";
            txtData.Size = new Size(479, 31);
            txtData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 144);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 2;
            label1.Text = "Data";
            // 
            // btnEncryptionRsa
            // 
            btnEncryptionRsa.Location = new Point(410, 229);
            btnEncryptionRsa.Name = "btnEncryptionRsa";
            btnEncryptionRsa.Size = new Size(207, 34);
            btnEncryptionRsa.TabIndex = 3;
            btnEncryptionRsa.Text = "Encryption with RSA";
            btnEncryptionRsa.UseVisualStyleBackColor = true;
            btnEncryptionRsa.Click += btnEncryptionRsa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 450);
            Controls.Add(btnEncryptionRsa);
            Controls.Add(label1);
            Controls.Add(txtData);
            Controls.Add(btnAES);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAES;
        private TextBox txtData;
        private Label label1;
        private Button btnEncryptionRsa;
    }
}