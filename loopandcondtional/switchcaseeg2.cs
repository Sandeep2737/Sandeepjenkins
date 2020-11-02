using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopandcondtional
{
    class switchcaseeg2
    {
        static void Main()
        {
            Console.WriteLine("enter the value of input1 and input2");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result;
            Console.WriteLine("Enter the operation to be performed");
            string operation = Console.ReadLine();
            switch(operation)
            {
                case "+":
                    {
                        result = input1 + input2;
                        Console.WriteLine("Addition:{0}", result);
                        break;
                    }
                case "-" :
                    {
                        result = input1 - input2;
                        Console.WriteLine("subtraction:{0}", result);
                        break;

                    }
                default:
                    {
                        Console.WriteLine("enter a valid operation");
                        break;
                    }
                    Console.Read();

            }
        }
    }
}
