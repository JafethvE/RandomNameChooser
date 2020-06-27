using System;

namespace RandomNameChooser
{
    class StringSplitter
    {
        public String[] SplitStringOnSplitter(String singleString, String splitter)
        {
            return singleString.Split(splitter);
        }
    }
}
