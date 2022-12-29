namespace CitizenLinq
{
    internal static class Class
    {

        public static int GetAge(DateTime Birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - Birthday.Year;
            if (Birthday > now.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public static List<Country> FillCountry()
        {
            List<Country> countries = new List<Country>()
            {
                new Country(1, "Россия"),
                new Country(2, "США"),
                new Country(3, "Германия"),
                new Country(4, "Япония")
            };

            return countries;
        }

        public static List<City> FillCity()
        {
            List<City> cities = new List<City>()
            {
                new City(1, 1, "Саратов"),
                new City(2, 1, "Москва"),
                new City(3, 2, "Нью-Йорк"),
                new City(4, 2, "Сан-Франциско"),
                new City(5, 3, "Берлин"),
                new City(6, 3, "Мюнхен"),
                new City(7, 4, "Нагоя"),
                new City(8, 4, "Киото")
            };

            return cities;
        }

        public static List<Street> FillStreet()
        {
            List<Street> streets = new List<Street>()
            {
                new Street(1, 1, "2-ая Садовая"),
                new Street(2, 1, "Большая Садовая"),
                new Street(3, 1, "Блинова"),
                new Street(4, 2, "Московская"),
                new Street(5, 3, "Уолл-стрит"),
                new Street(6, 4, "Брайант"),
                new Street(7, 5, "Фридрихштрассе"),
                new Street(8, 6, "Бургштрассе"),
                new Street(9, 7, "Сакаэ"),
                new Street(10, 8, "Такацудзи")
            };

            return streets;
        }

        public static List<HomeAddress> FillHomeAddress()
        {
            List<HomeAddress> homeAddresses = new List<HomeAddress>()
            {
                new HomeAddress(1, 1, "31-35", 1),
                new HomeAddress(2, 1, "17", 2),
                new HomeAddress(3, 3, "25", 80),
                new HomeAddress(4, 2, "45", 4),
                new HomeAddress(5, 5, "60", 55),
                new HomeAddress(6, 6, "71", 62),
                new HomeAddress(7, 7, "55", 66),
                new HomeAddress(8, 8, "90", 63),
                new HomeAddress(9, 9, "11", 61),
                new HomeAddress(10, 10, "11", 61)
            };

            return homeAddresses;
        }

        public static List<People> FillPeople()
        {
            List<People> people = new List<People>()
            {
                new People(1, "Данила", "Шмелев", new DateTime(2003, 1, 1), 2, 2),
                new People(2, "Лёша", "Иванов", new DateTime(1987, 2, 2), 3, 4),
                new People(3, "Тёма", "Смирнов", new DateTime(1970, 3, 3), 5, null),
                new People(4, "Вадик", "Смирнов", new DateTime(2000, 1, 5), 7, 1),
                new People(5, "Вова", "Кузнецов", new DateTime(2005, 3, 7), 8, 3),
                new People(6, "Валя", "Попова", new DateTime(1998, 4, 4), 9, null),
                new People(7, "Дима", "Васильев", new DateTime(1991, 2, 1), 3, 7),
                new People(8, "Егор", "Петров", new DateTime(1978, 3, 5), 8, 2),
                new People(9, "Кира", "Соколов", new DateTime(1985, 3, 1), 3, 1),
                new People(10, "Макс", "Михайлов", new DateTime(2010, 3, 7), 8, 3),
                new People(10, "Олег", "Дорофеев", new DateTime(1999, 3, 5), 2, 2),
                new People(10, "Рома", "Емельянов", new DateTime(1990, 3, 2), 2, 3),
            };

            return people;
        }

        public static List<(string Name, string Surname)> GetAdults(List<People> peoples)
        {
            List<(string, string)> list = new();
            list = (from people in peoples
                    where people.Birthday.AddYears(18) < DateTime.Now
                    select (people.FirstName, people.LastName)).ToList();

            return list;
        }

        public static List<(string Name, string Surname)> GetSaratovCitizens(List<People> peoples, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities)
        {
            List<(string, string)> list = new();
            list = (from people in peoples
                    join homeAddress in homeAddresses on people.LiveID equals homeAddress.ID
                    join street in streets on homeAddress.StreetID equals street.ID
                    join city in cities on street.CityID equals city.ID
                    where city.Title == "Саратов"
                    select (people.FirstName, people.LastName)).ToList();

            return list;
        }

        public static List<string> GetSadovayaCities(List<Street> streets, List<City> cities)
        {
            List<string> list = new List<string>();

            list = ((from street in streets
                                 join city in cities on street.CityID equals city.ID
                                 where street.Title.Contains("Садовая")
                                 select city.Title).Distinct()).ToList();

            return list;
        }

        public static List<(string Surname, string Name, string Country, string City, string Street, string HomeNumber, int Apartment)>
        GetAllCitizensInfo(List<People> peoples, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities, List<Country> countries)
        {
            List<(string, string, string, string, string, string, int)> list = new();

            list = (from people in peoples
                    join homeAddress in homeAddresses on people.RegistrationID equals homeAddress.ID
                    join street in streets on homeAddress.StreetID equals street.ID
                    join city in cities on street.CityID equals city.ID
                    join countrie in countries on city.CountryID equals countrie.ID
                    select (people.LastName, people.FirstName, countrie.Title, city.Title, street.Title, homeAddress.HomeNumber, homeAddress.Apartment)).ToList();

            return list;
        }

        public static double 
        GetAverangeAge(List<People> peoples, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities, List<Country> countries)
        {
            double age = (from people in peoples
                          join homeAddress in homeAddresses on people.RegistrationID equals homeAddress.ID
                          join street in streets on homeAddress.StreetID equals street.ID
                          join city in cities on street.CityID equals city.ID
                          join countrie in countries on city.CountryID equals countrie.ID
                          where countrie.Title == "Россия" && city.Title == "Саратов" && street.Title == "2-ая Садовая" && homeAddress.HomeNumber == "17" && people.RegistrationID == people.LiveID
                          select GetAge(people.Birthday)).Average();

            return age;
        }
    }
}
