using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    [DataContract]
   public class Student
    {
       [DataMember]
        private String ime;
       [DataMember]
        private String prezime;
       [DataMember]
        private String index;
       [DataMember]
        private List<Subject> subjects;

       public Student()
        {
            subjects = new List<Subject>();

        }
       [DataMember]
        public List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }
       [DataMember]
        public String Index
        {
            get { return index; }
            set { index = value; }
        }
       [DataMember]
        public String Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
       [DataMember]
        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        

    }
}
