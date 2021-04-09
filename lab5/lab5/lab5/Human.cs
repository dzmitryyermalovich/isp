using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Human : AllLivingOrganizm
    {
        protected int age;
        protected string name;

        public override void NumberOfChromosomes()
        {
            Console.WriteLine("I,am human.I Have 46 Chromosomes");
        }

        public override void PrintInfoAboutOrganizm()
        {
            Console.WriteLine("Name = " + this.name + "\nAge = " + this.age);
        }

        public Human(string name, int age)
        {
            Cheak cheak;
            int action = cheak.CheckedWord(name);
            if (action == 0)
            {
                Environment.Exit(0);
            }

            this.name = name;
            this.age = age;
        }

        public void AttendMeeting(string action)
        {
            Speed speed;
            switch (action)
            {
                case "Yes":
                    speed.WalkFast();
                    break;
                case "No":
                    speed.WalkSlow();
                    break;
            }
        }

        public Human()
        {
            this.name = string.Empty;
            this.age = 0;
        }

        public virtual void PassExamsAndEnterTheUniversity()
        {
            Console.WriteLine("Oh great idea,try enter the university");
        }
    }
}
