using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNameChooser
{
    class RandomStringChooser
    {
        Random random;

        public RandomStringChooser()
        {
            random = new Random();
        }

        public String ChooseRandomString(String[] strings)
        {
            return strings[random.Next(strings.Length)];
        }
    }
}
