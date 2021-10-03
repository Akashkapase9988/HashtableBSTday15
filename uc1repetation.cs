using System;
using System.Collections.Generic;
using System.Text;

namespace HashandBSTday15
{
    class uc1repetation
    {



        public static int CountStringOccurrences(string text, string pattern)
        {

            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return (count);
            }
        }
    }

