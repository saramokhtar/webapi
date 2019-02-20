using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
{
    class calc : icalc
    {
        List<string> names = new List<string>() {"samy","hany","fady","ezaat"};
        public List<string> add(string name)
        {
            names.Add(name);
            return names;
        }

        public List<string> getall()
        {
            return names;
        }

        public string getbyindex(string index)
        {
            int _index = int.Parse(index);
            return names[_index];
        }
    }
}
