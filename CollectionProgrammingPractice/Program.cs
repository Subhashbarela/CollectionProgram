﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProgrammingPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("1:Create LinkedList \n2: Add Data");
            Console.WriteLine("Enter the choice");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        list.Add(56);
                        list.Add(30);
                        list.Add(70); 
                        list.display();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("insert the first element into linked list :");
                        int first = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("insert the second element into linked list :");
                        int second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("insert the third element into linked list :");
                        int third = Convert.ToInt32(Console.ReadLine());
                        list.Add(first);
                        list.Add(second);
                        list.Add(third);
                        list.display();
                        break;
                    }
           
        }
           
            Console.ReadLine();
        }
    }
}
