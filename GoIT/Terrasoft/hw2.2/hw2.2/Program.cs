using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("make your choice:\n1.circule\n2.sphere\n3.rectangle\n4.cuboid");
            string choise = Console.ReadLine();
            if (choise == "1" || choise == "1.circule" || choise == "circule")
            {
                Console.WriteLine("you have chosen to count the square of circle. input the radius:");
                string ans = Console.ReadLine();
                int rad = Convert.ToInt32(ans);
                double count = Math.PI * Math.Pow(rad, 2);
                Console.WriteLine(count);

            }
            else if (choise == "2" || choise == "2.sphere" || choise == "sphere")
            {
                Console.WriteLine("you have chosen to count the volume of sphere. input the radius:");
                string ans = Console.ReadLine();
                int rad = Convert.ToInt32(ans);
                double count = (4 * Math.PI * Math.Pow(rad, 3)) / 3;
                Console.WriteLine(count);
            }
            else if (choise == "3" || choise == "3.rectangle" || choise == "rectangle")
            {
                Console.WriteLine("you have chosen to count the square of rectangle. input the length of the first side:");
                string ans = Console.ReadLine();
                Console.WriteLine("input the length of the second side: ");
                string ans1 = Console.ReadLine();

                int side = Convert.ToInt32(ans);
                int side1 = Convert.ToInt32(ans1);
                double count = side * side1;
                Console.WriteLine(count);
            }
            else if (choise == "4" || choise == "4.cuboid" || choise == "cuboid")
            {
                Console.WriteLine("you have chosen to count the volume of cuboid. input the length of the first side:");
                string ans = Console.ReadLine();
                Console.WriteLine("input the length of the second side: ");
                string ans1 = Console.ReadLine();
                Console.WriteLine("input the length of the third side: ");
                string ans2 = Console.ReadLine();

                int side = Convert.ToInt32(ans);
                int side1 = Convert.ToInt32(ans1);
                int side2 = Convert.ToInt32(ans2);
                double count = side * side1 * side2;
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("Try again");
            }
            Console.ReadLine();
        }
    }
}
