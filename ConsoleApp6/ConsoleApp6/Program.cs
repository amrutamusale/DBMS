using ConsoleApp6.Models;
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();
            SampleDb1Context sample = new Sample();
            sample.Id = 1;
            sample.Name = "Amruta Musale";
            db.Samples.Add(sample);
            db.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
