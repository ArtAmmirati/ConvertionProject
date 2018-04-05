namespace DecToRom
{
    partial class DecToRom
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
            this.decToRomGroupBox = new System.Windows.Forms.GroupBox();
            this.romToDecRadioButton = new System.Windows.Forms.RadioButton();
            this.decToRomRadioButton = new System.Windows.Forms.RadioButton();
            this.arabicEnterLB = new System.Windows.Forms.Label();
            this.romanEnterLB = new System.Windows.Forms.Label();
            this.convertBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.clearBTN = new System.Windows.Forms.Button();
            this.decToRomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // decToRomGroupBox
            // 
            this.decToRomGroupBox.Controls.Add(this.romToDecRadioButton);
            this.decToRomGroupBox.Controls.Add(this.decToRomRadioButton);
            this.decToRomGroupBox.Location = new System.Drawing.Point(32, 32);
            this.decToRomGroupBox.Name = "decToRomGroupBox";
            this.decToRomGroupBox.Size = new System.Drawing.Size(253, 105);
            this.decToRomGroupBox.TabIndex = 0;
            this.decToRomGroupBox.TabStop = false;
            this.decToRomGroupBox.Text = "Select Conversion Type";
            // 
            // romToDecRadioButton
            // 
            this.romToDecRadioButton.AutoSize = true;
            this.romToDecRadioButton.Location = new System.Drawing.Point(17, 65);
            this.romToDecRadioButton.Name = "romToDecRadioButton";
            this.romToDecRadioButton.Size = new System.Drawing.Size(199, 17);
            this.romToDecRadioButton.TabIndex = 1;
            this.romToDecRadioButton.TabStop = true;
            this.romToDecRadioButton.Text = "Roman Numerals to Decimal Number";
            this.romToDecRadioButton.UseVisualStyleBackColor = true;
            this.romToDecRadioButton.CheckedChanged += new System.EventHandler(this.romToDecRadioButton_CheckedChanged);
            // 
            // decToRomRadioButton
            // 
            this.decToRomRadioButton.AutoSize = true;
            this.decToRomRadioButton.Location = new System.Drawing.Point(17, 19);
            this.decToRomRadioButton.Name = "decToRomRadioButton";
            this.decToRomRadioButton.Size = new System.Drawing.Size(199, 17);
            this.decToRomRadioButton.TabIndex = 0;
            this.decToRomRadioButton.TabStop = true;
            this.decToRomRadioButton.Text = "Decimal Number to Roman Numerals";
            this.decToRomRadioButton.UseVisualStyleBackColor = true;
            this.decToRomRadioButton.CheckedChanged += new System.EventHandler(this.decToRomRadioButton_CheckedChanged);
            // 
            // arabicEnterLB
            // 
            this.arabicEnterLB.AutoSize = true;
            this.arabicEnterLB.Location = new System.Drawing.Point(29, 156);
            this.arabicEnterLB.Name = "arabicEnterLB";
            this.arabicEnterLB.Size = new System.Drawing.Size(180, 13);
            this.arabicEnterLB.TabIndex = 3;
            this.arabicEnterLB.Text = "Enter a number between 1 and 3999";
            // 
            // romanEnterLB
            // 
            this.romanEnterLB.AutoSize = true;
            this.romanEnterLB.Location = new System.Drawing.Point(29, 234);
            this.romanEnterLB.Name = "romanEnterLB";
            this.romanEnterLB.Size = new System.Drawing.Size(136, 13);
            this.romanEnterLB.TabIndex = 4;
            this.romanEnterLB.Text = "Roman Numeral Equivalent";
            this.romanEnterLB.Click += new System.EventHandler(this.romanEnterLB_Click);
            // 
            // convertBTN
            // 
            this.convertBTN.Location = new System.Drawing.Point(32, 324);
            this.convertBTN.Name = "convertBTN";
            this.convertBTN.Size = new System.Drawing.Size(75, 23);
            this.convertBTN.TabIndex = 5;
            this.convertBTN.Text = "Con&vert";
            this.convertBTN.UseVisualStyleBackColor = true;
            this.convertBTN.Click += new System.EventHandler(this.convertBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(210, 324);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.Text = "E&xit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(32, 188);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(253, 20);
            this.inputTextBox.TabIndex = 7;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(32, 267);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(253, 26);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(121, 324);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 9;
            this.clearBTN.Text = "Clear\r\n\r\n";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // DecToRom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 381);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.convertBTN);
            this.Controls.Add(this.romanEnterLB);
            this.Controls.Add(this.arabicEnterLB);
            this.Controls.Add(this.decToRomGroupBox);
            this.Name = "DecToRom";
            this.Text = "Decimal to Roman / Roman to Decimal Converter";
            this.decToRomGroupBox.ResumeLayout(false);
            this.decToRomGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox decToRomGroupBox;
        private System.Windows.Forms.RadioButton romToDecRadioButton;
        private System.Windows.Forms.RadioButton decToRomRadioButton;
        private System.Windows.Forms.Label arabicEnterLB;
        private System.Windows.Forms.Label romanEnterLB;
        private System.Windows.Forms.Button convertBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button clearBTN;
    }
}

