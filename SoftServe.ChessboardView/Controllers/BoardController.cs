namespace SoftServe.ChessboardView
{
    class BoardController : IBoardController
    {
        public void CreateAndPrintBoard(int highField, int weightField)
        {
            Chessboard.Chessboard chessboard = new Chessboard.Chessboard(highField, weightField);

            PrinterBoard printer = new PrinterBoard();

            printer.PrintBoard(chessboard);
        }
    }
}
