using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberGenerator
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> Front;
        private Node<T> Rear;

        public LinkedQueue()
        {
            Front = null;
            Rear = null;
        }

        //Push
        public T Push(T Element)
        {
            if (Element == null)
            {
                //
            }
            if (IsEmpty())
            {
                Node<T> Tmp = new Node<T>(Element, null);
                Rear = Front = Tmp;
            }else
            {
                //General case
                Node<T> Tmp = new Node<T>(Element, null);
                Rear.Next = Tmp;
                Rear = Tmp;
            }
            return Element;
        }

        //Pop
        public T Pop()
        {
            T Tmp = null;
            if(IsEmpty())
            {
                //
            }
            else if(Front == Rear)
            {
                Tmp = Front.Data;
                Front = null;
                Rear = null;
            }
            else
            {
                Tmp = Front.Data;
                Front = Front.Next;
            }
            return Tmp;
        }

        //IsEmpty
        public bool IsEmpty()
        {
            if(Front==null && Rear==null)
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
