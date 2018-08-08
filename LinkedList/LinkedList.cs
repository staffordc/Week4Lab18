using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Non-Generic LinkedList
    class LinkedList
    {
        public LinkedList()
        {
            Head = new Node();
            Current = Head;
        }

        public Node Head;
        public Node Current;
        public int Count = 0;

        public void AddAtStart(object value)
        {
            var newNode = new Node()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }
        
        public bool InsertAt(int index, Object o)
        {
            if (Count <= 0)
            {
                return false;
            }

            int insertcount = 0;
            Node InsertNode = new Node();
            InsertNode.Value = o;
            Node curr = Head;
            while (insertcount <= index)
            {
                if (insertcount == index)
                {
                    InsertNode.Next = curr.Next;
                    curr.Next = InsertNode;
                    ++Count;
                    return true;
                }
                else if (insertcount > Count)
                {
                    return false;
                }
                curr = curr.Next;
                insertcount++;
            }
            return false;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public bool RemoveAt(int index)
        {
            if (Count <= 0)
            {
                return false;
            }

            int removecount = 0;
            Node curr = Head;
            while (removecount <= index)
            {
                if (removecount == index)
                {
                    curr.Next = curr.Next.Next;
                    --Count;
                    return true;
                }
                else if (removecount > Count)
                {
                    return false;
                }
                curr = curr.Next;
                removecount++; 
            }
            return false;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value); //If using a reference type (any class/interface), you will need to override ToString for this to work.
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
        
        public void PrintAllNodesReverse()
        {
            string output = (" <- Head ");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                output = (" <- ") + curr.Value + output; 
            }
            Console.Write(" Tail" + output);
            Console.WriteLine();
        }

    }

    //Linked List using Generics
    class LinkedList<T> where T : class
    {
        public LinkedList()
        {
            Head = new Node<T>();
            Current = Head;
        }
        public Node<T> Head;
        public Node<T> Current;
        public int Count = 0;

        public void AddAtStart(T value)
        {
            var newNode = new Node<T>()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
    }

    
    
}
