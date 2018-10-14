using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberGenerator
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        /// <summary>
        /// Singly linked node object
        /// </summary>
        /// <param name="data">What's in the node</param>
        /// <param name="next">The next node in the linked list</param>
        
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }

        /// <summary>
        /// Setter and getter for data
        /// </summary>
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Setter and getter for next
        /// </summary>
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
