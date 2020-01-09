using System;

namespace CMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Profile p = new Profile("hi","hi","hi","hi","hi","hi","hi","hi","hi","hi","hi","hi","hi","hi","hi","hi");
            Console.WriteLine(p.getAddress());
        }
    }
}