using System;

namespace UnityTest
{
    public class CUTran : ICUTran
    {
        public CUTran()
        {
            UserId = "TestTransient";
        }
        public string UserId { get; set; }
    }
}
