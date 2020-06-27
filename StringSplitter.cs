using System;
using System.Collections.Generic;
using System.Text;

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
