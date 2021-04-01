using System;

using Printers;

namespace SoftServe.Chessboard
{
    class Program
    {

        // ToDo: add XML documentation

        static void Main(string[] args)
        {
            int highField;
            int weightField;

            const string instractionPath = "..\\..\\..\\..\\instraction.txt";

            if (FieldValidator.IsValidField(args))
            {
                highField = int.Parse(args[0]);
                weightField = int.Parse(args[1]);
            }
            else
            {
                Printers.Printer<string>.PrintInstraction(instractionPath);
                return;
            }

            ChessboardController chessboardController = new ChessboardController();

            chessboardController.CreateAndPrintChessboard(highField, weightField);
        }
    }
}
