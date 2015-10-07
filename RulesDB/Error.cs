using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesDB
{
    class Error : Exception
    {
        public Error()
        {

        }

        public Error(string message)
        {

        }

        public Error(string message, int code)
        {

        }

        public Error(string message, int code, object data)
        {

        }
    }
}
