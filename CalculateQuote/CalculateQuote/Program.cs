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
            CarYearQuote carQuote = new CarYearQuote();
            Console.WriteLine("Age from birth date");
            carQuote.CalcAge();

            Console.WriteLine("Car year");
            carQuote.YearQuote(p);

            Console.WriteLine("Car Make");
            carQuote.MakeQuote(porshe);

            Console.WriteLine("Car Model");
            carQuote.ModelQuote(porshe);

            Console.WriteLine("How many speeding tickets have you gotten?");
            carQuote.TicketCount(nowTotal);

            Console.WriteLine("Do you have a DUI on your record?");
            carQuote.DUI();

            Console.WriteLine("Would you like full coverage or just liability");
            carQuote.Coverage(nowTotal);
        }
    }
}
