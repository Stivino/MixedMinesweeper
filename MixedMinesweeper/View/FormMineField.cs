using MixedMinesweeper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MixedMinesweeper.View
{
    public partial class FormMineField : Form
    {
        private DateTime _Time;

        private MineField _MineField;
        public MineField MineField
        {
            get { return _MineField; }
        }


        public FormMineField(MineField field)
        {
            InitializeComponent();
            if (field == null)
            {
                throw new ArgumentNullException("field");
            }
            this._MineField = field;
            this._Time = DateTime.Now;
        }

        private void FormMineField_Load(object sender, EventArgs e)
        {
            int heigth = this._MineField.Fields.GetLength(1);
            int width = this._MineField.Fields.GetLength(0);
            CtrlFieldCheckBox[,] fields = new CtrlFieldCheckBox[width, heigth];
            this.flowLayoutPanel_MineField.Width = width * 42;
            this.flowLayoutPanel_MineField.Height = heigth * 42;

            bool blueEnabled = this._MineField.MineColoring[MinesColors.Blue] > 0;
            bool greenEnabled = this._MineField.MineColoring[MinesColors.Green] > 0;
            bool yellowEnabled = this._MineField.MineColoring[MinesColors.Yellow] > 0;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < heigth; y++)
                {
                    fields[x, y] = new CtrlFieldCheckBox(this._MineField.Fields[x, y],blueEnabled );
                    this.flowLayoutPanel_MineField.Controls.Add(fields[x, y]);
                }
            }

            for (int x = 0; x < fields.GetLength(0); x++)
            {
                for (int y = 0; y < fields.GetLength(1); y++)
                {
                    // First line (in a square of 3...)
                    List<CtrlFieldCheckBox> neighbours = new List<CtrlFieldCheckBox>();
                    if (x - 1 >= 0)
                    {
                        if (y - 1 >= 0)
                        {
                            neighbours.Add(fields[x - 1, y - 1]);
                        }
                        neighbours.Add(fields[x - 1, y]);
                        if (y + 1 < this.MineField.Fields.GetLength(1))
                        {
                            neighbours.Add(fields[x - 1, y + 1]);
                        }
                    }

                    // second line
                    if (y - 1 >= 0)
                    {
                        neighbours.Add(fields[x, y - 1]);
                    }
                    if (y + 1 < this.MineField.Fields.GetLength(1))
                    {
                        neighbours.Add(fields[x, y + 1]);
                    }

                    // third line
                    if (x + 1 < this.MineField.Fields.GetLength(0))
                    {
                        if (y - 1 >= 0)
                        {
                            neighbours.Add(fields[x + 1, y - 1]);
                        }
                        neighbours.Add(fields[x + 1, y]);
                        if (y + 1 < this.MineField.Fields.GetLength(1))
                        {
                            neighbours.Add(fields[x + 1, y + 1]);
                        }
                    }
                    fields[x, y].NeighbouringFields = neighbours;
                }
            }
            //for (int x = 0; x < this._MineField.Fields.GetLength(0); x++)
            //{
            //    for (int y = 0; y < this._MineField.Fields.GetLength(1); y++)
            //    {
            //    }
            //}
        }

        private void checkBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                string text = (sender as CheckBox).Text;
                int i = Convert.ToInt32(text);
                i++;
                (sender as CheckBox).Text = i.ToString();
            }
        }

        private void timePlayingTime_Tick(object sender, EventArgs e)
        {
            TimeSpan played = DateTime.Now - this._Time;
            this.lblTime.Text = played.Minutes.ToString().PadLeft(2, '0') + ":" + played.Seconds.ToString().PadLeft(2, '0');
        }

    }
}
