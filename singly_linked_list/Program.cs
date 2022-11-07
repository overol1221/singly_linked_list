using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    // each node consist of the information part and link to the next node
    class node
    {
        public int rollnumber;
        public string name;
        public node next;
    }

    class list
    {
        node start;
        public list()
        {
            start = null;
        }
        public void addnote() // add a note in the list
        {
            int rollNo;
            string nm;
            Console.Write();
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollnumber = rollNo;
            newnode.name = nm;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
