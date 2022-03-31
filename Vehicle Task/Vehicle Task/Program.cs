using System;

namespace Vehicle_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\t~~~~VEHICLE~~~~\n");
            Console.Write("Zehmet olmasa Masin sayi qeyd edin : ");
            int Carsize = Convert.ToInt32(Console.ReadLine());
           
            CarList carList = new CarList();

            for (int i = 0; i < Carsize; i++)
            {


                Console.WriteLine("Car modeli teyin edin:");
                string Brand = Console.ReadLine();
                Console.WriteLine("Car Rengini teyin edin:");
                string Color = Console.ReadLine();
                Console.WriteLine("Car yuruyusunu teyin edin:");
                int Millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Benzin bakinin umumi hecmi:");
                int FuelCapastiy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bakda olan benzinin hecmi:");
                double CurrentFuel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1Km - e yandirdigi benzinin hecmi:");
                double FuelFor1km = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("\n----------------------------\n");


                Console.WriteLine("\t~~~New Car~~~");

                Car car = new Car(FuelCapastiy, CurrentFuel, FuelFor1km, Brand, Color, Millage);

                carList.AddCar(car);

            }
            Console.WriteLine("\nTek deyerlere gore Menu:");
            byte Enter = 0;
            do
            {
                Console.WriteLine("\n\t~~~FIRST MENU~~~");
                Console.WriteLine("1. Masinlari millage-e gore.");
                Console.WriteLine("2. Butun masinlari goster.");
                Console.WriteLine("3. Prosesi bitir.");

                Console.Write("Sellect: ");
                Enter = Convert.ToByte(Console.ReadLine());

                switch (Enter)
                {
                    case 1:
                        for (int i = 0; i < carList.CarArr.Length; i++)
                        {

                            Console.WriteLine($"Car brand: {carList.CarArr[i].Brand}, Car total milage:{carList.CarArr[i].Millage} Km.");

                        }
                        Console.WriteLine("\n------------------------\n");
                        break;
                    case 2:
                        for (int i = 0; i < carList.CarArr.Length; i++)
                        {

                            Console.WriteLine($"Car brand: {carList.CarArr[i].Brand}.");

                        }
                        Console.WriteLine("\n------------------------\n");
                        break;
                    case 3:
                        break;

                    default:
                        Console.WriteLine("Duzgun secim edin.");
                        Console.WriteLine("\n------------------------\n");
                        break;
                }

            } while (!(Enter == 3));
            byte Enter2 = 0;
            do
            {

            
            Console.WriteLine("\nUmumi deyerlere gore:");
            Console.WriteLine("\n\t~~~ SECOND MENU~~~");
            Console.WriteLine("1. MinMill ve MaxMill araligina dusen masinlari goster.");
            Console.WriteLine("2. Butun masin datalari gosterilir.");
            Console.WriteLine("3. Prosesi bitir.");
            Console.Write("Sellect: ");
             Enter2 = Convert.ToByte(Console.ReadLine());
            switch (Enter2)
            {
                case 1:
                    Console.WriteLine("Min milage araligini girin:");
                    int Min_Mill = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Max milage araligini girin:");
                    int Max_Mill = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < carList.CarArr.Length; i++)
                    {
                        if (carList.CarArr[i].Millage > Min_Mill && carList.CarArr[i].Millage < Max_Mill)
                        {
                            Console.WriteLine($"Car brand: {carList.CarArr[i].Brand}.");
                        }
                    }
                    Console.WriteLine("\n------------------------\n");
                    break;
                case 2:
                    for (int i = 0; i < carList.CarArr.Length; i++)
                    {
                        Console.WriteLine($"Car brand: {carList.CarArr[i].Brand}, Car color: {carList.CarArr[i].Color}, Car total milage:{carList.CarArr[i].Millage},");
                        Console.WriteLine($"Car fuel capacity: {carList.CarArr[i].FuelCapacity}, Car current fuel: {carList.CarArr[i].CurrentFuel}, Car fuel for 1km: {carList.CarArr[i].FuelFor1km}.");  
                        Console.WriteLine("Calling drive Methods:");
                        carList.CarArr[i].Drive();
                        Console.WriteLine("\n----------------------------\n");
                        Console.WriteLine("\t~~~New Car Value~~~");
                    }
                    Console.WriteLine("\n------------------------\n");
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin.");
                    break;
            }
            } while (!(Enter2 == 3));
            Console.WriteLine("\t~~~~FINISH~~~~");

        }
    }
}
