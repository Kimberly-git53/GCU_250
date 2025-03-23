using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        // Constructor initializes the CarList and ShoppingList properties
        public Store() 
        { 
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal total = 0;
            foreach (Car car in ShoppingList)
            {
                total += car.Price;
            }
            return total;
        }

        public List<Car> Search(string searchTerm)
        {
            // Create a new list to hold the search results
            List<Car> searchResults = new List<Car>();
            // Convert the search term to lowercase
            searchTerm = searchTerm.ToLower();
            // Search the inventory for cars that contain the search term in the Make, Model, or Color properties
            foreach (Car car in CarList)
            {
                if (car.Make.ToLower().Contains(searchTerm) || 
                    car.Model.ToLower().Contains(searchTerm) || 
                    (car.Color != null && car.Color.ToLower().Contains(searchTerm)))
                {
                    searchResults.Add(car);
                }
            }
            return searchResults;
        }
    }
}
