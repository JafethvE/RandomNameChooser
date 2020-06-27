using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNameChooser
{
    class InputValidator
    {
        public static ValidationResult Validate(String text, String[] names)
        {
            if (text.Length > 0)
            {
                if (names.Length > 1)
                {
                    foreach(String name in names)
                    {
                        if(name.Length == 0)
                        {
                            return ValidationResult.NewLineAtEndOfInput;
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
