using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            String _str = Console.ReadLine();
            Double _firstArg = Convert.ToDouble(_str);        
            for(int i = 0; i < 999; i++)
            {
                Console.WriteLine();
                String _oper = getOperation();
                Console.WriteLine();
                Double _secondArg = getAnotherNumber();
                Console.WriteLine();
                Double _res = getResult(_firstArg, _secondArg, _oper);
                Console.WriteLine("your result :{0}", _res);
                _firstArg = _res;
            }   
            Console.ReadKey();
        }

        static string getOperation()
        {
            Console.WriteLine("choose operation:\n 1: '+' \n 2: '-' \n 3: '/' \n 4: '*' \n 5: '%' \n 6: 'pow' \n");
            String _oper = Console.ReadLine();
            return _oper;
        }

        static double getAnotherNumber()
        {
            Console.WriteLine("enter a number:");
            String _str = Console.ReadLine();
            Double _secondArg  = Convert.ToDouble(_str);
            return _secondArg;
        }

        static double getResult(Double _firstArg, Double _secondArg, String _operArg)
        {
            Double result = 0;
            if (_operArg == "1"|| _operArg == "+" )
            {
                result = Addition(_firstArg,_secondArg);
            }
            else if(_operArg == "2" || _operArg == "-")
            {
                result = Subtraction(_firstArg, _secondArg);
            }
            else if(_operArg == "3" || _operArg == "/")
            {
                result = Division(_firstArg, _secondArg); 
            }
            else if(_operArg == "4" || _operArg == "*")
            {
                result = Multiplication(_firstArg, _secondArg);
            }
            else if (_operArg == "5" || _operArg == "%")
            {
                result = Mod(_firstArg, _secondArg);
            }
            else if (_operArg == "6" || _operArg == "pow")
            {
                result = Pow(_firstArg, _secondArg);
            }
            return result;
        }

        static double Addition(Double _firstArg, Double _secondArg)
        {
            Double result = _firstArg + _secondArg;

            return result;
        }

        static double Subtraction(Double _firstArg, Double _secondArg)
        {
            Double result = _firstArg - _secondArg;

            return result;
        }

        static double Division(Double _firstArg, Double _secondArg)
        {
            Double result = _firstArg / _secondArg;

            return result;
        }

        static double Multiplication(Double _firstArg, Double _secondArg)
        {
            Double result = _firstArg * _secondArg;

            return result;
        }

        static double Mod(Double _firstArg, Double _secondArg)
        {
            Double result = _firstArg % _secondArg;

            return result;
        }

        static double Pow(Double _firstArg, Double _secondArg)
        {
            Double result = Math.Pow(_firstArg, _secondArg);

            return result;
        }

    }

}
