using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp9
{
    class Class1
    {
        static void ListData(SampleDb1Context db)
        {
            var data = db.TblSamples;
            foreach(var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
        }
        static void Main(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();
            bool Exit = false;
            while (true)
            {
                Console.WriteLine("Please Enter Some Choice \n 1.Add Record \n 2.List Record \n 3.Update Record \n 4.Delete Record \n 5.Exit");
                Console.WriteLine("========================================");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your name");
                        string name = Console.ReadLine();

                        TblSample tblsample = new TblSample();
                        tblsample.Text = name;
                        db.TblSamples.Add(tblsample);
                        db.SaveChanges();
                        Console.WriteLine("Record added successfullly");
                        Console.WriteLine("======================================");
                        break;
                    case 2:
                        ListData(db);
                        break;
                    case 3:
                        ListData(db);
                        Console.WriteLine("Please enter id which you want to update");
                        int UpdateId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the new name");
                        var newName = Console.ReadLine();
                        var UpdateObject = db.TblSamples.Where(x => x.Id == UpdateId).FirstOrDefault();
                        UpdateObject.Text = newName;
                        db.TblSamples.Update(UpdateObject);
                        db.SaveChanges();
                        Console.WriteLine("Record is successfully updated.");
                        break;
                    case 5:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice!!");
                        break;
                }
                if (Exit)
                    break;
            }
        }
    }
}