using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class FileIO
    {
        Store store;
        
        // constructor gets a reference to the store. The inventory will be saved to and loaded from a file
        public FileIO(Store store)
        { 
            this.store = store; 
        }

        //Store.txt file will be created in the same directory as the executable.
        public void SaveInventory()
        {
            string filename = "store.txt";

            // It's a best practice to use "using" statements to ensure that IDisposable objects are disposed of correctly.
            // stream writer is used to write text to a file.
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Write each car to the file. One car per line, with fields separated by commas. 
                foreach (Car car in store.CarList)
                {
                    writer.WriteLine($"{car.Make}, {car.Model}, {car.Year}, {car.Price}, {car.Color}, {car.Miles}, New:{car.IsNew}, Engine size:{car.SizeOfEngine}");
                }
            }
        }

        // Load the store from the file. This method returns a list of cars.
        public List<Car> LoadStore()
        {
            List<Car> cars = new List<Car>();
            string filename = "store.txt";

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Split the line into parts using the comma as a separator
                    string[] parts = line.Split(',');
                    string make = parts[0];
                    string model = parts[1];
                    string color = parts[2];
                    // Always good to handle potential format issues with int and decimal parsing
                    try
                    {
                        int year = int.Parse(parts[3]);
                        int miles = int.Parse(parts[4]);
                        decimal price = decimal.Parse(parts[5]);
                        decimal sizeOfEngine = decimal.Parse(parts[6]);

                        // Add boolean status
                        bool isNew = bool.Parse(parts[7]);

                        Car car = new Car(make, model, year, color, price, miles, isNew, sizeOfEngine);
                        cars.Add(car);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error parsing data for car: " + line);
                    }
                }
            }
            return cars;
        }
    }
}
