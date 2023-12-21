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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.pnRight = new System.Windows.Forms.Panel();
            this.lbNamePlayerB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Speed = new System.Windows.Forms.TextBox();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.lbNamePlayerA);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Location = new System.Drawing.Point(12, 182);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(190, 179);
            this.pnLeft.TabIndex = 0;
            // 
            // lbNamePlayerA
            // 
            this.lbNamePlayerA.AutoSize = true;
            this.lbNamePlayerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNamePlayerA.Location = new System.Drawing.Point(54, 122);
            this.lbNamePlayerA.Name = "lbNamePlayerA";
            this.lbNamePlayerA.Size = new System.Drawing.Size(72, 24);
            this.lbNamePlayerA.TabIndex = 2;
            this.lbNamePlayerA.Text = "Player1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NGƯỜI CHƠI 1";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(417, 565);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(146, 28);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Game mới";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPC
            // 
            this.btnPC.Location = new System.Drawing.Point(251, 603);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(142, 27);
            this.btnPC.TabIndex = 1;
            this.btnPC.Text = "Chơi với máy";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerson.Location = new System.Drawing.Point(251, 565);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(146, 31);
            this.btnPerson.TabIndex = 1;
            this.btnPerson.Text = "Chơi với người";
            this.btnPerson.UseVisualStyleBackColor = false;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.lbNamePlayerB);
            this.pnRight.Controls.Add(this.label2);
            this.pnRight.Location = new System.Drawing.Point(841, 182);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(188, 179);
            this.pnRight.TabIndex = 0;
            // 
            // lbNamePlayerB
            // 
            this.lbNamePlayerB.AutoSize = true;
            this.lbNamePlayerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNamePlayerB.Location = new System.Drawing.Point(55, 122);
            this.lbNamePlayerB.Name = "lbNamePlayerB";
            this.lbNamePlayerB.Size = new System.Drawing.Size(72, 24);
            this.lbNamePlayerB.TabIndex = 2;
            this.lbNamePlayerB.Text = "Player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "NGƯỜI CHƠI 2";
            // 
            // txt_Speed
            // 
            this.txt_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txt_Speed.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Speed.Location = new System.Drawing.Point(591, 565);
            this.txt_Speed.Name = "txt_Speed";
            this.txt_Speed.ReadOnly = true;
            this.txt_Speed.Size = new System.Drawing.Size(339, 53);
            this.txt_Speed.TabIndex = 4;
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCenter.Location = new System.Drawing.Point(252, 12);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(562, 540);
            this.pnCenter.TabIndex = 0;
            this.pnCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCenter_Paint);
            this.pnCenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnCenter_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::GAME_CARO.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(853, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txt_Speed);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Name = "frMain";
            this.Text = "GAME CỜ CARO";
            this.Load += new System.EventHandler(this.frMain_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_Speed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}