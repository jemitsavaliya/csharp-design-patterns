using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpattern.Creational.Singletone
{
    internal class EagerSingleton
    {
        private static readonly EagerSingleton _instance = new EagerSingleton();

        private EagerSingleton() { }

        public static EagerSingleton GetInstance()
        {
            // Return the already-created shared instance
            return _instance;
        }
    }

    /// <summary>
    /// Alternative: Lazy Thread-Safe Singleton (Recommended for Production)
    /// </summary>
    /*public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _instance =
            new Lazy<Singleton>(() => new Singleton());

        private Singleton() { }

        public static Singleton Instance => _instance.Value;
    }*/
}
