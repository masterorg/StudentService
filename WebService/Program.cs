using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using StudentLibrary;

namespace WebService
{
    class Program
    {
        private static StudentController cont;

        static void Main(string[] args)
        {
            cont = new StudentController();

            Uri address = new Uri("http://localhost:8000/IStudentServer");
            BasicHttpBinding bindig = new BasicHttpBinding();
            ServiceHost sv = new ServiceHost(typeof(IStudent));
            

        }
    }
}
