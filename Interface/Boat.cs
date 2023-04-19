namespace Interface
{
    class Boat : Itransportation
    {
        public string Brand { get; set; }
        public string RegistrationNumber { get; set; }

        public void Drive()
        {
            Console.WriteLine("Båten kjører");
        }
    }
}
