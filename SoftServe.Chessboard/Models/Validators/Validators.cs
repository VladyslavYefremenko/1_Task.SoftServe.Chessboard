namespace SoftServe.Chessboard
{
    public class Validators : IValidators
    {
        public bool ArgsIsEmpty(string[] args)
        {
            bool isEmpty = true;

            if (args.Length == 0)
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        public bool IsNumInt(string arg)
        {
            bool isNum = true;

            if (!int.TryParse(arg, out _))
            {
                isNum = false;
            }
            return isNum;
        }

        public bool IsValidSize(int maxSize, int minSize, int arg1, int arg2)
        {
            bool isValid = true;

            if (arg1 < minSize || arg1 > maxSize || arg2 < minSize || arg2 > maxSize)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
