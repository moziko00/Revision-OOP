using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.OperatorOverLoading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Operators Overloading


        #region Binary Operator
        //// Overloading Operator: Must be non private class member Function

        //public static Complex operator +(Complex Left, Complex Right)
        //{
        //    return new Complex()
        //    {
        //        Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
        //        Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
        //    };

        //}
        //public static Complex operator -(Complex Left, Complex Right)
        //{
        //    return new Complex()
        //    {
        //        Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
        //        Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0),
        //    };

        //} 
        #endregion

        #region Unary Operator
        //public static Complex operator ++(Complex C)
        //{
        //    return new Complex
        //    {
        //        Real = (C?.Real ?? 0) + 1,
        //        Imag = (C?.Imag ?? 0)
        //    };
        //} 
        #endregion

        #region Comparison Operator

        public static bool operator > (Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left?.Imag > Right?.Imag;

            else 
                return Left?.Real > Right?.Real;
        }

        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left?.Imag < Right?.Imag;

            else
                return Left?.Real < Right?.Real;
        }



        #endregion


        #region Casting Operators Overloading

        // overloading casting operator: Create Non-Private Class Member Function

        public static  explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }


        
        #endregion

        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
