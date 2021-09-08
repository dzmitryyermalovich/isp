using System;
using System.Collections.Generic;
using System.Text;
using _053506_Ermolovich_Lab5.Collections;

namespace _053506_Ermolovich_Lab5.Entities
{
    class Entities<T> where T:Hotel
    {
        public static int EnterInfo(MyCustomCollection<T> myCustomCollection,T item)
        {
            Node<T> currant = myCustomCollection.head;
            while (currant != null)
            {
                if (currant.Item.roomNumber==item.roomNumber)
                {
                    currant.Item.price = item.price;
                    currant.Item.isFree = true;
                    currant.Item.name = "";
                    Console.WriteLine("Rewrite");
                    return 0;
                }
                currant = currant.Next;
            }
            myCustomCollection.Add(item);
            Console.WriteLine("Added");
            return 0;
        }
        public static int Register(MyCustomCollection<T> myCustomCollection, T item)
        {
            Node<T> currant = myCustomCollection.head;
            while (currant != null)
            {
                if (currant.Item.roomNumber==item.roomNumber)
                {
                    if (currant.Item.isFree == false)
                    {
                        Console.WriteLine("This room is reserved");
                        return 0;
                    }
                    else
                    {
                        currant.Item.isFree = false;
                        currant.Item.name = item.name;
                        return 0;
                    }
                }
                currant = currant.Next;
            }
            Console.WriteLine("This room was not found");
            return 0;
        }
        public static int NotPreservedRoom(MyCustomCollection<T> myCustomCollection)
        {
            Node<T> currant = myCustomCollection.head;
            while (currant != null)
            {
                if (currant.Item.isFree == true)
                {
                    Console.WriteLine($"Room number = {currant.Item.roomNumber}, price = {currant.Item.price}, isFree = {currant.Item.isFree}, name = {currant.Item.name}");
                }
                currant = currant.Next;
            }
                return 0;
        }
        public static int clientInfo(MyCustomCollection<T> myCustomCollection,string name)
        {
            Node<T> currant = myCustomCollection.head;
            while (currant != null)
            {
                if (currant.Item.name == name)
                {
                    Console.WriteLine($"name = {currant.Item.name}, price = {currant.Item.price}");
                }
                currant = currant.Next;
            }
                return 0;
        }

    }
}
