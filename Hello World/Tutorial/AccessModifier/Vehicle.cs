namespace AccessModifier
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            System.Console.WriteLine("Vehicle initialized with registration number");
        }


    }
}
