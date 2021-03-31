using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe.Chessboard
{
    class Chessboard : IChessboard
    {
        private Cell[,] chessboardField;

        private int highField;
        private int weightField;

        public int HighField { get { return highField; } }
        public int WeightField { get { return weightField; } }

        public Cell[,] ChessboardField { get { return chessboardField; } }

        public Chessboard (int highField, int weightField)
        {
            this.highField = highField;
            this.weightField = weightField;

            chessboardField = new Cell[highField, weightField];

            CreateField();
        }

        private void CreateField ()
        {
            for (int i = 0; i < highField; i++)
            {
                for (int j = 0; j < weightField; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            chessboardField[i, j] = new BlackCell();
                        }
                        else
                        {
                            chessboardField[i, j] = new WhiteCell();
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            chessboardField[i, j] = new WhiteCell();
                        }
                        else
                        {
                            chessboardField[i, j] = new BlackCell();
                        }
                    }
                }
            }
        }
    }
}
