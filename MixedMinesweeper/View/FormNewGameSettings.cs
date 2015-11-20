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
    public partial class FormNewGameSettings : Form
    {
        public FormNewGameSettings()
        {
            InitializeComponent();
        }

        private void FormNewGameSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            FormMineField field = new FormMineField();
            field.Show();
        }

        private void numericUpDown_Mines_ValueChanged(object sender, EventArgs e)
        {
            this.CheckMinesAndFields();
        }

        private void numericUpDown_FieldSize_ValueChanged(object sender, EventArgs e)
        {
            this.CheckMinesAndFields();
        }

        private void CheckMinesAndFields()
        {
            int sumFields = (int)this.numericUpDown_FieldHeight.Value * (int)this.numericUpDown_FieldWidth.Value;
            int sumMines = (int)this.numericUpDown_RedMines.Value
                + (int)this.numericUpDown_YellowMines.Value
                + (int)this.numericUpDown_GreenMines.Value
                + (int)this.numericUpDown_BlueMines.Value;

            if ((sumMines >= sumFields))
            {
                this.lblError.Text = "Es wurden mehr Minen als Felder eingestellt.";
                this.btnStartGame.Enabled = false;
            }
            else
            {
                this.lblError.Text = String.Empty;
                if (sumMines > 0)
                {
                    this.btnStartGame.Enabled = true;
                }
            }
        }

        private void radioButton_Beginner_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSettings(10, 10, 9, 0, 0, 0);
            }
        }

        private void radioButton_Intermediate_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSettings(16, 16, 15, 25, 0, 0);
            }
        }

        private void radioButton_Expert_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSettings(16, 30, 35, 30, 10, 20);
            }
        }
        
        private void SetSettings(int height, int width, int redMines, int blueMines, int yellowMines, int greenMines)
        {
            this.numericUpDown_FieldHeight.Value = height;
            this.numericUpDown_FieldWidth.Value = width;
            this.numericUpDown_RedMines.Value = redMines;
            this.numericUpDown_BlueMines.Value = blueMines;
            this.numericUpDown_YellowMines.Value = yellowMines;
            this.numericUpDown_GreenMines.Value = greenMines;
        }

      
    }
}
