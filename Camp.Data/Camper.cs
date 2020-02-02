using System;
using System.Collections.Generic;

namespace Camp.Data
{
    public class Camper 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public string BunkName { get; set; } 
        public bool Allergies { get; set; }
        public string AllergyFoods { get; set; }
        public int Year { get; set; }
        public string FatherFirstName { get; set; }
        public string FatherLastName { get; set; }
        public string FatherPhoneNumber { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherLastName { get; set; }
        public string MotherPhoneNumber { get; set; }
        public string EmergencyContactFirstName { get; set; }
        public string EmergencyContactLastName { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }


    }

    public class Bunk
    {
        public int Id { get; set; }
        public string BunkName { get; set; }
        public List<Camper> Campers { get; set; }

    }
  


}
