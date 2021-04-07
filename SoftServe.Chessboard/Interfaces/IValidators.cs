namespace SoftServe.Chessboard
{
    interface IValidators
    {
        bool ArgsIsEmpty(string[] args);

        bool IsNumInt(string arg);

        bool IsValidSize(int maxSize, int minSize, int arg1, int arg2);
    }
}
