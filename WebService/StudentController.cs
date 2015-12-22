using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using StudentLibrary;
using System.Threading;
using System.Threading.Tasks;

namespace WebService
{
    public delegate void ErrorStudent(string message);
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
  public  class StudentController:IStudent
    {

        private Dictionary<String, Student> students;
       

        public StudentController()
        {
            this.students = new Dictionary<string, Student>();
           

        }

        //event
        public event ErrorStudent Changed;

        public virtual void OnChanged(String message)
        {
            if (Changed != null)
                Changed(message);
        }
        

        public void AddStudent(Student st)
        {
            lock(students)
            {
                students.Add(st.Index, st);
                Console.WriteLine("Student added");

            }

        }
        public void DeleteStudent(String index)
        {
            lock(students)
            {

                if(!students.ContainsKey(index))
                    Console.WriteLine("Student with id: "+index+" doesnt exists");
                else
                {
                    students.Remove(index);
                    Console.WriteLine("Student with id: "+index+" deleted");
                }
            }
        }



        public Student Read(string index)
        {
            if(!students.ContainsKey(index))
            {
                Changed("Student with index :" + index + " doesn't exists");
                return null;
            }
            else
            {
                return students[index];
            }
        }

        public void Write(Student s)
        {
            AddStudent(s);
        }


        public void AddSubject(string index, Subject subject)
        {

            if (!students.ContainsKey(index))
            
                Changed("Student with index :" + index + " doesn't exists");
            else
            {
                students[index].Subjects.Add(subject);
                Changed("Subject: " + subject.Naziv + " had been added to student: " + students[index].Ime + " " + students[index].Prezime);
            }
            
        }
    }
}
