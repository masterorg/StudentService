using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Subject
    {

        String naziv;

        public Subject()
        { }
        public Subject(String naziv)
        { this.naziv = naziv;
        }
        public String Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
    }
}
