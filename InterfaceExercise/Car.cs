using System;
namespace InterfaceExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }
          
        public double EngineSize    { get; set; } = 6.6;
        public string Make          { get; set; } = "Hyundai";
        public string Model         { get; set; } = "Sonata";
        public int SeatCount        { get; set; } = 5;
        public string CompanyName   { get; set; } = "Hyundai";
        public string Motto         { get; set; } = "New Thinking, New Possibilities";
        public bool HasChangedGears { get; set; } 

        public void Drive()
        {
            Console.WriteLine($"Tiny little {GetType().Name} Now driving forward. . .");
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"Tiny little {GetType().Name} Now driving backward. . . ");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears");
            }
        }

        public void Park()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . . ");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears.");
            }

        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
 

    }
}
