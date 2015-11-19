using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MixedMinesweeper
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
    }
}
