using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class StatsCoinForm : Form
    {
        bool _showPercent = false;
        double[] _percentage = { 0, 0};
        int[] counter;
        int count;
        public StatsCoinForm()
        {
            InitializeComponent();
        }

        private void StatsCoinForm_Load(object sender, EventArgs e)
        {
            counter = FormCoinFlipper.GetCounter();
            count = FormCoinFlipper.GetCount();

            labelResCount1.Text = counter[0].ToString();
            labelResCount2.Text = counter[1].ToString();

            if (count > 0)
            {
                for (int i = 0; i < counter.Length; i++)
                {
                    _percentage[i] = (counter[i] * 1.0) / (count * 1.0);
                }
            }
        }

        private void btnTogglePercent_Click(object sender, EventArgs e)
        {
            if (!_showPercent)
            {
                _showPercent = true;
                labelN.Text = "%";
                labelResCount1.Text = (_percentage[0] * 100).ToString("0.##");
                labelResCount2.Text = (_percentage[1] * 100).ToString("0.##");
                labelStatistics.Text = "Xác suất thực nghiệm";

            }
            else
            {
                _showPercent = false;
                labelN.Text = "N";
                labelResCount1.Text = counter[0].ToString();
                labelResCount2.Text = counter[1].ToString();
                labelStatistics.Text = "Số lần xuất hiện";
            }
        }
    }
}
