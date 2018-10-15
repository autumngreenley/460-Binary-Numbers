using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberGenerator
{
    public class Program
    {
        /**
        * Print the binary representation of all numbers from 1 up to n.
        * This is accomplished by using a FIFO queue to perform a level 
        * order (i.e. BFS) traversal of a virtual binary tree that 
        * looks like this:
        *                 1
        *             /       \
        *            10       11
        *           /  \     /  \
        *         100  101  110  111
        *          etc.
        * and then storing each "value" in a list as it is "visited".
        **/

        /// <summary>
        /// As the name implies, generates a list of binary representations of decimal numbers
        /// </summary>
        /// <param name="n">The number of binary numbers to generate</param>
        /// <returns>Returns a list of binary numbers</returns>
        static LinkedList<string> GenerateBinaryRepresentationList(int n)
        {
            // Create an empty queue of strings with which to perform the traversal.
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            // A list for returning the binary values
            LinkedList<string> output = new LinkedList<string>();

            if (n < 1)
            {
                // Binary representations of negative numbers aren't supported.
                // Returns an empty list.
                return output;
            }

            // Enqueue the first binary number.  Use a dynamic string to avoid string concat.
            q.Push(new StringBuilder("1"));

            // BFS.
            while(n-- > 0)
            {
                // Prints the front of the queue.
                StringBuilder sb = q.Pop();
                output.AddLast(sb.ToString());

                // Makes a copy.
                StringBuilder sbc = new StringBuilder(sb.ToString());

                // Left child.
                sb.Append('0');
                q.Push(sb);

                // Right child.
                sbc.Append('1');
                q.Push(sbc);
            }
            return output;
        }

        /// <summary>
        ///  Driver program to test above function
        /// </summary>
        /// <param name="args">The command line argument of a decimal int to make a binary list of</param>
        public static void Main(string[] args)
        {
            int n = 10;
            if(args.Length < 1)
            {
                Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
                Console.WriteLine("\tcsc Main 12");
            }
            try
            {
                n = Int32.Parse(args[0]);
            }
            catch(FormatException e)
            {
                Console.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
                return;
            }

            // Print it right justified.  Longest string is the last one.
            // Print enough spaces to move it over the correct distance
            LinkedList<string> output = GenerateBinaryRepresentationList(n);
            int maxlength = output.Last().Length;
            foreach(string s in output)
            {
                for(int i = 0; i< maxlength - s.Length; ++i)
                {
                    Console.Write("");
                }
                Console.WriteLine(s);
            }
        } 
    }
}
