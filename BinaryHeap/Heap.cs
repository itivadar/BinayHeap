using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryHeap
{
    class Heap<T> : IHeap<T> where T : IComparable
    {      
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        private IComparer<T> _comparer;
        T[] maxHeap;

        public Heap()
        {
            InitHeap();
            _comparer = null;
        }
        public Heap(IComparer<T> comparer)
        {
            InitHeap();           
            _comparer = comparer;
        }

        private void InitHeap()
        {
            Capacity = 4;
            maxHeap = new T[Capacity + 1];
            Count = 0;
        }

        public void AddKey(T key)
        {
            if (Count == Capacity) Resize(2 * Capacity);
            maxHeap[++Count] = key;
            Swim(Count);
        }

        public T GetMax()
        {
            return maxHeap[1];
        }

        public T PopMax()
        {
            T max = GetMax();
            Swap(1, Count--);
            Sink(1);
            if (Count > 0 && Count == Capacity / 4) Resize(Capacity / 2);
            return max;
        }

        private void Resize(int length)
        {
            Capacity = length;
            T[] copy = new T[length+1];
            for(int i=0; i<=Count; i++)
            {
                copy[i] = maxHeap[i];
            }
            maxHeap = copy;
        }

        private void Swim(int node)
        {
            while(node > 1 && IsLess(Father(node), node))
            {
                int father = Father(node);
                Swap(node, father);
                node = father;
            }
        }


        private void Sink(int node)
        {
            while(LeftSon(node) <= Count)
            {
                int leftSon = LeftSon(node);
                int rightSon = RightSon(node);
                int exchangedSon = leftSon;
                if (rightSon <= Count && IsLess(leftSon, rightSon)) exchangedSon = rightSon;
                if (IsLess(exchangedSon, node)) break;
                Swap(node, exchangedSon);
                node = exchangedSon;
            }
        }

        private int RightSon(int nodeIndex)
        {
            return 2 * nodeIndex + 1;
        }

        private int LeftSon(int nodeIndex )
        {
            return 2 * nodeIndex;
        }

        private int Father(int nodeIndex)
        {
            return nodeIndex / 2;
        }

        private void Swap(int thisIndex, int thatIndex)
        {
            T aux = maxHeap[thisIndex];
            maxHeap[thisIndex] = maxHeap[thatIndex];
            maxHeap[thatIndex] = aux;
        }

        private bool IsLess(int thisIndex, int thatIndex)
        {
            if(_comparer is null) return maxHeap[thisIndex].CompareTo(maxHeap[thatIndex]) < 0;
            return _comparer.Compare(maxHeap[thisIndex], maxHeap[thatIndex]) < 0;
        }
    }
}
