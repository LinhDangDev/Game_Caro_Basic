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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.lbNamePlayerA = new System.Windows.Forms.Label();
            this.lbNamePlayerB = new System.Windows.Forms.Label();
            this.pnLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
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
            this.pnRight.Controls.Add(this.lbNamePlayerB);
            this.pnRight.Controls.Add(this.label2);
            this.pnRight.Location = new System.Drawing.Point(730, 12);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(150, 521);
            this.pnRight.TabIndex = 0;
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
            // lbNamePlayerA
            // 
            this.lbNamePlayerA.AutoSize = true;
            this.lbNamePlayerA.Location = new System.Drawing.Point(39, 79);
            this.lbNamePlayerA.Name = "lbNamePlayerA";
            this.lbNamePlayerA.Size = new System.Drawing.Size(42, 13);
            this.lbNamePlayerA.TabIndex = 2;
            this.lbNamePlayerA.Text = "Player1";
            // 
            // lbNamePlayerB
            // 
            this.lbNamePlayerB.AutoSize = true;
            this.lbNamePlayerB.Location = new System.Drawing.Point(40, 79);
            this.lbNamePlayerB.Name = "lbNamePlayerB";
            this.lbNamePlayerB.Size = new System.Drawing.Size(42, 13);
            this.lbNamePlayerB.TabIndex = 2;
            this.lbNamePlayerB.Text = "Palyer2";
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
    }
}