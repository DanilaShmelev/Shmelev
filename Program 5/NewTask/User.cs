using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ClassUser
{
    public class User
    {
        private string _name;
        private string _surname;
        private string? _email = null; 
        private DateTime? _dateOfBirth = null;
        private DateTime _dateOfRegistration;
        private string _login;

        private const int NameLength = 50;
        private const int SurnameLength = 200;
        private const int LoginLength = 20;

        private const string NamePattern = @"(?:^[А-ЯЁ][а-яА-ЯёЁ]*)$|(?:^[A-Z][a-zA-Z]*)$";
        private const string SurnamePattern = @"(?:^[A-Z](?:\-[A-Z]|[a-z])*)$|(?:^[А-ЯЁ](?:\-[А-ЯЁ]|[а-яё])*)$"; 
        private const string EmailPattern = @"(?:^[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?)@" +
                                               @"(?:[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?\.)+(?:[a-zA-Z]{2,6})$";
        private const string LoginPattern = @"^(?:[a-zA-Z])+$";
        private const string FillByStringPattern = @"([^,]*), ([^,]*), ([^,]*), ([^,]*), ([^,]*)";

        public User(string name, string surname, string? email, DateTime? dateOfBirth, string login)
        {
            Name = name;
            Surname = surname;
            Email = email;
            DateOfBirth = dateOfBirth;
            Login = login;
        }

        public User(string name, string surname, string login)
        {
            Name = name;
            Surname = surname;
            Login = login;
        }

        public string Name
        {
            set
            {
          
                if ((value!= null) && (value.Length <= NameLength) && Regex.IsMatch(value, NamePattern))
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
                
                if ((value != null) && (value.Length <= SurnameLength) && Regex.IsMatch(value, SurnamePattern))
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

                if (Regex.IsMatch(value, EmailPattern))
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

                if (value > DateTime.Now)
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
                
                if ((value != null) && (value.Length <= LoginLength) && Regex.IsMatch(value, LoginPattern))
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
                return $"{Login}, {Name}, {Surname}, {Email}, ";
            }
            else
            {
                return $"{Login}, {Name}, {Surname}, {Email}, {DateOfBirth.Value.ToString("dd-MM-yyyy")}";
            }
        }

        public void FillByString(string data)
        {
            const int groupsCount = 6;
            Match result = Regex.Match(data, FillByStringPattern);

            if (result.Groups.Count != groupsCount) 
            {
                throw new MyException("FillByString error");
            }

            Login = result.Groups[1].Value;
            Name = result.Groups[2].Value;
            Surname = result.Groups[3].Value;
            string email = result.Groups[4].Value;

            if (email == "")
            {
                Email = null;
            }
            else
            {
                Email = email;
            }

            if (result.Groups[5].Value == "")
            {
                DateOfBirth = null;
                return;
            }

            if (!DateTime.TryParse(result.Groups[5].Value, out DateTime date))
            {
                throw new MyException("DateOfBirth error");
            }

            DateOfBirth = date;
        }
    }
}
