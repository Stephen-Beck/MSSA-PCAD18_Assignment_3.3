namespace Assignment_3._3
{
    public class Student
    {
        public enum Month { Unknown = 0, Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
        private static int studentID =1;
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public char Grade { get; set; }

        public Student()
        {
            StudentID = studentID++;
        }

        public static List<Student> PopulateStudents()
        {
            return new List<Student>()
            {
                new Student() { FirstName = "Mark",  LastName = "Meta",     Address = "Brooklyn, NY", MonthOfAdmission = Month.Aug, Grade = 'F'},
                new Student() { FirstName = "Linus", LastName = "Linux",    Address = "Brooklyn, NY", MonthOfAdmission = Month.Jun, Grade = 'A'},
                new Student() { FirstName = "Val",   LastName = "Gaben",    Address = "Brooklyn, NY", MonthOfAdmission = Month.Jul, Grade = 'A'},
                new Student() { FirstName = "Billy", LastName = "Windows",  Address = "Brooklyn, NY", MonthOfAdmission = Month.Aug, Grade = 'B'},
                new Student() { FirstName = "Tim",   LastName = "Apple",    Address = "Brooklyn, NY", MonthOfAdmission = Month.Aug, Grade = 'C'},
                new Student() { FirstName = "Jack",  LastName = "Twitter",  Address = "Brooklyn, NY", MonthOfAdmission = Month.Sep, Grade = 'C'},
                new Student() { FirstName = "Sammy", LastName = "Crypto",   Address = "Brooklyn, NY", MonthOfAdmission = Month.Aug, Grade = 'F'},
                new Student() { FirstName = "Larry", LastName = "O'Racle",  Address = "Brooklyn, NY", MonthOfAdmission = Month.Jul, Grade = 'A'},
                new Student() { FirstName = "Bill",  LastName = "Snow",     Address = "Brooklyn, NY", MonthOfAdmission = Month.Jul, Grade = 'D'},
                new Student() { FirstName = "Paul",  LastName = "Anteer",   Address = "Brooklyn, NY", MonthOfAdmission = Month.Aug, Grade = 'B'}
            };
        }
    }
}
