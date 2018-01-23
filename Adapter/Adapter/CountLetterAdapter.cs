using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CountLetterAdapter : ICountLetter
    {
        string str;

        public CountLetterAdapter(string str)
        {
            this.str = str;
        }

        public int CountLetter(char c)
        {
            var count = str.Count(chr => chr == c);
            return count;
        }
    }
}
