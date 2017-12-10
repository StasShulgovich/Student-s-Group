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
            Marks.Add(mark);
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
            Marks.ForEach(Mark => Console.Write(Mark.LectureName + " " + Mark.MarkNumber + " "));
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
            return " Average Mark is " + (double) x / y;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + MinMark() + MaxMark() + AverageMark();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType()) return false;
            Student student = (Student)obj;
            return (FirstName == student.FirstName && LastName == student.LastName);
        }
    }

    public struct Mark : IComparable<Mark>
    {
        public string LectureName { get; }
        public DateTime Date { get; }
        public int MarkNumber { get; }        

        public Mark(string lectureName, DateTime date, int markNumber) : this()
        {
            LectureName = lectureName;
            Date = date;
            MarkNumber = markNumber;

        }       
        //Сравнение по оценкам
        public int CompareTo(Mark other)
        {
            return MarkNumber.CompareTo(other.MarkNumber);
        }
    }
}

