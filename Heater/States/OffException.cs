using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public class OffException : Exception
    {
        public OffException() : base("まずはONにしてください")
        {

        }
    }
}
