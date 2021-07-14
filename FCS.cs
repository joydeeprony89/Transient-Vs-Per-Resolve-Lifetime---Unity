using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    public class FCS : IFCS
    {
        private readonly ICU _cU;
        private readonly IESC _esc;
        private readonly ICUTran _cUTran;
        public FCS(ICU cU, IESC esc, ICUTran cUTran)
        {
            _cU = cU;
            _esc = esc;
            _cUTran = cUTran;
        }

        public void Print(string no)
        {
            Console.WriteLine("Thread {0} , FSC CU = {1} after update",no, _cU.OperatorIdentifier);
            Console.WriteLine("Thread {0} , FSC TranCU = {1} after update", no, _cUTran.UserId);
            _esc.Print(no);
        }
    }
}
