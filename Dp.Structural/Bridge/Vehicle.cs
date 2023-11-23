namespace Dp.Structural.Bridge
{
    // Top level abstraction
    internal abstract class Vehicle
    {
        protected IMake make;

        public void Start()
        {
            make.PerformRitual();
            make.StartCar();
        }

        public abstract bool AllowedToDrive(string person);
    }

    internal interface IMake
    {
        void PerformRitual();
        void StartCar();
    }

    // implementation
    internal class Lada : IMake
    {
        public void PerformRitual()
        {
            Console.WriteLine("Hit the car");
        }

        public void StartCar()
        {
            Console.WriteLine("fix the wiring");
            Console.WriteLine("lube the engine");
            Console.WriteLine("put the key in");
            Console.WriteLine("turn the key");
        }
    }

    internal class Volvo : IMake
    {
        public void PerformRitual()
        {
            Console.WriteLine("Greateful for buying a volvo");
        }

        public void StartCar()
        {
            Console.WriteLine("Press button");
        }
    }

    // lower level abstraction
    internal class Car : Vehicle
    {
        public Car(IMake make)
        {
            this.make = make;
        }

        public override bool AllowedToDrive(string person)
        {
            return person == "has license";
        }
    }

    internal class Truck : Vehicle
    {
        public Truck(IMake make)
        {
            this.make = make;
        }

        public override bool AllowedToDrive(string person)
        {
            return person == "has special truck license";
        }
    }
}
