namespace Dice_Roller
{
    partial class StatsCoinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsCoinForm));
            this.labelN = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelResCount2 = new System.Windows.Forms.Label();
            this.labelResCount1 = new System.Windows.Forms.Label();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.btnTogglePercent = new System.Windows.Forms.Button();
            this.labelDiceFace2 = new System.Windows.Forms.PictureBox();
            this.labelDiceFace1 = new System.Windows.Forms.PictureBox();
            this.labelWatermark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labelDiceFace2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDiceFace1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelN.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.Location = new System.Drawing.Point(73, 125);
            this.labelN.Margin = new System.Windows.Forms.Padding(0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(150, 100);
            this.labelN.TabIndex = 21;
            this.labelN.Text = "N";
            this.labelN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelX.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(73, 25);
            this.labelX.Margin = new System.Windows.Forms.Padding(0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(150, 100);
            this.labelX.TabIndex = 20;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResCount2
            // 
            this.labelResCount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResCount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResCount2.Font = new System.Drawing.Font("Arial", 20F);
            this.labelResCount2.Location = new System.Drawing.Point(323, 125);
            this.labelResCount2.Margin = new System.Windows.Forms.Padding(0);
            this.labelResCount2.Name = "labelResCount2";
            this.labelResCount2.Size = new System.Drawing.Size(100, 100);
            this.labelResCount2.TabIndex = 19;
            this.labelResCount2.Text = "0";
            this.labelResCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResCount1
            // 
            this.labelResCount1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResCount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResCount1.Font = new System.Drawing.Font("Arial", 20F);
            this.labelResCount1.Location = new System.Drawing.Point(223, 125);
            this.labelResCount1.Margin = new System.Windows.Forms.Padding(0);
            this.labelResCount1.Name = "labelResCount1";
            this.labelResCount1.Size = new System.Drawing.Size(100, 100);
            this.labelResCount1.TabIndex = 18;
            this.labelResCount1.Text = "0";
            this.labelResCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatistics
            // 
            this.labelStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatistics.Font = new System.Drawing.Font("Arial", 18F);
            this.labelStatistics.Location = new System.Drawing.Point(73, 247);
            this.labelStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(287, 43);
            this.labelStatistics.TabIndex = 25;
            this.labelStatistics.Text = "Số lần xuất hiện";
            this.labelStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTogglePercent
            // 
            this.btnTogglePercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTogglePercent.BackColor = System.Drawing.Color.LightCoral;
            this.btnTogglePercent.BackgroundImage = global::Dice_Roller.Properties.Resources.change;
            this.btnTogglePercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTogglePercent.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnTogglePercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTogglePercent.Location = new System.Drawing.Point(378, 247);
            this.btnTogglePercent.Name = "btnTogglePercent";
            this.btnTogglePercent.Size = new System.Drawing.Size(45, 43);
            this.btnTogglePercent.TabIndex = 24;
            this.btnTogglePercent.UseVisualStyleBackColor = false;
            this.btnTogglePercent.Click += new System.EventHandler(this.btnTogglePercent_Click);
            // 
            // labelDiceFace2
            // 
            this.labelDiceFace2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiceFace2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiceFace2.Image = ((System.Drawing.Image)(resources.GetObject("labelDiceFace2.Image")));
            this.labelDiceFace2.Location = new System.Drawing.Point(323, 25);
            this.labelDiceFace2.Margin = new System.Windows.Forms.Padding(0);
            this.labelDiceFace2.Name = "labelDiceFace2";
            this.labelDiceFace2.Size = new System.Drawing.Size(100, 100);
            this.labelDiceFace2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelDiceFace2.TabIndex = 23;
            this.labelDiceFace2.TabStop = false;
            // 
            // labelDiceFace1
            // 
            this.labelDiceFace1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiceFace1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiceFace1.Image = ((System.Drawing.Image)(resources.GetObject("labelDiceFace1.Image")));
            this.labelDiceFace1.Location = new System.Drawing.Point(223, 25);
            this.labelDiceFace1.Margin = new System.Windows.Forms.Padding(0);
            this.labelDiceFace1.Name = "labelDiceFace1";
            this.labelDiceFace1.Size = new System.Drawing.Size(100, 100);
            this.labelDiceFace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelDiceFace1.TabIndex = 22;
            this.labelDiceFace1.TabStop = false;
            // 
            // labelWatermark
            // 
            this.labelWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWatermark.AutoSize = true;
            this.labelWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelWatermark.Location = new System.Drawing.Point(0, 296);
            this.labelWatermark.Name = "labelWatermark";
            this.labelWatermark.Size = new System.Drawing.Size(0, 13);
            this.labelWatermark.TabIndex = 35;
            // 
            // StatsCoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 311);
            this.Controls.Add(this.labelWatermark);
            this.Controls.Add(this.labelStatistics);
            this.Controls.Add(this.btnTogglePercent);
            this.Controls.Add(this.labelDiceFace2);
            this.Controls.Add(this.labelDiceFace1);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelResCount2);
            this.Controls.Add(this.labelResCount1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsCoinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatsCoinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labelDiceFace2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDiceFace1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox labelDiceFace2;
        private System.Windows.Forms.PictureBox labelDiceFace1;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelResCount2;
        private System.Windows.Forms.Label labelResCount1;
        private System.Windows.Forms.Button btnTogglePercent;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Label labelWatermark;
    }
}