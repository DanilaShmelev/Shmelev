using LastPerson;

const int N = 10;

Queue<int> persons = Class.Fill(N);
List<int> deletedPersons = Class.DeletePersons(persons);
if (deletedPersons.Count > 0)
{
    Console.Write("Удаление производилось в таком порядке: ");

    foreach (var item in deletedPersons)
    {
        Console.Write(item + " ");
    }

    Console.Write("\n");
}

Console.WriteLine($"В кругу остался {persons.Dequeue()}");