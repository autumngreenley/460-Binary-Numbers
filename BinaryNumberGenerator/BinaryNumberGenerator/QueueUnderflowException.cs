﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberGenerator
{
    class QueueUnderflowException : Exception
    {
        /// <summary>
        /// Throws an underflow exception with no message
        /// </summary>
        public QueueUnderflowException()
        {}

        /// <summary>
        /// Throws an underflow exception with a message
        /// </summary>
        /// <param name="message"></param>
        public QueueUnderflowException(string message): base(message)
        {}
    }
}
