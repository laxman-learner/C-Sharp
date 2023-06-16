using System;
namespace StaticMembers
{
    class Country
    {

        public string Name { get; set; }
        public string population { get; set; }

        public static bool IsOnEarth = true;    // same for all instance of a class

        // instance constructor - either default or parameterized

        // static constructor - exeutes only once and excutes before default or parameterized 
        // constructor 

        static Country() { }
    }

    public class Demo
    {

        void DoSomething()
        {
            Country country1 = new Country();
        }
    }
}
