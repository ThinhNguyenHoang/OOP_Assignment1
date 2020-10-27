using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    enum TypeVehicle
    {
        Car=0,
        Truck=1,
        
    }
    enum TypeCar
    {
        FourChairclassic,
        SevenChairclassic,
        Sport,
        Luxury,

    }
    enum TypeTruck
    {
        PartTruck,
        Contener,
        Ben,
    }

    abstract class Vehicle 
    {
        protected  string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected int id;
        public int idVehicle
        {
            get { return id; }
            set { id = value; }
        }

        public string Branch { get => branch; set => branch = value; }
        protected string Description { get => description; set => description = value; }
        protected string RoleId { get => roleId; set => roleId = value; }
        protected TypeVehicle Type { get => type; set => type = value; }
        public bool Maintain { get => maintain; set => maintain = value; }
        public bool Used1 { get => Used; set => Used = value; }

        protected string branch;
        protected string description;
        protected string roleId;
        protected TypeVehicle type;
        protected bool maintain;
        protected bool Used;
    }
    class Car : Vehicle
    {
       private  TypeCar typeCar;

        public TypeCar TypeCar { get => typeCar; set => typeCar = value; }
    }
    class Truck : Vehicle
    {
        private TypeTruck typeTruck;

        public TypeTruck TypeTruck { get => typeTruck; set => typeTruck = value; }
    }
    abstract class Account
    {
        protected string name;

        public string Name { get => name; set => name = value; }
       public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        protected string password;
        protected string email;
        protected string phoneNumber;
    }
    class Custormer : Account
    {
       
    }
    class Manager : Account
    {

    }
    class Staff : Account
    {

    }
    
}
