using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dice_Roller
{
    public partial class FormDiceRoller : Form
    {
        static private readonly Random dice = new Random();
        static private int _count = 0;
        static private readonly int[] _counter = { 0, 0, 0, 0, 0, 0 };

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
            public override string ToString() => $"\t{count}{tabs}Xuất hiện mặt {res} chấm";
        }

        static private readonly List<ResultEntry> EntryTable = new List<ResultEntry>();
        static public int GetCount()
        {
            return _count;
        }

        static public int[] GetCounter()
        {
            return _counter;
        }
        private void Reset()
        {
            if (_count != 0) { rollResults.SelectedIndex = 0; };
            rollResults.Items.Clear();
            EntryTable.Clear();
            _count = 0;
            for (int i = 0; i < _counter.Length; i++)
            {
                _counter[i] = 0;
            }
            picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_default.png");
        }


        public FormDiceRoller()
        {
            InitializeComponent();
        }
        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void numbersOfRoll(object sender, KeyPressEventArgs e)
        {
            char numsOnly = e.KeyChar;
            if (!Char.IsDigit(numsOnly) && numsOnly != 8)
            {
                e.Handled = true;
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(rollsNum.Text);

            int lastRes = 0;

            for (int i = 0; i < num; i++)
            {
                _count++;
                int res = dice.Next(1, 7);

                _counter[res - 1]++;


                ResultEntry newEntry = new ResultEntry(_count, res);
                EntryTable.Add(newEntry);

                string result = newEntry.ToString();
                rollResults.Items.Add(result);
                lastRes = res;
            }

            rollResults.SelectedIndex = _count - 1;
            rollResults.Focus();

            switch(lastRes)
            {
                case 1:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_1.png");
                    break;
                case 2:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_2.png");
                    break;
                case 3:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_3.png");
                    break;
                case 4:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_4.png");
                    break;
                case 5:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_5.png");
                    break;
                case 6:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_6.png");
                    break;
                default:
                    break;
            }
        }

        private void btnShowsStats_Click(object sender, EventArgs e)
        {
            var newform = new StatsDiceForm();
            newform.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_count != 0) { rollResults.SelectedIndex = 0; };
            rollResults.Items.Clear();
            EntryTable.Clear();
            _count = 0;
            for (int i = 0; i < _counter.Length; i++)
            {
                _counter[i] = 0;
            }
            picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_default.png");
        }

        private void rollResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = rollResults.SelectedIndex;
            int res = EntryTable[index].res;
            switch (res)
            {
                case 1:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_1.png");
                    break;
                case 2:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_2.png");
                    break;
                case 3:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_3.png");
                    break;
                case 4:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_4.png");
                    break;
                case 5:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_5.png");
                    break;
                case 6:
                    picDice.Image = new Bitmap(Application.StartupPath + "\\Resources\\dice_6.png");
                    break;
                default:
                    break;
            }
        }

        private void btnCoinFlip_Click(object sender, EventArgs e)
        {
            var newForm = new FormCoinFlipper();
            this.Reset();
            this.Hide();
            newForm.Show();
        }

        private void FormDiceRoller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void rollResults_DrawItem(object sender, DrawItemEventArgs e)
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

            string str = rollResults.Items[e.Index].ToString();
            g.DrawString(str, e.Font, new SolidBrush(Color.Black), e.Bounds, stringFormat);
            e.DrawFocusRectangle();
        }

        private void btnBallPicker_Click(object sender, EventArgs e)
        {
            var newForm = new FormBallsPicker();
            this.Reset();
            this.Hide();
            newForm.Show();
        }
    }
}
