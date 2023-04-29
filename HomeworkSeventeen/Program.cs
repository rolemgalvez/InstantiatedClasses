using HomeworkSeventeen;

PersonModel person = new PersonModel();
AddressModel address = new AddressModel();

Process.GetPersonDetails(person);
Console.WriteLine();
Process.GetAddressDetails(address);
Console.WriteLine();
Process.ShowGatheredDetails(person, address);

Console.ReadLine();