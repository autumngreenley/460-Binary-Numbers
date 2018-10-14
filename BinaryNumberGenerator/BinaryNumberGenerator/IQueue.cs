using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberGenerator
{
    public interface IQueue
    {
        /// <summary>
        /// Add an element to the rear of the queue
        /// </summary>
        /// <param name="Element">The element to add</param>
        /// <returns>The element that was enqueued</returns>
        T Push(T Element);

        /// <summary>
        /// Remove and return the front element.
        /// </summary>
        /// <returns>The front element</returns>
        T Pop();

        /// <summary>
        /// Test if the queue is empty
        /// </summary>
        /// <returns>True if the queue is empty; otherwise false</returns>
        Boolean IsEmpty();
    }
}
