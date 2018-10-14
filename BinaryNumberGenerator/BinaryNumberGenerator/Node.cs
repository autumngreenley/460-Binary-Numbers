﻿using System;
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

        public Node(T Data, Note<T> Next)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }
}
