using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Add(5, 7);
            Console.WriteLine(answer);
            //or
            //Console.WriteLine(Add(5,7));
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;

        }

    }
}
