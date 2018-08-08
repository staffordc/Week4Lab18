using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Non-Generic Node
    public class Node
    {
        public Node Next;
        public object Value;
    }

    //Node using Generics
    public class Node<T> where T : class 
    {
        public Node<T> Next;
        public T Value;
    }
}
