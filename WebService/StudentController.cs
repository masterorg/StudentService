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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
  public  class StudentController
    {

        private Dictionary<String, Student> students;
       

        public StudentController()
        {
            this.students = new Dictionary<string, Student>();
           

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


    }
}
