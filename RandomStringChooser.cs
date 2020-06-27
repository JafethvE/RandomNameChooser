using System;

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
