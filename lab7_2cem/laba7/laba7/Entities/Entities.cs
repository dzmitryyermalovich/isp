using System;
using System.Collections.Generic;
using System.Text;
using laba7.Collections;
namespace laba7.Entities
{
    class Entities<T> where T:Room
    {
        public static event EventHandler SomethChanged;
        public static int EnterInfo(Dictionary<int,Room> rooms, int numberOfRoom,int price)
        {
            foreach (KeyValuePair<int, Room> keyValue in rooms)
            {
               if (keyValue.Key== numberOfRoom)
                {
                    Console.WriteLine("Rewrite");
                    rooms[keyValue.Key].price = price;
                    rooms[keyValue.Key].isFree = true;
                    rooms[keyValue.Key].name = "";
                    return 0;
                }
            }
            Console.WriteLine("Write");
            rooms.Add(numberOfRoom, new Room { name = "", price = price, isFree = true });
            return 0;
        }
        public static int Register(Dictionary<int, Room> rooms, int numberOfRoom,string name)
        {
            try
            {
                rooms[numberOfRoom].isFree = false;
                rooms[numberOfRoom].name = name;
                Console.WriteLine("Resgistered");
            }
            catch
            {
                Console.WriteLine("Haven't got this room");
            }
            return 0;
        }
        public static int NotPreservedRoom(Dictionary<int, Room> rooms)
        {
            foreach (KeyValuePair<int, Room> keyValue in rooms)
            {
                if (keyValue.Value.isFree == true)
                {
                    Console.WriteLine("Room number = " + keyValue.Key + "  info: price = " + keyValue.Value.price + "  name = " + keyValue.Value.name + "  isFree = " + keyValue.Value.isFree);
                }
            }
            return 0;
        }
        public static int clientInfo(Dictionary<int, Room> rooms, string name)
        {
            foreach (KeyValuePair<int, Room> keyValue in rooms)
            {
                if (keyValue.Value.name == name)
                {
                    Console.WriteLine("Room number = " + keyValue.Key + "  info: price = " + keyValue.Value.price + "  name = " + keyValue.Value.name + "  isFree = " + keyValue.Value.isFree);
                }
            }
            return 0;
        }

    }
}
