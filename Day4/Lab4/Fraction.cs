using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;
        // get = read & set = write
       
        public int Numerator { get { return numerator; } set { numerator = value; } }
        public int Denominator { get { return denominator; } set { denominator = value; } }

        // constructor 
        public Fraction(int numerator = 1, int denominator = 1)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        // method to simplify fraction

        //public int Simplify(Fraction fraction)
        //{

        //    int simpilifiedFraction = fraction.numerator / fraction.denominator;

        //    for (int i = 0; i < 9; i++)
        //    {
        //        if (numerator % 2 == 0 && denominator % 2 == 0)
        //        {
        //            return numerator / 2 & numerator / 2;
        //        }
        //        if (numerator % 2 == 0 && denominator % 2 == 0)
        //        {
        //            return numerator / 2 & numerator / 2;
        //        }

        //    }

        //    return simpilifiedFraction;
        //}

        //////

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2.Denominator;
            res.Numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            return res;
        }
        public static Fraction operator +(Fraction f1, int f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * 1;
            res.Numerator = f1.Numerator *1 + f2 * f1.Denominator;
            return res;
        }

        public static Fraction operator +(int f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = 1 * f2.Denominator;
            res.Numerator = f1 * f2.Denominator + f2.Numerator *1;
            return res;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2.Denominator;
            res.Numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            return res;
        }
        public static Fraction operator -(Fraction f1, int f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * 1;
            res.Numerator = f1.Numerator * 1 - f2 * f1.Denominator;
            return res;
        }

        public static Fraction operator -(int f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = 1 * f2.Denominator;
            res.Numerator = f1 * f2.Denominator - f2.Numerator * 1;
            return res;
        }

        /// mul 
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2.Denominator;
            res.Numerator = f1.Numerator * f2.Numerator;
            return res;
        }
        public static Fraction operator *(Fraction f1, int f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * 1;
            res.Numerator = f1.Numerator * f2 ;
            return res;
        }

        public static Fraction operator *(int f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = 1 * f2.Denominator;
            res.Numerator = f1 * f2.Numerator;
            return res;
        }

        //// div 
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2.Numerator;
            res.Numerator = f1.Numerator * f2.Denominator;
            return res;
        }
        public static Fraction operator /(Fraction f1, int f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2;
            res.Numerator = f1.Numerator * 1 ;
            return res;
        }

        public static Fraction operator /(int f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = 1 * f2.Numerator;
            res.Numerator = f1 * f2.Denominator;
            return res;
        }

        //<= >=
        public static bool operator >= (Fraction f1, Fraction f2)
        {
            if (f1.Denominator != f2.Denominator) {
                return f1.Denominator >= f2.Denominator;
            } else
            {
                return f1.Numerator >= f2.Numerator;


            }
        }
        public static bool operator >= (Fraction f1, int f2)
        {

            if (f1.Denominator != 0)
            {
                return f1.Denominator >= 1;
            }
            else
            {
                return f1.Numerator >= f2;


            }
        }
        public static bool operator >= (int f1, Fraction f2)
        {

            if (f2.Denominator != 1)
            {
                return 1 >= f2.Denominator;
            }
            else
            {
                return f1 >= f2.Numerator;


            }
        }
        public static bool operator <= (Fraction f1, Fraction f2)
        {
            return f1.Denominator <= f2.Denominator;

            if (f1.Denominator != f2.Denominator)
            {
                return f1.Denominator >= f2.Denominator;
            }
            else
            {
                return f1.Numerator >= f2.Numerator;

            }
        }
        public static bool operator <=(Fraction f1, int f2)
        {

            if (f1.Denominator != 1)
            {
                return f1.Denominator <= 1;
            }
            else
            {
                return f1.Numerator <= f2;


            }
        }
        public static bool operator <=(int f1, Fraction f2)
        {

            if (f2.Denominator != 1)
            {
                return 1 <= f2.Denominator;
            }
            else
            {
                return f1 <= f2.Numerator;


            }
        }

        //// display fraction 

        public override string ToString()
        {
            return $"{this.Numerator} / {this.Denominator}";
        }

    }
}
