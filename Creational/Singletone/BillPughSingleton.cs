using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpattern.Creational.Singletone
{
    internal sealed class BillPughSingleton
    {
        private BillPughSingleton() { }

        public static class SingletonHelper
        {
            internal readonly static BillPughSingleton INSTANCE = new BillPughSingleton();
        }

        public static BillPughSingleton GetInstance()
        {
            return SingletonHelper.INSTANCE;
        }

    }
}
