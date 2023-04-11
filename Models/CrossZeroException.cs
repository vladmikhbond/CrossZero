using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossZero.Models
{
   internal class CrossZeroException : Exception
   {
      public CrossZeroException(string message) : base(message) { }
   }
}
