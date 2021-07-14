using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    public class CU : ICU
    {
        public CU()
        {
            OperatorIdentifier = "test";
        }
        public string OperatorIdentifier { get; set; }
    }
}
