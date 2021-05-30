# Binay Heap

My idea was to create simple and clear implementation of the binary heap data structure. The .NET framework lacks an implementation for this data structure. However, binary heaps are needed for some algorithms like `A*` or `IDA*` search algorithms.

The implemented type is max-heap but it can be easy transformed into a min-heap if needed.


## Creating a new binary heap
A new heap containing ints can be created as follows
```C#
H<int> heap = new H<int>();
```

## Adding keys
After the heap is created, we can add new keys.
```C#
heap.AddKey(2);
heap.AddKey(4);
heap.AddKey(6);
```
This operation is  _O(log N)_ where _N_ is the number of elements within the heap.

## Getting the max
The main feature of the heap is that it get the max (or min) element in constant time.
```C#
var max = heap.PopMax();
```
This method removes and returns the max element of the heap. It is  _O(1)_ operation.
