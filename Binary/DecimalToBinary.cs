using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class DecimalToBinary
    {
        public static void Run()
        {
            Console.WriteLine("Decimal to Binary Converter");
            ConvertDecimalToBinary("213");
        }

        public static string ConvertDecimalToBinary(string decimalIP)
        {
            int[] Binarytable = new int[] { 128, 64, 32, 16, 8, 4, 2, 1};

            int Binary1 = Convert.ToInt32(decimalIP) - Binarytable[0];
            int Binary2 = Convert.ToInt32(decimalIP) - Binarytable[1];
            int Binary3 = Convert.ToInt32(decimalIP) - Binarytable[2];
            int Binary4 = Convert.ToInt32(decimalIP) - Binarytable[3];
            int Binary5 = Convert.ToInt32(decimalIP) - Binarytable[4];
            int Binary6 = Convert.ToInt32(decimalIP) - Binarytable[5];
            int Binary7 = Convert.ToInt32(decimalIP) - Binarytable[6];
            Console.WriteLine(Binary1);
            Console.WriteLine(Binary2);
            Console.WriteLine(Binary3);
            Console.WriteLine(Binary4);
            Console.WriteLine(Binary5);
            Console.WriteLine(Binary6);
            Console.WriteLine(Binary7);

            Console.WriteLine($"Example: {decimalIP} => 01111111.00000000.00000000.00000001");
            return "01111111.00000000.00000000.00000001";
        }
    }
}
