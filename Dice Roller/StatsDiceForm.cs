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
    public partial class StatsDiceForm : Form
    {

        bool _showPercent = false;
        double[] _percentage = { 0, 0, 0, 0, 0, 0 };
        int[] counter;
        int count;
        public StatsDiceForm()
        {
            InitializeComponent();
        }

        private void showStats_Load(object sender, EventArgs e)
        {
            counter = FormDiceRoller.GetCounter();
            count = FormDiceRoller.GetCount();
            
            labelResCount1.Text = counter[0].ToString();
            labelResCount2.Text = counter[1].ToString();
            labelResCount3.Text = counter[2].ToString();
            labelResCount4.Text = counter[3].ToString();
            labelResCount5.Text = counter[4].ToString();
            labelResCount6.Text = counter[5].ToString();

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
                labelResCount3.Text = (_percentage[2] * 100).ToString("0.##");
                labelResCount4.Text = (_percentage[3] * 100).ToString("0.##");
                labelResCount5.Text = (_percentage[4] * 100).ToString("0.##");
                labelResCount6.Text = (_percentage[5] * 100).ToString("0.##");
                labelStatistics.Text = "Xác suất thực nghiệm";
                
            }
            else
            {
                _showPercent = false;
                labelN.Text = "N";
                labelResCount1.Text = counter[0].ToString();
                labelResCount2.Text = counter[1].ToString();
                labelResCount3.Text = counter[2].ToString();
                labelResCount4.Text = counter[3].ToString();
                labelResCount5.Text = counter[4].ToString();
                labelResCount6.Text = counter[5].ToString();
                labelStatistics.Text = "Số lần xuất hiện";
            }
        }
    }
}
