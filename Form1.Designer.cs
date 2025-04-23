namespace QuestionsForm
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
            this.tbChoice1 = new System.Windows.Forms.TextBox();
            this.tbChoice2 = new System.Windows.Forms.TextBox();
            this.tbChoice4 = new System.Windows.Forms.TextBox();
            this.tbChoice3 = new System.Windows.Forms.TextBox();
            this.pbQuestionPhoto = new System.Windows.Forms.PictureBox();
            this.tbQusetion = new System.Windows.Forms.TextBox();
            this.gbQuestionLevel = new System.Windows.Forms.GroupBox();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.rbBiology = new System.Windows.Forms.RadioButton();
            this.rbChemitry = new System.Windows.Forms.RadioButton();
            this.rbPhysics = new System.Windows.Forms.RadioButton();
            this.rbMath = new System.Windows.Forms.RadioButton();
            this.tbExblanantion = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbRightAnswer = new System.Windows.Forms.GroupBox();
            this.rbRightAnswerD = new System.Windows.Forms.RadioButton();
            this.rbRightAnswerC = new System.Windows.Forms.RadioButton();
            this.rbRightAnswerB = new System.Windows.Forms.RadioButton();
            this.rbRightAnswerA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionPhoto)).BeginInit();
            this.gbQuestionLevel.SuspendLayout();
            this.gbSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gbRightAnswer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbChoice1
            // 
            this.tbChoice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbChoice1.Location = new System.Drawing.Point(356, 359);
            this.tbChoice1.Multiline = true;
            this.tbChoice1.Name = "tbChoice1";
            this.tbChoice1.Size = new System.Drawing.Size(254, 56);
            this.tbChoice1.TabIndex = 0;
            this.tbChoice1.TextChanged += new System.EventHandler(this.tbChoice1_TextChanged);
            // 
            // tbChoice2
            // 
            this.tbChoice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChoice2.Enabled = false;
            this.tbChoice2.Location = new System.Drawing.Point(735, 354);
            this.tbChoice2.Multiline = true;
            this.tbChoice2.Name = "tbChoice2";
            this.tbChoice2.Size = new System.Drawing.Size(254, 56);
            this.tbChoice2.TabIndex = 1;
            this.tbChoice2.TextChanged += new System.EventHandler(this.tbChoice2_TextChanged);
            // 
            // tbChoice4
            // 
            this.tbChoice4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChoice4.Enabled = false;
            this.tbChoice4.Location = new System.Drawing.Point(735, 443);
            this.tbChoice4.Multiline = true;
            this.tbChoice4.Name = "tbChoice4";
            this.tbChoice4.Size = new System.Drawing.Size(254, 56);
            this.tbChoice4.TabIndex = 2;
            this.tbChoice4.TextChanged += new System.EventHandler(this.tbChoice4_TextChanged_1);
            // 
            // tbChoice3
            // 
            this.tbChoice3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbChoice3.Enabled = false;
            this.tbChoice3.Location = new System.Drawing.Point(356, 443);
            this.tbChoice3.Multiline = true;
            this.tbChoice3.Name = "tbChoice3";
            this.tbChoice3.Size = new System.Drawing.Size(254, 56);
            this.tbChoice3.TabIndex = 3;
            this.tbChoice3.TextChanged += new System.EventHandler(this.tbChoice3_TextChanged);
            // 
            // pbQuestionPhoto
            // 
            this.pbQuestionPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQuestionPhoto.BackColor = System.Drawing.Color.Silver;
            this.pbQuestionPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbQuestionPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQuestionPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestionPhoto.Location = new System.Drawing.Point(441, 26);
            this.pbQuestionPhoto.Name = "pbQuestionPhoto";
            this.pbQuestionPhoto.Size = new System.Drawing.Size(528, 247);
            this.pbQuestionPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionPhoto.TabIndex = 4;
            this.pbQuestionPhoto.TabStop = false;
            this.pbQuestionPhoto.Click += new System.EventHandler(this.pbQuestionPhoto_Click);
            // 
            // tbQusetion
            // 
            this.tbQusetion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQusetion.Location = new System.Drawing.Point(521, 279);
            this.tbQusetion.Multiline = true;
            this.tbQusetion.Name = "tbQusetion";
            this.tbQusetion.Size = new System.Drawing.Size(361, 44);
            this.tbQusetion.TabIndex = 5;
            this.tbQusetion.TextChanged += new System.EventHandler(this.tbQusetion_TextChanged);
            // 
            // gbQuestionLevel
            // 
            this.gbQuestionLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuestionLevel.Controls.Add(this.rbHard);
            this.gbQuestionLevel.Controls.Add(this.rbMedium);
            this.gbQuestionLevel.Controls.Add(this.rbEasy);
            this.gbQuestionLevel.Location = new System.Drawing.Point(1110, 40);
            this.gbQuestionLevel.Name = "gbQuestionLevel";
            this.gbQuestionLevel.Size = new System.Drawing.Size(238, 219);
            this.gbQuestionLevel.TabIndex = 6;
            this.gbQuestionLevel.TabStop = false;
            this.gbQuestionLevel.Text = "Question Level";
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(72, 161);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(69, 24);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(72, 104);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(90, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(72, 47);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(69, 24);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.rbBiology);
            this.gbSubject.Controls.Add(this.rbChemitry);
            this.gbSubject.Controls.Add(this.rbPhysics);
            this.gbSubject.Controls.Add(this.rbMath);
            this.gbSubject.Location = new System.Drawing.Point(23, 40);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(238, 219);
            this.gbSubject.TabIndex = 7;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Subject";
            // 
            // rbBiology
            // 
            this.rbBiology.AutoSize = true;
            this.rbBiology.Location = new System.Drawing.Point(42, 172);
            this.rbBiology.Name = "rbBiology";
            this.rbBiology.Size = new System.Drawing.Size(85, 24);
            this.rbBiology.TabIndex = 3;
            this.rbBiology.TabStop = true;
            this.rbBiology.Text = "Biology";
            this.rbBiology.UseVisualStyleBackColor = true;
            // 
            // rbChemitry
            // 
            this.rbChemitry.AutoSize = true;
            this.rbChemitry.Location = new System.Drawing.Point(40, 127);
            this.rbChemitry.Name = "rbChemitry";
            this.rbChemitry.Size = new System.Drawing.Size(104, 24);
            this.rbChemitry.TabIndex = 2;
            this.rbChemitry.TabStop = true;
            this.rbChemitry.Text = "Chemistry";
            this.rbChemitry.UseVisualStyleBackColor = true;
            // 
            // rbPhysics
            // 
            this.rbPhysics.AutoSize = true;
            this.rbPhysics.Location = new System.Drawing.Point(40, 82);
            this.rbPhysics.Name = "rbPhysics";
            this.rbPhysics.Size = new System.Drawing.Size(87, 24);
            this.rbPhysics.TabIndex = 1;
            this.rbPhysics.TabStop = true;
            this.rbPhysics.Text = "Physics";
            this.rbPhysics.UseVisualStyleBackColor = true;
            // 
            // rbMath
            // 
            this.rbMath.AutoSize = true;
            this.rbMath.Location = new System.Drawing.Point(40, 37);
            this.rbMath.Name = "rbMath";
            this.rbMath.Size = new System.Drawing.Size(70, 24);
            this.rbMath.TabIndex = 0;
            this.rbMath.TabStop = true;
            this.rbMath.Text = "Math";
            this.rbMath.UseVisualStyleBackColor = true;
            // 
            // tbExblanantion
            // 
            this.tbExblanantion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbExblanantion.Location = new System.Drawing.Point(13, 25);
            this.tbExblanantion.Multiline = true;
            this.tbExblanantion.Name = "tbExblanantion";
            this.tbExblanantion.Size = new System.Drawing.Size(387, 58);
            this.tbExblanantion.TabIndex = 8;
            // 
            // p
            // 
            this.p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p.BackColor = System.Drawing.Color.Silver;
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p.Location = new System.Drawing.Point(644, 359);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(57, 51);
            this.p.TabIndex = 9;
            this.p.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(644, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 51);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(1023, 359);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 51);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(1023, 448);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 51);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(1140, 600);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(152, 54);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send Question";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbRightAnswer
            // 
            this.gbRightAnswer.Controls.Add(this.rbRightAnswerD);
            this.gbRightAnswer.Controls.Add(this.rbRightAnswerC);
            this.gbRightAnswer.Controls.Add(this.rbRightAnswerB);
            this.gbRightAnswer.Controls.Add(this.rbRightAnswerA);
            this.gbRightAnswer.Location = new System.Drawing.Point(29, 308);
            this.gbRightAnswer.Name = "gbRightAnswer";
            this.gbRightAnswer.Size = new System.Drawing.Size(238, 219);
            this.gbRightAnswer.TabIndex = 7;
            this.gbRightAnswer.TabStop = false;
            this.gbRightAnswer.Text = "RightAnswer";
            // 
            // rbRightAnswerD
            // 
            this.rbRightAnswerD.AutoSize = true;
            this.rbRightAnswerD.Enabled = false;
            this.rbRightAnswerD.Location = new System.Drawing.Point(75, 179);
            this.rbRightAnswerD.Name = "rbRightAnswerD";
            this.rbRightAnswerD.Size = new System.Drawing.Size(46, 24);
            this.rbRightAnswerD.TabIndex = 3;
            this.rbRightAnswerD.TabStop = true;
            this.rbRightAnswerD.Text = "D";
            this.rbRightAnswerD.UseVisualStyleBackColor = true;
            // 
            // rbRightAnswerC
            // 
            this.rbRightAnswerC.AutoSize = true;
            this.rbRightAnswerC.Enabled = false;
            this.rbRightAnswerC.Location = new System.Drawing.Point(76, 135);
            this.rbRightAnswerC.Name = "rbRightAnswerC";
            this.rbRightAnswerC.Size = new System.Drawing.Size(45, 24);
            this.rbRightAnswerC.TabIndex = 2;
            this.rbRightAnswerC.TabStop = true;
            this.rbRightAnswerC.Text = "C";
            this.rbRightAnswerC.UseVisualStyleBackColor = true;
            // 
            // rbRightAnswerB
            // 
            this.rbRightAnswerB.AutoSize = true;
            this.rbRightAnswerB.Enabled = false;
            this.rbRightAnswerB.Location = new System.Drawing.Point(76, 91);
            this.rbRightAnswerB.Name = "rbRightAnswerB";
            this.rbRightAnswerB.Size = new System.Drawing.Size(45, 24);
            this.rbRightAnswerB.TabIndex = 1;
            this.rbRightAnswerB.TabStop = true;
            this.rbRightAnswerB.Text = "B";
            this.rbRightAnswerB.UseVisualStyleBackColor = true;
            // 
            // rbRightAnswerA
            // 
            this.rbRightAnswerA.AutoSize = true;
            this.rbRightAnswerA.Enabled = false;
            this.rbRightAnswerA.Location = new System.Drawing.Point(76, 47);
            this.rbRightAnswerA.Name = "rbRightAnswerA";
            this.rbRightAnswerA.Size = new System.Drawing.Size(45, 24);
            this.rbRightAnswerA.TabIndex = 0;
            this.rbRightAnswerA.TabStop = true;
            this.rbRightAnswerA.Text = "A";
            this.rbRightAnswerA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "D";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "C";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.Location = new System.Drawing.Point(294, 60);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(122, 41);
            this.btnClearPhoto.TabIndex = 20;
            this.btnClearPhoto.Text = "Clear Photo";
            this.btnClearPhoto.UseVisualStyleBackColor = true;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tbExblanantion);
            this.groupBox1.Location = new System.Drawing.Point(29, 554);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Explanation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 769);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbRightAnswer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.p);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.gbQuestionLevel);
            this.Controls.Add(this.tbQusetion);
            this.Controls.Add(this.pbQuestionPhoto);
            this.Controls.Add(this.tbChoice3);
            this.Controls.Add(this.tbChoice4);
            this.Controls.Add(this.tbChoice2);
            this.Controls.Add(this.tbChoice1);
            this.Name = "Form1";
            this.Text = "Creat Question";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionPhoto)).EndInit();
            this.gbQuestionLevel.ResumeLayout(false);
            this.gbQuestionLevel.PerformLayout();
            this.gbSubject.ResumeLayout(false);
            this.gbSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gbRightAnswer.ResumeLayout(false);
            this.gbRightAnswer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChoice1;
        private System.Windows.Forms.TextBox tbChoice2;
        private System.Windows.Forms.TextBox tbChoice4;
        private System.Windows.Forms.TextBox tbChoice3;
        private System.Windows.Forms.PictureBox pbQuestionPhoto;
        private System.Windows.Forms.TextBox tbQusetion;
        private System.Windows.Forms.GroupBox gbQuestionLevel;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.RadioButton rbChemitry;
        private System.Windows.Forms.RadioButton rbPhysics;
        private System.Windows.Forms.RadioButton rbMath;
        private System.Windows.Forms.RadioButton rbBiology;
        private System.Windows.Forms.TextBox tbExblanantion;
        private System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbRightAnswer;
        private System.Windows.Forms.RadioButton rbRightAnswerD;
        private System.Windows.Forms.RadioButton rbRightAnswerC;
        private System.Windows.Forms.RadioButton rbRightAnswerB;
        private System.Windows.Forms.RadioButton rbRightAnswerA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

