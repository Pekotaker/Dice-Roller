namespace Dice_Roller
{
    partial class FormCoinFlipper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoinFlipper));
            this.labelResults = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowsStats = new System.Windows.Forms.Button();
            this.labelFlipTimes = new System.Windows.Forms.Label();
            this.flipResults = new System.Windows.Forms.ListBox();
            this.flipsNum = new System.Windows.Forms.TextBox();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnBallPick = new System.Windows.Forms.Button();
            this.btnCoinFlip = new System.Windows.Forms.Button();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.labelWatermark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResults
            // 
            this.labelResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResults.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResults.Font = new System.Drawing.Font("Arial", 19F);
            this.labelResults.Location = new System.Drawing.Point(647, 35);
            this.labelResults.Margin = new System.Windows.Forms.Padding(0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(308, 37);
            this.labelResults.TabIndex = 19;
            this.labelResults.Text = "Kết quả tung";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelCount.Size = new System.Drawing.Size(142, 37);
            this.labelCount.TabIndex = 18;
            this.labelCount.Text = "Lần tung";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(819, 533);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 47);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShowsStats
            // 
            this.btnShowsStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowsStats.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnShowsStats.Location = new System.Drawing.Point(503, 533);
            this.btnShowsStats.Name = "btnShowsStats";
            this.btnShowsStats.Size = new System.Drawing.Size(150, 47);
            this.btnShowsStats.TabIndex = 16;
            this.btnShowsStats.Text = "Thống kê";
            this.btnShowsStats.UseVisualStyleBackColor = true;
            this.btnShowsStats.Click += new System.EventHandler(this.btnShowsStats_Click);
            // 
            // labelFlipTimes
            // 
            this.labelFlipTimes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFlipTimes.AutoSize = true;
            this.labelFlipTimes.Font = new System.Drawing.Font("Arial", 19F);
            this.labelFlipTimes.Location = new System.Drawing.Point(337, 542);
            this.labelFlipTimes.Name = "labelFlipTimes";
            this.labelFlipTimes.Size = new System.Drawing.Size(48, 31);
            this.labelFlipTimes.TabIndex = 15;
            this.labelFlipTimes.Text = "lần";
            // 
            // flipResults
            // 
            this.flipResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flipResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flipResults.Font = new System.Drawing.Font("Arial", 18F);
            this.flipResults.FormattingEnabled = true;
            this.flipResults.IntegralHeight = false;
            this.flipResults.ItemHeight = 35;
            this.flipResults.Location = new System.Drawing.Point(505, 72);
            this.flipResults.Margin = new System.Windows.Forms.Padding(0);
            this.flipResults.Name = "flipResults";
            this.flipResults.Size = new System.Drawing.Size(450, 450);
            this.flipResults.TabIndex = 14;
            this.flipResults.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.flipResults_DrawItem);
            this.flipResults.SelectedIndexChanged += new System.EventHandler(this.flipResults_SelectedIndexChanged);
            // 
            // flipsNum
            // 
            this.flipsNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flipsNum.Font = new System.Drawing.Font("Arial", 19F);
            this.flipsNum.Location = new System.Drawing.Point(258, 539);
            this.flipsNum.Name = "flipsNum";
            this.flipsNum.Size = new System.Drawing.Size(73, 37);
            this.flipsNum.TabIndex = 13;
            this.flipsNum.Text = "1";
            // 
            // btnFlip
            // 
            this.btnFlip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFlip.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnFlip.Location = new System.Drawing.Point(61, 532);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(179, 47);
            this.btnFlip.TabIndex = 12;
            this.btnFlip.Text = "TUNG";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
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
            this.btnBallPick.TabIndex = 22;
            this.btnBallPick.UseVisualStyleBackColor = true;
            this.btnBallPick.Click += new System.EventHandler(this.btnBallsPicker_Click);
            // 
            // btnCoinFlip
            // 
            this.btnCoinFlip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCoinFlip.BackgroundImage = global::Dice_Roller.Properties.Resources.coin_head1;
            this.btnCoinFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoinFlip.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnCoinFlip.Location = new System.Drawing.Point(21, 19);
            this.btnCoinFlip.Name = "btnCoinFlip";
            this.btnCoinFlip.Size = new System.Drawing.Size(47, 47);
            this.btnCoinFlip.TabIndex = 21;
            this.btnCoinFlip.UseVisualStyleBackColor = true;
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiceRoll.BackgroundImage = global::Dice_Roller.Properties.Resources.dice_6;
            this.btnDiceRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiceRoll.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnDiceRoll.Location = new System.Drawing.Point(74, 19);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(47, 47);
            this.btnDiceRoll.TabIndex = 20;
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // picCoin
            // 
            this.picCoin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCoin.Image = ((System.Drawing.Image)(resources.GetObject("picCoin.Image")));
            this.picCoin.Location = new System.Drawing.Point(21, 72);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(450, 450);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoin.TabIndex = 11;
            this.picCoin.TabStop = false;
            // 
            // labelWatermark
            // 
            this.labelWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWatermark.AutoSize = true;
            this.labelWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelWatermark.Location = new System.Drawing.Point(-1, 597);
            this.labelWatermark.Name = "labelWatermark";
            this.labelWatermark.Size = new System.Drawing.Size(496, 13);
            this.labelWatermark.TabIndex = 35;
            this.labelWatermark.Text = "Thực hiện: Lê Thị Duyên - Nguyễn Trung Thành, trường THCS Trần Hưng Đạo, Phú Giáo" +
    ", Bình Dương.";
            // 
            // FormCoinFlipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.labelWatermark);
            this.Controls.Add(this.btnBallPick);
            this.Controls.Add(this.btnCoinFlip);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShowsStats);
            this.Controls.Add(this.labelFlipTimes);
            this.Controls.Add(this.flipResults);
            this.Controls.Add(this.flipsNum);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.picCoin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCoinFlipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Flipper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCoinFlipper_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiceRoll;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShowsStats;
        private System.Windows.Forms.Label labelFlipTimes;
        private System.Windows.Forms.ListBox flipResults;
        private System.Windows.Forms.TextBox flipsNum;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.Button btnCoinFlip;
        private System.Windows.Forms.Button btnBallPick;
        private System.Windows.Forms.Label labelWatermark;
    }
}