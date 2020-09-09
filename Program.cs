using System;

namespace Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA;
            double sideB; 
            double hypo;
            Console.Write("Side A : ");
                sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side B : ");
                sideB = Convert.ToDouble(Console.ReadLine());
                hypo = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
                Console.WriteLine("Hypotenuse = " + hypo);
                Console.ReadKey();
            }
        }
    }



