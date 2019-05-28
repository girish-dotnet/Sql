using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Exceptions
{
    public class BusinessException : ApplicationException
    {
        public BusinessException()
        { }

        public BusinessException(string message) : base(message)
        { }

    }
}