using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.OPPS.Car
{
    class CarMain
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("enter car Price");
                float price = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Modal");
                string modal = Console.ReadLine();

                Console.WriteLine("enter Color");
                string color = Console.ReadLine();
                Car car = new Car(price, modal, color);
                car.Display();
                Console.WriteLine("You want to add more details (y/n)");
                char f = Convert.ToChar(Console.ReadLine());
                if (f == 'N' || f == 'n')
                {
                    break;
                }
            } while (true);

        }
    }
}
