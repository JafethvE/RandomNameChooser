using System;

namespace RandomNameChooser
{
    public class InputValidator
    {
        private readonly StringSplitter stringSplitter;

        public InputValidator()
        {
            stringSplitter = new StringSplitter();
        }

        public ValidationResult Validate(String text, ref String[] strings)
        {
            if (text.Length > 0)
            {

                strings = stringSplitter.SplitStringOnSplitter(text, "\n");

                if (strings.Length > 1)
                {
                    foreach(String subString in strings)
                    {
                        if (subString.Length == 0 || subString.Equals("\r"))
                        {
                            return ValidationResult.EmptyStringDetected;
                        }
                    }

                    return ValidationResult.Valid;
                }
                else
                {
                    return ValidationResult.InsufficientData;
                }
            }
            else
            {
                return ValidationResult.NoData;
            }
        }
    }
}
