using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Task
{
    internal class Vehicle
    {
        public string Brand;
        public string Color;
        public int Millage;
        // Car ucun constructor
        public Vehicle(string brand,string color,int mill)
        {
            Brand = brand;
            Color = color;
            Millage = mill;
        }
        // Bycle ucun constructor ,cunki velosbetde bu gune qeder qet etdiyi km olmur
        public Vehicle(string brand,string color)
        {
            Brand = brand;
            Color = color;
            
        }
        public virtual void ShowInfo()
        {

        }
    }
}
