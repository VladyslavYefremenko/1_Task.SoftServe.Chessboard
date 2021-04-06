namespace SoftServe.Chessboard
{
    public class Cell : ICell
    {
        private ColorEnum.CellColors cellColor = ColorEnum.CellColors.Empty;

        public ColorEnum.CellColors CellColor { get { return cellColor; } }
    }
}
