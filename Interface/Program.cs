namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicle1 = new Car();
            var vehicle2 = new Car();
            var vehicle3 = new Boat();
            var vehicle4 = new Boat();
            var vehicle5 = new Boat();
            var vehicle6 = new Boat();
            List<Itransportation> vehicles = new List<Itransportation>();
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(vehicle3);
            vehicles.Add(vehicle4);
            vehicles.Add(vehicle5);
            vehicles.Add(vehicle6);
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
        }
    }
}