using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using StudentLibrary;
using System.Threading;

namespace StudentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(2000);
            Uri address = new Uri("http://localhost:8000/IStudentServer");
            BasicHttpBinding binding = new BasicHttpBinding();

            /***********************CREATING AND OPEINING PROXY CHANNEL**********************/

            ChannelFactory<IStudent> factory = new ChannelFactory<IStudent>(binding, new EndpointAddress(address));
           IStudent proxy = factory.CreateChannel();
            Student s = new Student();
            s.Ime="Stefan";
            s.Prezime="Plazic";
            s.Index="65/12";
            proxy.Write(s);
            Console.WriteLine("Student had been added \nAdding new subject to student");

            /**********************ADDING SUBJECTS TO STUDENT***********************/
            proxy.AddSubject(s.Index, new Subject { Naziv = "Math" });
            proxy.AddSubject(s.Index, new Subject { Naziv = "Programing" });

            s = proxy.Read(s.Index);
            Console.WriteLine("Student: "+s.Ime+" "+s.Prezime+" subjects:");
            foreach (Subject item in s.Subjects)
            {
                Console.WriteLine(item.Naziv);
            }

            Console.ReadKey();

        }
    }
}
