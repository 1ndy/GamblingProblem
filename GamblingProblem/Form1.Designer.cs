namespace GamblingProblem
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
            this.playerName = new System.Windows.Forms.Label();
            this.handCard1 = new System.Windows.Forms.PictureBox();
            this.handCard2 = new System.Windows.Forms.PictureBox();
            this.handCard3 = new System.Windows.Forms.PictureBox();
            this.handCard4 = new System.Windows.Forms.PictureBox();
            this.handCard5 = new System.Windows.Forms.PictureBox();
            this.exchangeButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.betTextbox = new System.Windows.Forms.TextBox();
            this.computerCard1 = new System.Windows.Forms.PictureBox();
            this.computerCard2 = new System.Windows.Forms.PictureBox();
            this.computerCard3 = new System.Windows.Forms.PictureBox();
            this.computerCard4 = new System.Windows.Forms.PictureBox();
            this.computerCard5 = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.callButton = new System.Windows.Forms.Button();
            this.humanWonButton = new System.Windows.Forms.Button();
            this.computerWonButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.computerMoneyLabel = new System.Windows.Forms.Label();
            this.newComputerPlayerButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.handCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(31, 13);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(46, 17);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "label1";
            // 
            // handCard1
            // 
            this.handCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.handCard1.Location = new System.Drawing.Point(16, 135);
            this.handCard1.Name = "handCard1";
            this.handCard1.Size = new System.Drawing.Size(142, 205);
            this.handCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard1.TabIndex = 1;
            this.handCard1.TabStop = false;
            this.handCard1.Click += new System.EventHandler(this.handCard1_Click);
            // 
            // handCard2
            // 
            this.handCard2.Location = new System.Drawing.Point(164, 135);
            this.handCard2.Name = "handCard2";
            this.handCard2.Size = new System.Drawing.Size(142, 205);
            this.handCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard2.TabIndex = 2;
            this.handCard2.TabStop = false;
            this.handCard2.Click += new System.EventHandler(this.handCard2_Click);
            // 
            // handCard3
            // 
            this.handCard3.Location = new System.Drawing.Point(312, 135);
            this.handCard3.Name = "handCard3";
            this.handCard3.Size = new System.Drawing.Size(142, 205);
            this.handCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard3.TabIndex = 3;
            this.handCard3.TabStop = false;
            this.handCard3.Click += new System.EventHandler(this.handCard3_Click);
            // 
            // handCard4
            // 
            this.handCard4.Location = new System.Drawing.Point(460, 135);
            this.handCard4.Name = "handCard4";
            this.handCard4.Size = new System.Drawing.Size(142, 205);
            this.handCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard4.TabIndex = 4;
            this.handCard4.TabStop = false;
            this.handCard4.Click += new System.EventHandler(this.handCard4_Click);
            // 
            // handCard5
            // 
            this.handCard5.Location = new System.Drawing.Point(608, 135);
            this.handCard5.Name = "handCard5";
            this.handCard5.Size = new System.Drawing.Size(142, 205);
            this.handCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard5.TabIndex = 5;
            this.handCard5.TabStop = false;
            this.handCard5.Click += new System.EventHandler(this.handCard5_Click);
            // 
            // exchangeButton
            // 
            this.exchangeButton.Location = new System.Drawing.Point(675, 415);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(84, 32);
            this.exchangeButton.TabIndex = 6;
            this.exchangeButton.Text = "Exchange";
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(675, 13);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(66, 17);
            this.moneyLabel.TabIndex = 7;
            this.moneyLabel.Text = "Money: 0";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(231, 415);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 8;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Visible = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // betTextbox
            // 
            this.betTextbox.Location = new System.Drawing.Point(312, 415);
            this.betTextbox.Name = "betTextbox";
            this.betTextbox.Size = new System.Drawing.Size(65, 22);
            this.betTextbox.TabIndex = 9;
            this.betTextbox.Text = "0";
            this.betTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.betTextbox.Visible = false;
            // 
            // computerCard1
            // 
            this.computerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.computerCard1.ImageLocation = "C:\\Users\\DSU\\source\\repos\\GamblingProblem\\GamblingProblem\\cards\\gray_back.png";
            this.computerCard1.Location = new System.Drawing.Point(227, -3);
            this.computerCard1.Name = "computerCard1";
            this.computerCard1.Size = new System.Drawing.Size(79, 110);
            this.computerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerCard1.TabIndex = 10;
            this.computerCard1.TabStop = false;
            // 
            // computerCard2
            // 
            this.computerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.computerCard2.ImageLocation = "C:\\Users\\DSU\\source\\repos\\GamblingProblem\\GamblingProblem\\cards\\gray_back.png";
            this.computerCard2.Location = new System.Drawing.Point(304, -3);
            this.computerCard2.Name = "computerCard2";
            this.computerCard2.Size = new System.Drawing.Size(73, 110);
            this.computerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerCard2.TabIndex = 11;
            this.computerCard2.TabStop = false;
            // 
            // computerCard3
            // 
            this.computerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.computerCard3.ImageLocation = "C:\\Users\\DSU\\source\\repos\\GamblingProblem\\GamblingProblem\\cards\\gray_back.png";
            this.computerCard3.Location = new System.Drawing.Point(376, -1);
            this.computerCard3.Name = "computerCard3";
            this.computerCard3.Size = new System.Drawing.Size(73, 108);
            this.computerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerCard3.TabIndex = 12;
            this.computerCard3.TabStop = false;
            // 
            // computerCard4
            // 
            this.computerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.computerCard4.ImageLocation = "C:\\Users\\DSU\\source\\repos\\GamblingProblem\\GamblingProblem\\cards\\gray_back.png";
            this.computerCard4.Location = new System.Drawing.Point(442, 1);
            this.computerCard4.Name = "computerCard4";
            this.computerCard4.Size = new System.Drawing.Size(77, 106);
            this.computerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerCard4.TabIndex = 13;
            this.computerCard4.TabStop = false;
            // 
            // computerCard5
            // 
            this.computerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.computerCard5.ImageLocation = "C:\\Users\\DSU\\source\\repos\\GamblingProblem\\GamblingProblem\\cards\\gray_back.png";
            this.computerCard5.Location = new System.Drawing.Point(516, -3);
            this.computerCard5.Name = "computerCard5";
            this.computerCard5.Size = new System.Drawing.Size(73, 110);
            this.computerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerCard5.TabIndex = 14;
            this.computerCard5.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(373, 103);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 16;
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(34, 414);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(75, 33);
            this.callButton.TabIndex = 17;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Visible = false;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // humanWonButton
            // 
            this.humanWonButton.Location = new System.Drawing.Point(272, 372);
            this.humanWonButton.Name = "humanWonButton";
            this.humanWonButton.Size = new System.Drawing.Size(75, 30);
            this.humanWonButton.TabIndex = 18;
            this.humanWonButton.Text = "I won";
            this.humanWonButton.UseVisualStyleBackColor = true;
            this.humanWonButton.Visible = false;
            this.humanWonButton.Click += new System.EventHandler(this.humanWonButton_Click);
            // 
            // computerWonButton
            // 
            this.computerWonButton.Location = new System.Drawing.Point(394, 372);
            this.computerWonButton.Name = "computerWonButton";
            this.computerWonButton.Size = new System.Drawing.Size(125, 30);
            this.computerWonButton.TabIndex = 19;
            this.computerWonButton.Text = "Computer Won";
            this.computerWonButton.UseVisualStyleBackColor = true;
            this.computerWonButton.Visible = false;
            this.computerWonButton.Click += new System.EventHandler(this.computerWonButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(71, 64);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(110, 39);
            this.playAgainButton.TabIndex = 20;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // computerMoneyLabel
            // 
            this.computerMoneyLabel.AutoSize = true;
            this.computerMoneyLabel.Location = new System.Drawing.Point(618, 30);
            this.computerMoneyLabel.Name = "computerMoneyLabel";
            this.computerMoneyLabel.Size = new System.Drawing.Size(123, 17);
            this.computerMoneyLabel.TabIndex = 21;
            this.computerMoneyLabel.Text = "Comuter Money: 0";
            // 
            // newComputerPlayerButton
            // 
            this.newComputerPlayerButton.Location = new System.Drawing.Point(621, 68);
            this.newComputerPlayerButton.Name = "newComputerPlayerButton";
            this.newComputerPlayerButton.Size = new System.Drawing.Size(102, 52);
            this.newComputerPlayerButton.TabIndex = 22;
            this.newComputerPlayerButton.Text = "New Opponent";
            this.newComputerPlayerButton.UseVisualStyleBackColor = true;
            this.newComputerPlayerButton.Click += new System.EventHandler(this.newComputerPlayerButton_Click);
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(127, 414);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(75, 33);
            this.matchButton.TabIndex = 23;
            this.matchButton.Text = "Match";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // foldButton
            // 
            this.foldButton.Location = new System.Drawing.Point(127, 372);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(75, 36);
            this.foldButton.TabIndex = 24;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.newComputerPlayerButton);
            this.Controls.Add(this.computerMoneyLabel);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.computerWonButton);
            this.Controls.Add(this.humanWonButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.computerCard5);
            this.Controls.Add(this.computerCard4);
            this.Controls.Add(this.computerCard3);
            this.Controls.Add(this.computerCard2);
            this.Controls.Add(this.computerCard1);
            this.Controls.Add(this.betTextbox);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.exchangeButton);
            this.Controls.Add(this.handCard5);
            this.Controls.Add(this.handCard4);
            this.Controls.Add(this.handCard3);
            this.Controls.Add(this.handCard2);
            this.Controls.Add(this.handCard1);
            this.Controls.Add(this.playerName);
            this.Name = "Form1";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.handCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.PictureBox handCard2;
        private System.Windows.Forms.PictureBox handCard3;
        private System.Windows.Forms.PictureBox handCard4;
        private System.Windows.Forms.PictureBox handCard5;
        public System.Windows.Forms.PictureBox handCard1;
        private System.Windows.Forms.Button exchangeButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.TextBox betTextbox;
        public System.Windows.Forms.PictureBox computerCard1;
        public System.Windows.Forms.PictureBox computerCard2;
        public System.Windows.Forms.PictureBox computerCard3;
        public System.Windows.Forms.PictureBox computerCard4;
        public System.Windows.Forms.PictureBox computerCard5;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button humanWonButton;
        private System.Windows.Forms.Button computerWonButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label computerMoneyLabel;
        private System.Windows.Forms.Button newComputerPlayerButton;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Button foldButton;
    }
}

