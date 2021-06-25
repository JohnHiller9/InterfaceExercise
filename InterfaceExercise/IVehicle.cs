using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        //Vehicle Properties -----
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        public bool HasEngine { get; set; }
        public int Wheels { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedG { get; set; }

        //Methods -
        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
    }


}
