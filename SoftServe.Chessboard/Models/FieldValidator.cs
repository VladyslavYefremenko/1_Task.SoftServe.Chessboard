using System;
using System.Collections.Generic;
using System.Text;

using Validators;

namespace SoftServe.Chessboard
{
    class FieldValidator
    {
        private const int MAX_SIZE = 50;
        private const int MIN_SIZE = 2;

        public static bool IsValidField(string[] args)
        {
            bool isValid = false;

            if (Validator.ArgsIsEmpty(args) && Validator.IsNumInt(args[0]) && Validator.IsNumInt(args[1]) && Validator.IsValidSize(MAX_SIZE, MIN_SIZE, int.Parse(args[0]), int.Parse(args[1])))
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
