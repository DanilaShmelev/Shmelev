namespace LastPerson
{
    internal static class Class
    {
        public static Queue<int> Fill(int N)
        {
            Queue<int> temp = new Queue<int>();

            for (int i = 1; i <= N; i++)
            {
                temp.Enqueue(i);
            }
             
            return temp;
        }

        public static List<int> DeletePersons(Queue<int> temp)
        {
            if (temp is null)
            {
                throw new ArgumentNullException();
            }

            List<int> deletedPersons = new();

            while (temp.Count > 1)
            {
                int i = temp.Dequeue();
                temp.Enqueue(i);
                int deleted = temp.Dequeue();
                deletedPersons.Add(deleted);
            }

            return deletedPersons;
        }
    }
}
