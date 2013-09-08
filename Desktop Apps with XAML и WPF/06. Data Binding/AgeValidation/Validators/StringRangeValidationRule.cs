using System.Globalization;
using System.Windows.Controls;

namespace AgeValidation.Validators
{
    public class StringRangeValidationRule : ValidationRule
    {
        private int _minimumLength = 10;
        private int _maximumLength = 80;

        public int MinimumLength
        {
            get { return _minimumLength; }
            set { _minimumLength = value; }
        }

        public int MaximumLength
        {
            get { return _maximumLength; }
            set { _maximumLength = value; }
        }

        public string ErrorMessage { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var result = new ValidationResult(true, null);
            int inputString = int.Parse(value.ToString());
            if (inputString < this.MinimumLength ||
                   (this.MaximumLength > 0 &&
                    inputString > this.MaximumLength))
            {
                result = new ValidationResult(false, this.ErrorMessage);
            }
            return result;
        }
    }
}
