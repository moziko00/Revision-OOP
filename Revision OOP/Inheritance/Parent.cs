using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.Inheritance
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors

        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion

        #region Methods

        public virtual int Prodcut()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return $"X = {X} \nY = {Y}";
        } 
        #endregion



    }
}
