using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.OPPS.Car
{
    class Car
    {
        float price;
        string modal;
        string color;

        public Car(float price,string modal,string color)
        {
            this.Price = price;
            this.Modal = modal;
            this.Color = color;
        }

        public float Price { get => price; set => price = value; }
        public string Modal { get => modal; set => modal = value; }
        public string Color { get => color; set => color = value; }

        public void Display()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine($"Car Price = {this.price}\nCar Modal = {this.modal}\nCar Color = {this.color}");
            Console.WriteLine("*************************************************");
            Console.WriteLine();
        }
    }
}
