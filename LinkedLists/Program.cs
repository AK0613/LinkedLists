using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.insert_front(1);
            list.insert_back(3);
            list.insert_at(2, 1);
            list.print_recursive(list.head);
            Console.WriteLine();/*
            Console.WriteLine();
            Console.WriteLine(list.pop());
            Console.WriteLine();
            list.print_recursive(list.head);
            Console.WriteLine();
            Console.WriteLine(list.dequeue());
            Console.WriteLine();
            list.print_recursive(list.head);
            Console.WriteLine(list.find_index(4));
            Console.WriteLine();
            Console.WriteLine(list.delete_value(0));
            Console.WriteLine();
            list.print_recursive(list.head);*/
            Console.WriteLine(list.delete_index(3));
            Console.WriteLine();
            list.print_recursive(list.head);
            
        }
    }
}
