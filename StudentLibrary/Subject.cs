using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace StudentLibrary
{
    [DataContract]
    public class Subject
    {
        [DataMember]
        String naziv;

        public Subject()
        { }
        public Subject(String naziv)
        { this.naziv = naziv;
        }
        [DataMember]
        public String Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
    }
}
