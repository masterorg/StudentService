using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
   public class Student
    {

        private String ime;
        private String prezime;
        private String index;
        private List<Subject> subjects;

       public Student()
        {
            subjects = new List<Subject>();

        }

        public List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }

        public String Index
        {
            get { return index; }
            set { index = value; }
        }

        public String Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        

    }
}
