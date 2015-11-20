using MixedMinesweeper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MixedMinesweeper.View
{
    public class CtrlFieldCheckBox : CheckBox
    {
        private FieldStates _FieldState = FieldStates.Covered;
        public FieldStates FieldState
        {
            get { return _FieldState; }
        }

        private Field _Field;
        public Field Field
        {
            get { return _Field; }
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
            this._Field = field;
            base.MouseClick += CtrlFieldCheckBox_MouseClick;
        }

        void CtrlFieldCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this._Field.IsMine)
                {
                    // loser
                    switch (this._Field.Color)
                    {
                        case MinesColors.NoColor:
                            throw new Exception("no color but is mine?");
                        case MinesColors.Red:
                            break;
                        case MinesColors.Green:
                            break;
                        case MinesColors.Blue:
                            break;
                        case MinesColors.Yellow:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    this.IncrementFieldState();
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

            }
        }

        private void IncrementFieldState()
        {
            this._FieldState = ((int)this._FieldState == Enum.GetValues(typeof(FieldStates)).Length - 1) ? 0 : this._FieldState++;
        }



    }
}
