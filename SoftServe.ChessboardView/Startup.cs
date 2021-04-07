using System;

using SoftServe.Chessboard;

namespace SoftServe.ChessboardView
{
    class Startup
    {
        public static void Start(string[] args)
        {
            int highField = 0;
            int weightField = 0;


            Printer printer = new Printer();

            FieldValidator validator = new FieldValidator();

            if (validator.IsValidField(args))
            {
                highField = int.Parse(args[0]);
                weightField = int.Parse(args[1]);
            }
            else
            {
                printer.PrintInstraction(DefaultSetting.instractionPath);
                Console.ReadKey();
                return;
            }

            BoardController boardController = new BoardController();

            boardController.CreateAndPrintBoard(highField, weightField);

            Console.ReadKey();
        }
    }
}
