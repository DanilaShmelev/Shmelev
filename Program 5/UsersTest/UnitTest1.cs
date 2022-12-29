namespace UsersTest
{
    namespace Users.Tests
    {
        [TestClass]
        public class UserTests
        {
            private User test;

            [TestInitialize]
            public void Initialize()
            {
                test = new("Name", "Surname", "login");
            }

            [TestMethod]
            public void FirstConstructorTest() 
            {
                string name = "Danila";
                string surname = "Shmelev";
                string email = "shmel29960707@gmail.com";
                DateTime birthday = new DateTime(2003, 08, 30);
                string login = "Kimetsu";

                test = new(name, surname, email, birthday, login);

                Assert.AreEqual(name, test.Name);
                Assert.AreEqual(surname, test.Surname);
                Assert.AreEqual(email, test.Email);
                Assert.AreEqual(birthday, test.DateOfBirth);
                Assert.AreEqual(login, test.Login);
            }

            [TestMethod]
            public void SecondConstructorTest() 
            {
                string name = "Danila";
                string surname = "Shmelev";
                string? email = null;
                DateTime? birthday = null;
                string login = "Kimetsu";

                test = new(name, surname, null, null, login);

                Assert.AreEqual(name, test.Name);
                Assert.AreEqual(surname, test.Surname);
                Assert.AreEqual(email, test.Email);
                Assert.AreEqual(birthday, test.DateOfBirth);
                Assert.AreEqual(login, test.Login);
            }

            [DataTestMethod]
            [DataRow("Danila")]
            [DataRow("ƒ‡ÌËÎ‡")]
            [DataRow("¿ÎËÌ‡")]
            public void GoodNameTests(string goodName)
            {
                test.Name = goodName;

                Assert.AreEqual(goodName, test.Name);
            }

            [DataTestMethod]
            [DataRow("DaÌËÎ‡")]
            [DataRow("danila")]
            [DataRow(null)]
            [DataRow(" ÓÎˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇˇ")]
            [ExpectedException(typeof(MyException))]
            public void BadNameTests(string badName)
            {
                test.Name = badName;
            }


            [DataTestMethod]
            [DataRow("Shmelev")]
            [DataRow("ÿÏÂÎÂ‚")]
            [DataRow("Ã‡ÏËÌ-—Ë·ËˇÍ")]
            public void GoodSurnameTests(string goodSurname)
            {
                test.Surname = goodSurname;

                Assert.AreEqual(goodSurname, test.Surname);
            }

            [DataTestMethod]
            [DataRow("ShmelevD")]
            [DataRow("ÿÏÂlev")]
            [DataRow("ÔÂÚÓ‚")]
            [DataRow(null)]
            [DataRow("»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡»‚‡ÌÓ‚‡‡‡‡‡‡‡‡‡‡‡‡‡‡")]
            [ExpectedException(typeof(MyException))]
            public void BadSurnameTests(string badSurname)
            {
                test.Surname = badSurname;
            }


            [DataTestMethod]
            [DataRow("a@mail.ru")]
            [DataRow("alex@a.ru")]
            [DataRow("alex@aa.ss.dd.ff.gg.hh.jj.kk.ru")]
            public void GoodEmailTests(string goodEmail)
            {
                test.Email = goodEmail;

                Assert.AreEqual(goodEmail, test.Email);
            }

            [DataTestMethod]
            [DataRow("_aa@mail.ru")]
            [DataRow("aa_@mail.ru")]
            [DataRow("aa@.ru")]
            [DataRow("aa@w..ru")]
            [ExpectedException(typeof(MyException))]
            public void BadEmailTests(string badEmail)
            {
                test.Email = badEmail;
            }

            [TestMethod]
            public void FirstGoodBirthdayTest()
            {
                DateTime expectedDate = new DateTime(2000, 12, 12); 

                test.DateOfBirth = expectedDate; 

                Assert.AreEqual(expectedDate, test.DateOfBirth); 
            }

            [TestMethod]
            public void SecondGoodBirthdayTest()
            {
                DateTime? expectedDate = null;

                test.DateOfBirth = expectedDate;

                Assert.AreEqual(expectedDate, test.DateOfBirth);
            }

            [TestMethod]
            [ExpectedException(typeof(MyException))]
            public void BadBirthdayTest()
            {
                DateTime expectedDate = DateTime.Now.AddDays(1);

                test.DateOfBirth = expectedDate;
            }

            [DataTestMethod]
            [DataRow("Kimetsu")]
            [DataRow("K")]
            [DataRow("QWERTY")]
            public void GoodLoginTests(string goodLogin)
            {
                test.Login = goodLogin;

                Assert.AreEqual(goodLogin, test.Login);
            }

            [DataTestMethod]
            [DataRow("123")]
            [DataRow("User1")]
            [DataRow("1First1")]
            [DataRow("_www_")]
            [DataRow(null)]
            [ExpectedException(typeof(MyException))]
            public void BadLoginTests(string badLogin)
            {
                test.Login = badLogin;
            }

            [TestMethod]
            [ExpectedException(typeof(NullReferenceException))]
            public void NullLoginTest()
            {
                test.Login = null;
            }

            [TestMethod]
            public void FirstToStringTest()
            {
                string name = "Danila";
                string surname = "Shmelev";
                string email = "shmel29960707@gmail.com";
                DateTime birthday = new DateTime(2003, 08, 30);
                string login = "Kimetsu";

                string expected = $"{login}, {name}, {surname}, {email}, {birthday.ToString("dd-MM-yyyy")}"; 

                test = new(name, surname, email, birthday, login);
                string result = test.ToString(); 

                Assert.AreEqual(expected, result); 
            }

            [TestMethod]
            public void SecondToStringTest()
            {
                string name = "»‚‡Ì";
                string surname = "»‚‡ÌÓ‚";
                string? email = null;
                DateTime? birthday = null;
                string login = "user";

                string expected = $"{login}, {name}, {surname}, {email}, {birthday}"; 

                test = new(name, surname, email, birthday, login);
                string result = test.ToString();

                Assert.AreEqual(expected, result); 
            }

            [DataTestMethod]
            [DataRow("UserFirst, Ivan, Ivanov, ivan2301@mail.ru, 10-07-2007")]
            [DataRow("UserSecond, Dima, Smirnov, qwerty123@gmail.com, ")]
            [DataRow("UserThird, Danila, Shmelev, , 10-10-2020")]
            public void FillByStringGoodTests(string expectedStr)
            {
                test.FillByString(expectedStr);
                string result = test.ToString();

                Assert.AreEqual(expectedStr, result); 
            }

            [DataTestMethod]
            [DataRow("UserFirst, , , ivan2301@mail.ru, 10-07-2007")]
            [DataRow("UserSecond, , Smirnov, qwerty123@gmail.com, ")]
            [DataRow(", Danila, Shmelev, , 10-10-2020")]
            [ExpectedException(typeof(MyException))]
            public void FillByStringBadTests(string badString) 
            {
                test.FillByString(badString);
            }
        }
    }
}