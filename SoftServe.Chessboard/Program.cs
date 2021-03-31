using System;

namespace SoftServe.Chessboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int highField;
            int weightField;

            if (FieldValidator.IsValidField(args))
            {
                highField = int.Parse(args[0]);
                weightField = int.Parse(args[1]);
            }
            else
            {
                PrinterInstraction.PrintInstraction();
                return;
            }

            ChessboardController chessboardController = new ChessboardController();

            chessboardController.CreateAndPrintChessboard(highField, weightField);
        }
    }
}
