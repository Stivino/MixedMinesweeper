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
        public FormMineField()
        {
            InitializeComponent();
        }

        private void FormMineField_Load(object sender, EventArgs e)
        {
         
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
    }
}
