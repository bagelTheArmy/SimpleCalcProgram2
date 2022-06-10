using System;

namespace SimpleCalcProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Write("enter a number with two decimal places -1 to exit:");
                string strNumber = Console.ReadLine();
                if(!(strNumber=="-1"))
                {
                    try
                    {
                        double number = double.Parse(strNumber);
                        double finalNum = number + 2;
                        finalNum = finalNum + 10;
                        finalNum = finalNum + (number * .20);
                        Console.WriteLine(finalNum);
                    }catch(Exception e)
                    {
                        Console.WriteLine("not a double var");
                    }
                }
                else
                {
                    exit = true;
                }


            }
        }
    }
}
