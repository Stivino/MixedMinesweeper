using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixedMinesweeper.Model
{
    /// <summary>
    /// Die Klasse repräsentiert ein Feld im Minenfeld. Ein Feld kann auch eine Mine sein, sofern eine Farbe zugewiesen wird.
    /// </summary>
    public class Field
    {
        private int _XCoordinate = -1;
        private int _YCoordinate = -1;

        private MinesColors _Color = MinesColors.NoColor;
        /// <summary>
        /// Gibt im Falle einer Mine die dazugehörige Farbe an.
        /// </summary>
        public MinesColors Color
        {
            get { return _Color; }
        }

        private int _NeighbouringMines = 0;
        /// <summary>
        /// Gibt die Anzahl der benachbarten Minen an.
        /// </summary>
        public int NeighbouringMines
        {
            get { return _NeighbouringMines; }
        }

        private List<Field> _NeighbouringFields = new List<Field>();
        /// <summary>
        /// Gibt die benachbarten Felder inklusive der Minen zurück.
        /// </summary>
        public List<Field> NeighbouringFields
        {
            get { return _NeighbouringFields; }
            set
            {
                this._NeighbouringFields = value;
                foreach (Field field in NeighbouringFields)
                {
                    if (field.IsMine)
                    {
                        this._NeighbouringMines++;
                    }
                }
            }
        }

        private bool _IsMine = false;
        /// <summary>
        /// Gibt an, ob das Feld eine Mine ist.
        /// </summary>
        public bool IsMine
        {
            get { return _IsMine; }
        }


        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="xCoordinate">X-Koordinate im Feld</param>
        /// <param name="yCoordinate">Y-Koordinate im Feld</param>
        /// <param name="mineColor">Optional: Bestimmt, ob das Feld eine Mine ist und gibt die Farbe an.</param>
        public Field( int xCoordinate, int yCoordinate, MinesColors mineColor = MinesColors.NoColor)
        {
            if (xCoordinate < 0)
            {
                throw new ArgumentException("Coordinate must be >= 0", "xCoordinate");
            }
            if (yCoordinate < 0)
            {
                throw new ArgumentException("Coordinate must be >= 0", "<yCoordinate");
            }
            if (mineColor != MinesColors.NoColor)
            {
                this._IsMine = true;
            }
            this._Color = mineColor;
            this._XCoordinate = xCoordinate;
            this._YCoordinate = yCoordinate;
        }

        /// <summary>
        /// Gibt die Anzahl der benachbarten Minen einer Farbe an.
        /// </summary>
        /// <param name="color">Gibt die zu suchende Farbe an.</param>
        /// <returns>Anzahl der gefundenen Minen.</returns>
        public int GetColoredMines(MinesColors color)
        {
            int mines = 0;
            foreach (Field field in this.NeighbouringFields)
            {
                if (field.Color == color)
                {
                    mines++;
                }
            }
            return mines;
        }

        /// <summary>
        /// Überschreibt die ToString Methode.
        /// </summary>
        /// <returns>String, der Informationen über die Instanz enthält.</returns>
        public override string ToString()
        {
            StringBuilder bs = new StringBuilder();
            bs.Append("IsMine:");
            bs.Append(this.IsMine.ToString());
            bs.Append("; ");
            bs.Append("Color:");
            bs.Append(this.Color.ToString());
            bs.Append(";");
            bs.Append("NeighbouringMines:");
            bs.Append(this.NeighbouringMines.ToString());
            bs.Append(";");
            bs.Append("NeighbouringField:");
            bs.Append(this.NeighbouringFields.Count.ToString());
            bs.Append(";");

            return bs.ToString();
        }
    }
}
