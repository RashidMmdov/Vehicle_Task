using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Task
{
    internal class Bycle:Vehicle
    {
        public Bycle(string brand,string color):base(brand,color)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Bycle brand: {Brand}, Bycle color: {Color}.");
        }
        public void Drive()
        {
            Console.WriteLine("Qeth edilecek Km - i qeyd edin:");
            double PassMill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Qeth edilen Km: {PassMill}");
        }
    }
}
