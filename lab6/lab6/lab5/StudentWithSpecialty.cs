using System;

namespace lab5
{
    sealed class StudentWithSpecialty : Student, IDoHomework, IComparable<StudentWithSpecialty>, IConvertible
    {
        protected string faculty;
        protected double averageScore;

        public int CompareTo(StudentWithSpecialty p)
        {
            return this.averageScore.CompareTo(p.averageScore);
        }

        public void DoHomework(double hours)
        {
            if (hours < 2)
            {
                Console.WriteLine("You spent very little time on work,chances are that you will get a bad grade");
            }
            else
            {
                Console.WriteLine("You did a great job, i think you can count on a high score");
            }
        }

        public void DontDoHomework()
        {
            Console.WriteLine("You are very lazy, be careful you may be expelled");
        }

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
                    case "averageScore": return Convert.ToString(this.averageScore);
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
                        activation = cheak.CheckedNumber(value);
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
                    case "averageScore":
                        activation = cheak.CheckedNumber(value);
                        if (activation == 0)
                        {
                            Environment.Exit(0);
                        }

                        break;
                }
            }
        }

        public StudentWithSpecialty(string name, int age, string university, string faculty,double averageScore)
            : base(name, age)
        {
            this["name"] = name;
            this["age"] = Convert.ToString(age);
            this["university"] = university;
            this["faculty"] = faculty;
            this.university = university;
            this.faculty = faculty;
            this.averageScore = averageScore;
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
            Console.WriteLine("university = " + this.university + "\nfaculty = " + this.faculty+"\naverage score = "+this.averageScore);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            if (this.averageScore > 7.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        double GetDoubleValue()
        {
            return Math.Sqrt(this.averageScore * this.averageScore);
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(this.GetDoubleValue());
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(this.GetDoubleValue());
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime(this.GetDoubleValue());
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(this.GetDoubleValue());
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return this.GetDoubleValue();
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(this.GetDoubleValue());
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(this.GetDoubleValue());
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(this.GetDoubleValue());
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(this.GetDoubleValue());
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(this.GetDoubleValue());
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return String.Format("({0}, {1})", this.averageScore);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(this.GetDoubleValue(), conversionType);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(this.GetDoubleValue());
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(this.GetDoubleValue());
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(this.GetDoubleValue());
        }
    }
}
