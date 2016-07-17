using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 12, z = 2;
            Console.WriteLine((x++ - --y + --x << z++) * (x + y + z));
            //x++ = 5;
            //--y = 11;
            //--x = 5;
            //z++ = 2;
            //x++ - --y + --x = -1;
            // сдвигаем -1 на 2 еденицы влево = -4;
            //x = 5
            //y= 11
            //z = 3
            //x+y+z = 19
            //-4*19=-76 
            Console.ReadKey();
        }
    }
}
