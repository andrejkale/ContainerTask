using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerClass
{
    public class Student
    {
        private string FirstName;
        private string LastName;
        private string Subject;
        private List<int> Marks = new List<int>();


        public Student(string firstName, string lastName, string subject, int mark)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            if (mark >= 0 && mark <= 5)
            {
                Marks.Add(mark);
            }
            else
            {
                Marks.Add(0);
            }
        }

        public int Mark
        {
            get
            {                   
                return Marks.Count;
               
            }
            set
            {
                if (value >= 0 && value <= 5)
                    Marks.Add(value);
            }

        }

        public string Name
        { get { return FirstName; } }

        public List<int> MarksGet
        { 
           get => Marks;
        }

        

        public override string? ToString()
        {
            return "Student " + " " + FirstName + " " + LastName + " " + Subject + " " + "Average mark = ";
        }
    }
}
