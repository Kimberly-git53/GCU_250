using CarClassLibrary;

namespace CarShopConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.Out.WriteLine("Welcome to the car shop! First you must create some cars and put " +
                "them into the inventory. Then you may add cars to the cart. Finally, you may checkout," +
                "which will calculate your total bill.");

            int action = ChooseAction();

            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        // Make of car
                        Console.WriteLine("Enter the make of the car: ");
                        string make = Console.ReadLine();                    
                        // Model of car
                        Console.WriteLine("Enter the model of the car: ");
                        string model = Console.ReadLine();
                        // Year of car with while loop incase user inputs an invalid input
                        int year;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the year of the car: ");
                                year = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Your input was invalid. Please enter a whole number as the year of the car.");
                            }
                        }
                        // Price of car with while incase the user inputs an invalid value
                        decimal price;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the price of the car: ");
                                price = decimal.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Your input was invalid. Please enter a valid decimal such as 2300.00.");
                            }
                        }
                        // Color of car
                        Console.WriteLine("Enter the color of the car: ");
                        string color = Console.ReadLine();
                        // Mileage of car with while loop incase of user error.
                        int miles;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the current milage of the car: ");
                                miles = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Your input was invalid. Please enter mileage as a whole number.");
                            }
                        }
                        // Boolean to determine of the car is new 
                        Console.WriteLine("Is the car new? Enter Yes if new. No if used.");
                        string carStatus = Console.ReadLine();
                        bool isNew = carStatus.ToLower() == "Yes";
                        // Engine size with while loop just incase 
                        decimal sizeOfEngine;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the engine size: ");
                                sizeOfEngine = decimal.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Your input was invalid. Please enter a valid decimal value such as 8.45.");
                            }
                        }
                        Car car = new Car(make, model, year, color, price, miles, isNew, sizeOfEngine);
                        store.CarList.Add(car);
                        break;

                    case 2:
                        PrintStoreInventory();
                        Console.WriteLine("Enter the index of the car you would like to add to the cart: ");
                        int index = int.Parse(Console.ReadLine());
                        store.ShoppingList.Add(store.CarList[index]);
                        break;

                    case 3:
                        decimal total = store.Checkout();
                        PrintShoppingList();
                        Console.WriteLine("Your total is: " + total);
                        break;

                    case 4:
                        FileIO fileIO = new FileIO(store);
                        fileIO.SaveInventory();
                        break;

                    case 5:
                        FileIO fileIO2 = new FileIO(store);
                        store.CarList = fileIO2.LoadStore();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                PrintStoreInventory();
                action = ChooseAction();

            }

            int ChooseAction()
            {
                int choice = 0;
                Console.WriteLine("Choose an action: (0) quit (1) create car (2) add car to cart " +
                    "(3) checkout (4) save inventory to a text file (5) Load inventory from text file.");
                choice = int.Parse(Console.ReadLine());
                return choice;
            }

            void PrintStoreInventory()
            {
                Console.WriteLine("Inventory:");
                for (int i = 0; i < store.CarList.Count; i++)
                {
                    Console.WriteLine(i + ": " + store.CarList[i]);
                }
            }

            void PrintShoppingList()
            {
                Console.WriteLine("Shopping List:");
                for (int i = 0; i < store.ShoppingList.Count; i++)
                {
                    Console.WriteLine(i + ": " + store.ShoppingList[i]);
                }
            }

        }

        
    }
}




