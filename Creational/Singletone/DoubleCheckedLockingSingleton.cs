using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpattern.Creational
{
    //Sealed Class
    //Private Constructor
    //Thread Safe 
    //Double Lock
    internal sealed class DoubleCheckedLockingSingleton
    {
        private DoubleCheckedLockingSingleton() { }

        private static DoubleCheckedLockingSingleton Instance = null;
        public static readonly object _lock = new object();
        public static DoubleCheckedLockingSingleton GetInstance()
        {
            if (Instance == null)
            {
                lock (_lock)
                {
                    if (Instance == null)
                    {
                        Instance = new DoubleCheckedLockingSingleton();
                    }
                }
            }

            return Instance;
        }


    }

}
