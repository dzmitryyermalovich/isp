using System;
using System.Collections.Generic;
using System.Text;
using laba7.Collections;
using System.Linq;

namespace laba7.LinqFunc
{
    class LinqFunc
    {
        static public void print(IOrderedEnumerable<KeyValuePair<int, Room>> sortedPrices)
        {
            foreach (KeyValuePair<int, Room> keyValue in sortedPrices)
            {
                Console.WriteLine("Room number = " + keyValue.Key + "  info: price = " + keyValue.Value.price + "  name = " + keyValue.Value.name + "  isFree = " + keyValue.Value.isFree);
            }
        }
        static public IOrderedEnumerable<KeyValuePair<int, Room>> SortByPrice(Dictionary<int, Room> rooms)
        {
            IOrderedEnumerable<KeyValuePair<int,Room>> sortedPrices = from room in rooms
                               orderby room.Value.price
                               select room;
            return sortedPrices;
        }
        static public void SumOfAllReservedRooms(Dictionary<int, Room> rooms)
        {
            var ReservedRooms = from room in rooms
                                where room.Value.isFree == false
                                select room;
            int sumPrice = ReservedRooms.Sum(u => u.Value.price);
            Console.WriteLine("Sum = " + sumPrice);
        }
        static public void WhoPayMore(Dictionary<int, Room> rooms)
        {
            var ReservedRooms = from room in rooms
                                where room.Value.isFree == false
                                select room;
            var WhoIsPayMore = from room in ReservedRooms
                               where room.Value.price == ReservedRooms.Max(u => u.Value.price)
                               select room;
            foreach (KeyValuePair<int, Room> keyValue in WhoIsPayMore)
            {
                Console.WriteLine("Price = " + keyValue.Value.price + "  Name = " + keyValue.Value.name);
                break;
            }
        }
        static public IEnumerable<KeyValuePair<int, Room>> WhoPayMoreThanCertainPrice_(Dictionary<int, Room> rooms,int price)
        {
            IEnumerable<KeyValuePair<int,Room>> WhoPayMoreThanCertainPrice = from room in rooms
                                    where room.Value.isFree == false && room.Value.price>price
                                    select room;
            return WhoPayMoreThanCertainPrice;
        }
        static public void CountAmountOfGroup(Dictionary<int, Room> rooms)
        {
            var groupPrices = from room in rooms
                              group room by room.Value.price;
            foreach (IGrouping<int, KeyValuePair<int, Room>> keyValue in groupPrices)
            {
                Console.WriteLine("Price = " + keyValue.Key + " Amount of rooms = " + keyValue.Count());
            }
        }
    }
}
