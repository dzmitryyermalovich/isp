using System;
using System.Collections.Generic;
using System.Text;

namespace _053506_Ermolovich_Lab5.Interfaces
{
    interface ICustomCollection<T>
    {
        T this[int index] { get;set; }
        void Reset();
        void Next();
        T Current();
        int count { get; set; }
        void Add(T item);
        void Remove(T item);
        T RemoveCurrent();
    }
}