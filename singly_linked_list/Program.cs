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
        node START;
        public list()
        {
            START = null;
        }
        public void addnote() // add a note in the list
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollnumber = rollNo;
            newnode.name = nm;
            if ((START != null) && (rollNo <= START.rollNumber)) ;
            {
                if ((START != null) && (rollNo == START.rollNumber)) ;
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }
            node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (rollNo >= current.rollnumber))
            {
                if (rollNo == current.rollnumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = newnode;
        }

        public bool delnode(int rollNo)
        {
            node previous, current;
            previous = current = null;
            if (search(rollNo, ref previous, ref current) == false)
                return false;
            if (current == START)
                START = START.next;
            return true;
        }
        public bool search(int rollNo, ref node previous, ref node current)
        {
            previous = START;
            current = START;
            while ((current != null) && (rollNo != current.rollnumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void travarse()
        {
            if (listEmpty())
                Console.WriteLine();
            else
            {
                Console.WriteLine();
                node currentNode;
                for (currentNode = START; currentNode != null ;
                currentNode = currentNode.next)
                    Console.Write(currentNode.rollnumber + "" + currentNode.rollnumber + " " + currentNode.name + "\n");
                Console.WriteLine();
            }
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }
    class program
    { 
        static void Main(string[] args)
        {
            list obj = new list();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. add record to the list");
                    Console.WriteLine("2. delete a record to the list");
                    Console.WriteLine("3. view all the record from the list");
                    Console.WriteLine("4. search for a record in the list");
                    Console.WriteLine("5. exit");
                    Console.Write("\nEnter your choice (1-5) :");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.addnote();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nlist is empty");
                                    break;
                                }
                                Console.WriteLine("Enter the roll number of" + "" +
                                    "the student whose record is to be deleted: ");
                                int rollNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (obj.delnode(rollNo) == false)
                                    Console.WriteLine("\nRecord not found.");
                                else
                                    Console.WriteLine("record with roll number" +
                                        rollNo + "Deleted");
                            }
                            break;
                        case '3':
                            {
                                obj.traverse();
                            }
                            break;



                    }
                }

                
                    
                }
            }
        }
    }
}
