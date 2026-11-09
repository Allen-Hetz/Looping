namespace TAH.Looping.UI
{
    partial class frmLooping
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
            lblPhrase = new Label();
            lblNumOfReps = new Label();
            txtNumOfReps = new TextBox();
            txtPhrase = new TextBox();
            lstOutput = new ListBox();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblPhrase
            // 
            lblPhrase.AutoSize = true;
            lblPhrase.Font = new Font("Segoe UI", 12F);
            lblPhrase.Location = new Point(24, 29);
            lblPhrase.Name = "lblPhrase";
            lblPhrase.Size = new Size(57, 21);
            lblPhrase.TabIndex = 0;
            lblPhrase.Text = "Phrase";
            // 
            // lblNumOfReps
            // 
            lblNumOfReps.AutoSize = true;
            lblNumOfReps.Font = new Font("Segoe UI", 12F);
            lblNumOfReps.Location = new Point(24, 79);
            lblNumOfReps.Name = "lblNumOfReps";
            lblNumOfReps.Size = new Size(164, 21);
            lblNumOfReps.TabIndex = 2;
            lblNumOfReps.Text = "Number of repetitions";
            // 
            // txtNumOfReps
            // 
            txtNumOfReps.Font = new Font("Segoe UI", 12F);
            txtNumOfReps.Location = new Point(240, 76);
            txtNumOfReps.Name = "txtNumOfReps";
            txtNumOfReps.Size = new Size(100, 29);
            txtNumOfReps.TabIndex = 3;
            txtNumOfReps.TextChanged += txtNumOfReps_TextChanged;
            // 
            // txtPhrase
            // 
            txtPhrase.Font = new Font("Segoe UI", 12F);
            txtPhrase.Location = new Point(139, 26);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(302, 29);
            txtPhrase.TabIndex = 1;
            txtPhrase.TextChanged += txtPhrase_TextChanged;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Segoe UI", 12F);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(26, 131);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(415, 193);
            lstOutput.TabIndex = 4;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Segoe UI", 12F);
            btnDisplay.Location = new Point(26, 366);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(123, 46);
            btnDisplay.TabIndex = 5;
            btnDisplay.Text = "&Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(172, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 46);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(318, 366);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 46);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLooping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lstOutput);
            Controls.Add(txtPhrase);
            Controls.Add(txtNumOfReps);
            Controls.Add(lblNumOfReps);
            Controls.Add(lblPhrase);
            Name = "frmLooping";
            Text = "Who Me??";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhrase;
        private Label lblNumOfReps;
        private TextBox txtNumOfReps;
        private TextBox txtPhrase;
        private ListBox lstOutput;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnExit;
    }
}
