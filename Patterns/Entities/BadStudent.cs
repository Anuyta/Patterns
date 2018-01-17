using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class BadStudent : IStudent
    {
        public string InfoAboutStudent
        {
            get { return "This is a BAD student"; }
        }
    }
}
