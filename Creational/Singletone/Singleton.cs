using designpattern.Creational;
using designpattern.Creational.Singletone;
using System;


namespace designpattern
{
    internal class Singleton
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" DoubleCheckedLockingSingleton => {DoubleCheckedLockingSingleton.GetInstance() == DoubleCheckedLockingSingleton.GetInstance()}");
            Console.WriteLine($" BillPughSingleton => {BillPughSingleton.GetInstance() == BillPughSingleton.GetInstance()}");
            Console.WriteLine($" EagerSingleton => {EagerSingleton.GetInstance() == EagerSingleton.GetInstance()}");               
        }
    }
}
