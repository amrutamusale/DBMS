
using System;
using ConsoleApp9.Models;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main1(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();


            // Insertion

            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();
            // SampleDBContext db = new SampleDBContext();
            //Tblsample tblsample = new Tblsample();
            //tblsample.Text = name;
            //db.Tblsamples.Add(tblsample);
            //db.SaveChanges();


            //How we can show the values
            /*var data = db.Tblsamples;

            Console.WriteLine("Values from database ");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
            */
            //How we can delete the value
            //Console.WriteLine("Pleae enter id of your name which you want to delete");
            //int DeleteItem = Convert.ToInt32(Console.ReadLine());
            //var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();
            //db.Tblsamples.Remove(DeleteObject);
            //db.SaveChanges();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id + " | " + item.Text);
            //}
            //How we can Update the value
            var data = db.TblSamples;
            Console.WriteLine("Pleae enter id of your name which you want to update");
            int InsertItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new name");
            var newName = Console.ReadLine();
            var UpdatteObject = db.TblSamples.Where(x => x.Id == InsertItem).FirstOrDefault();
            UpdatteObject.Text = newName;
            db.TblSamples.Update(UpdatteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
        }
    }
}