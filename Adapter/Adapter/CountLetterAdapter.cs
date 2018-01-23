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
            this.Str = str;
        }

        public string Str { get; set; }

        public int CountLetter(char c)
        {
            var count = Str.Count(chr => chr == c);
            return count;
        }
    }
}
