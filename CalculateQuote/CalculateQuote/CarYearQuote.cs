using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateQuote
{
    class CarYearQuote
    {
        public void CalcAge()
        {
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

            int price = 50;
            if (age < 25)
            {
                int newPrice = price + 25;
                Console.WriteLine("Age: {0} years Y = {1}", age, newPrice);
                Console.ReadLine();
            }
            else if (age <= 18)
            {
                int newPrice = price + 100;
                Console.WriteLine("Age: {0} years Y = {1}", age, newPrice);
                Console.ReadLine();
            }
            else if (age >= 100)
            {
                int newPrice = price + 25;
                Console.WriteLine("Age: {0} years Y = {1}", age, newPrice);
                Console.ReadLine();
            }
            else
            {
                int newPrice = price;
                Console.WriteLine("Age: {0} years, current monthly total is: ${1}", age, newPrice);
                Console.ReadLine();
            }
        }

        public void YearQuote(int price, int newPrice)
        {

            int carYear = Convert.ToInt32(Console.ReadLine());
            
            if (carYear < 2000)
            {
                int amount = newPrice + 25;
                Console.WriteLine("Your current estimated monthly total is {0}", amount);
            }
            else if (carYear > 2015)
            {
                int amount = newPrice + 25;
                Console.WriteLine("Your current estimated monthly total is {0}", amount);
            }
            else
            {
                int amount = newPrice;
                Console.WriteLine("Your current estimated monthly total is {0}", amount);
            }
            Console.ReadLine();
        }

        public void MakeQuote(int amount)
        {
            string carMake = Convert.ToString(Console.ReadLine()).ToLower();

            if (carMake == "Porshe")
            {
                int porshe = amount + 25;
            }
            else
            {
                int porshe = amount;
            }
        }

        public void ModelQuote(int money, string carMake)
        {
            string carModel = Convert.ToString(Console.ReadLine());

            if (carMake == "Porshe" && carModel == "911 Carrera")
            {
                int porshe = money + 25;
            }
            else
            {
                int porshe = money;
            }
        }

        public void TicketCount(int porshe)
        {
            int tickets = Convert.ToInt32(Console.ReadLine());

            if (tickets > 0)
            {
                int total = tickets * 10;
            }
            else
            {
                int total = porshe;
            }
        }

        public void DUI(int total)
        {
            bool dui = Convert.ToBoolean(Console.ReadLine());
            if (dui == true)
            {
                int nowTotal = (total / 4) + total;
            }
            else
            {
                int nowTotal = total;
            }
        }

        public void Coverage(int nowTotal)
        {
            string coverage = Convert.ToString(Console.ReadLine()).ToLower();
            if (coverage == "Full")
            {
                int newTotal = (nowTotal / 2) + nowTotal; 
            }
            else
            {
                int newTotal = nowTotal;
            }
        }
    }
}
