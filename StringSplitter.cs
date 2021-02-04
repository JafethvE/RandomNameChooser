using System;

namespace RandomNameChooser
{
    public class StringSplitter
    {
        public string[] SplitStringOnSplitter(string singleString, string splitter)
        {
            return singleString.Split(splitter);
        }
    }
}
