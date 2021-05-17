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
        public static void doWork(IDoHomework doHomework,int hours)
        {
            doHomework.DoHomework(hours);
        }

        public static void dontDoWork(IDoHomework doHomework, int hours)
        {
            doHomework.DontDoHomework(0);
        }

        public static void GoForward(Human ob,string pace)
        {
            ob.Y += ob.Pace(pace);
        }

        public static void GoBack(Human ob, string pace)
        {
            ob.Y -= ob.Pace(pace);
        }

        public static void GoRight(Human ob, string pace)
        {
            ob.X += ob.Pace(pace);
        }

        public static void GoLeft(Human ob, string pace)
        {
            ob.X -= ob.Pace(pace);
        }

        private static void Main(string[] args)
        {
            Operation op;
            bool cheakPrograss;
            op = Operation.Nothing;
            string name = string.Empty, university = string.Empty, faculty = string.Empty, answer = string.Empty;
            int age = 0, activation = 0, who = 0;
            double averageScore = 0;
            double score;
            int ans;
            StudentWithSpecialty s1 = new StudentWithSpecialty("Alex", 18, "Bsuir", "Kciss", 9.2);
            StudentWithSpecialty s2 = new StudentWithSpecialty("Tima", 19, "Bsuir", "Kciss", 7.3);
            StudentWithSpecialty s3 = new StudentWithSpecialty("Stas", 17, "Bsuir", "Kciss", 8.1);
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

                        Console.WriteLine("Average score");
                        try
                        {
                            averageScore = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("You number has char elements");
                            Environment.Exit(0);
                        }

                        student = new StudentWithSpecialty(name, age, university, faculty, averageScore);
                        op = Operation.StudentWithSpecialty;
                        break;
                }

                while (true)
                {
                    switch ((int)op)
                    {
                        case 0:
                            Console.WriteLine("\nChoose a function:\n1) Print Info\n2) Try pass the exams and enter the university\n3) Attend a event\n4) Clear house\n5) Move in space");
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
                                case 4:
                                    Console.WriteLine("Will you clear house");
                                    answer = Console.ReadLine();
                                    if (answer == "No")
                                    {
                                        dontDoWork(human, 0);
                                    }
                                    else if (answer == "Yes")
                                    {
                                        Console.WriteLine("How many hours will you clear house");
                                        ans = Convert.ToInt32(Console.ReadLine());
                                        doWork(human, ans);
                                    }

                                    break;
                                case 5:
                                    Console.WriteLine("GoForward,GoBack,GoRight,GoLeft");
                                    answer = Console.ReadLine();
                                    switch (answer)
                                    {
                                        case "GoForward":
                                            human.MoveInSpace(GoForward, "fast");
                                            human.defineLocation();

                                            break;
                                        case "GoRight":
                                            human.MoveInSpace(GoRight, "fast");
                                            human.defineLocation();

                                            break;
                                        case "GoBack":
                                            human.MoveInSpace(GoBack, "fast");
                                            human.defineLocation();

                                            break;
                                        case "GoLeft":
                                            human.MoveInSpace(GoLeft, "fast");
                                            human.defineLocation();

                                            break;
                                    }

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
                            Console.WriteLine("\nChoose a function:\n1) Print Info\n2) Enter the Universite\n3) Attend a lesson\n4) Do homework\n5) Show rating\n6) Check progress\n7) Change your score");
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
                                case 4:
                                    Console.WriteLine("Will you do your homework");
                                    answer = Console.ReadLine();
                                    if (answer == "No")
                                    {
                                        dontDoWork(student,0);
                                    }
                                    else if (answer == "Yes")
                                    {
                                        Console.WriteLine("How many hours will you do homework");
                                        ans = Convert.ToInt32(Console.ReadLine());
                                        doWork(student, ans);
                                    }

                                    break;
                                case 5:
                                    StudentWithSpecialty[] Students = new StudentWithSpecialty[] { s1, s2, s3, student };
                                    Array.Sort(Students);
                                    foreach (StudentWithSpecialty s in Students)
                                    {
                                        s.PrintInfo();
                                        Console.WriteLine();
                                    }

                                    break;
                                case 6:
                                    cheakPrograss = student.ToBoolean(null);
                                    if (cheakPrograss)
                                    {
                                        Console.WriteLine("You study very well");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You study badly, try harder");
                                    }

                                    break;
                                case 7:
                                    Console.WriteLine("Do you want to add or subtract");
                                    answer = Console.ReadLine();
                                    if (answer == "add")
                                    {
                                        Console.WriteLine("How much to add");
                                        score = Convert.ToDouble(Console.ReadLine());
                                        student.OperationWithScore(score, (StudentWithSpecialty ob, double delta) => ob.averageScore += delta);
                                    }
                                    else if (answer == "subtract")
                                    {
                                        Console.WriteLine("How much to subtract");
                                        score = Convert.ToDouble(Console.ReadLine());
                                        student.OperationWithScore(score, delegate(StudentWithSpecialty ob, double delta)
                                        {
                                            try
                                            {
                                                if (ob.averageScore - delta < 0)
                                                {
                                                    throw new PersonException("Score cant be less than 0");
                                                }
                                                else
                                                {
                                                    ob.averageScore -= delta;
                                                }
                                            }
                                            catch (PersonException ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                                Environment.Exit(0);
                                            }
                                        });
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cheak your operation");
                                    }

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