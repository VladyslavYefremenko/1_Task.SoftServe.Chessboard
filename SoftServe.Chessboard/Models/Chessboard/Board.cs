namespace SoftServe.Chessboard
{
    public abstract class Board
    {
        protected Cell[,] boardField;

        protected int highField;
        protected int weightField;

        public int HighField { get => highField; }

        public int WeightField { get => weightField; }

        public Cell[,] BoardField { get => boardField; }

        public Board (int highField, int weightField)
        {
            this.highField = highField;
            this.weightField = weightField;

            boardField = new Cell[highField, weightField];
        }

        protected abstract void CreateField();
    }
}
