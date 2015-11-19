using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixedMinesweeper.Model
{
    public class Field
    {
        private int XCoordinate = -1;
        private int YCoordinate = -1;

        private FieldColors _Color = FieldColors.NoColor;
        public FieldColors Color
        {
            get { return _Color; }
        }

        private int _NeighbouringMines = 0;
        public int NeighbouringMines
        {
            get { return _NeighbouringMines; }
        }

        private List<Field> _NeighbouringFields = new List<Field>();
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
        public bool IsMine
        {
            get { return _IsMine; }
        }

        
        public Field( int xCoordinate, int yCoordinate, FieldColors mineColor = FieldColors.NoColor)
        {
            if (xCoordinate < 0)
            {
                throw new ArgumentException("Coordinate must be >= 0", "xCoordinate");
            }
            if (yCoordinate < 0)
            {
                throw new ArgumentException("Coordinate must be >= 0", "<yCoordinate");
            }
            if (mineColor != FieldColors.NoColor)
            {
                this._IsMine = true;
            }
            this._Color = mineColor;
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }

        public int GetColoredMines(FieldColors color)
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
