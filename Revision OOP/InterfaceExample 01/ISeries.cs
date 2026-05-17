using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.InterfaceExample_01
{
    internal interface ISeries
    {
        public int Current { get; set; }

        public void GetNext();
        public void Reset();
    }
}
