using System;
using System.Collections.Generic;

namespace Student_s_Group
{
    public class StudentGroup
    {
        private readonly List<Student> Students = new List<Student>();    
        
        public Student this[int index]
        {
            get { return Students[index]; }
            set { Students[index] = value; }
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void ShowStudents()
        {
            foreach (var st in Students)
            {
                Console.Write(st.FirstName + " " + st.LastName + " ");
                st.ShowMarks();
            }
        }

        //Реализация через индексаторы
        public void ShowStudentsIndex(int index1)
        {
            for (int i = index1; i < Students.Count; i++)
            {
                Console.WriteLine(Students[i].FirstName + Students[i].LastName);
            }
        }        
    }
}
