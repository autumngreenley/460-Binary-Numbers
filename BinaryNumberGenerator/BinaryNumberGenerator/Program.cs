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
        */

        static LinkedList<string> GenerateBinaryRepresentationList(int n)
        {
            // Create an empty queue of strings with which to perform the traversal
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            // A list for returning the binary values
            LinkedList<string> output = new LinkedList<string>();

            if (n < 1)
            {
                return output;
            }

            q.Push(new StringBuilder("1"));

            while(n-- > 0)
            {
                StringBuilder sb = q.Pop();
                output.AddLast(sb.ToString());

                StringBuilder sbc = new StringBuilder(sb.ToString());

                sb.Append('0');
                q.Push(sb);

                sbc.Append('1');
                q.Push(sbc);
            }
            return output;
        }

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

        // The code provided will print ‘Hello World’ to the console.
        // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
        //Console.WriteLine("Hello World!");
        //Console.ReadKey();
            
        
    }
}
