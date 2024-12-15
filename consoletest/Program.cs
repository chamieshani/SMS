using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoletest
{
    public class Animal
    {
        public int Id { get; set; }
        private string Name { get; set; }
        protected string Price { get; set; }
    }
    public class Cow:Animal
    {
        public void GetDetails()
        {
            Cow mycow = new Cow();
            mycow.Id = 4;
            mycow.Price = "";
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            string text = "AMMA1";
            char [] a=text.ToCharArray();
            int size = a.Length;
            char[] b= new char[size];
            bool isa = true;
            int i = 0;
            // reverse the string
            while (i != size)
            {
                b[i] = a[size-1-i];
                i++;
            }
            i = 0;

            // check the reverse string and the give string is same
            while (i != size)
            {
                if (b[i] != a[i])
                {
                    Console.WriteLine(text + " is not a Pallindrome");
                    isa = false;
                    break;
                }
                
                i++;
            }

            if(isa)
            Console.WriteLine("is a palindrome");


            for (i = 5; i>0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();

            }
            
            Console.WriteLine();

            for (int row = 1; row <= 5; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();


            }

            Console.WriteLine();

            for ( i = 0; i < 5; i++)
            {
                for (int j = 0; j < (5-i-1); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5-1-i; k<5; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();

            }

            Console.WriteLine();


            for ( i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                for (int z = i; z < 5; z++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }




            Stack st = new Stack();

            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push('D');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Queue q = new Queue();
            q.Enqueue("Two");
            q.Enqueue("One");

            // remove elements
            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());



            // POS
            Console.WriteLine();
            int balance = 19;
            int numberofcoins = 0;
            int remainder = 0;
            int[] coins = {10,5,2,1};
            size = coins.Length;
            int[] mybalacecoins= new int[size];
          
            for (i = 0; i < size; i++)
            {
                remainder = balance % coins[i];
                numberofcoins = balance /(coins[i]);
                mybalacecoins[i]= numberofcoins;
                if (remainder == 0)
                    i=size;
                else
                balance = remainder;
            }
            for (int j = 0; j < size; j++)
            {
                Console.Write(mybalacecoins[j]);
            }


            Console.WriteLine();
            // reverse
            string mytext = "chamika";
            char[] textarray = mytext.ToCharArray();
            size = textarray.Length;
            char[] reversetextarray = new char[size];

            for (i = 0; i < size; i++)
            {
                reversetextarray[i]= textarray[size-1-i];
                
            }
            for (i = 0; i < size; i++)
            {
                Console.Write(reversetextarray[i]);
            }




                Console.Read();
        }
    }
}
