using System;

namespace nasledovanie
{
    class Student
    {
        static void Main(string[] args)
        { }
        
            public string Fio { get; set; }
        public Student(string fio)
        {
            Fio = fio;
        }
        public void Print()
        {
            Console.WriteLine(Fio);
        }
    }

    class Teacher : Student
    {
        public string Job { get; set; }
        public Teacher(string fio, string job)
            : base(fio)
        {
            Job=job;
        }
    }
    }

