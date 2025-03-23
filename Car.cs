using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }
        public bool IsNew { get; set; }
        public decimal SizeOfEngine { get; set; }

        public Car(string make,  string model, int year, string color, decimal price = 0, int miles = 0, bool isNew = true, decimal sizeOfEngine = 0)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
            Miles = miles;
            IsNew = isNew;
            SizeOfEngine = sizeOfEngine;
        }

        public Car() 
        {
            Make = "Nothing yet";
            Model = "Nothing yet";
            Year = 0; 
            Price = 0;
            Color = "Nothing yet";
            Miles = 0;
            IsNew = true;
            SizeOfEngine = 0;
        }
        public override string ToString()
        {
            return $"{Year} {Make} {Model} {Color} {Miles} - New car: {IsNew} - Engine size = {SizeOfEngine} - ${Price}";
        }

    }
}
