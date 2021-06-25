using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        //Vehicle Properties -----
        public int Year { get; set; } = 2005 - 2020;
        public string Model { get; set; } = "Small-Medium";
        public string Make { get; set; } = "RYGB";

        public bool HasEngine { get; set; } = true;
        public int Wheels { get; set; } = 4;
        public int SeatCount { get; set; } = 6;
        public bool HasChangedG { get; set; }

        //Company Properties -----
        public string CompanyName { get; set; } = "SUV.co";
        public string CoLocation { get; set; } = "Japan";
        public bool Manufactures { get; set; } = true;
        public string Sells { get; set; } = "SUVs";

        public bool SUVairbags { get; set; } = true;
        public int TrunkSizeFeet { get; set; } = 5;


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