using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.session03
{
    internal class Ex1
    {
        public static void Main2(string[] args)
        {
            Console.Write("Nhap do C:");
            string input = Console.ReadLine();
            if 
                (double.TryParse(input,out double celsius))
            {
                double kelvin = celsius + 273;
                double fah = celsius + 32 * 1.8;
                Console.WriteLine($"Do K: {kelvin}");
                Console.WriteLine($"Do F: {fah}");
            }    

   
          
        }

    }
}
