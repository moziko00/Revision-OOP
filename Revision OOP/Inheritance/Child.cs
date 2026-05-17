using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int X, int Y, int Z) : base(X,Y)
        {
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"X = {X} \nY = {Y} \nZ ={Z}";
        }



    }
}
