﻿using System;

using SoftServe.Chessboard;

namespace SoftServe.ChessboardView
{
    class PrinterBoard : IPrinterBoard
    {
        public void PrintBoard(Chessboard.Chessboard chessboard)
        {
            for (int i = 0; i < chessboard.HighField; i++)
            {
                for (int j = 0; j < chessboard.WeightField; j++)
                {
                    if (chessboard.BoardField[i, j].GetType() == typeof(BlackCell))
                    {
                        Console.Write(DefaultChars.BLACK_CELL);
                    }
                    else
                    {
                        Console.Write(DefaultChars.WHITE_CELL);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
