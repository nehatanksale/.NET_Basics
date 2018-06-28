using System;

namespace Practice_Core
{
    class Program
    {
        String name;
        public String accept(String name)
        {
            this.name = name;
            return name;
        }
        public String display()
        {
            return name;
        }
        static void Main(string[] args)
        {
            Program o1 = new Program();     //way1 to access
            o1.accept("By Method1");
            Console.WriteLine(o1.display());
            var o2 = new Program();      //way2 to access
            o2.accept("By Method2");
            Console.WriteLine(o2.display());
           

        }
    }
}
