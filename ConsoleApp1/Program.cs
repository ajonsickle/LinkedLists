using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList x = new LinkedList();
            x.add("test1");
            x.add("test2");
            x.add("test3");
            x.printAll();
            x.delete("test1");
            x.delete("test2");
            x.add("test4");
            x.printAll();
            x.delete(x.getByIndex(1).getValue());
            x.printAll();
            
        }
    }
}
