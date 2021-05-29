using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryHeap
{
    interface IHeap<T> where T:IComparable
    {
        int Capacity { get;}
        int Count { get;}

        void AddKey(T key);

        T GetMax();

        T PopMax();

    }
}
