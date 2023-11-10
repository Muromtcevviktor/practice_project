using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Exceptions

{
    public class StackInitializationException : Exception
    {
        public StackInitializationException(string message) : base(message) { }
    }
}
