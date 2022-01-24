using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList x = new LinkedList();
            x.addToEnd("edward");
            x.addToEnd("lachlan");
            x.delete("edward");
            x.addToStart("ben");
            x.printAll();
            
        }
    }
}
