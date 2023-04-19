namespace Interface
{
    class Car : Itransportation
    {
        public string Brand { get; set; }
        public string RegistrationNumber { get; set; }

        public void Drive()
        {
            Console.WriteLine("Bilen kjører");
        }
    }
}
