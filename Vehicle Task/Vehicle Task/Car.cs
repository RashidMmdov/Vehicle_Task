using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Task
{
    internal class Car : Vehicle
    {
        public int FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;
        public Car(int capacity, double currentfule, double fuelfor1km, string brand, string color, int mill) : base(brand, color, mill)
        {
            FuelCapacity = capacity;
            CurrentFuel = currentfule;
            FuelFor1km = fuelfor1km;


        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Car brand: {Brand}, Car color: {Color}, Car total milage:{Millage}, Car fuel capacity: {FuelCapacity}.");
        }
        public void Drive()
        {
            bool Search = false;
            if (FuelCapacity >= CurrentFuel)
            {


                Console.WriteLine("Qeth edilecek Km - i qeyd edin:");
                double PassMill = Convert.ToDouble(Console.ReadLine());

                double KmAddLitr = PassMill * FuelFor1km;

                CurrentFuel -= KmAddLitr;
                Console.WriteLine("Var olan benzinle yol gede bilecek?");
                // >=0 yazmagimin sebebi mentiqi olaraq 2km liq benzin varsa benzin 0 olduqda 2 km qeth edilecek
                if (CurrentFuel >= 0)
                {
                    Search = true;
                    Console.WriteLine(Search);
                    Console.WriteLine($"\nQalan benzin: {CurrentFuel} L");
                    Console.WriteLine($"Gedilen yol: {Millage + PassMill} Km");

                }
                else
                {
                    Console.WriteLine(Search);
                }
            }
            else
            {
                Console.WriteLine("Girdiyiniz current fuel bakin hecminden coxdur!!!");
            }

        }
    }
}
