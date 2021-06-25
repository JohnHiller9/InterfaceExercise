using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        //Vehicle Properties -----
        public int Year { get; set; } = 2000 - 2020;
        public string Model { get; set; } = "Medium-Large";
        public string Make { get; set; } = "RYB";

        public bool HasEngine { get; set; } = true;
        public int Wheels { get; set; } = 8;
        public int SeatCount { get; set; } = 2;
        public bool HasChangedG { get; set; }

        //Company Properties -----
        public string CompanyName { get; set; } = "Truck.co";
        public string CoLocation { get; set; } = "America";
        public bool Manufactures { get; set; } = true;
        public string Sells { get; set; } = "Trucks";

        //Truck Properties -----
        public bool EightWheelDrive { get; set; } = true;
        public int StorageWeight { get; set; } = 10000;


        public void Drive()
        {
            if (EightWheelDrive == true)
            {
                Console.WriteLine($"8 wheel drive {GetType().Name} now driving.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving.");
            }
        }
    

        public void Reverse()
        {
            if (HasChangedG == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing.");
                HasChangedG = false;
            }
            else
            {
                Console.WriteLine($"Cannot reverse until gears have changed.");
            }

        }


        public void Park()
        {
            if (HasChangedG == true)
            {
                Console.WriteLine($"{GetType().Name} now parking.");
                HasChangedG = false;
            }
            else
            {
                Console.WriteLine($"Cannot park until gears have changed.");
            }
        }


        public void ChangeGears(bool isChanged)
        {
            HasChangedG = isChanged;
        }




        /*
        public bool HasEngine { get; set; } = true;
        public int HasWheels { get; set; } = 4;
        public bool HasSteeringWheel { get; set; } = true;
        public int HasSeats { get; set; } = 2;

        public string CompanyName { get; set; }
        public bool Manufactures { get; set; } = true;
        public bool SellsVehicles { get; set; } = true;
        */
   
    }
}
