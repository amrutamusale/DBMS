using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp4
{
    //arraylist
    class class2
    {
        public static void Main2()
        {
            ArrayList al = new ArrayList();
            string str = "Amruta";
            int x = 7;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Remove(d);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
