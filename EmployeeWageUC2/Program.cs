using System;

namespace EmployeeWageUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fulltime = 1;
            int Emprateperhr = 20;

            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == Fulltime)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * Emprateperhr;
            Console.WriteLine("Employee Wage : " + empwage);
        }
    }
}
