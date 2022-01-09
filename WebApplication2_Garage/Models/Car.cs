using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2_Garage.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string NameOwner { get; set; }
        public int NumCar { get; set; }
        public string Status { get; set; }

        public Car(int iD, string nameOwner, int numCar, string status)
        {
            ID = iD;
            NameOwner = nameOwner;
            NumCar = numCar;
            Status = status;
        }
        public Car() { }
    }
}