﻿using System.Collections;

namespace Algorithms_DataStruct_Lib.Queue
{
    public class ArrayQueue<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;

        public int Count => _tail - _head;
        public bool IsEmpty => Count == 0;
        public int Capacity => _queue.Length;


        public ArrayQueue()
        {
            const int defaultCapacity = 4;
            _queue = new T[defaultCapacity];
        }

        public ArrayQueue(int capacity)
        {
            _queue = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (_queue.Length == _tail)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_queue, largerArray, Count);
                _queue = largerArray;
            }

            _queue[_tail++] = item;
        }

        public void Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            _queue[_head++] = default;

            if (IsEmpty)
                _head = _tail = 0;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return _queue[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _head; i < _tail; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
