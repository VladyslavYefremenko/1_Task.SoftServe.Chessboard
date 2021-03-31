using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe.Chessboard
{
    class ChessboardController : IChessboardController
    {
        public void CreateAndPrintChessboard(int highField, int weightField)
        {
            Chessboard chessboard = new Chessboard(highField, weightField);

            PrinterChessboard.PrintChessboard(chessboard);
        }
    }
}
