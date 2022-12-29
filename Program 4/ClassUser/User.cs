using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ClassUser
{
    internal class User
    {
        private string _name;
        private string _surname;
        private string? _email;
        private DateTime? _dateOfBirth;
        private DateTime _dateOfRegistration;
        private string _login;

        private const int NameLength = 50;
        private const int SurnameLength = 200;
        private const int LoginLength = 20;

        public User(string name, string surname, string? email, DateTime? dateOfBirth, string login)
        {
            Name = name;
            Surname = surname;
            Email = email;
            DateOfBirth = dateOfBirth;
            Login = login;
        }

        public string Name
        {
            set
            {
                string pattern = @"(?:^[А-ЯЁ][а-яА-ЯёЁ]*)$|(?:^[A-Z][a-zA-Z]*)$"; //const 

                if ((value.Length <= NameLength) && Regex.IsMatch(value, pattern))
                {
                    _name = value;
                }
                else
                {
                    throw new MyException("Имя не соответствует длине(>50) или не соответствует формату имени"); 
                }
            }
            get
            {
                return _name;
            }
        }

        public string Surname
        {
            set
            {
                string pattern = @"(?:^[A-Z](?:\-[A-Z]|[a-zA-Z])*)$|(?:^[А-ЯЁ](?:\-[А-ЯЁ]|[а-яА-ЯёЁ])*)$";

                if ((value.Length <= SurnameLength) && Regex.IsMatch(value, pattern))
                {
                    _surname = value;
                }
                else
                {
                    throw new MyException("Фамилия не соответствует длине(>200) или не соответствует формату фамилии");
                }
            }
            get
            {
                return _surname;
            }
        }

        public string? Email
        {
            set
            {
                if (value is null)
                {
                    _email = null;
                    return;
                }

                string pattern = @"(?:^[\w](?:[a-zA-Z0-9\-_]*[\w])?)@(?:[\w](?:[a-zA-Z0-9\-_]*[\w])?\.)+(?:[a-zA-Z]{2,6})$";

                if (Regex.IsMatch(value, pattern))
                {
                    _email = value;
                }
                else
                {
                    throw new MyException("Email не соответствует формату Email");
                }
            }
            get
            {
                return _email;
            }
        }

        public DateTime? DateOfBirth
        {
            set
            {
                if (value is null)
                {
                    _dateOfBirth = null;
                    return;
                }

                if ((value > DateTime.Now) || (value < DateTime.Parse("01.01.1900")))
                {
                    throw new MyException("Такой даты рождения не может быть!");
                }
                else
                {
                    _dateOfBirth = value;
                }
            }
            get
            {
                return _dateOfBirth;
            }
        }

        public DateTime DateOfRegistration
        {
            set
            {
                DateOfRegistration = value;
            }
            get
            {
                return _dateOfRegistration;
            }
        }

        public string Login
        {
            set
            {
                string pattern = @"^(?:[a-zA-Z])+$";

                if ((value.Length <= LoginLength) && Regex.IsMatch(value, pattern))
                {
                    _login = value;
                }
                else
                {
                    throw new MyException("Login не соответствует длине(>20) или не соответствует формату login");
                }
            }
            get
            {
                return _login;
            }
        }

        public override string ToString()
        {
            if (DateOfBirth is null)
            {
                return $"{Login}, {Name}, {Surname}, {Email},";
            }
            else
            {
                return $"{Login}, {Name}, {Surname}, {Email}, {DateOfBirth.Value.ToString("dd-MM-yyyy")}";
            }
        }

        public void FillByString(string data)
        {
            string pattern = @"([^,]*), ([^,]*), ([^,]*), ([^,]*), ([^,]*)";
            Match result = Regex.Match(data, pattern);

            if (result.Groups.Count != 6)
            {
                throw new MyException("FillByString error");
            }

            Login = result.Groups[1].Value;
            Name = result.Groups[2].Value;
            Surname = result.Groups[3].Value;
            Email = result.Groups[4].Value;

            if (!DateTime.TryParse(result.Groups[5].Value, out DateTime date))
            {
                throw new MyException("DateOfBirth error");
            }

            DateOfBirth = date;
        }
    }
}
