using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //FV had to make this an abstract class
    abstract class PhoneBookItem
    {
      public abstract string GetContactSummary();
    }
}
