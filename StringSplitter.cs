using System;

namespace RandomNameChooser
{
    public class StringSplitter
    {
        public String[] SplitStringOnSplitter(String singleString, String splitter)
        {
            return singleString.Split(splitter);
        }
    }
}
