namespace SoftServe.Chessboard
{
    public class FieldValidator : IFieldValidator
    {
        public bool IsValidField(string[] args)
        {
            bool isValid = false;

            Validators validators = new Validators();

            if (validators.ArgsIsEmpty(args) && validators.IsNumInt(args[0]) && validators.IsNumInt(args[1]) && validators.IsValidSize(DefaultSetting.MAX_SEZE, DefaultSetting.MIN_SIZE, int.Parse(args[0]), int.Parse(args[1])))
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
