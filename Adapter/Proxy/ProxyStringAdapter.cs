using Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyStringAdapter
    {
        private CountLetterAdapter adapter;

        public string GetString
        {
            get { return adapter.Str; }
            set { adapter.Str = value; }
        }

        public ProxyStringAdapter(string str)
        {
            adapter = new CountLetterAdapter(str);
        }

        public void CountLetter(char c)
        {
            GetString = adapter.Str.ToUpper();
            adapter.CountLetter(char.ToUpper(c));
        }
    }
}
