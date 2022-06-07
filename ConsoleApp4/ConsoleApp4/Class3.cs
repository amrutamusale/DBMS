using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp4
{

    //arratlist
    class class4
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Ora", "Oracle");
            ht.Add("vb", "vb.Net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            Console.WriteLine("=================");

            SortedList s1 = new SortedList();
            s1.Add("Ora", "Oracle");
            s1.Add("vb", "vb.net");
            s1.Add("cs", "cs.net");
            s1.Add("asp", "asp.net");

            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            Console.WriteLine("==================");
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            stk.Pop();

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");

            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}


