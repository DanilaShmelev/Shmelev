using ClassUser;

try
{
    User userOne = new("Dima", "Daniil", null, DateTime.Parse("01.01.2010"), "kimetsu");
    Console.WriteLine(userOne.ToString());
    userOne.FillByString("Kimetsu, Danils, ShmelevdD, shmel29960707@gmail.com, 15.12.2000");
    Console.WriteLine(userOne.ToString());
}
catch (Exception error)
{
    Console.WriteLine("Eror: " + error.Message);
}