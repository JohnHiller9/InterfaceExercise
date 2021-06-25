using System;
namespace InterfaceExercise
{
    public interface ICompany
    {
        //Company Properties -----
        public string CompanyName { get; set; }
        public string CoLocation { get; set; }
        public bool Manufactures { get; set; }
        public string Sells { get; set; }
    }
}
