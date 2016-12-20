using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    class BussinessRulesException :ApplicationException
    {
         public BussinessRulesException(string msg1, Exception msg2)
            : base(msg1, msg2)
        {

        }

        public BussinessRulesException(string msg)
            : base(msg)
        {

        }
    }
}
