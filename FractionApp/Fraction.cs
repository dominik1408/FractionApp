using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    class Compare : IComparer<Fraction>
    {
        int IComparer<Fraction>.Compare(Fraction fraction, Fraction fraction1)
        {
            int num1 = fraction.numerator * fraction1.denonminator;
            int num2 = fraction1.numerator * fraction.denonminator;

            if (num1 > num2)
            {
                return 1;
            }
            else if (num1 < num2)
            {
                return -1;
            }
            return 0;
        }
    }




    public class Fraction : IComparable<Fraction>, IEquatable<Fraction>
    {
        public readonly int numerator;
        public readonly int denonminator;

        public Fraction(int numerator, int denonminator)
        {
            if (denonminator == 0)
            {
                throw new ArgumentException("W miankowniku nie może być 0");
            }
            this.numerator = numerator;
            this.denonminator = denonminator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denonminator}";
        }

        public Fraction add(Fraction secondFraction)
        {
            return new Fraction(numerator * secondFraction.denonminator + secondFraction.numerator * denonminator, denonminator * secondFraction.denonminator);
        }

        public int CompareTo(Fraction fraction1)
        {
            int num1 = numerator * fraction1.denonminator;
            int num2 = fraction1.numerator * denonminator;

            if (num1 > num2)
            {
                return 1;
            }else if (num1 < num2)
            {
                return -1;
            }
            return 0;
        }

        public bool Equals(Fraction other)
        {
            throw new NotImplementedException();
        }

        public static Fraction operator +(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.numerator * fraction1.denonminator + fraction1.numerator * fraction.denonminator, fraction.denonminator * fraction1.denonminator);
        }

        public static Fraction operator -(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.numerator * fraction1.denonminator - fraction1.numerator * fraction.denonminator, fraction.denonminator * fraction1.denonminator);
        }

        public static Fraction operator /(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.numerator * fraction1.denonminator, fraction.denonminator * fraction1.numerator);
        }
    }
}
