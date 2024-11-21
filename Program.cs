using System.Collections.Generic;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> myList = new List<int>();
            char input = ' ';
            Console.WriteLine("   =============menu options========");
            Console.WriteLine("       p - print numbers");
            Console.WriteLine("       A - Add a number");
            Console.WriteLine("       M - Display mean of the numbers ");
            Console.WriteLine("       S - Display the smallest number");
            Console.WriteLine("       L - Display the largest number");
            Console.WriteLine("       F - Find anumber");
            Console.WriteLine("       C - Clear the whole list");
            Console.WriteLine("       Q - Quit");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("enter your choice from menu");


            do
            {
                Console.Write("==> ");
                input = char.Parse(Console.ReadLine());


                if (input == 'p' || input == 'P')
                {
                    if (myList.Count == 0)
                    {
                        Console.WriteLine("[] - The list is empty ");
                    }
                    else
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < myList.Count; i++)
                        {
                            Console.Write(myList[i] + " ");

                        }
                        Console.WriteLine("] ");
                    }
                }


                else if (input == 'a' || input == 'A')
                {
                    Console.Write("Enter the number to add : ==> ");
                    int newItem = int.Parse(Console.ReadLine());

                    // ===========for ponus  do not allow duplicate ==============
                    bool exist = false;
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] == newItem)
                        {
                            exist = true;
                            Console.WriteLine("this number is exist input another number");
                            break;
                        }
                    }
                    if (!exist)
                    {
                        myList.Add(newItem);
                        Console.WriteLine($"{newItem} added");
                    }
                }


                else if (input == 'm' || input == 'M')
                {
                    if (myList.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }

                    double sum = 0.0;
                    double mean = 0.0;
                    for (int i = 0; i < myList.Count; i++)
                    {
                        sum += myList[i];
                    }
                    mean = sum / myList.Count;
                    Console.WriteLine($"Mean: {mean}");
                }


                else if (input == 's' || input == 'S')
                {
                    if (myList.Count == 0)
                    {
                        Console.WriteLine("Unable to detemine the smallest number -list is empty");
                    }
                    int smallest = myList[0];
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] < smallest)
                        {
                            smallest = myList[i];
                        }
                    }
                    Console.WriteLine($"the smallest uumber is {smallest}");
                }


                else if (input == 'l' || input == 'L')
                {
                    if (myList.Count == 0)
                    {
                        Console.WriteLine("Unable to detemine the largest number -list is empty");
                    }
                    int largest = myList[0];
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] > largest)
                        {
                            largest = myList[i];
                        }
                    }
                    Console.WriteLine($"the largest uumber is {largest}");
                }

                //==========search task===========
                else if (input == 'f' || input == 'F')
                {
                    Console.Write("Enter number to search fo it : ");
                    int n = int.Parse(Console.ReadLine());
                    bool found = false;
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] == n)
                        {
                            found = true;
                            Console.WriteLine($"needed number in index {i}");
                            break;
                        }
                    }
                    if (!found)
                    { Console.WriteLine("needed number not in list!"); }
                }

                //========search task==========
                else if (input == 'c' || input == 'C')
                {
                    myList.Clear();
                    Console.WriteLine("list clear successed");
                }
                else if (input != 'q' && input != 'Q')
                {
                    Console.WriteLine("Unknown selection, please try again");
                    Console.WriteLine("   =============menu options========");
                    Console.WriteLine("       p - print numbers");
                    Console.WriteLine("       A - Add a number");
                    Console.WriteLine("       M - Display mean of the numbers ");
                    Console.WriteLine("       S - Display the smallest number");
                    Console.WriteLine("       L - Display the largest number");
                    Console.WriteLine("       F - Find anumber");
                    Console.WriteLine("       C - Clear the whole list");
                    Console.WriteLine("       Q - Quit");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("enter your choice from menu");
                }



            } while (input != 'q' && input != 'Q');
            Console.WriteLine("Goodbye");





        }
    }
}
