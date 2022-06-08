using ConsoleApp7.Models;
using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();
            TblSample sample = new TblSample();
            sample.Text = "Amruta Musale New";
            db.TblSamples.Add(sample);
            db.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
