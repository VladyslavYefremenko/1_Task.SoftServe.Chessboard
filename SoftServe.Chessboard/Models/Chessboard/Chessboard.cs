namespace SoftServe.Chessboard
{
    public class Chessboard : Board
    {
        public Chessboard(int highField, int weightField) : base(highField, weightField)
        {
            CreateField();
        }
        protected override void CreateField()
        {
            for (int i = 0; i < highField; i++)
            {
                for (int j = 0; j < weightField; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            boardField[i, j] = new BlackCell();
                        }
                        else
                        {
                            boardField[i, j] = new WhiteCell();
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            boardField[i, j] = new WhiteCell();
                        }
                        else
                        {
                            boardField[i, j] = new BlackCell();
                        }
                    }
                }
            }
        }
    }
}
