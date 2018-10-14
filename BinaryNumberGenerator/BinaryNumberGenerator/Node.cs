using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberGenerator
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        /// <summary>
        /// Singly linked node object
        /// </summary>
        /// <param name="Data">What's in the node</param>
        /// <param name="Next">The next node in the linked list</param>
        
        public Node(T Data, Note<T> Next)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }
}
