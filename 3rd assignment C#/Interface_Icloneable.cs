using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Icloneable
{
    interface Icloneable
    {
        void Push(int data);
        int Pop();
    }
    class UsingInterface_Icloneable
    {

        public static void Main()

        {
            MyStack pp = new MyStack();

            pp.Push(100);
            pp.Push(25);
            pp.Push(35);
            pp.Push(49);
            pp.Push(55);
            pp.Push(66);
            pp.print();
            Console.WriteLine();
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            //Console.WriteLine("Element removed from stack:" + pp.Pop());

            //pp.print()

        }
    }

    public class MyStack : Icloneable
    {



        int[] arr = new int[5];

        int top = 0;



        public void Push(int data)

        {

            try
            {
                if (top == 6)
                {
                    Console.WriteLine("-----StackOverFlow-------");

                }


                else
                {
                    arr[top] = data;
                    top++;
                }

            }
            catch (Exception)
            {

            }
        }

        public void print()
        {

            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int Pop()
        {
            if (top <= 0)
            {
                Console.WriteLine("-----Stack Under Flow------");
                return -1;
            }
            else
            {
                int temp = arr[top - 1];
                top--;

                return temp;
            }
        }
    }
}

   
