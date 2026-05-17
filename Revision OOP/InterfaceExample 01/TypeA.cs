using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.InterfaceExample_01
{
    class TypeA : IType
    {
        private int myProperty;
        public int MyProperty 
        {
            get { return myProperty; } 
            set { myProperty = value; }
        }

        public void MyMethod()
        {
            
        }


    }
}
