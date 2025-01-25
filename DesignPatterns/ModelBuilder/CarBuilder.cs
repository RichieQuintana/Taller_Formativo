using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilder
{
	public class CarBuilder
	{
		private string color = "red";
		private string brand = "Ford";
		private string model = "Mustang";
		private int year = DateTime.Now.Year;

		public CarBuilder setColor(string color)
		{
			this.color = color;
			return this;
		}
		public CarBuilder setBrand(string brand)
		{
			this.brand = brand;
			return this;
		}

		public CarBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }
		
		public CarBuilder setYear(int year)
        {
            this.year = year;
            return this;
        }

        public Vehicle Build()
		{
			return new Car(color, brand, model,year);
		}
	}
}
