using System;

namespace lab3
{
    class Human
    {
        protected int age;
        protected string name;

        protected int CheckedNumber(string number)
        {
            try
            {
                int buf = Convert.ToInt32(number);
                if (buf < 0)
                {
                    Console.WriteLine("It is impossible age");
                    return 0;
                }
            }
            catch
            {
                Console.WriteLine("In your age letters");
                return 0;
            }

            return 1;
        }

        protected int CheckedWord(string str)
        {
            foreach (char ch in str)
            {
                if (Convert.ToChar(ch) >= 48 && Convert.ToChar(ch) <= 57)
                {
                    Console.WriteLine("Your string has numbers");
                    return 0;
                }
            }

            return 1;
        }

    }

    class Student : Human
    {
        protected string university;
    }

    class StudentWithSpecialty : Student
    {
        protected string faculty;

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
                switch (proponename)
                {
                    case "name":
                        activation = this.CheckedWord(value);
                        if (activation == 1)
                        {
                            this.name = value;
                        }

                        break;
                    case "age":
                        activation = this.CheckedNumber(value);
                        if (activation == 1)
                        {
                            this.age = Convert.ToInt32(value);
                        }

                        break;
                    case "faculty":
                        activation = this.CheckedWord(value);
                        if (activation == 1)
                        {
                            this.faculty = value;
                        }

                        break;
                    case "university":
                        activation = this.CheckedWord(value);
                        if (activation == 1)
                        {
                            this.university = value;
                        }

                        break;
                }
            }
        }

        public StudentWithSpecialty(string name, int age, string university, string faculty)
        {
            this["name"] = name;
            this["age"] = Convert.ToString(age);
            this["university"] = university;
            this["faculty"] = faculty;
        }

        public StudentWithSpecialty()
        {
            this.name = string.Empty;
            this.university = string.Empty;
            this.faculty = string.Empty;
            this.age = 0;
        }

        public void EnterTheUniversity()
        {
            Console.WriteLine("You haven't got documents,you may not be allowed");
        }

        public void EnterTheUniversity1(string doc)
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
            Console.WriteLine("Name = " + this["name"] + "\nAge = " + this["age"] + "\nuniversity = " + this["university"] + "\nfaculty = " + this["faculty"]);
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            string name, university, faculty, answer;
            int age, activation;

            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter age :");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter university :");
            university = Console.ReadLine();

            Console.WriteLine("Enter faculty :");
            faculty = Console.ReadLine();

            StudentWithSpecialty student = new StudentWithSpecialty(name, age, university, faculty);

            while (true)
            {
                Console.WriteLine("\nChoose a function:\n1) Print Info\n2) Enter the Universite\n");
                activation = Convert.ToInt32(Console.ReadLine());
                switch (activation)
                {
                    case 1:
                        student.PrintInfo();
                        break;
                    case 2:
                        Console.WriteLine("\nHave you got documents?");
                        answer = Console.ReadLine();
                        if (answer == "No")
                        {
                            student.EnterTheUniversity();
                        }
                        else if (answer == "Yes")
                        {
                            Console.WriteLine("What documents have you got?");
                            answer = Console.ReadLine();
                            student.EnterTheUniversity1(answer);
                        }

                        break;
                }
            }
        }
    }
}