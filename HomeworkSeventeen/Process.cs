namespace HomeworkSeventeen
{
    public static class Process
    {
        public static void GetPersonDetails(PersonModel person)
        {
            Console.WriteLine("PERSON DETAILS");
            Console.WriteLine();

            Console.Write("Enter first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter age: ");
            int.TryParse(Console.ReadLine(), out int age);
            person.Age = age;
        }

        public static void GetAddressDetails(AddressModel address)
        {
            Console.WriteLine("ADRESS DETAILS");
            Console.WriteLine();

            Console.Write("Enter street: ");
            address.Street = Console.ReadLine();

            Console.Write("Enter city: ");
            address.City = Console.ReadLine();

            Console.Write("Enter state: ");
            address.State = Console.ReadLine();

            Console.Write("Enter country: ");
            address.Country = Console.ReadLine();
        }

        public static void ShowGatheredDetails(PersonModel person, AddressModel address)
        {
            Console.WriteLine("GATHERED DETAILS");
            Console.WriteLine();

            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"State: {address.State}");
            Console.WriteLine($"Country: {address.Country}");
        }
    }
}
