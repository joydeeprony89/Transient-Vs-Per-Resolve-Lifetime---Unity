using System;

namespace UnityTest
{
    public class BInder : IBInder
    {
        private readonly IHelper _helper;
        private readonly IFCS _fsc;
        public BInder(IFCS fsc, IHelper helper)
        {
            _helper = helper;
            _fsc = fsc;
        }

        public void MessageReceived(string no)
        {
            _helper.Update(no);
            _fsc.Print(no);
        }
    }
}
