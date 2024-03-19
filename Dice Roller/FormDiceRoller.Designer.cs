using System;
using System.Windows.Forms;

namespace Dice_Roller
{
    partial class FormDiceRoller
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiceRoller));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRoll = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rollsNum = new System.Windows.Forms.TextBox();
            this.rollResults = new System.Windows.Forms.ListBox();
            this.labelRollTimes = new System.Windows.Forms.Label();
            this.btnShowsStats = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.btnBallPick = new System.Windows.Forms.Button();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.btnCoinFlip = new System.Windows.Forms.Button();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.labelWatermark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoll.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnRoll.Location = new System.Drawing.Point(61, 532);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(179, 47);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "GIEO";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // rollsNum
            // 
            this.rollsNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollsNum.Font = new System.Drawing.Font("Arial", 19F);
            this.rollsNum.Location = new System.Drawing.Point(258, 539);
            this.rollsNum.Name = "rollsNum";
            this.rollsNum.Size = new System.Drawing.Size(73, 37);
            this.rollsNum.TabIndex = 3;
            this.rollsNum.Text = "1";
            this.rollsNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOfRoll);
            // 
            // rollResults
            // 
            this.rollResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rollResults.Font = new System.Drawing.Font("Arial", 18F);
            this.rollResults.FormattingEnabled = true;
            this.rollResults.IntegralHeight = false;
            this.rollResults.ItemHeight = 35;
            this.rollResults.Location = new System.Drawing.Point(505, 72);
            this.rollResults.Margin = new System.Windows.Forms.Padding(0);
            this.rollResults.Name = "rollResults";
            this.rollResults.Size = new System.Drawing.Size(450, 450);
            this.rollResults.TabIndex = 4;
            this.rollResults.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.rollResults_DrawItem);
            this.rollResults.SelectedIndexChanged += new System.EventHandler(this.rollResults_SelectedIndexChanged);
            // 
            // labelRollTimes
            // 
            this.labelRollTimes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRollTimes.AutoSize = true;
            this.labelRollTimes.Font = new System.Drawing.Font("Arial", 19F);
            this.labelRollTimes.Location = new System.Drawing.Point(337, 542);
            this.labelRollTimes.Name = "labelRollTimes";
            this.labelRollTimes.Size = new System.Drawing.Size(48, 31);
            this.labelRollTimes.TabIndex = 5;
            this.labelRollTimes.Text = "lần";
            // 
            // btnShowsStats
            // 
            this.btnShowsStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowsStats.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnShowsStats.Location = new System.Drawing.Point(503, 533);
            this.btnShowsStats.Name = "btnShowsStats";
            this.btnShowsStats.Size = new System.Drawing.Size(150, 47);
            this.btnShowsStats.TabIndex = 6;
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
            this.btnReset.TabIndex = 7;
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
            this.labelCount.Size = new System.Drawing.Size(142, 37);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Lần gieo";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelResults.TabIndex = 9;
            this.labelResults.Text = "Kết quả gieo";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnBallPick.TabIndex = 21;
            this.btnBallPick.UseVisualStyleBackColor = true;
            this.btnBallPick.Click += new System.EventHandler(this.btnBallPicker_Click);
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
            this.btnDiceRoll.TabIndex = 11;
            this.btnDiceRoll.UseVisualStyleBackColor = true;
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
            this.btnCoinFlip.TabIndex = 10;
            this.btnCoinFlip.UseVisualStyleBackColor = true;
            this.btnCoinFlip.Click += new System.EventHandler(this.btnCoinFlip_Click);
            // 
            // picDice
            // 
            this.picDice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDice.Image = ((System.Drawing.Image)(resources.GetObject("picDice.Image")));
            this.picDice.Location = new System.Drawing.Point(21, 72);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(450, 450);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDice.TabIndex = 1;
            this.picDice.TabStop = false;
            // 
            // labelWatermark
            // 
            this.labelWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWatermark.AutoSize = true;
            this.labelWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelWatermark.Location = new System.Drawing.Point(2, 596);
            this.labelWatermark.Name = "labelWatermark";
            this.labelWatermark.Size = new System.Drawing.Size(496, 13);
            this.labelWatermark.TabIndex = 35;
            this.labelWatermark.Text = "Thực hiện: Lê Thị Duyên - Nguyễn Trung Thành, trường THCS Trần Hưng Đạo, Phú Giáo" +
    ", Bình Dương.";
            // 
            // FormDiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.labelWatermark);
            this.Controls.Add(this.btnBallPick);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.btnCoinFlip);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShowsStats);
            this.Controls.Add(this.labelRollTimes);
            this.Controls.Add(this.rollResults);
            this.Controls.Add(this.rollsNum);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picDice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiceRoller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDiceRoller_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox rollsNum;
        private System.Windows.Forms.ListBox rollResults;
        private System.Windows.Forms.Label labelRollTimes;
        private System.Windows.Forms.Button btnShowsStats;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button btnCoinFlip;
        private Button btnDiceRoll;
        private Button btnBallPick;
        private Label labelWatermark;
    }
}

