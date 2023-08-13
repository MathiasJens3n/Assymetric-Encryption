namespace RSASender
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
            publicDataGroupContainer = new GroupBox();
            modulusTextBox = new TextBox();
            modulusLabel = new Label();
            exponentLabel = new Label();
            exponentTextBox = new TextBox();
            plainTextBox = new TextBox();
            plaintextLabel = new Label();
            cypherBytesTextBox = new TextBox();
            label1 = new Label();
            encryptButton = new Button();
            publicDataGroupContainer.SuspendLayout();
            SuspendLayout();
            // 
            // publicDataGroupContainer
            // 
            publicDataGroupContainer.Controls.Add(modulusTextBox);
            publicDataGroupContainer.Controls.Add(modulusLabel);
            publicDataGroupContainer.Controls.Add(exponentLabel);
            publicDataGroupContainer.Controls.Add(exponentTextBox);
            publicDataGroupContainer.Location = new Point(12, 23);
            publicDataGroupContainer.Name = "publicDataGroupContainer";
            publicDataGroupContainer.Size = new Size(452, 134);
            publicDataGroupContainer.TabIndex = 0;
            publicDataGroupContainer.TabStop = false;
            publicDataGroupContainer.Text = "Public Data";
            // 
            // modulusTextBox
            // 
            modulusTextBox.Location = new Point(85, 75);
            modulusTextBox.Name = "modulusTextBox";
            modulusTextBox.Size = new Size(361, 27);
            modulusTextBox.TabIndex = 4;
            // 
            // modulusLabel
            // 
            modulusLabel.Location = new Point(6, 78);
            modulusLabel.Name = "modulusLabel";
            modulusLabel.Size = new Size(79, 25);
            modulusLabel.TabIndex = 3;
            modulusLabel.Text = "Modulus:";
            // 
            // exponentLabel
            // 
            exponentLabel.Location = new Point(6, 37);
            exponentLabel.Name = "exponentLabel";
            exponentLabel.Size = new Size(79, 25);
            exponentLabel.TabIndex = 1;
            exponentLabel.Text = "Exponent:";
            // 
            // exponentTextBox
            // 
            exponentTextBox.Location = new Point(73, 35);
            exponentTextBox.Name = "exponentTextBox";
            exponentTextBox.Size = new Size(373, 27);
            exponentTextBox.TabIndex = 2;
            // 
            // plainTextBox
            // 
            plainTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            plainTextBox.Location = new Point(97, 185);
            plainTextBox.Name = "plainTextBox";
            plainTextBox.Size = new Size(367, 27);
            plainTextBox.TabIndex = 5;
            // 
            // plaintextLabel
            // 
            plaintextLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            plaintextLabel.Location = new Point(-1, 188);
            plaintextLabel.Name = "plaintextLabel";
            plaintextLabel.Size = new Size(98, 25);
            plaintextLabel.TabIndex = 6;
            plaintextLabel.Text = "Plain Text:";
            // 
            // cypherBytesTextBox
            // 
            cypherBytesTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cypherBytesTextBox.Location = new Point(97, 269);
            cypherBytesTextBox.Name = "cypherBytesTextBox";
            cypherBytesTextBox.Size = new Size(367, 27);
            cypherBytesTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(-7, 269);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 8;
            label1.Text = "Cypher Bytes:";
            // 
            // encryptButton
            // 
            encryptButton.Location = new Point(207, 234);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(94, 29);
            encryptButton.TabIndex = 9;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += EncryptButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(encryptButton);
            Controls.Add(label1);
            Controls.Add(cypherBytesTextBox);
            Controls.Add(plaintextLabel);
            Controls.Add(plainTextBox);
            Controls.Add(publicDataGroupContainer);
            Name = "Form1";
            Text = "Form1";
            publicDataGroupContainer.ResumeLayout(false);
            publicDataGroupContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox publicDataGroupContainer;
        private Label exponentLabel;
        private TextBox exponentTextBox;
        private TextBox modulusTextBox;
        private Label modulusLabel;
        private TextBox plainTextBox;
        private Label plaintextLabel;
        private TextBox cypherBytesTextBox;
        private Label label1;
        private Button encryptButton;
    }
}