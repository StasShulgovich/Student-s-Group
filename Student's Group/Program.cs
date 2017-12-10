using System;
using System.Collections.Generic;

namespace Student_s_Group
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Conditions
            //            Задача

            // Создать класс StudentGroup

            // Добавить вложенную приватную коллекцию Students
            // Чтение коллекции осуществить через индексатор StudentGroup[i]
            // Запись Students через методы Add / Remove

            // Создать класс Student

            // Содержит коллекцию Marks
            // Cодержит поля FirstName / LastName и DOB
            // Содержит метод AddMark
            // Переоприделяет методы Equals и метод ToString.

            // Создать структуру Mark
            // Содержит свойства cвойства только для чтения:
            // LectureName - string
            // Date - DateTime
            // MarkNumber – int

            // Реализовать интерфейс IComparable для Mark
            // В методе ToString у класса студет организовать вывод
            //полного имени пользователя и его Макс/ Мин / Сред оценки


            #endregion
            #region Dates
            DateTime datemark1 = new DateTime(2017, 12, 1);
            DateTime datemark2 = new DateTime(2017, 12, 1);
            DateTime datemark3 = new DateTime(2017, 12, 1);
            DateTime dateDOB1 = new DateTime(1992, 4, 22);
            #endregion
            #region Student's
            Student st1 = new Student();
            st1.FirstName = "Mike";
            st1.LastName = "Jordan";
            st1.DOB = dateDOB1;

            Student st2 = new Student();
            st2.FirstName = "Mike";
            st2.LastName = "Jordan";
            st2.DOB = dateDOB1;

            Student st3 = new Student();
            st3.FirstName = "Mikky";
            st3.LastName = "Rurg";
            st3.DOB = dateDOB1;
            #endregion
            #region Student's Marks
            //it's better to make double FOR cycle to create test data
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Mark mark = new Mark("Math", datemark1, j);

                }
            }


            #region StudentGroup
            StudentGroup stgr1 = new StudentGroup();
            stgr1.AddStudent(st1);
            stgr1.AddStudent(st2);
            stgr1.AddStudent(st3);
            #endregion

            List<DateTime> dates = new List<DateTime> { new DateTime(2017, 12, 1), new DateTime(2017, 12, 1), new DateTime(2017, 12, 1) };
            List<string> subjects = new List<string> { "Math", "English", "Russian" };
            List<string> firstNames = new List<string> { "m1", "m2", "m3" };
            List<string> LastNames = new List<string> { "s1", "s2", "s3" };
            for (int i = 0; i < 3; i++)
            {
                Student s = new Student() { FirstName = firstNames[i], LastName = LastNames[i], DOB = dates[i] };
                for (int j = 0; j < 3; j++)
                {
                    s.AddMark(new Mark(subjects[i], dates[j], i * 3 + j));
                    {
                        stgr1.AddStudent(s);
                    }
                    //Mark mark1 = new Mark("Math", datemark1, 5);
                    //st1.AddMark(mark1);
                    //Mark mark2 = new Mark("English", datemark2, 9);
                    //st1.AddMark(mark2);
                    //Mark mark3 = new Mark("Russian", datemark3, 2);
                    //st1.AddMark(mark3);

                    //Mark mark4 = new Mark("Math", datemark1, 1);
                    //st2.AddMark(mark4);
                    //Mark mark5 = new Mark("English", datemark2, 7);
                    //st2.AddMark(mark5);
                    //Mark mark6 = new Mark("Russian", datemark3, 9);
                    //st2.AddMark(mark6);

                    //Mark mark7 = new Mark("Math", datemark1, 8);
                    //st3.AddMark(mark7);
                    //Mark mark8 = new Mark("English", datemark2, 6);
                    //st3.AddMark(mark8);
                    //Mark mark9 = new Mark("Russian", datemark3, 3 );
                    //st3.AddMark(mark9);
                    #endregion

                    //просто вывод инфы из коллекции в том порядке в котором он там лежит
                    stgr1.ShowStudents();
                    Console.WriteLine(string.Empty);

                    //вывод по убыванию
                    //если коллекция однажды отсортировалась, то этот порядок отсортируется и на будущее
                    //чтобы отсортировать только вывод, нужно использовать LINQ (select, where, etc)
                    st1.SortMarks(st1);
                    st2.SortMarks(st2);
                    st3.SortMarks(st3);

                    //Переопределение ToString();
                    Console.WriteLine(st1.ToString());

                    //Переопределение Equals();
                    Console.WriteLine("Are these objects equal? " + Object.Equals(st1, st2));

                    Console.ReadLine();
                }
            }
        }
    }
}
           

