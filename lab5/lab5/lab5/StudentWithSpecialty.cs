using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    sealed class StudentWithSpecialty : Student
    {
        protected string faculty;

        public void AttendLesson(string action)
        {
            this.AttendMeeting(action);
        }

        public string this[string proponename]
        {
            get
            {
                switch (proponename)
                {
                    case "name": return this.name;
                    case "age": return Convert.ToString(this.age);
                    case "faculty": return this.faculty;
                    case "university": return this.university;
                    default: return null;
                }
            }

            set
            {
                int activation;
                Cheak cheak;
                switch (proponename)
                {
                    case "name":
                        activation = cheak.CheckedWord(value);
                        if (activation == 0)
                        {
                            Environment.Exit(0);
                        }

                        break;
                    case "age":
                        activation = cheak.CheckedWord(value);
                        if (activation == 0)
                        {
                            Environment.Exit(0);
                        }

                        break;
                    case "faculty":
                        activation = cheak.CheckedWord(value);
                        if (activation == 0)
                        {
                            Environment.Exit(0);
                        }

                        break;
                    case "university":
                        activation = cheak.CheckedWord(value);
                        if (activation == 0)
                        {
                            Environment.Exit(0);
                        }

                        break;
                }
            }
        }

        public StudentWithSpecialty(string name, int age, string university, string faculty)
            : base(name, age)
        {
            this["name"] = name;
            this["age"] = Convert.ToString(age);
            this["university"] = university;
            this["faculty"] = faculty;

            this.university = university;
            this.faculty = faculty;
        }

        public StudentWithSpecialty()
            : base()
        {
            this.university = string.Empty;
            this.faculty = string.Empty;
        }

        public void EnterTheUniversity()
        {
            Console.WriteLine("You haven't got documents,you may not be allowed");
        }

        public void EnterTheUniversity(string doc)
        {
            if (doc == "StudentBilet")
            {
                Console.WriteLine("All is ok.You have got " + doc);
            }
            else if (doc == "FakeBilet")
            {
                Console.WriteLine("You are kamikaze,be careful with " + doc);
            }
            else
            {
                Console.WriteLine("I dont now this type");
            }
        }

        public void PrintInfo()
        {
            this.PrintInfoAboutOrganizm();
            Console.WriteLine("university = " + this.university + "\nfaculty = " + this.faculty);
        }
    }
}
