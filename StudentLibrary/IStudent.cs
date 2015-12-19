using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
  public  interface IStudent
    {
      Student Read(String index);
      void Write(Student s);
    }
}
