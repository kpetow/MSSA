using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRef
{
    public class Patient
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string ssn;
        private string blood;
        private int height;
        private int weight;
        private string insurance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public string Blood
        {
            get { return blood; }
            set { blood = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Insurance
        {
            get {return insurance; }
            set { insurance = value; }
        }

        public Patient (string firstName = "first", string lastName = "last", int age = 0, int id = 0000, 
                        string ssn = "0", string blood = "unknown" , int height = 0, 
                        int weight = 0, string insurance = "unknown")
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.id = id;
            this.ssn = ssn;
            this.blood = blood;
            this.height = height;
            this.weight = weight;
            this.insurance = insurance;
        }
    }
}
