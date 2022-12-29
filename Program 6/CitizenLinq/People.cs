using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenLinq
{
    public class People
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int RegistrationID { get; set; }
        public int? LiveID { get; set; }

        public People(int id, string firstName, string lastName, DateTime birthday, int regId, int? liveId)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            RegistrationID = regId;
            LiveID = liveId;
        }
    }
}
