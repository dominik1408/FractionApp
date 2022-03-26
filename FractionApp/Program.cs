using System;
using System.Collections.Generic;

namespace FractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(2, 3);
            Fraction fraction1 = new Fraction(1, 5);

            Console.WriteLine(fraction);
            Console.WriteLine(fraction1);

            Console.WriteLine(fraction.add(fraction1));
            Console.WriteLine(fraction - fraction1);


            List<Fraction> list = new List<Fraction>();
            list.Add(fraction);
            list.Add(fraction1);
            list.Add(new Fraction(3, 4));
            list.Add(new Fraction(3, 2));
        }
    }
}
