using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = UnityConfig.RegisterComponents();
            List<string> list = new List<string>() { "1", "2", "3" };
            Parallel.ForEach(list, (ll) =>
            {
                var binder = container.Resolve<IBInder>();
                binder.MessageReceived(ll);
            });
            
            
            Console.Read();
        }
    }
}
