using System;

namespace RandomNameChooser
{
    class InputValidator
    {
        public static ValidationResult Validate(String text, String[] strings)
        {
            if (text.Length > 0)
            {
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
