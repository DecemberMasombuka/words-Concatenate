namespace words_Concatenate
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
            txtNewWord = new TextBox();
            btnAdd = new Button();
            cboWord1 = new ComboBox();
            label1 = new Label();
            cboWord2 = new ComboBox();
            btnConcatenate = new Button();
            rbRemove2 = new RadioButton();
            rbRemove1 = new RadioButton();
            label3 = new Label();
            lblConcatenatedWord = new Label();
            SuspendLayout();
            // 
            // txtNewWord
            // 
            txtNewWord.Location = new Point(147, 52);
            txtNewWord.Name = "txtNewWord";
            txtNewWord.Size = new Size(370, 31);
            txtNewWord.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(215, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(214, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add  a word";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // cboWord1
            // 
            cboWord1.FormattingEnabled = true;
            cboWord1.Location = new Point(22, 234);
            cboWord1.Name = "cboWord1";
            cboWord1.Size = new Size(182, 33);
            cboWord1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter a new word";
            label1.Click += label1_Click;
            // 
            // cboWord2
            // 
            cboWord2.FormattingEnabled = true;
            cboWord2.Location = new Point(464, 237);
            cboWord2.Name = "cboWord2";
            cboWord2.Size = new Size(182, 33);
            cboWord2.TabIndex = 5;
            // 
            // btnConcatenate
            // 
            btnConcatenate.Location = new Point(227, 350);
            btnConcatenate.Name = "btnConcatenate";
            btnConcatenate.Size = new Size(178, 34);
            btnConcatenate.TabIndex = 6;
            btnConcatenate.Text = "Concatenate";
            btnConcatenate.UseVisualStyleBackColor = true;
            btnConcatenate.Click += button2_Click;
            // 
            // rbRemove2
            // 
            rbRemove2.AutoSize = true;
            rbRemove2.Location = new Point(464, 300);
            rbRemove2.Name = "rbRemove2";
            rbRemove2.Size = new Size(101, 29);
            rbRemove2.TabIndex = 7;
            rbRemove2.TabStop = true;
            rbRemove2.Text = "Remove";
            rbRemove2.UseVisualStyleBackColor = true;
            // 
            // rbRemove1
            // 
            rbRemove1.AutoSize = true;
            rbRemove1.Location = new Point(22, 300);
            rbRemove1.Name = "rbRemove1";
            rbRemove1.Size = new Size(101, 29);
            rbRemove1.TabIndex = 8;
            rbRemove1.TabStop = true;
            rbRemove1.Text = "Remove";
            rbRemove1.UseVisualStyleBackColor = true;
            rbRemove1.CheckedChanged += rbRemove1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 177);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 9;
            label3.Text = "OR";
            // 
            // lblConcatenatedWord
            // 
            lblConcatenatedWord.AutoSize = true;
            lblConcatenatedWord.BorderStyle = BorderStyle.Fixed3D;
            lblConcatenatedWord.Location = new Point(22, 459);
            lblConcatenatedWord.Name = "lblConcatenatedWord";
            lblConcatenatedWord.Size = new Size(624, 27);
            lblConcatenatedWord.TabIndex = 10;
            lblConcatenatedWord.Text = "                                                                                                                          ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 505);
            Controls.Add(lblConcatenatedWord);
            Controls.Add(label3);
            Controls.Add(rbRemove1);
            Controls.Add(rbRemove2);
            Controls.Add(btnConcatenate);
            Controls.Add(cboWord2);
            Controls.Add(label1);
            Controls.Add(cboWord1);
            Controls.Add(btnAdd);
            Controls.Add(txtNewWord);
            Name = "Form1";
            Text = "Words";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewWord;
        private Button btnAdd;
        private ComboBox cboWord1;
        private Label label1;
        private ComboBox cboWord2;
        private Button btnConcatenate;
        private RadioButton rbRemove2;
        private RadioButton rbRemove1;
        private Label label3;
        private Label lblConcatenatedWord;
    }
}