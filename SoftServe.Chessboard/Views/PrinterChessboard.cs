using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe.Chessboard
{
    class PrinterChessboard : IPrinterChessboard
    {
        public static void PrintChessboard(Chessboard chessboard)
        {
            const string BLACK_CELL = "*";
            const string WHITE_CELL = "  ";

            for (int i = 0; i < chessboard.HighField; i++)
            {
                for (int j = 0; j < chessboard.WeightField; j++)
                {
                    if (chessboard.ChessboardField[i, j].GetType() == typeof(BlackCell))
                    {
                        Console.Write(BLACK_CELL);
                    }
                    else
                    {
                        Console.Write(WHITE_CELL);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
