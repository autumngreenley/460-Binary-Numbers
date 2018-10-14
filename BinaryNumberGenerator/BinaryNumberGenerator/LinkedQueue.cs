using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberGenerator
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;

        public LinkedQueue()
        {
            front = null;
            rear = null;
        }

        //Push
        public T Push(T element)
        {
            if (element == null)
            {
                //
            }
            if (IsEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                rear = front = tmp;
            }else
            {
                //General case
                Node<T> tmp = new Node<T>(element, null);
                rear.Next = tmp;
                rear = tmp;
            }
            return element;
        }

        //Pop
        public T Pop()
        {
            T tmp = null;
            if(IsEmpty())
            {
                //
            }
            else if(front == rear)
            {
                tmp = front.Data;
                front = null;
                rear = null;
            }
            else
            {
                tmp = front.Data;
                front = front.Next;
            }
            return tmp;
        }

        //IsEmpty
        public bool IsEmpty()
        {
            if(front==null && rear==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
