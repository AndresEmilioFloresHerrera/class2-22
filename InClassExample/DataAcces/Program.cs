using System;

namespace DataAcces
{
    class Program
    {

        
        static void Main(string[] args)
        {
           double Result =  Add(5, 15.5);
            Console.WriteLine($" 5 + 17.5 = {Result.ToString("N2")}");
            double num1 = 1, num2 = 2, num3 = 3;

            double[] nums = { num1, num2, num3 };

            nums = new Double[3];
            nums[0] = num1;
            nums[1] = num1;
            nums[2] = num1;
            nums[3] = num1;
            Console.ReadKey();
        }

        static double Add(double[] numbersToAddUp)
        {
            double r = 0;
            int counter = 0;
            while (counter < numbersToAddUp.Length)
            {
                var number = numbersToAddUp[counter];
                r += number;
                counter++;
            }


            for (counter = 0; counter < numbersToAddUp.Length; counter++)
            {
                var number = numbersToAddUp[counter];
                r += number;
            }

            foreach (var number in numbersToAddUp)
            {
                r += number;
            }
            return r;

        }
        /// <summary>
        /// Sumps pt two numbers and provides results 
        /// 
        /// </summary>
        /// <param name="val1"></param>the lefthand operand of the operation
        /// <param name="val2"></param>the righthand operand of the operation
        /// <returns></returns>The syum of val1 and val2
        static double Add(double val1, double val2)
        {

            double Sum = val1 + val2;

            return Sum;
        }
    }
}
