using CitizenLinq;
using System.Diagnostics.Metrics;

List<Country> countries = Class.FillCountry();
List<City> cities = Class.FillCity();
List<Street> streets = Class.FillStreet();
List<HomeAddress> homeAddresses = Class.FillHomeAddress();
List<People> peoples = Class.FillPeople();

var adults = Class.GetAdults(peoples);

foreach (var item in adults)
{
    Console.WriteLine($"{item.Name}, {item.Surname}");
}

Console.WriteLine("=======================================");

var saratovCitizens = Class.GetSaratovCitizens(peoples, homeAddresses, streets, cities);

foreach (var item in saratovCitizens)
{
    Console.WriteLine($"{item.Name}, {item.Surname}");
}

Console.WriteLine("=======================================");

var sadovayaCities = Class.GetSadovayaCities(streets, cities);

foreach (var item in sadovayaCities)
{
    Console.WriteLine(item);
}

Console.WriteLine("=======================================");

var allCitizens = Class.GetAllCitizensInfo(peoples, homeAddresses, streets, cities, countries);

foreach (var item in allCitizens)
{
    Console.WriteLine($"{item.Surname}, {item.Name}, {item.Country}, {item.City}, {item.Street}, {item.HomeNumber}, {item.Apartment}");
}

Console.WriteLine("=======================================");

var age = Class.GetAverangeAge(peoples, homeAddresses, streets, cities, countries);

Console.WriteLine($"Средний возвраст: {Math.Round(age)}");