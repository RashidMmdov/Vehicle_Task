using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Task
{
    internal class CarList
    {
        public Car[] CarArr;
        public CarList()
        {
            CarArr = new Car[0];
        }
        public Car[]  AddCar(Car model)
        {
            Array.Resize(ref CarArr, CarArr.Length + 1);
            CarArr[CarArr.Length - 1] = model;
            return CarArr;
        }
    }
}
