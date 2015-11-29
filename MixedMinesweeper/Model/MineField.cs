using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MixedMinesweeper.Model
{
    public class MineField
    {
        private Dictionary<MinesColors, int> _MineColoring = new Dictionary<MinesColors, int>();
        public Dictionary<MinesColors, int> MineColoring
        {
            get { return _MineColoring; }
        }

        private Field[,] _Fields;
        public Field[,] Fields
        {
            get { return _Fields; }
        }

        private int _FieldsCount = 0;
        public int FieldsCount
        {
            get { return _FieldsCount; }
        }

        private int _MinesCount = 0;
        public int MinesCount
        {
            get { return _MinesCount; }
        }

        public MineField(int xLength, int yLength, Dictionary<MinesColors, int> mineColoring)
        {
            int numOfFields = xLength * yLength;
            int numOfMines = 0;
            foreach (var coloring in mineColoring)
            {
                numOfMines += coloring.Value;
            }

            if (xLength <= 0)
            {
                throw new ArgumentException("Value must be greater than 0", "xLength");
            }
            if (yLength <= 0)
            {
                throw new ArgumentException("Value must be greater than 0", "yLength");
            }
            if (numOfMines >= numOfFields)
            {
                throw new ArgumentException("Number of mines must be smaller than number of fields!", "numOfMines");
            }
            this._MineColoring = mineColoring;
            this._FieldsCount = numOfFields;
            this._MinesCount = numOfMines;
            this._Fields = new Field[xLength, yLength];
            this.CreateMineField();
        }

        private void CreateMineField()
        {
            // Create random Mines in the minefield
            foreach (KeyValuePair<MinesColors, int> coloring in this.MineColoring)
            {
                CreateColoredMines(coloring);
            }

            // Fill the rest of the minefield with normal fields
            for (int x = 0; x < this.Fields.GetLength(0); x++)
            {
                for (int y = 0; y < this.Fields.GetLength(1); y++)
                {
                    if (this.Fields[x, y] == null || !this.Fields[x, y].IsMine)
                    {
                        this.Fields[x, y] = new Field(x, y);
                    }
                }
            }

            // Search and set the neighbouring fields correctly
            for (int x = 0; x < this.Fields.GetLength(0); x++)
            {
                for (int y = 0; y < this.Fields.GetLength(1); y++)
                {
                    // First line (in a square of 3...)
                    List<Field> neighbours = new List<Field>();
                    if (x - 1 >= 0)
                    {
                        if (y - 1 >= 0)
                        {
                            neighbours.Add(this._Fields[x - 1, y - 1]);
                        }
                        neighbours.Add(this._Fields[x - 1, y]);
                        if (y + 1 < this._Fields.GetLength(1))
                        {
                            neighbours.Add(this._Fields[x - 1, y + 1]);
                        }
                    }

                    // second line
                    if (y - 1 >= 0)
                    {
                        neighbours.Add(this._Fields[x, y - 1]);
                    }
                    if (y + 1 < this._Fields.GetLength(1))
                    {
                        neighbours.Add(this._Fields[x, y + 1]);
                    }

                    // third line
                    if (x + 1 < this._Fields.GetLength(0))
                    {
                        if (y - 1 >= 0)
                        {
                            neighbours.Add(this._Fields[x + 1, y - 1]);
                        }
                        neighbours.Add(this._Fields[x + 1, y]);
                        if (y + 1 < this._Fields.GetLength(1))
                        {
                            neighbours.Add(this._Fields[x + 1, y + 1]);
                        }
                    }
                    this._Fields[x, y].NeighbouringFields = neighbours;
                }
            }
        }

        private void CreateColoredMines(KeyValuePair<MinesColors, int> coloring)
        {
            /*
             * Zufallsverfahren geändert. So wie jetzt gibt es keine Mismatches mehr bei der Platzvergabe,
             * da nur unter den vorhandenen, freien Feldern ausgelost wird.
             * */
            int mines = 0;
            for (int x = 0; x < this._Fields.GetLength(0); x++)
            {
                for (int y = 0; y < this._Fields.GetLength(1); y++)
                {
                    if (this._Fields[x, y] == null)
                    {
                        this._Fields[x, y] = new Field(x, y, MinesColors.NoColor);
                    }
                }
            }

            List<Field> tmpFields = new List<Field>();
            foreach (Field field in this._Fields)
            {
                if (field != null && !field.IsMine)
                {
                    tmpFields.Add(field);
                }
            }
            while (mines < coloring.Value)
            {
                Thread.Sleep(3);
                Random rand = new Random(DateTime.Now.Millisecond);
                int pos = rand.Next(0, tmpFields.Count - 1);
                int x = tmpFields[pos].XCoordinate;
                int y = tmpFields[pos].YCoordinate;
                this.Fields[x, y] = new Field(x, y, coloring.Key);
                tmpFields.RemoveAt(pos);
                mines++;
            }
        }
    }
}
