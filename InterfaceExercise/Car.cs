using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        //Vehicle Properties -----
        public int Year { get; set; } = 2010-2020;
        public string Model { get; set; } = "Small-Large";
        public string Make { get; set; } = "RGB";

        public bool HasEngine { get; set; } = true;
        public int Wheels { get; set; } = 4;
        public int SeatCount { get; set; } = 4;
        public bool HasChangedG { get; set; }

        //Company Properties -----
        public string CompanyName { get; set; } = "Car.co";
        public string CoLocation { get; set; } = "Europe";
        public bool Manufactures { get; set; } = true;
        public string Sells { get; set; } = "Cars";

        //Car Properties -----
        public int TopSpeed { get; set; } = 120;
        public bool IsElectric { get; set; } = false;


        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving.");
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

    
        

    }       
}