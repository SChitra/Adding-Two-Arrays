using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a1 = { 1, 2, 3 };
            //int[] a2 = { 2, 3, 4 };
            int[] a1 = { 2, 6, 6 };
            int[] a2 = { 3, 4, 6 };
            int sum;
            int carry = 0;
            Stack<int> st1 = new Stack<int>(); 
           
            for(int i = a1.Length -1; i >= 0; i--)
            {
                sum = a1[i] + a2[i] + carry;
                //Checking to see if there is a carry over
                if (sum <= 9)
                {
                    //if there is no carry over push the sum to stack and set carry equal to 0.
                    st1.Push(sum);
                    //Console.Write(sum);
                    carry = 0;
                }
                else
                {
                    //if there is a carry over then push the ones answer to the stack and set carry equal to 1.
                    int ones = sum - 10;
                    st1.Push(ones);
                    //Console.Write(ones);
                    carry = 1;
                }
            }
            //Console.WriteLine(st1.Count);
            for (int i = st1.Count; i > 0; i--)
            {
                Console.Write("{0} ",st1.Peek());
                st1.Pop();
            }

        }
    }
}
