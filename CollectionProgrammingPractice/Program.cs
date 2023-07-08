using System;
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
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("1:Create LinkedList \n2: Add Data \n3: Appending data \n4: Insert Specific Pos" +
                " \n5: Delete first elem \n6: Dlete last elem\n7: Search Elem \n8: Insert after");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
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
                case 3:
                    {
                        Console.WriteLine("insert the first element into linked list :");
                        int first = Convert.ToInt32(Console.ReadLine());
                        list.AddLast(first);
                        list.display();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("insert the  element into specific position :");
                        int data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("insert the position :");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        list.InterAtPosition(pos, data);
                        list.display();
                        break;
                    }
                case 5:
                    {                       
                        list.display();
                        list.DeleteFirstElement();
                        list.display();
                        break;
                    }
                case 6:
                    {
                        list.display();
                        list.DeleteLastElement();
                        list.display();
                        break;
                    }
                case 7:
                    {                     
                        list.display();
                        Console.WriteLine("\n......................");
                        list.FindElement(70);
                        break;
                    }
                case 8:
                    {                       
                        list.display();
                        Console.WriteLine("\n......................");
                        list.InsertAfter(30, 40);
                        list.display();
                        break;
                    }
                default:
                    Console.WriteLine("Please insert the valid input....!");
                    break;

            }

            Console.ReadLine();
        }
    }
}
