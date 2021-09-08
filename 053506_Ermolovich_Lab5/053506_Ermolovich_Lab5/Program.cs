using System;
using _053506_Ermolovich_Lab5.Collections;
using _053506_Ermolovich_Lab5.Entities;
namespace _053506_Ermolovich_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomCollection<Hotel> arr = new MyCustomCollection<Hotel>();
            Entities<Hotel>.EnterInfo(arr,new Hotel { roomNumber=12,price=1800,isFree=true});
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 15, price = 1111, isFree = true });
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 17, price = 1234, isFree = true });
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 12, price = 523, isFree = true });
            Entities<Hotel>.EnterInfo(arr, new Hotel { roomNumber = 11, price = 4567, isFree = true });
            arr.print();

            Console.WriteLine("\n\n");
            Entities<Hotel>.Register(arr, new Hotel { roomNumber = 11, name="Dima" });
            arr.print();
            Console.WriteLine("\n\n");
            Entities<Hotel>.Register(arr, new Hotel { roomNumber = 11, name = "Vasua" });
            arr.print();
            Console.WriteLine("\n\n");
            Entities<Hotel>.Register(arr, new Hotel { roomNumber = 99, name = "Vasua" });
            arr.print();
            Console.WriteLine("\n\n");
            Entities<Hotel>.NotPreservedRoom(arr);
            Console.WriteLine("\n\n");
            Entities<Hotel>.clientInfo(arr, "Dima");

            Console.WriteLine("\n=====================================\n");

            arr.Next();
            arr.Remove(arr.Current());
            arr.print();
            Console.WriteLine("\n\n");

            arr.Remove(new Hotel { roomNumber = 99, price = 1111, isFree = true });
            arr.print();
            Console.WriteLine("\n\n");

            arr.Reset();
            arr.Next();
            Console.WriteLine(arr.Current().roomNumber);

            arr.Reset();
            Console.WriteLine(arr.Current().roomNumber);

            arr.Next();
            arr.Next();
            arr.Next();
            arr.Next();
            Console.WriteLine(arr.Current().roomNumber);
            Console.WriteLine("\n\n");

            arr.RemoveCurrent();
            arr.print();

            Console.WriteLine("\n\n");
            Console.WriteLine("\n=====================================\n");
            Console.WriteLine("\n\n");

            Console.WriteLine(arr[0].roomNumber);
            Console.WriteLine(arr[1].roomNumber);
            Console.WriteLine("\n\n");

            arr[3] = new Hotel { roomNumber = 99, price = 1111, isFree = true };
            arr.print();
            Console.WriteLine(arr[5].roomNumber);
        }
    }
}
