using System;

namespace TShirts
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal TAX = .08m;
            string name = "";
            string addr = "";
            string city = "";
            string state = "";
            string odr = "";
            string zipCode = "";
            int zip = 0;
            int order = 0;
            decimal total = 0.0m;
            decimal salesTax = 0.0m;
            decimal amntDue = 0.0m;
            int cnt = 0;
            int cnt1 = 0;
            int cnt2 = 0;
            int cnt3 = 0;
            int cnt4 = 0;
            int cnt5 = 0;

            while (cnt == 0)
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("ERROR! Input cannot be left blank!\n");
                }
                else
                    cnt = 1;
            }

            while (cnt1 == 0)
            {
                Console.Write("Street address: ");
                 addr = Console.ReadLine();
                if (addr == "")
                {
                    Console.WriteLine("ERROR! Input cannot be left blank!\n");
                }
                else
                    cnt1 = 1;
            }

            while (cnt2 == 0)
            {
                Console.Write("City: ");
                city = Console.ReadLine();
                if (city == "")
                {
                    Console.WriteLine("ERROR! Input cannot be left blank!\n");
                }
                else
                    cnt2 = 1;
            }

            while (cnt3 == 0)
            {
                Console.Write("State: ");
                state = Console.ReadLine();
                if (state == "")
                {
                    Console.WriteLine("ERROR! Input cannot be left blank!\n");
                }
                else
                    cnt3 = 1;
            }

            while (cnt4 == 0)
            {
                Console.Write("Zip: ");
                zipCode = Console.ReadLine();
                bool successfullyParsed = int.TryParse(zipCode, out zip);
                if (successfullyParsed)
                {
                    zip = Convert.ToInt32(zipCode);
                    cnt4 = 1;
                }
                else
                    Console.WriteLine("ERROR! Input non-numeric or left blank!\n");

            }

            while (cnt5 == 0)
            {
                Console.Write("How many T-Shirts did you want to order? ");
                odr = Console.ReadLine();
                bool successfullyParsed = int.TryParse(odr, out order);
                if (successfullyParsed)
                {
                    order = Convert.ToInt32(odr);
                    cnt5 = 1;
                }
                else
                    Console.WriteLine("ERROR! Input non-numeric or left blank!\n");
            }

            total = order * 14.99m;

            salesTax = total * TAX;

            amntDue = total + salesTax;

            Console.WriteLine("\n\nReceipt for:");
            Console.WriteLine(name);
            Console.WriteLine(addr);
            Console.WriteLine(city+", "+state+" "+zip+"\n");

            Console.WriteLine(order+" T-Shirt(s) ordered @ $14.99 each\n");
            Console.WriteLine("Total:\t\t"+ String.Format("{0:C}", total));
            Console.WriteLine("Tax:\t\t"+ String.Format("{0:C}", salesTax));
            Console.WriteLine("-----------------------");
            Console.WriteLine("Due:\t\t"+ String.Format("{0:C}", amntDue));

            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
