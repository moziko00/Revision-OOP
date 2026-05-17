using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.InterfaceExample_01
{
    internal class TypeSeries : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
