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
      
        //error log function
        public static void ErrorLog(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            StudentController  singleton = new StudentController();
            //add to event
            singleton.Changed += ErrorLog;

            Uri address = new Uri("http://localhost:8000/IStudentServer");
            BasicHttpBinding bindig = new BasicHttpBinding();
            ServiceHost sv = new ServiceHost(singleton);
            sv.AddServiceEndpoint(typeof(IStudent), bindig, address);
            sv.Open();
            Console.WriteLine("WCFServer spreman za primanje poruka.");
            Console.ReadLine();
            sv.Close();

        }
    }
}
