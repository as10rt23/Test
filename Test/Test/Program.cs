using System;
using System.Dynamic;

public class animal
{
    int head = 1;
    int leg;
}
public class bird : animal
{
    int leg = 2;
    int wing = 2;
    bool canfly;
}

namespace Test
{
    class Program
    {
        bird chicken = new bird();
        
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
