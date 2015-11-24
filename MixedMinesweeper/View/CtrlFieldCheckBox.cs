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

        private FieldStates _FieldState = FieldStates.Default;
        /// <summary>
        /// Gibt den aktuellen, durch den Rechtsklick festgelegten Status des Feldes zurück.
        /// </summary>
        /// <remarks>
        /// Wenn die Checked-Eigenschaft true ist, greift diese Eigenschaft nicht mehr. 
        /// </remarks>
        public FieldStates FieldState
        {
            get { return _FieldState; }
        }

        private int _NeighbouringMines = 0;
        /// <summary>
        /// Gibt die Anzahl der angrenzenden Minen des unterliegenden Feldes zurück.
        /// </summary>
        public int NeighbouringMines
        {
            get { return _NeighbouringMines; }
        }

        private List<CtrlFieldCheckBox> _NeighbouringFields = new List<CtrlFieldCheckBox>();
        /// <summary>
        /// Gets oder sets the neighbouring fields as CtrlFieldCheckbox controls.
        /// </summary>
        public List<CtrlFieldCheckBox> NeighbouringFields
        {
            get { return _NeighbouringFields; }
            set
            {
                this._NeighbouringFields = value;
                int tmpMines = 0;
                foreach (CtrlFieldCheckBox field in NeighbouringFields)
                {
                    if (field.Field.IsMine)
                    {
                        tmpMines++;
                    }
                }
                this._NeighbouringMines = tmpMines;
            }
        }

        private Field _Field;
        /// <summary>
        /// Gibt das Feld an, welches durch diese Instanz repräsentiert wird.
        /// </summary>
        public Field Field
        {
            get { return _Field; }
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="field">Gibt das zu repräsentierende Feld an.</param>
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

        /// <summary>
        /// Weist das Feld an, sich selbst zu öffnen und wenn die NeighbouringMines Eigenschaft 0 ist auch die Nachbarn zu öffnen.
        /// </summary>
        /// <remarks>
        /// Über die Instanzgrenze hinweg erfolgt der Aufruf rekursiv.</remarks>
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

       
        /// <summary>
        /// Lädt das Hintergrundbild in Abhängigkeit zu den angrenzenden Minenfarben.
        /// </summary>
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

        /// <summary>
        /// Handled das MouseDown event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Enthält Informationen über die gedrückte Taste.</param>
        private void CtrlFieldCheckBox_MouseDown(object sender, MouseEventArgs e)
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

        /// <summary>
        /// Setzt das Hintergrund entsprechend dem geladenem Bild.
        /// </summary>
        private void SetBackgroundImage()
        {
            base.BackgroundImage = this._BackgroundImg;
            base.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Inkrementiert den aktuellen Feldstatus.
        /// </summary>
        private void IncrementFieldState()
        {
            if (!this.Checked)
            {
                this._FieldState = ((int)this._FieldState == Enum.GetValues(typeof(FieldStates)).Length - 1) ? 0 : ++this._FieldState;
                switch (this._FieldState)
                {
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
                    default:
                        this.Text = "";
                        break;
                }
            }

        }



    }
}
