using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrotResult : Result
    {
        public ErrotResult(string message) : base(false,message)
        {

        }

        public ErrotResult() : base(false)
        {
        }
    }
}
