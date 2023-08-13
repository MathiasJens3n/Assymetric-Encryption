namespace RSAReciever
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
            publicDataGroupBox = new GroupBox();
            modulusTextBox = new TextBox();
            modulusLabel = new Label();
            exponentTextBox = new TextBox();
            exponentLabel = new Label();
            privateDataGroupBox = new GroupBox();
            qLabel = new Label();
            pLabel = new Label();
            inverseQLabel = new Label();
            dqLabel = new Label();
            qTextBox = new TextBox();
            pTextBox = new TextBox();
            inverseQTextBox = new TextBox();
            dqTextBox = new TextBox();
            dpTextBox = new TextBox();
            dpLabel = new Label();
            dTextBox = new TextBox();
            dLabel = new Label();
            cipherBytesTextBox = new TextBox();
            decryptedTextBox = new TextBox();
            cipherBytesLabel = new Label();
            decryptedLabel = new Label();
            decryptButton = new Button();
            encryptButton = new Button();
            publicDataGroupBox.SuspendLayout();
            privateDataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // publicDataGroupBox
            // 
            publicDataGroupBox.Controls.Add(modulusTextBox);
            publicDataGroupBox.Controls.Add(modulusLabel);
            publicDataGroupBox.Controls.Add(exponentTextBox);
            publicDataGroupBox.Controls.Add(exponentLabel);
            publicDataGroupBox.Location = new Point(12, 12);
            publicDataGroupBox.Name = "publicDataGroupBox";
            publicDataGroupBox.Size = new Size(458, 113);
            publicDataGroupBox.TabIndex = 0;
            publicDataGroupBox.TabStop = false;
            publicDataGroupBox.Text = "Public Data";
            // 
            // modulusTextBox
            // 
            modulusTextBox.Location = new Point(100, 71);
            modulusTextBox.Name = "modulusTextBox";
            modulusTextBox.Size = new Size(352, 27);
            modulusTextBox.TabIndex = 4;
            // 
            // modulusLabel
            // 
            modulusLabel.AutoSize = true;
            modulusLabel.Location = new Point(6, 74);
            modulusLabel.Name = "modulusLabel";
            modulusLabel.Size = new Size(69, 20);
            modulusLabel.TabIndex = 3;
            modulusLabel.Text = "Modulus:";
            // 
            // exponentTextBox
            // 
            exponentTextBox.Location = new Point(100, 33);
            exponentTextBox.Name = "exponentTextBox";
            exponentTextBox.Size = new Size(352, 27);
            exponentTextBox.TabIndex = 2;
            // 
            // exponentLabel
            // 
            exponentLabel.AutoSize = true;
            exponentLabel.Location = new Point(6, 36);
            exponentLabel.Name = "exponentLabel";
            exponentLabel.Size = new Size(74, 20);
            exponentLabel.TabIndex = 1;
            exponentLabel.Text = "Exponent:";
            // 
            // privateDataGroupBox
            // 
            privateDataGroupBox.Controls.Add(qLabel);
            privateDataGroupBox.Controls.Add(pLabel);
            privateDataGroupBox.Controls.Add(inverseQLabel);
            privateDataGroupBox.Controls.Add(dqLabel);
            privateDataGroupBox.Controls.Add(qTextBox);
            privateDataGroupBox.Controls.Add(pTextBox);
            privateDataGroupBox.Controls.Add(inverseQTextBox);
            privateDataGroupBox.Controls.Add(dqTextBox);
            privateDataGroupBox.Controls.Add(dpTextBox);
            privateDataGroupBox.Controls.Add(dpLabel);
            privateDataGroupBox.Controls.Add(dTextBox);
            privateDataGroupBox.Controls.Add(dLabel);
            privateDataGroupBox.Location = new Point(12, 131);
            privateDataGroupBox.Name = "privateDataGroupBox";
            privateDataGroupBox.Size = new Size(458, 284);
            privateDataGroupBox.TabIndex = 1;
            privateDataGroupBox.TabStop = false;
            privateDataGroupBox.Text = "Private Data";
            // 
            // qLabel
            // 
            qLabel.AutoSize = true;
            qLabel.Location = new Point(6, 246);
            qLabel.Name = "qLabel";
            qLabel.Size = new Size(23, 20);
            qLabel.TabIndex = 12;
            qLabel.Text = "Q:";
            // 
            // pLabel
            // 
            pLabel.AutoSize = true;
            pLabel.Location = new Point(6, 197);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(20, 20);
            pLabel.TabIndex = 11;
            pLabel.Text = "P:";
            // 
            // inverseQLabel
            // 
            inverseQLabel.AutoSize = true;
            inverseQLabel.Location = new Point(6, 155);
            inverseQLabel.Name = "inverseQLabel";
            inverseQLabel.Size = new Size(73, 20);
            inverseQLabel.TabIndex = 10;
            inverseQLabel.Text = "Inverse Q:";
            // 
            // dqLabel
            // 
            dqLabel.AutoSize = true;
            dqLabel.Location = new Point(6, 113);
            dqLabel.Name = "dqLabel";
            dqLabel.Size = new Size(34, 20);
            dqLabel.TabIndex = 9;
            dqLabel.Text = "DQ:";
            // 
            // qTextBox
            // 
            qTextBox.Location = new Point(100, 246);
            qTextBox.Name = "qTextBox";
            qTextBox.Size = new Size(352, 27);
            qTextBox.TabIndex = 8;
            // 
            // pTextBox
            // 
            pTextBox.Location = new Point(100, 197);
            pTextBox.Name = "pTextBox";
            pTextBox.Size = new Size(352, 27);
            pTextBox.TabIndex = 7;
            // 
            // inverseQTextBox
            // 
            inverseQTextBox.Location = new Point(100, 155);
            inverseQTextBox.Name = "inverseQTextBox";
            inverseQTextBox.Size = new Size(352, 27);
            inverseQTextBox.TabIndex = 6;
            // 
            // dqTextBox
            // 
            dqTextBox.Location = new Point(100, 113);
            dqTextBox.Name = "dqTextBox";
            dqTextBox.Size = new Size(352, 27);
            dqTextBox.TabIndex = 5;
            // 
            // dpTextBox
            // 
            dpTextBox.Location = new Point(100, 71);
            dpTextBox.Name = "dpTextBox";
            dpTextBox.Size = new Size(352, 27);
            dpTextBox.TabIndex = 4;
            // 
            // dpLabel
            // 
            dpLabel.AutoSize = true;
            dpLabel.Location = new Point(6, 74);
            dpLabel.Name = "dpLabel";
            dpLabel.Size = new Size(31, 20);
            dpLabel.TabIndex = 3;
            dpLabel.Text = "DP:";
            // 
            // dTextBox
            // 
            dTextBox.Location = new Point(100, 33);
            dTextBox.Name = "dTextBox";
            dTextBox.Size = new Size(352, 27);
            dTextBox.TabIndex = 2;
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new Point(6, 36);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(23, 20);
            dLabel.TabIndex = 1;
            dLabel.Text = "D:";
            // 
            // cipherBytesTextBox
            // 
            cipherBytesTextBox.Location = new Point(112, 430);
            cipherBytesTextBox.Name = "cipherBytesTextBox";
            cipherBytesTextBox.Size = new Size(352, 27);
            cipherBytesTextBox.TabIndex = 13;
            // 
            // decryptedTextBox
            // 
            decryptedTextBox.Location = new Point(112, 518);
            decryptedTextBox.Name = "decryptedTextBox";
            decryptedTextBox.Size = new Size(352, 27);
            decryptedTextBox.TabIndex = 14;
            // 
            // cipherBytesLabel
            // 
            cipherBytesLabel.AutoSize = true;
            cipherBytesLabel.Location = new Point(18, 433);
            cipherBytesLabel.Name = "cipherBytesLabel";
            cipherBytesLabel.Size = new Size(94, 20);
            cipherBytesLabel.TabIndex = 15;
            cipherBytesLabel.Text = "Cipher Bytes:";
            // 
            // decryptedLabel
            // 
            decryptedLabel.AutoSize = true;
            decryptedLabel.Location = new Point(18, 521);
            decryptedLabel.Name = "decryptedLabel";
            decryptedLabel.Size = new Size(81, 20);
            decryptedLabel.TabIndex = 16;
            decryptedLabel.Text = "Decrypted:";
            // 
            // decryptButton
            // 
            decryptButton.Location = new Point(219, 473);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(94, 29);
            decryptButton.TabIndex = 17;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += DecryptButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 574);
            Controls.Add(encryptButton);
            Controls.Add(decryptButton);
            Controls.Add(decryptedLabel);
            Controls.Add(cipherBytesLabel);
            Controls.Add(decryptedTextBox);
            Controls.Add(cipherBytesTextBox);
            Controls.Add(privateDataGroupBox);
            Controls.Add(publicDataGroupBox);
            Name = "Form1";
            Text = "Form1";
            publicDataGroupBox.ResumeLayout(false);
            publicDataGroupBox.PerformLayout();
            privateDataGroupBox.ResumeLayout(false);
            privateDataGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox publicDataGroupBox;
        private TextBox modulusTextBox;
        private Label modulusLabel;
        private TextBox exponentTextBox;
        private Label exponentLabel;
        private GroupBox privateDataGroupBox;
        private TextBox dpTextBox;
        private Label dpLabel;
        private TextBox dTextBox;
        private Label dLabel;
        private Label qLabel;
        private Label pLabel;
        private Label inverseQLabel;
        private Label dqLabel;
        private TextBox qTextBox;
        private TextBox pTextBox;
        private TextBox inverseQTextBox;
        private TextBox dqTextBox;
        private TextBox cipherBytesTextBox;
        private TextBox decryptedTextBox;
        private Label cipherBytesLabel;
        private Label decryptedLabel;
        private Button decryptButton;
        private Button encryptButton;
    }
}