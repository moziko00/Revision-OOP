using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP
{
    internal struct Point
    {
        // Attributes
        private int X;  // 4 bytes
        private int Y;  // 4 bytes

        // Constructor : Is A Special Function
        //              1. Name Always With the same name of the class or struct
        //              2. Has No Return 



        // in Struct , Compiler will always  parameter less constructor
        // This Constructor Will Initialize each and every struct object attribute with its default value
        // 
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"X = {X} \nY = {Y}";
        }

    }
}
