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
            Console.WriteLine("Student had been added \n Reading non existing student");

            s = proxy.Read("62");

            Console.ReadKey();

        }
    }
}
