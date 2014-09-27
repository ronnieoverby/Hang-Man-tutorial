namespace HangmanGame
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
            this.getNewWord = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.letterA = new System.Windows.Forms.Button();
            this.letterT = new System.Windows.Forms.Button();
            this.letterC = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.letterV = new System.Windows.Forms.Button();
            this.letterY = new System.Windows.Forms.Button();
            this.letterZ = new System.Windows.Forms.Button();
            this.letterB = new System.Windows.Forms.Button();
            this.letterD = new System.Windows.Forms.Button();
            this.letterE = new System.Windows.Forms.Button();
            this.letterF = new System.Windows.Forms.Button();
            this.letterG = new System.Windows.Forms.Button();
            this.letterH = new System.Windows.Forms.Button();
            this.letterI = new System.Windows.Forms.Button();
            this.letterJ = new System.Windows.Forms.Button();
            this.letterK = new System.Windows.Forms.Button();
            this.letterL = new System.Windows.Forms.Button();
            this.letterM = new System.Windows.Forms.Button();
            this.letterN = new System.Windows.Forms.Button();
            this.letterO = new System.Windows.Forms.Button();
            this.letterP = new System.Windows.Forms.Button();
            this.letterQ = new System.Windows.Forms.Button();
            this.letterR = new System.Windows.Forms.Button();
            this.letterS = new System.Windows.Forms.Button();
            this.letterU = new System.Windows.Forms.Button();
            this.letterX = new System.Windows.Forms.Button();
            this.letterW = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLosses = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getNewWord
            // 
            this.getNewWord.Location = new System.Drawing.Point(132, 21);
            this.getNewWord.Name = "getNewWord";
            this.getNewWord.Size = new System.Drawing.Size(147, 23);
            this.getNewWord.TabIndex = 2;
            this.getNewWord.Text = "New Word";
            this.getNewWord.UseVisualStyleBackColor = true;
            this.getNewWord.Click += new System.EventHandler(this.getNewWord_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(81, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(250, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "***";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letterA
            // 
            this.letterA.Location = new System.Drawing.Point(30, 131);
            this.letterA.Name = "letterA";
            this.letterA.Size = new System.Drawing.Size(45, 23);
            this.letterA.TabIndex = 4;
            this.letterA.TabStop = false;
            this.letterA.Text = "A";
            this.letterA.UseVisualStyleBackColor = true;
            this.letterA.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterT
            // 
            this.letterT.Location = new System.Drawing.Point(286, 211);
            this.letterT.Name = "letterT";
            this.letterT.Size = new System.Drawing.Size(44, 23);
            this.letterT.TabIndex = 5;
            this.letterT.TabStop = false;
            this.letterT.Text = "T";
            this.letterT.UseVisualStyleBackColor = true;
            this.letterT.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterC
            // 
            this.letterC.Location = new System.Drawing.Point(132, 131);
            this.letterC.Name = "letterC";
            this.letterC.Size = new System.Drawing.Size(45, 23);
            this.letterC.TabIndex = 6;
            this.letterC.TabStop = false;
            this.letterC.Text = "C";
            this.letterC.UseVisualStyleBackColor = true;
            this.letterC.Click += new System.EventHandler(this.letterA_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Guesses Remaining";
            // 
            // letterV
            // 
            this.letterV.Location = new System.Drawing.Point(81, 251);
            this.letterV.Name = "letterV";
            this.letterV.Size = new System.Drawing.Size(45, 23);
            this.letterV.TabIndex = 9;
            this.letterV.TabStop = false;
            this.letterV.Text = "V";
            this.letterV.UseVisualStyleBackColor = true;
            this.letterV.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterY
            // 
            this.letterY.Location = new System.Drawing.Point(234, 251);
            this.letterY.Name = "letterY";
            this.letterY.Size = new System.Drawing.Size(45, 23);
            this.letterY.TabIndex = 10;
            this.letterY.TabStop = false;
            this.letterY.Text = "Y";
            this.letterY.UseVisualStyleBackColor = true;
            this.letterY.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterZ
            // 
            this.letterZ.Location = new System.Drawing.Point(286, 251);
            this.letterZ.Name = "letterZ";
            this.letterZ.Size = new System.Drawing.Size(45, 23);
            this.letterZ.TabIndex = 11;
            this.letterZ.TabStop = false;
            this.letterZ.Text = "Z";
            this.letterZ.UseVisualStyleBackColor = true;
            this.letterZ.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterB
            // 
            this.letterB.Location = new System.Drawing.Point(81, 131);
            this.letterB.Name = "letterB";
            this.letterB.Size = new System.Drawing.Size(45, 23);
            this.letterB.TabIndex = 12;
            this.letterB.TabStop = false;
            this.letterB.Text = "B";
            this.letterB.UseVisualStyleBackColor = true;
            this.letterB.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterD
            // 
            this.letterD.Location = new System.Drawing.Point(183, 131);
            this.letterD.Name = "letterD";
            this.letterD.Size = new System.Drawing.Size(45, 23);
            this.letterD.TabIndex = 13;
            this.letterD.TabStop = false;
            this.letterD.Text = "D";
            this.letterD.UseVisualStyleBackColor = true;
            this.letterD.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterE
            // 
            this.letterE.Location = new System.Drawing.Point(234, 131);
            this.letterE.Name = "letterE";
            this.letterE.Size = new System.Drawing.Size(45, 23);
            this.letterE.TabIndex = 14;
            this.letterE.TabStop = false;
            this.letterE.Text = "E";
            this.letterE.UseVisualStyleBackColor = true;
            this.letterE.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterF
            // 
            this.letterF.Location = new System.Drawing.Point(285, 131);
            this.letterF.Name = "letterF";
            this.letterF.Size = new System.Drawing.Size(45, 23);
            this.letterF.TabIndex = 15;
            this.letterF.TabStop = false;
            this.letterF.Text = "F";
            this.letterF.UseVisualStyleBackColor = true;
            this.letterF.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterG
            // 
            this.letterG.Location = new System.Drawing.Point(336, 131);
            this.letterG.Name = "letterG";
            this.letterG.Size = new System.Drawing.Size(45, 23);
            this.letterG.TabIndex = 16;
            this.letterG.TabStop = false;
            this.letterG.Text = "G";
            this.letterG.UseVisualStyleBackColor = true;
            this.letterG.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterH
            // 
            this.letterH.Location = new System.Drawing.Point(30, 173);
            this.letterH.Name = "letterH";
            this.letterH.Size = new System.Drawing.Size(45, 23);
            this.letterH.TabIndex = 17;
            this.letterH.TabStop = false;
            this.letterH.Text = "H";
            this.letterH.UseVisualStyleBackColor = true;
            this.letterH.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterI
            // 
            this.letterI.Location = new System.Drawing.Point(81, 173);
            this.letterI.Name = "letterI";
            this.letterI.Size = new System.Drawing.Size(45, 23);
            this.letterI.TabIndex = 18;
            this.letterI.TabStop = false;
            this.letterI.Text = "I";
            this.letterI.UseVisualStyleBackColor = true;
            this.letterI.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterJ
            // 
            this.letterJ.Location = new System.Drawing.Point(132, 173);
            this.letterJ.Name = "letterJ";
            this.letterJ.Size = new System.Drawing.Size(45, 23);
            this.letterJ.TabIndex = 19;
            this.letterJ.TabStop = false;
            this.letterJ.Text = "J";
            this.letterJ.UseVisualStyleBackColor = true;
            this.letterJ.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterK
            // 
            this.letterK.Location = new System.Drawing.Point(185, 173);
            this.letterK.Name = "letterK";
            this.letterK.Size = new System.Drawing.Size(45, 23);
            this.letterK.TabIndex = 20;
            this.letterK.TabStop = false;
            this.letterK.Text = "K";
            this.letterK.UseVisualStyleBackColor = true;
            this.letterK.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterL
            // 
            this.letterL.Location = new System.Drawing.Point(234, 173);
            this.letterL.Name = "letterL";
            this.letterL.Size = new System.Drawing.Size(45, 23);
            this.letterL.TabIndex = 21;
            this.letterL.TabStop = false;
            this.letterL.Text = "L";
            this.letterL.UseVisualStyleBackColor = true;
            this.letterL.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterM
            // 
            this.letterM.Location = new System.Drawing.Point(285, 173);
            this.letterM.Name = "letterM";
            this.letterM.Size = new System.Drawing.Size(45, 23);
            this.letterM.TabIndex = 22;
            this.letterM.TabStop = false;
            this.letterM.Text = "M";
            this.letterM.UseVisualStyleBackColor = true;
            this.letterM.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterN
            // 
            this.letterN.Location = new System.Drawing.Point(336, 173);
            this.letterN.Name = "letterN";
            this.letterN.Size = new System.Drawing.Size(45, 23);
            this.letterN.TabIndex = 23;
            this.letterN.TabStop = false;
            this.letterN.Text = "N";
            this.letterN.UseVisualStyleBackColor = true;
            this.letterN.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterO
            // 
            this.letterO.Location = new System.Drawing.Point(30, 211);
            this.letterO.Name = "letterO";
            this.letterO.Size = new System.Drawing.Size(45, 23);
            this.letterO.TabIndex = 24;
            this.letterO.TabStop = false;
            this.letterO.Text = "O";
            this.letterO.UseVisualStyleBackColor = true;
            this.letterO.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterP
            // 
            this.letterP.Location = new System.Drawing.Point(81, 211);
            this.letterP.Name = "letterP";
            this.letterP.Size = new System.Drawing.Size(45, 23);
            this.letterP.TabIndex = 25;
            this.letterP.TabStop = false;
            this.letterP.Text = "P";
            this.letterP.UseVisualStyleBackColor = true;
            this.letterP.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterQ
            // 
            this.letterQ.Location = new System.Drawing.Point(132, 211);
            this.letterQ.Name = "letterQ";
            this.letterQ.Size = new System.Drawing.Size(45, 23);
            this.letterQ.TabIndex = 26;
            this.letterQ.TabStop = false;
            this.letterQ.Text = "Q";
            this.letterQ.UseVisualStyleBackColor = true;
            this.letterQ.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterR
            // 
            this.letterR.Location = new System.Drawing.Point(185, 211);
            this.letterR.Name = "letterR";
            this.letterR.Size = new System.Drawing.Size(45, 23);
            this.letterR.TabIndex = 27;
            this.letterR.TabStop = false;
            this.letterR.Text = "R";
            this.letterR.UseVisualStyleBackColor = true;
            this.letterR.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterS
            // 
            this.letterS.Location = new System.Drawing.Point(234, 211);
            this.letterS.Name = "letterS";
            this.letterS.Size = new System.Drawing.Size(45, 23);
            this.letterS.TabIndex = 28;
            this.letterS.TabStop = false;
            this.letterS.Text = "S";
            this.letterS.UseVisualStyleBackColor = true;
            this.letterS.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterU
            // 
            this.letterU.Location = new System.Drawing.Point(336, 211);
            this.letterU.Name = "letterU";
            this.letterU.Size = new System.Drawing.Size(45, 23);
            this.letterU.TabIndex = 29;
            this.letterU.TabStop = false;
            this.letterU.Text = "U";
            this.letterU.UseVisualStyleBackColor = true;
            this.letterU.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterX
            // 
            this.letterX.Location = new System.Drawing.Point(185, 251);
            this.letterX.Name = "letterX";
            this.letterX.Size = new System.Drawing.Size(45, 23);
            this.letterX.TabIndex = 30;
            this.letterX.TabStop = false;
            this.letterX.Text = "X";
            this.letterX.UseVisualStyleBackColor = true;
            this.letterX.Click += new System.EventHandler(this.letterA_Click);
            // 
            // letterW
            // 
            this.letterW.Location = new System.Drawing.Point(132, 251);
            this.letterW.Name = "letterW";
            this.letterW.Size = new System.Drawing.Size(45, 23);
            this.letterW.TabIndex = 31;
            this.letterW.TabStop = false;
            this.letterW.Text = "W";
            this.letterW.UseVisualStyleBackColor = true;
            this.letterW.Click += new System.EventHandler(this.letterA_Click);
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(185, 328);
            this.txtWins.Name = "txtWins";
            this.txtWins.ReadOnly = true;
            this.txtWins.Size = new System.Drawing.Size(44, 20);
            this.txtWins.TabIndex = 32;
            this.txtWins.TabStop = false;
            this.txtWins.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Wins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Losses";
            // 
            // txtLosses
            // 
            this.txtLosses.Location = new System.Drawing.Point(185, 354);
            this.txtLosses.Name = "txtLosses";
            this.txtLosses.ReadOnly = true;
            this.txtLosses.Size = new System.Drawing.Size(44, 20);
            this.txtLosses.TabIndex = 34;
            this.txtLosses.TabStop = false;
            this.txtLosses.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLosses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.letterW);
            this.Controls.Add(this.letterX);
            this.Controls.Add(this.letterU);
            this.Controls.Add(this.letterS);
            this.Controls.Add(this.letterR);
            this.Controls.Add(this.letterQ);
            this.Controls.Add(this.letterP);
            this.Controls.Add(this.letterO);
            this.Controls.Add(this.letterN);
            this.Controls.Add(this.letterM);
            this.Controls.Add(this.letterL);
            this.Controls.Add(this.letterK);
            this.Controls.Add(this.letterJ);
            this.Controls.Add(this.letterI);
            this.Controls.Add(this.letterH);
            this.Controls.Add(this.letterG);
            this.Controls.Add(this.letterF);
            this.Controls.Add(this.letterE);
            this.Controls.Add(this.letterD);
            this.Controls.Add(this.letterB);
            this.Controls.Add(this.letterZ);
            this.Controls.Add(this.letterY);
            this.Controls.Add(this.letterV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.letterC);
            this.Controls.Add(this.letterT);
            this.Controls.Add(this.letterA);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.getNewWord);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getNewWord;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button letterA;
        private System.Windows.Forms.Button letterT;
        private System.Windows.Forms.Button letterC;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button letterV;
        private System.Windows.Forms.Button letterY;
        private System.Windows.Forms.Button letterZ;
        private System.Windows.Forms.Button letterB;
        private System.Windows.Forms.Button letterD;
        private System.Windows.Forms.Button letterE;
        private System.Windows.Forms.Button letterF;
        private System.Windows.Forms.Button letterG;
        private System.Windows.Forms.Button letterH;
        private System.Windows.Forms.Button letterI;
        private System.Windows.Forms.Button letterJ;
        private System.Windows.Forms.Button letterK;
        private System.Windows.Forms.Button letterL;
        private System.Windows.Forms.Button letterM;
        private System.Windows.Forms.Button letterN;
        private System.Windows.Forms.Button letterO;
        private System.Windows.Forms.Button letterP;
        private System.Windows.Forms.Button letterQ;
        private System.Windows.Forms.Button letterR;
        private System.Windows.Forms.Button letterS;
        private System.Windows.Forms.Button letterU;
        private System.Windows.Forms.Button letterX;
        private System.Windows.Forms.Button letterW;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLosses;
    }
}

