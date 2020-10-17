using System;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            single one = single.getinstance();
            one.PrintA();
            one.a = 55;
            single two = single.getinstance();
            two.PrintA();
        }
    }
}
