using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Exceptoins
{
    public class DonarException : ApplicationException
    {
        public DonarException()
        { }

        public DonarException(string message) : base(message)
        { }
    }
}