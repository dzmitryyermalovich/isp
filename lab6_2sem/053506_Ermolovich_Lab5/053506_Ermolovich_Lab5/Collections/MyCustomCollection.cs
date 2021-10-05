using _053506_Ermolovich_Lab5.Interfaces;
using System;

namespace _053506_Ermolovich_Lab5.Collections
{
    class OwnEception:Exception
    {
        public OwnEception(string mes):base(mes)
        {
        }
    }
    public class Node<T>
    {
        public Node(T item)
        {
            Item = item;
        }
        public T Item { get; set; }
        public Node<T> Next { get; set; }
    }
    class MyCustomCollection<T> : ICustomCollection<T> where T : Hotel
    {
        public Node<T> head;
        public Node<T> tail;
        private int Count;
        public int count {
            get
            {
                return Count;
            }
            set
            {
                Count = value;
            }
        }
        public int Position;
        public int position
        {
            get
            {
                return Position;
            }
            set
            {
                Position = value;
            }
        }
        public T this[int index]
        {
            get
            {
                Hotel a = new Hotel { roomNumber = -1, price = -1, isFree = true };
                try
                {
                    Node<T> currant = head;
                    if (index >= count)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        for (int i = 0; i < index; i++)
                        {
                            currant = currant.Next;
                        }
                        return currant.Item;
                    }
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid index");
                    return (T)a;
                }     
            }
            set
            {
                 Add(value);
                 

            }
        }
        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            if (head == null)
            {
                head = node;
                Count = 0;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            Count++;
        }

        public T Current()
        {
            Node<T> currant = head;
            for (int i = 0; i < Position; i++)
            {
                currant = currant.Next;
            }
            return currant.Item;
        }

        public void Next()
        {
            Position++;
            if (Position == count)
            {
                Position--;
            }
        }

        public void Remove(T item)
        {
            Node<T> current = head;
            Node<T> previous = null;
            bool isDelete = false;
            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                        {
                            tail = null;
                        }                      
                    }
                    Count--;
                    isDelete = true;
                }
                previous = current;
                current = current.Next;
            }
            if (isDelete == false)
            {
                throw new OwnEception("object not found");
            }
        }

        public T RemoveCurrent()
        {
            Node<T> currant = head;
            Node<T> previous = null;

            for (int i = 0; i < Position; i++)
            {
                previous = currant;
                currant = currant.Next;
            }

            if (Position == 0)
            {
                head = head.Next;

                if (head == null)
                {
                    tail = null;
                }            
            }
            else if (Position == Count - 1)
            {
                previous.Next = currant.Next;
                tail = previous;
            }
            else
            {
                previous.Next = currant.Next;
            }

            return currant.Item;
        }

        public void Reset()
        {
            Position = 0;
        }
        public void print()
        {
            Node<T> currant = head;
            while (currant != null)
            {
                Console.WriteLine($"Room number = {currant.Item.roomNumber}, price = {currant.Item.price}, isFree = {currant.Item.isFree}, name = {currant.Item.name}");
                currant = currant.Next;
            }
        }
    }
    class Hotel
    {
        public int roomNumber;
        public int price;
        public bool isFree;
        public string name;
    }
}