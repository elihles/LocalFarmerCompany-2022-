using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFarmerCompany_2022_
{
    
    internal class Program
    {
        const double lessthan40kg = 5;
        const double morethan80kg = 7.50;
        const double More=8.50;
        static void Main(string[] args)
        {
            double weight,total;
            total = 0;
          
            Console.Write("Enter the produce weight:");
            weight = double.Parse(Console.ReadLine());
            if (weight<=40)
            {
                total = weight * lessthan40kg;
            }
            else if (weight >40 && weight <= 80)
            {
                total = weight * morethan80kg;
            }
            else
            {
                total = weight * More;
            }
            Console.WriteLine("{0:C}kg delivered, total due {1:C}",weight,total);
            Console.ReadLine();

        }
    }
}
