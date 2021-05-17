using System;

namespace lab5
{
    class Dog : AllLivingOrganizm
    {
        protected int age = 5;
        protected string nickname = "Bobik";

        public override void NumberOfChromosomes()
        {
            Console.WriteLine("I,am dog.I Have 78 Chromosomes");
        }

        public override void PrintInfoAboutOrganizm()
        {
            Console.WriteLine("Nickname = " + this.nickname + "\nAge = " + this.age);
        }
    }
}
