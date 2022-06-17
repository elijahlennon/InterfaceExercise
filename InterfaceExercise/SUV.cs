using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle
    {
        public SUV()
        {
        }

        public double EngineSize { get; set; } = 6.6;
        public string Make { get; set; } = "Hyundai";
        public string Model { get; set; } = "Sonata";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Hyundai";
        public string Motto { get; set; } = "New Thinking, New Possibilities";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Big ol' {GetType().Name} now driving forward. . .");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"Big ol' {GetType().Name} Now driving backward. . . ");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
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
