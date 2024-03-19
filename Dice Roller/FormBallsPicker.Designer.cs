namespace Dice_Roller
{
    partial class FormBallsPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBallsPicker));
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.picksNum = new System.Windows.Forms.TextBox();
            this.pickResults = new System.Windows.Forms.ListBox();
            this.labelPickTimes = new System.Windows.Forms.Label();
            this.btnShowsStats = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.btnCoinFlip = new System.Windows.Forms.Button();
            this.btnBallPick = new System.Windows.Forms.Button();
            this.labelWatermark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBall.Image = global::Dice_Roller.Properties.Resources.ball_default1;
            this.picBall.Location = new System.Drawing.Point(21, 72);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(450, 450);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBall.TabIndex = 22;
            this.picBall.TabStop = false;
            // 
            // btnPick
            // 
            this.btnPick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPick.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnPick.Location = new System.Drawing.Point(57, 533);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(179, 47);
            this.btnPick.TabIndex = 23;
            this.btnPick.Text = "LẤY BÓNG";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // picksNum
            // 
            this.picksNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picksNum.Font = new System.Drawing.Font("Arial", 19F);
            this.picksNum.Location = new System.Drawing.Point(258, 539);
            this.picksNum.Name = "picksNum";
            this.picksNum.Size = new System.Drawing.Size(73, 37);
            this.picksNum.TabIndex = 24;
            this.picksNum.Text = "1";
            // 
            // pickResults
            // 
            this.pickResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pickResults.Font = new System.Drawing.Font("Arial", 18F);
            this.pickResults.FormattingEnabled = true;
            this.pickResults.IntegralHeight = false;
            this.pickResults.ItemHeight = 35;
            this.pickResults.Location = new System.Drawing.Point(505, 72);
            this.pickResults.Margin = new System.Windows.Forms.Padding(0);
            this.pickResults.Name = "pickResults";
            this.pickResults.Size = new System.Drawing.Size(450, 450);
            this.pickResults.TabIndex = 25;
            this.pickResults.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.pickResults_DrawItem);
            this.pickResults.SelectedIndexChanged += new System.EventHandler(this.pickResults_SelectedIndexChanged);
            // 
            // labelPickTimes
            // 
            this.labelPickTimes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPickTimes.AutoSize = true;
            this.labelPickTimes.Font = new System.Drawing.Font("Arial", 19F);
            this.labelPickTimes.Location = new System.Drawing.Point(337, 542);
            this.labelPickTimes.Name = "labelPickTimes";
            this.labelPickTimes.Size = new System.Drawing.Size(48, 31);
            this.labelPickTimes.TabIndex = 26;
            this.labelPickTimes.Text = "lần";
            // 
            // btnShowsStats
            // 
            this.btnShowsStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowsStats.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnShowsStats.Location = new System.Drawing.Point(503, 533);
            this.btnShowsStats.Name = "btnShowsStats";
            this.btnShowsStats.Size = new System.Drawing.Size(150, 47);
            this.btnShowsStats.TabIndex = 27;
            this.btnShowsStats.Text = "Thống kê";
            this.btnShowsStats.UseVisualStyleBackColor = true;
            this.btnShowsStats.Click += new System.EventHandler(this.btnShowsStats_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(819, 533);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 47);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCount.Font = new System.Drawing.Font("Arial", 19F);
            this.labelCount.Location = new System.Drawing.Point(505, 35);
            this.labelCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(170, 37);
            this.labelCount.TabIndex = 29;
            this.labelCount.Text = "Lần lấy bóng";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResults
            // 
            this.labelResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResults.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResults.Font = new System.Drawing.Font("Arial", 19F);
            this.labelResults.Location = new System.Drawing.Point(675, 35);
            this.labelResults.Margin = new System.Windows.Forms.Padding(0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(280, 37);
            this.labelResults.TabIndex = 30;
            this.labelResults.Text = "Kết quả";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiceRoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiceRoll.BackgroundImage")));
            this.btnDiceRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiceRoll.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnDiceRoll.Location = new System.Drawing.Point(74, 19);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(47, 47);
            this.btnDiceRoll.TabIndex = 31;
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // btnCoinFlip
            // 
            this.btnCoinFlip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCoinFlip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoinFlip.BackgroundImage")));
            this.btnCoinFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoinFlip.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnCoinFlip.Location = new System.Drawing.Point(21, 19);
            this.btnCoinFlip.Name = "btnCoinFlip";
            this.btnCoinFlip.Size = new System.Drawing.Size(47, 47);
            this.btnCoinFlip.TabIndex = 32;
            this.btnCoinFlip.UseVisualStyleBackColor = true;
            this.btnCoinFlip.Click += new System.EventHandler(this.btnCoinFlip_Click);
            // 
            // btnBallPick
            // 
            this.btnBallPick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBallPick.BackgroundImage = global::Dice_Roller.Properties.Resources.ball_blue;
            this.btnBallPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBallPick.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnBallPick.Location = new System.Drawing.Point(127, 19);
            this.btnBallPick.Name = "btnBallPick";
            this.btnBallPick.Size = new System.Drawing.Size(47, 47);
            this.btnBallPick.TabIndex = 33;
            this.btnBallPick.UseVisualStyleBackColor = true;
            // 
            // labelWatermark
            // 
            this.labelWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWatermark.AutoSize = true;
            this.labelWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelWatermark.Location = new System.Drawing.Point(2, 597);
            this.labelWatermark.Name = "labelWatermark";
            this.labelWatermark.Size = new System.Drawing.Size(496, 13);
            this.labelWatermark.TabIndex = 34;
            this.labelWatermark.Text = "Thực hiện: Lê Thị Duyên - Nguyễn Trung Thành, trường THCS Trần Hưng Đạo, Phú Giáo" +
    ", Bình Dương.";
            // 
            // FormBallsPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.labelWatermark);
            this.Controls.Add(this.btnBallPick);
            this.Controls.Add(this.btnCoinFlip);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShowsStats);
            this.Controls.Add(this.labelPickTimes);
            this.Controls.Add(this.pickResults);
            this.Controls.Add(this.picksNum);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.picBall);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBallsPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balls Picker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BallPickerForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.TextBox picksNum;
        private System.Windows.Forms.ListBox pickResults;
        private System.Windows.Forms.Label labelPickTimes;
        private System.Windows.Forms.Button btnShowsStats;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button btnDiceRoll;
        private System.Windows.Forms.Button btnCoinFlip;
        private System.Windows.Forms.Button btnBallPick;
        private System.Windows.Forms.Label labelWatermark;
    }
}