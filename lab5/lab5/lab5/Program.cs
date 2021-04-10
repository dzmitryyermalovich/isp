using System;

namespace lab5
{

    enum Operation
    {
        Human,
        Student,
        StudentWithSpecialty,
        Dog,
        Nothing,
    }

    class Program
    {
        private static void Main(string[] args)
        {
            Operation op;
            op = Operation.Nothing;
            string name = string.Empty, university = string.Empty, faculty = string.Empty, answer = string.Empty;
            int age = 0, activation = 0, who = 0;
            StudentWithSpecialty student = new StudentWithSpecialty();
            Human human = new Human();
            Console.WriteLine("Are you alive?");
            answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Console.WriteLine("Who are you:\n1) Human\n2) Student\n3) Student with speciality");
                who = Convert.ToInt32(Console.ReadLine());

                switch (who)
                {
                    case 1:
                        Console.WriteLine("Enter Name :");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter age :");
                        try
                        {
                            age = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("You number has char elements");
                            Environment.Exit(0);
                        }

                        human = new Human(name, age);
                        op = Operation.Human;
                        break;
                    case 2:
                        Console.WriteLine("Enter Name :");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter age :");
                        try
                        {
                            age = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("You number has char elements");
                            Environment.Exit(0);
                        }

                        human = new Student(name, age);
                        op = Operation.Student;
                        break;
                    case 3:
                        Console.WriteLine("Enter Name :");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter age :");
                        try
                        {
                            age = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("You number has char elements");
                            Environment.Exit(0);
                        }

                        Console.WriteLine("Enter university :");
                        university = Console.ReadLine();

                        Console.WriteLine("Enter faculty :");
                        faculty = Console.ReadLine();
                        student = new StudentWithSpecialty(name, age, university, faculty);
                        op = Operation.StudentWithSpecialty;
                        break;
                }

                while (true)
                {
                    switch ((int)op)
                    {
                        case 0:
                            Console.WriteLine("\nChoose a function:\n1) Print Info\n2) Try pass the exams and enter the university\n3) Attend a lesson");
                            activation = Convert.ToInt32(Console.ReadLine());
                            switch (activation)
                            {
                                case 1:
                                    human.PrintInfoAboutOrganizm();
                                    break;
                                case 2:
                                    human.PassExamsAndEnterTheUniversity();
                                    break;
                                case 3:
                                    Console.WriteLine("\nAre you late?");
                                    answer = Console.ReadLine();
                                    human.AttendMeeting(answer);
                                    break;
                            }

                            break;
                        case 1:
                            Console.WriteLine("\nChoose a function:\n1) Print Info\n2) Try pass the exams and enter the university\n3) Attend a lesson");
                            activation = Convert.ToInt32(Console.ReadLine());
                            switch (activation)
                            {
                                case 1:
                                    human.PrintInfoAboutOrganizm();
                                    break;
                                case 2:
                                    human.PassExamsAndEnterTheUniversity();
                                    break;
                                case 3:
                                    Console.WriteLine("\nAre you late?");
                                    answer = Console.ReadLine();
                                    human.AttendMeeting(answer);
                                    break;
                            }

                            break;
                        case 2:
                            Console.WriteLine("\nChoose a function:\n1) Print Info\n2) Enter the Universite\n3) Attend a lesson");
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
                                        student.EnterTheUniversity(answer);
                                    }

                                    break;
                                case 3:
                                    Console.WriteLine("\nAre you late?");
                                    answer = Console.ReadLine();
                                    student.AttendLesson(answer);
                                    break;
                            }

                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You are dog");
                AllLivingOrganizm dog = new Dog();
                while (true)
                {
                    Console.WriteLine("\nChoose a function:\n1) Print Info\n2) Numbers of chromosomes\n");
                    activation = Convert.ToInt32(Console.ReadLine());

                    switch (activation)
                    {
                        case 1:
                            dog.PrintInfoAboutOrganizm();
                            break;
                        case 2:
                            dog.NumberOfChromosomes();
                            break;
                    }
                }
            }
        }
    }
}