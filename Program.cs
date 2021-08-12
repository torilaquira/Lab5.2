using System;
using System.Collections.Generic;

namespace Lab5_2
{
    enum CarMake
    {
        Ford,
        Chevrolet,
        Chrysler,
        Honda,
        Toyota
    }

    class Car
    {
        protected CarMake Make;
        protected string Model;
        protected int Year;
        protected int Price;


        public Car(CarMake nMake, string nModel, int nYear, int nPrice)
        {
            Make = nMake;
            Model = nModel;
            Year = nYear;
            Price = nPrice;

        }
        public override string ToString()
        {
            return $"{Make} {Model} {Year} {Price}";
        }
    }
    class NewCar : Car
    {
        protected bool ExtendedWarranty;


        public NewCar(CarMake nMake, string nModel, int nYear, int nPrice, bool nExtendedWarranty) : base(nMake, nModel, nYear, nPrice)
        {
            ExtendedWarranty = nExtendedWarranty;
        }
        public override string ToString()
        {
            return $" {base.ToString()} (Extended Warranty: {ExtendedWarranty})";
        }
    }

    class UsedCar : Car
    {
        protected int NumberofOwners;
        protected int Mileage;

        public UsedCar(CarMake nMake, string nModel, int nYear, int nPrice, int nNumberofOwners, int nMileage) : base(nMake, nModel, nYear, nPrice)
        {
            NumberofOwners = nNumberofOwners;
            Mileage = nMileage;
        }

        public override string ToString()
        {
            return $" {base.ToString()} (Number of Owners: {NumberofOwners} Mileage: {Mileage})";
        }
    }






    class Program
    {
        public static void Add(List<Car> TheList)
        {
            Console.Write("Is this a (U)sed Car or (N)ew Car: ");
            string entry = Console.ReadLine();

            Console.WriteLine("Please enter the details for the car!");
            Console.Write("Make: ");
            string _makestr = Console.ReadLine();
            CarMake _make = CarMake.Chevrolet;
            switch (_makestr)
            {
                case "Chevrolet":
                    _make = CarMake.Chevrolet;
                    break;
                case "Ford":
                    _make = CarMake.Ford;
                    break;
                case "Chrysler":
                    _make = CarMake.Chrysler;
                    break;
                case "Honda":
                    _make = CarMake.Honda;
                    break;
                case "Toyota":
                    _make = CarMake.Toyota;
                    break;
            }
            Console.Write("Model: ");
            string _model = Console.ReadLine();
            Console.Write("Year: ");
            string _Yearstr = Console.ReadLine();
            int _year = int.Parse(_Yearstr);
            Console.Write("Price: ");
            string _pricestr = Console.ReadLine();
            int _price = int.Parse(_pricestr);

            if (entry == "N")
            {
                Console.Write("Extended Warranty (True/False): ");
                string warrant = Console.ReadLine();
                bool nwarrant = bool.Parse(warrant);


                NewCar inst = new NewCar(_make, _model, _year, _price, nExtendedWarranty: nwarrant);
                TheList.Add(inst);
            }
            else
            {
                Console.Write("Number of Owners: ");
                string numO = Console.ReadLine();
                int _numO = int.Parse(numO);

                Console.Write("Mileage: ");
                string milO = Console.ReadLine();
                int _milO = int.Parse(milO);

                UsedCar inst = new UsedCar(_make, _model, _year, _price, _milO, _numO);
                TheList.Add(inst);
            }
        }
            static void Main(string[] args)
            {
                List<Car> mylist = new List<Car>();
                Car mycar;
                mycar = new UsedCar(CarMake.Chevrolet, "Trax", 2020, 150000, 2, 10000);
                mylist.Add(mycar);
                mycar = new UsedCar(CarMake.Chrysler, "Charger", 2015, 20000, 1, 32000);
                mylist.Add(mycar);
                mycar = new UsedCar(CarMake.Ford, "Fusion", 2010, 10000, 4, 59000);
                mylist.Add(mycar);
                mycar = new NewCar(CarMake.Ford, "Fusion", 2022, 25000, true);
                mylist.Add(mycar);
                mycar = new NewCar(CarMake.Chevrolet, "Equinox", 2020, 25000, true);
                mylist.Add(mycar);
                mycar = new UsedCar(CarMake.Toyota, "Corolla", 2015, 12000, 1, 10250);
                mylist.Add(mycar);
                while (true)
                {
                    foreach (Car car in mylist)
                    {
                        Console.WriteLine(car);
                    }

                    Console.WriteLine("Would you like to (A)dd a vehicle or (Q)uit?: ");
                    string entry = Console.ReadLine();

                    if (entry == "A")
                    {
                        Add(mylist);
                    }
                    else
                    {
                        Console.WriteLine("Thank you for visiting us!");
                        break;

                    }
                    
                }

            }
        }
    }





