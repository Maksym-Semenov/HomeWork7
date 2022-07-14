using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string [] words = new string[2];
            //Part 1
            //try
            //{
            //    string path = @"D:\Task7\phones.txt";
            //    using (StreamReader sr = new StreamReader(path))
            //    {
            //        string line;
            //        for (int i = 0; i < 9; i++)
            //        {
            //            if ((line = sr.ReadLine()) != null)
            //            {
            //                words = line.Split(',');
            //                PhoneBook.Add(words[0], words[1]);
            //            }
            //        }
            //    }
            //    foreach (var item in PhoneBook.Values)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadLine();
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File not found!");
            //}
            ////Part 2
            //Console.WriteLine("Enter name person:\t");
            //string name = Console.ReadLine();
            //foreach (var item in PhoneBook)
            //{
            //    if (item.Key == name)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}
            //Part 3
            string newTXT = @"D:\Task7\newTXT.txt";
            string[] temp = new string[2];
            Console.WriteLine("This Keys don't have +3");
            foreach (var item in PhoneBook)
            {
                item.Value.Trim();
                item.Key.Trim();
            }

            foreach (var item in PhoneBook)
            {
                using (StreamReader sr = new StreamReader(newTXT))
                {
                    if(item.Value != null && item.Key != null && item.Value.StartsWith("8"))
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.ReadLine();
            }
            //using (StreamReader sr = new StreamReader(newTXT))
            //{
            //    newTXT = sr.ReadLine();
            //}
            //foreach (var item in PhoneBook)
            //{
            //    if (item.Value.StartsWith("8"))
            //    {
            //        temp = item;
            //        PhoneBook.Remove(item.Key);
            //        Console.WriteLine($"+3{item.Value}");
            //        PhoneBook.
            //    }
            //}
            Console.ReadLine();
        }
    }
}
