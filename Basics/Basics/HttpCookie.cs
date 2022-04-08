using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class HttpCookie
    {
        //declare and initialize private dictionary field
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
