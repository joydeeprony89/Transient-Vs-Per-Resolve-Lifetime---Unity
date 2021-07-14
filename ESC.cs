using System;

namespace UnityTest
{
    public class ESC : IESC
    {
        private readonly ICU _cU;
        private readonly ICUTran _cUTran;
        public ESC(ICU cU, ICUTran cUTran)
        {
            _cU = cU;
            _cUTran = cUTran;
        }
        public void Print(string no)
        {
            Console.WriteLine("Thread {0} , ESC CU = {1} after update", no, _cU.OperatorIdentifier);
            Console.WriteLine("Thread {0} , ESC TranCU = {1} after update", no, _cUTran.UserId);
        }
    }
}
