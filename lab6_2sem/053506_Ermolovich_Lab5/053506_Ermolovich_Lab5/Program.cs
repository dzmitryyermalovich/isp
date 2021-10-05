using System;
using _053506_Ermolovich_Lab5.Collections;
using _053506_Ermolovich_Lab5.Entities;
using System.Collections.Generic;
namespace _053506_Ermolovich_Lab5
{
    class Program
    {
        delegate void del3(MyCustomCollection<Hotel> myCustomCollection, Hotel item);
        static void Main(string[] args)
        {
            MyCustomCollection<Hotel> arr = new MyCustomCollection<Hotel>();
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 12, price = 1800, isFree = true });
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 15, price = 1111, isFree = true });
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 17, price = 1234, isFree = true });
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 12, price = 523, isFree = true });
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 11, price = 4567, isFree = true });
            arr.print();

            Console.WriteLine("\n");
            Journal<Hotel> journal = new Journal<Hotel>();
            Entities<Hotel>.SomethChanged += journal.RecordEvent;
            journal.Notify += Entities<Hotel>.EnterInfo;
            journal.LaunchEvent(arr, new Hotel { roomNumber = 99, price = 9999, isFree = true });
            Console.WriteLine("\n\n");
            arr.print();

            Console.WriteLine("\n");
            journal.Notify -= Entities<Hotel>.EnterInfo;
            journal.Notify += Entities<Hotel>.Register;
            journal.LaunchEvent(arr, new Hotel { roomNumber = 11, name = "Dima" });
            Console.WriteLine("\n\n");
            arr.print();

            Console.WriteLine("\n\n");
            del3 Regist = (myCustomCollection, item) => journal.LaunchEvent(myCustomCollection, item);
            Regist.Invoke(arr, new Hotel { roomNumber = 17, name = "Vasya" });
            arr.print();

            Console.WriteLine("\n\n");
            journal.Notify += Entities<Hotel>.EnterInfo;
            journal.Notify += Entities<Hotel>.EnterInfo;
            journal.Notify += Entities<Hotel>.Register;
            journal.Notify += Entities<Hotel>.Register;
            journal.PrintAllEvents();

            Console.WriteLine("\n");
            try
            {
                arr.Remove(new Hotel { roomNumber = 99, price = 1111, isFree = true });
            }
            catch (OwnEception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");
            Console.WriteLine(arr[10].roomNumber);

        }

    }
}
