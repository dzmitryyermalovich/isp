using System;

namespace lab5
{
    class Student : Human
    {
        protected string university;

        public void AttendLesson(string action)
        {
            this.AttendMeeting(action);
        }

        public Student(string name, int age)
            : base(name, age)
        {
        }

        public Student()
            : base()
        {
        }

        public override void PassExamsAndEnterTheUniversity()
        {
            Console.WriteLine("Oh you are student,it isnt necessary to pass exam");
        }
    }
}
