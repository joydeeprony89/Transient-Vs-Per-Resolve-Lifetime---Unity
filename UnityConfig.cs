using Microsoft.Practices.Unity;

namespace UnityTest
{
    public class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer()
                .RegisterType<IFCS, FCS>()
                .RegisterType<IESC, ESC>()
                .RegisterType<IHelper, Helper>()
                .RegisterType<IBInder, BInder>()
                .RegisterType<ICUTran, CUTran>() // default registration as TransientLifeTime.
                .RegisterType<ICU, CU>(new PerResolveLifetimeManager()); // similar to Transient except CU instance will be injected same for all resolve.
            return container;
        }
    }
}
