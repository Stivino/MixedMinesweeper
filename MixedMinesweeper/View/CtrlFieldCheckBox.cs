using MixedMinesweeper.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MixedMinesweeper.View
{
    public class CtrlFieldCheckBox : CheckBox
    {
        private Image _BackgroundImg;

        private FieldStates _FieldState = FieldStates.Covered;
        public FieldStates FieldState
        {
            get { return _FieldState; }
        }

        private int _NeighbouringMines = 0;
        public int NeighbouringMines
        {
            get { return _NeighbouringMines; }
        }

        private List<CtrlFieldCheckBox> _NeighbouringFields = new List<CtrlFieldCheckBox>();
        public List<CtrlFieldCheckBox> NeighbouringFields
        {
            get { return _NeighbouringFields; }
            set
            {
                this._NeighbouringFields = value;
                foreach (CtrlFieldCheckBox field in NeighbouringFields)
                {
                    if (field.Field.IsMine)
                    {
                        this._NeighbouringMines++;
                    }
                }
            }
        }

        private Field _Field;
        public Field Field
        {
            get { return _Field; }
        }

        public void CoverupNeighbours()
        {
            this.SetBackgroundImage();
            if (!this.Field.IsMine)
            {
                this.Enabled = false;
                if (!this.Checked)
                {
                    this.Text = this.NeighbouringMines.ToString();
                    this.Checked = true;
                    if (this.NeighbouringMines == 0)
                    {
                        foreach (CtrlFieldCheckBox item in this.NeighbouringFields)
                        {
                            item.CoverupNeighbours();
                        }
                    }
                }
            }
        }

        public CtrlFieldCheckBox(Field field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("field");
            }
            base.Appearance = Appearance.Button;
            base.Height = 40;
            base.Width = 40;
            base.TextAlign = ContentAlignment.MiddleCenter;
            base.Font = new System.Drawing.Font("Consolas", 12, FontStyle.Bold);
            base.ForeColor = Color.FromKnownColor(System.Drawing.KnownColor.Black);
            base.Margin = new Padding(0);
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.FlatAppearance.CheckedBackColor = Color.FromKnownColor(System.Drawing.KnownColor.Black);
            this._Field = field;
            base.MouseDown += CtrlFieldCheckBox_MouseDown;

            this.LoadImage();
        }

        private void LoadImage()
        {
            string file = "field_";
            if (this.Field.IsMine)
            {
                file += this.Field.Color.ToString().ToLower();
            }
            else
            {
                if (this.Field.GetColoredMines(MinesColors.Red) > 0)
                {
                    file += "red";
                }
                if (this.Field.GetColoredMines(MinesColors.Blue) > 0)
                {
                    file += "blue";
                }
                if (file == "field_")
                {
                    file = "field";
                }
            }

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("MixedMinesweeper.Images." + file + ".png");
            Bitmap image = new Bitmap(myStream);
            this._BackgroundImg = image;
        }

        void CtrlFieldCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //this.Checked = true;
                //this.Enabled = false;

                if (this._Field.IsMine)
                {
                    // loser
                    this.Text = "*";
                }
                else
                {
                    this.CoverupNeighbours();
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.IncrementFieldState();
            }
        }

        private void SetBackgroundImage()
        {
            
            base.BackgroundImage = this._BackgroundImg;
            base.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void IncrementFieldState()
        {
            if (!this.Checked)
            {
                this._FieldState = ((int)this._FieldState == Enum.GetValues(typeof(FieldStates)).Length - 1) ? 0 : ++this._FieldState;
                switch (this._FieldState)
                {
                    case FieldStates.Covered:
                        break;
                    case FieldStates.RedFlag:
                        this.Text = "R";
                        break;
                    case FieldStates.BlueFlag:
                        this.Text = "B";
                        break;
                    case FieldStates.GreenFlag:
                        this.Text = "G";
                        break;
                    case FieldStates.YellowFlag:
                        this.Text = "Y";
                        break;
                    case FieldStates.QuestioMark:
                        this.Text = "?";
                        break;
                    case FieldStates.Uncoverd:
                        break;
                    default:
                        break;
                }
            }

        }



    }
}
