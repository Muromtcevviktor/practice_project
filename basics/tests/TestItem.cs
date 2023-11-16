using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [DebuggerDisplay("Value = {Value}")]
    public class TestItem
    {
        public int Value { get; set; }
    }
}
