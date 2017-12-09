using System;
using System.Collections.Generic;


namespace Student_s_Group
{
    public class Student
    {
        //test this GIT
        private readonly List<Mark> Marks = new List<Mark>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }          
        
        public void AddMark(Mark mark)
        {
            this.Marks.Add(mark);
        }       

        public void ShowMarks()
        {
            foreach (var mrks in Marks)
            {
                Console.Write(mrks.MarkNumber + " " + mrks.LectureName + " ");               
            }
            Console.WriteLine();
        }
        public void SortMarks(Student student)
        {
            Marks.Sort();
            Marks.Reverse();
            Console.Write(student.FirstName + " " + student.LastName + " ");
            Marks.ForEach(Marks => Console.Write(Marks.LectureName + " " + Marks.MarkNumber
                + " "));
            Console.WriteLine();
        }

        public string MinMark()
        {
            Marks.Sort();            
            foreach (var mark in Marks)
            {
                Console.WriteLine();
                 return " Min mark is " + mark.MarkNumber;
            }
            return "exception"; // вот эта штука не оч как-то
        }

        public string MaxMark()
        {
            Marks.Sort();
            Marks.Reverse();
            foreach (var mark in Marks)
            {
               return " Max mark is " + mark.MarkNumber;               
            }
            return "exception"; // вот эта штука не оч как-то
        }

        public string AverageMark()
        {
            int x = 0;
            int y = 0;

            foreach (var mark in Marks)
            {
                x += mark.MarkNumber;
                y += 1;
            }
            return " Average Mark is " + (double)x/y;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + this.MinMark() + this.MaxMark() + this.AverageMark();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Student student = (Student)obj;
            return (this.FirstName == student.FirstName && this.LastName == student.LastName);
        }
    }
    public struct Mark : IComparable<Mark>
    {
        public string LectureName { get; }
        public DateTime Date { get; }
        public int MarkNumber { get; }        

        public Mark(string LectureName, DateTime Date, int MarkNumber) : this()
        {
            this.LectureName = LectureName;
            this.Date = Date;
            this.MarkNumber = MarkNumber;
        }       
        //Сравнение по оценкам
        public int CompareTo(Mark other)
        {
            return MarkNumber.CompareTo(other.MarkNumber);
        }
    }
}

