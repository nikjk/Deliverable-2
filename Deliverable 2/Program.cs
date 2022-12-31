using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi. Welcom to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
        decimal partysize = decimal.Parse(Console.ReadLine());

        if (partysize > 6 || partysize <= 0)
        {
            Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
        }
        else
        {
            Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or coffee.");
            decimal coffee = 0;
            decimal water = 0;
            int person = 1;
            decimal buffetprice = 9.99M;
            decimal coffeeprice = 2.00M;
            do
            {
                Console.WriteLine("Alright, person number" + person + ", water or coffee?");
                string drink = Console.ReadLine();
                if (drink == "Water" || drink == "water")
                {
                    Console.WriteLine(drink + ", good choice!");
                    water++;
                }
                else if (drink == "Coffee" || drink == "coffee")
                {
                    Console.WriteLine(drink + ", good choice!");
                    coffee++;
                }
                else
                {
                    Console.WriteLine("We don't have that. No drink for you!");
                }

                person++;
            }
            while (person <= partysize);
            decimal buffets = (partysize * buffetprice);
            decimal coffeetotal = (coffee * coffeeprice);
            decimal total = (buffets + coffeetotal);
            Console.WriteLine("Okay, so that's " + coffee + " coffees and " + water + " waters. I'll be right back. Feel free to grab your food!");
            Console.WriteLine("Here's your bill! Total price: $" + total);
        }
    }
}