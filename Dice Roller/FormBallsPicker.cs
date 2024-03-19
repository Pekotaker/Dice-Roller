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
    public partial class FormBallsPicker : Form
    {
        static private readonly Random ball = new Random();
        static private int _count = 0;
        static private readonly int[] _counter = { 0, 0, 0 };
        static private readonly string[] colors = { "đỏ", "xanh", "vàng" };
        public struct ResultEntry
        {
            public ResultEntry(int index, int entry)
            {
                count = index;
                res = entry;

                switch (Math.Floor((Math.Log10(count))))
                {
                    case 0:
                    case 1:
                        tabs = "\t\t\t\t";
                        break;
                    case 2:
                    case 3:
                        tabs = "\t\t\t";
                        break;
                    case 4:
                    case 5:
                        tabs = "\t\t";
                        break;
                    case 6:
                    case 7:
                        tabs = "\t";
                        break;
                    default:
                        tabs = " ";
                        break;
                }
            }
            public int count { get; }
            public int res { get; }
            private string tabs;
            public override string ToString() => $"\t{count}{tabs}Xuất hiện màu {colors[res]}";
        }

        static private readonly List<ResultEntry> EntryTable = new List<ResultEntry>();

        public FormBallsPicker()
        {
            InitializeComponent();
        }

        static public int GetCount()
        {
            return _count;
        }

        static public int[] GetCounter()
        {
            return _counter;
        }

        private void BallPickerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Reset()
        {
            if (_count != 0) { pickResults.SelectedIndex = 0; };
            pickResults.Items.Clear();
            EntryTable.Clear();
            _count = 0;
            for (int i = 0; i < _counter.Length; i++)
            {
                _counter[i] = 0;
            }
            picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_default.png");
        }

        private void btnCoinFlip_Click(object sender, EventArgs e)
        {
            var newForm = new FormCoinFlipper();
            this.Reset();
            this.Hide();
            newForm.Show();
        }

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            var newForm = new FormDiceRoller();
            this.Reset();
            this.Hide();
            newForm.Show();
        }

        private void btnShowsStats_Click(object sender, EventArgs e)
        {
            var newform = new StatsBallForm();
            newform.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_count != 0) { pickResults.SelectedIndex = 0; };
            pickResults.Items.Clear();
            EntryTable.Clear();

            _count = 0;
            for (int i = 0; i < _counter.Length; i++)
            {
                _counter[i] = 0;
            }
            picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_default.png");
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(picksNum.Text);

            int lastRes = 0;

            for (int i = 0; i < num; i++)
            {
                _count++;
                int res = ball.Next(0, 3);

                _counter[res]++;

                ResultEntry newEntry = new ResultEntry(_count, res);
                EntryTable.Add(newEntry);

                string result = newEntry.ToString();
                pickResults.Items.Add(result);
                lastRes = res;                               
            }
            pickResults.SelectedIndex = _count - 1;
            pickResults.Focus();

            switch (lastRes)
            {
                case 0:
                    picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_red.png");
                    break;
                case 1:
                    picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_blue.png");
                    break;
                case 2:
                    picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_yellow.png");
                    break;
                default:
                    break;
            }

        }

        private void pickResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = pickResults.SelectedIndex;
            int res = EntryTable[index].res;
            switch (res)
            {
                case 0:
                    picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_red.png");
                    break;
                case 1:
                    picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_blue.png");
                    break;
                case 2:
                    picBall.Image = new Bitmap(Application.StartupPath + "\\Resources\\ball_yellow.png");
                    break;
                default:
                    break;
            }
        }

        private void pickResults_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int index = e.Index;
            Graphics g = e.Graphics;
            Color color;
            if (selected == true)
            {
                color = Color.DeepSkyBlue;
            }
            else if (index % 2 == 0)
            {
                color = Color.LightGray;
            }
            else
            {
                color = Color.White;
            }


            /* Draw Background */
            g.FillRectangle(new SolidBrush(color), e.Bounds);

            /* Draw Item Text */

            var stringFormat = new StringFormat(); stringFormat.SetTabStops(0, new float[] { 34 });

            string str = pickResults.Items[e.Index].ToString();
            g.DrawString(str, e.Font, new SolidBrush(Color.Black), e.Bounds, stringFormat);
            e.DrawFocusRectangle();
        }
    }
}
