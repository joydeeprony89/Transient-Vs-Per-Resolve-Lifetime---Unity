using System;

namespace UnityTest
{
    public class Helper : IHelper
    {
        private readonly ICU _cu;
        private readonly ICUTran _cuTran;
        public Helper(ICU cU, ICUTran cuTran)
        {
            _cu = cU;
            _cuTran = cuTran;
        }
        public void Update(string no)
        {
            Console.WriteLine($"Helper CU = {_cu.OperatorIdentifier} before update");
            Console.WriteLine($"Helper TranCU = {_cuTran.UserId} before update");
            _cu.OperatorIdentifier = no;
            _cuTran.UserId = no;
        }
    }
}
