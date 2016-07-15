using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ("Hello world");
            for (int i = 0; i <str.Length; i++){
                int dec = Convert.ToInt16(str[i]);
                string hex = String.Format("{0:X}", dec);
                Console.WriteLine("Char {0}: dec {1} hex {2}", str[i], dec, hex);
            }
            Console.ReadKey();
        }
    }
}
