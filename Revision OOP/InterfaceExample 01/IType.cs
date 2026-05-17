
using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.InterfaceExample_01
{
    internal interface IType
    {
        // Public is the Default Access Modifer inside The Namespace
        // Private is not Allowed for the Signature


        // What u can write inside inteface
        // 1. Signature for property

        public int MyProperty { get; set; }

        // 2. Signature for method
        public void MyMethod();

        //public int Sum();


        // 3. Default implemented method [ in C# 8.0 New Feature (.NET Core 3.1 [2019] ) ]

        public void Print()
        {
            Console.WriteLine("Default Implemented Method");
        }


        // 4. Static Members [ in C# 8.0 New Feature (.NET Core 3.1 [2019] ) ]
        // Static field 
        // Static Property
        // Static method
        // Static Events

    }
}
