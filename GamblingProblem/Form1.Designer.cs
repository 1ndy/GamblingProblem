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
            ((System.ComponentModel.ISupportInitialize)(this.handCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handCard5)).BeginInit();
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
            this.handCard1.Location = new System.Drawing.Point(15, 65);
            this.handCard1.Name = "handCard1";
            this.handCard1.Size = new System.Drawing.Size(142, 205);
            this.handCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard1.TabIndex = 1;
            this.handCard1.TabStop = false;
            // 
            // handCard2
            // 
            this.handCard2.Location = new System.Drawing.Point(163, 65);
            this.handCard2.Name = "handCard2";
            this.handCard2.Size = new System.Drawing.Size(142, 205);
            this.handCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard2.TabIndex = 2;
            this.handCard2.TabStop = false;
            // 
            // handCard3
            // 
            this.handCard3.Location = new System.Drawing.Point(311, 65);
            this.handCard3.Name = "handCard3";
            this.handCard3.Size = new System.Drawing.Size(142, 205);
            this.handCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard3.TabIndex = 3;
            this.handCard3.TabStop = false;
            // 
            // handCard4
            // 
            this.handCard4.Location = new System.Drawing.Point(459, 65);
            this.handCard4.Name = "handCard4";
            this.handCard4.Size = new System.Drawing.Size(142, 205);
            this.handCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard4.TabIndex = 4;
            this.handCard4.TabStop = false;
            // 
            // handCard5
            // 
            this.handCard5.Location = new System.Drawing.Point(607, 65);
            this.handCard5.Name = "handCard5";
            this.handCard5.Size = new System.Drawing.Size(142, 205);
            this.handCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handCard5.TabIndex = 5;
            this.handCard5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

