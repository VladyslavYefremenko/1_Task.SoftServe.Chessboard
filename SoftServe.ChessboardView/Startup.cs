using System;

namespace SoftServe.ChessboardView
{
    class Startup
    {
        public static void Start(string[] args)
        {
            int highField = 0;
            int weightField = 0;

            const string instractionPath = "..\\..\\..\\instraction.txt";

            FieldValidator fieldValidator = new FieldValidator();
            Printer printer = new Printer();

            if (fieldValidator.IsValidField(args))
            {
                highField = int.Parse(args[0]);
                weightField = int.Parse(args[1]);
            }
            else
            {
                printer.PrintInstraction(instractionPath);
                Console.ReadKey();
                return;
            }

            BoardController boardController = new BoardController();

            boardController.CreateAndPrintBoard(highField, weightField);

            Console.ReadKey();
        }
    }
}
