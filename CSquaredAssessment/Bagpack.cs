using System;
using System.Collections.Generic;

namespace CSquaredAssessment
{
    //Bagpack class
    class Bagpack
    {
        public List<string> BagItems = new List<string>();

        //print bag pack on items
        public void Print()
        {
            Console.WriteLine("Your bagpack contains.");
            foreach (var itm in BagItems)
            {
                Console.WriteLine(itm);
            }
        }

        //Add() method to add items to the BagItems list
        public void Add()
        {
            Console.WriteLine("Enter the name of an item to keep in the bag: ");
            string item = Console.ReadLine();
            BagItems.Add(item);

            while (item != "")
            {
                Console.WriteLine("Please enter another item: ");
                item = Console.ReadLine();
                BagItems.Add(item);
            }

            Print();
        }


        //remove item from list
        public void Remove()
        {
            Console.WriteLine("Enter the name of an item to take out of the bag: ");
            string item = Console.ReadLine();
            BagItems.Remove(item);

            while (item != "")
            {
                Console.WriteLine("Please enter another item to remove: ");
                item = Console.ReadLine();
                BagItems.Remove(item);
            }

            Print();
        }


        //find an item in list
        public void Find()
        {
            Console.WriteLine("What do you want to find: ");
            var item = Console.ReadLine();
            var ContainItems = new List<string>();

            foreach (var itm in BagItems)
            {
                if (itm.Contains(item))
                {
                    ContainItems.Add(item);
                    continue;
                }
                Console.WriteLine("Does not contain: " + itm);

            }

            Console.WriteLine("The bag contains following items: ");
            foreach (var itm in ContainItems)
            {
                Console.WriteLine("Contains: {0}", itm);
            }
        }


        //choose an action to perform
        public void ChooseAction()
        {
            Console.WriteLine("Please choose your action:");
            Console.WriteLine("Enter 1 to Display the list of items in side the bagpack.");
            Console.WriteLine("Enter 2 to Add items in the bagpack.");
            Console.WriteLine("Enter 3 to Remove items from the bagpack.");
            Console.WriteLine("Enter 4 to Find if an item is in the bagpack.");
            Console.WriteLine("Enter 5 to exit the application.");
        }

        

        //start point
        public void Start()
        {
            Print();
            ChooseAction();
            
            Console.WriteLine("Type the action number you want to perform: ");
           int action = Convert.ToInt32(Console.ReadLine());
            
            while (action<4
               ) { 
                switch (action)
                {
                    case 1:
                        Print();
                        ChooseAction();
                        break;
                    case 2:
                        Add();
                        ChooseAction();
                        break;
                    case 3:
                        Remove();
                        ChooseAction();
                        break;
                    case 4:
                        Find();
                        ChooseAction();
                        break;
                    case 5:
                        Console.Write("Thank you for using this bagpack. ");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid action number.");
                        Start();
                        break;
                }
            }
        }
    }
}