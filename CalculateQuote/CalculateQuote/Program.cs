using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Age from birth date");
            DateTime Dob = Convert.ToDateTime(Console.ReadLine());
            DateTime Now = DateTime.Now;
            int age = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(age);
            int months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    months = i;
                }
            }

            int x = 50;
            if (age < 25)
            {
                int y = x + 25;
                Console.WriteLine("Age: {0} years Y = {1}", age, y);
                Console.ReadLine();
            }
            else if (age <= 18)
            {
                int y = x + 100;
                Console.WriteLine("Age: {0} years Y = {1}", age, y);
                Console.ReadLine();
            }
            else if (age >= 100)
            {
                var y = x + 25;
                Console.WriteLine("Age: {0} years Y = {1}", age, y);
                Console.ReadLine();
            }
            else
            {
                int y = x;
                Console.WriteLine("Age: {0} years Y = {1}", age, y);
                Console.ReadLine();
            }
            
        }
    }
}
