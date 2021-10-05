using System;
using System.Collections.Generic;
using System.Linq;
using laba7.Collections;
using laba7.Entities;
using laba7.LinqFunc;
namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Room> rooms = new Dictionary<int, Room>();
            rooms.Add(6, new Room { price = 234, name = "Dima", isFree = false });
            rooms.Add(66, new Room { price = 190, name = "", isFree = true });
            rooms.Add(14, new Room { price = 234, name = "", isFree = true });
            rooms.Add(88, new Room { price = 927, name = "", isFree = true });
            rooms.Add(76, new Room { price = 234, name = "Vasya", isFree = false });
            rooms.Add(12, new Room { price = 190, name = "Igor", isFree = false });
            rooms.Add(32, new Room { price = 927, name = "", isFree = true });
            //var sortedPrices = LinqFunc.LinqFunc.SortByPrice(rooms);
            //LinqFunc.LinqFunc.print(sortedPrices);

            //LinqFunc.LinqFunc.SumOfAllReservedRooms(rooms);

            //LinqFunc.LinqFunc.WhoPayMore(rooms);


            //var WhoPayMoreThanCertainPrice = LinqFunc.LinqFunc.WhoPayMoreThanCertainPrice_(rooms, 150);

            //foreach (KeyValuePair<int, Room> keyValue in WhoPayMoreThanCertainPrice)
            //{
            //    Console.WriteLine("Room number = " + keyValue.Key + "  info: price = " + keyValue.Value.price + "  name = " + keyValue.Value.name + "  isFree = " + keyValue.Value.isFree);
            //}

            //LinqFunc.LinqFunc.CountAmountOfGroup(rooms);

            //List<String> clients = new List<string>();
            //clients.Add("Dima");
            //clients.Add("Vasya");
            //clients.Add("Igor");
            //foreach(string client in clients)
            //{
            //    Console.WriteLine("Client = " + client);
            //}
            //Console.WriteLine("\n\n");
            //Entities<Room>.EnterInfo(rooms, 155, 999);
            //Entities<Room>.EnterInfo(rooms, 12, 1000);
            //Entities<Room>.Register(rooms, 88, "Pol");
            //foreach (KeyValuePair<int, Room> keyValue in rooms)
            //{
            //    Console.WriteLine("Room number = " + keyValue.Key + "  info: price = " + keyValue.Value.price + "  name = " + keyValue.Value.name + "  isFree = " + keyValue.Value.isFree);
            //}
            //Console.WriteLine("\n\n");
            //Entities<Room>.NotPreservedRoom(rooms);
            //Console.WriteLine("\n\n");
            //Entities<Room>.clientInfo(rooms, "Dima");

        }
    }
}
