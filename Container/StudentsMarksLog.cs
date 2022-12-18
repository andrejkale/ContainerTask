using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerClass
{
   public class StudentsMarksLog
    {   
       private static List<Student> students = new List<Student>();
        public static Student CreateStudent(string firstName, string lastName, string subject, int mark)
        {
            return (new Student(firstName, lastName, subject, mark));
            
        }

        public static void AddStudentToLog(Student student)
        {
            
            if (!students.Exists(name => name.Name.Equals(student.Name)))
            {
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Student " + student.Name + " is exists = " + students.Exists(name => name.Name.Equals(student.Name)));
            }
        }

        public static void AddMark(Student student, int mark)
        {   if (mark >= 0 && mark <= 5)
            {
                student.Mark = mark;
            }
        }

        private static Double CalculateAveregeMark(Student student) 
        {
            return student.MarksGet.Sum() / student.Mark;
        }

        public static void PrintStudents()
        {
            students.ForEach(student => Console.WriteLine(student + " " + CalculateAveregeMark(student)));
            
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
