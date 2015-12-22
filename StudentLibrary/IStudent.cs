using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    [ServiceContract]
  public  interface IStudent
    {
        [OperationContract]
      Student Read(String index);
        [OperationContract]
      void Write(Student s);
        [OperationContract]
        void AddSubject(string index, Subject subject);
    }
}
