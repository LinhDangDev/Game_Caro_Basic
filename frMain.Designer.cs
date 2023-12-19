namespace GAME_CARO
{
    partial class frMain
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.lbNamePlayerA = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.lbNamePlayerB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.grb_Algorithm = new System.Windows.Forms.GroupBox();
            this.rb_Minimax = new System.Windows.Forms.RadioButton();
            this.rb_AlphaBeta_Prunning = new System.Windows.Forms.RadioButton();
            this.txt_Speed = new System.Windows.Forms.TextBox();
            this.pnLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.grb_Algorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.lbNamePlayerA);
            this.pnLeft.Controls.Add(this.btnNewGame);
            this.pnLeft.Controls.Add(this.btnPC);
            this.pnLeft.Controls.Add(this.btnPerson);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Location = new System.Drawing.Point(4, 12);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(150, 521);
            this.pnLeft.TabIndex = 0;
            // 
            // lbNamePlayerA
            // 
            this.lbNamePlayerA.AutoSize = true;
            this.lbNamePlayerA.Location = new System.Drawing.Point(47, 79);
            this.lbNamePlayerA.Name = "lbNamePlayerA";
            this.lbNamePlayerA.Size = new System.Drawing.Size(42, 13);
            this.lbNamePlayerA.TabIndex = 2;
            this.lbNamePlayerA.Text = "Player1";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(18, 454);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(115, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Game mới";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPC
            // 
            this.btnPC.Location = new System.Drawing.Point(18, 425);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(115, 23);
            this.btnPC.TabIndex = 1;
            this.btnPC.Text = "Chơi với máy";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(18, 396);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(115, 23);
            this.btnPerson.TabIndex = 1;
            this.btnPerson.Text = "Chơi với người";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NGƯỜI CHƠI 1";
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.txt_Speed);
            this.pnRight.Controls.Add(this.grb_Algorithm);
            this.pnRight.Controls.Add(this.lbNamePlayerB);
            this.pnRight.Controls.Add(this.label2);
            this.pnRight.Location = new System.Drawing.Point(730, 12);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(150, 521);
            this.pnRight.TabIndex = 0;
            // 
            // lbNamePlayerB
            // 
            this.lbNamePlayerB.AutoSize = true;
            this.lbNamePlayerB.Location = new System.Drawing.Point(55, 79);
            this.lbNamePlayerB.Name = "lbNamePlayerB";
            this.lbNamePlayerB.Size = new System.Drawing.Size(42, 13);
            this.lbNamePlayerB.TabIndex = 2;
            this.lbNamePlayerB.Text = "Palyer2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NGƯỜI CHƠI 2";
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCenter.Location = new System.Drawing.Point(162, 12);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(562, 521);
            this.pnCenter.TabIndex = 0;
            this.pnCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCenter_Paint);
            this.pnCenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnCenter_MouseClick);
            // 
            // grb_Algorithm
            // 
            this.grb_Algorithm.Controls.Add(this.rb_AlphaBeta_Prunning);
            this.grb_Algorithm.Controls.Add(this.rb_Minimax);
            this.grb_Algorithm.Location = new System.Drawing.Point(6, 275);
            this.grb_Algorithm.Name = "grb_Algorithm";
            this.grb_Algorithm.Size = new System.Drawing.Size(141, 96);
            this.grb_Algorithm.TabIndex = 3;
            this.grb_Algorithm.TabStop = false;
            this.grb_Algorithm.Text = "Algorithm";
            // 
            // rb_Minimax
            // 
            this.rb_Minimax.AutoSize = true;
            this.rb_Minimax.Location = new System.Drawing.Point(17, 28);
            this.rb_Minimax.Name = "rb_Minimax";
            this.rb_Minimax.Size = new System.Drawing.Size(63, 17);
            this.rb_Minimax.TabIndex = 0;
            this.rb_Minimax.TabStop = true;
            this.rb_Minimax.Text = "Minimax";
            this.rb_Minimax.UseVisualStyleBackColor = true;
            // 
            // rb_AlphaBeta_Prunning
            // 
            this.rb_AlphaBeta_Prunning.AutoSize = true;
            this.rb_AlphaBeta_Prunning.Location = new System.Drawing.Point(17, 61);
            this.rb_AlphaBeta_Prunning.Name = "rb_AlphaBeta_Prunning";
            this.rb_AlphaBeta_Prunning.Size = new System.Drawing.Size(122, 17);
            this.rb_AlphaBeta_Prunning.TabIndex = 1;
            this.rb_AlphaBeta_Prunning.TabStop = true;
            this.rb_AlphaBeta_Prunning.Text = "AlphaBeta_Prunning";
            this.rb_AlphaBeta_Prunning.UseVisualStyleBackColor = true;
            // 
            // txt_Speed
            // 
            this.txt_Speed.Location = new System.Drawing.Point(15, 413);
            this.txt_Speed.Name = "txt_Speed";
            this.txt_Speed.ReadOnly = true;
            this.txt_Speed.Size = new System.Drawing.Size(129, 20);
            this.txt_Speed.TabIndex = 4;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 552);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Name = "frMain";
            this.Text = "GAME CỜ CARO";
            this.Load += new System.EventHandler(this.frMain_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.grb_Algorithm.ResumeLayout(false);
            this.grb_Algorithm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNamePlayerA;
        private System.Windows.Forms.Label lbNamePlayerB;
        private System.Windows.Forms.GroupBox grb_Algorithm;
        private System.Windows.Forms.RadioButton rb_AlphaBeta_Prunning;
        private System.Windows.Forms.RadioButton rb_Minimax;
        private System.Windows.Forms.TextBox txt_Speed;
    }
}