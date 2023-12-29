using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Basics.Exceptions
{
    public class InvalidStackAccessException : Exception
    {
        public InvalidStackAccessException(string message) : base(message) { }
    }
}
