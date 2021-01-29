
using System;
using System.Collections.Generic;   // Added to allow "List<Player> to work

namespace Homework_Template
    {
    class Program
        {
        static void Main(string[] args)
            {
            string result;

            do
                {
                result = DisplayMenu();
                Run(result);
                }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

            }
        public static string DisplayMenu()
            {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework ?");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


            }
        private static bool Run(string exeArg)

            {
            switch (exeArg.ToLower())
                {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
                }
            }

        private static void DoExe1()
            {

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            }

        private static void DoExe2()
            {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            DoBattle(players);

            Console.ReadLine();
            }
        static void DoBattle(List<Player> players)
            {
            foreach (var player in players)
                {
                player.Attack();
                Console.WriteLine("");
                }
            }


        private static void DoExe3()
            {

            var appointment = new Appointment()
                {
                Name = "Bob",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 100D
                };

            var book = new Book()
                {
                Title = "How to Implement Interfaces",
                Price = 50D,
                TaxRate = 0.0825D,
                ShippingRate = 5D   // Added to give book instance access to 
                };

            var snack = new Snack()
                {
                Price = 2D
                };

            var tshirt = new TShirt()
                {
                Size = "2X",
                Price = 25D,
                TaxRate = 0.0625D,
                ShippingRate = 2D   // Added
                };

            var items = new List<IPurchasable>();
            items.Add(appointment);
            items.Add(book);
            items.Add(snack);
            items.Add(tshirt);

            var taxableItems = new List<ITaxable>();
            foreach (var item in items)
                {
                if (item is ITaxable)
                    {
                    taxableItems.Add(item as ITaxable);
                    }
                }
            var taxAmount = CalculateTax(taxableItems);
            Console.WriteLine($"Total tax amount: ${taxAmount.ToString("0.00")}");  // Converts taxAmount to a string with two decimal places
            Console.WriteLine("");  // Spaceing 



            // Checks if items are shippable
            var shippableItems = new List<IShippable>();
            foreach (var item in items)
                {
                if (item is IShippable)
                    {
                    shippableItems.Add(item as IShippable);
                    }
                }

            var shippingAmount = CalculateShipping(shippableItems);
            Console.WriteLine($"Total shipping amount: ${shippingAmount.ToString("0.00")}");    // Converts shippingAmount to a string with two decimal places
            Console.WriteLine("");

            double totalPurchasePrice = CalculatePrice(items);
          

            //CompleteTransaction(items);


            Console.WriteLine("==================");
            double grandTotal = shippingAmount + taxAmount + totalPurchasePrice;
            Console.WriteLine("Grand Total: $" + Math.Round(grandTotal, 2));

            Console.WriteLine("");
            double a = tshirt.Price + book.Price + appointment.Price + snack.Price;
            Console.WriteLine(a);

            Console.ReadLine();
            }

        static double CalculateTax(List<ITaxable> items)
            {
            double tax = 0D;

            foreach (var item in items)
                {
                tax += item.Tax();
                }

            return tax;
            }

        static double CalculateShipping(List<IShippable> items)
            {
            double shipping = 0D;

            foreach (var item in items)
                {
                shipping += item.Ship();
                }

            return shipping;
            }


        static double CalculatePrice(List<IPurchasable> items)
            {
            double price = 0D;

            foreach (var item in items)
                {
                price += item.Purchase();
                }

            return price;
            }


        static void CompleteTransaction(List<IPurchasable> items)
            {
            items.ForEach(p => p.Purchase());
            }


        

        private static void DoExe4()
            {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
            }

        private static void DoExe5()
            {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
            }
        }
    }



/*
Contact GitHub
Pricing
API
Training
Blog
About
*/


