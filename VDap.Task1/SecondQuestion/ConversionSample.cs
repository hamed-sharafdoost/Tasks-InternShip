using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.SecondQuestion
{
    public class ConversionSample
    {
        public static void DoConversion()
        {
            //Unboxing conversion
            Console.Write("Enter a number :");
            string input = Console.ReadLine() ?? "1";
            int number = Convert.ToInt32(input);
            Console.WriteLine($"The square of {number} is : {number * number}");

            //Implicit casting-Smaller type is converted to the bigger type
            int num1 = 3;
            double num2 = num1;
            Console.WriteLine("Implicit casting : " + num2);
            //Explicit casting-Data will be lost due to this casting
            double num3 = 250.6;
            int num4 = (int)num3;
            Console.WriteLine("Explicit casting : " + num4);

            //Reference type conversion
            Car car = new Car { Wheels = 8,Price = 140000,Model = "Scania"};
            Vehicle vehicle = car;
            car = (Car)vehicle;
            Console.WriteLine($"Wheels : {car.Wheels} , Price : {car.Price} , Model : {car.Model}");

            //Boxing conversion
            int num5 = 5;
            object obj = num5;


            //Custom conversion
            Flower flower = new Flower { Color = "Red" };
            string color = flower;
            Console.WriteLine($"Color of flower using implicit operator : {color}");
            string newcolor = "Pink";
            Flower newflower = (Flower)newcolor;
            Console.WriteLine($"Color of newflower is : {newflower.Color}");
        }
    }
    public class Vehicle
    {
        public int Wheels { get; set; }
        public double Price { get; set; }
    }
    public class Car : Vehicle
    {
        public string Model { get; set; }
    }
    public class Flower
    {
        public string Color { get; set; }
        public static implicit operator string(Flower flower) => flower.Color;
        public static explicit operator Flower(string color) => new Flower { Color = color };
    }
}
