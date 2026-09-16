using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    public class CustomStack<T>
    {
        private T[] _items;
        private int _count;
        private const int DefaultCapacity = 4;

        public CustomStack(int initialCapacity = DefaultCapacity)
        {
            if (initialCapacity < 0)
                throw new ArgumentOutOfRangeException(nameof(initialCapacity), "Capacity cannot be negative.");

            _items = new T[initialCapacity];
            _count = 0;
        }

        // Number of elements in the stack
        public int Count => _count;

        // Check if the stack is empty
        public bool IsEmpty => _count == 0;

        // Push: Adds an item to the top of the stack
        public void Push(T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }

            _items[_count] = item;
            _count++;
        }

        // Pop: Removes and returns the top item
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty.");

            _count--;
            T item = _items[_count];

            // Clear memory reference for garbage collection (especially if T is a reference type)
            _items[_count] = default!;

            return item;
        }

        // Peek: Returns the top item without removing it
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty.");

            return _items[_count - 1];
        }

        // Doubles array capacity when full
        private void Resize()
        {
            int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(_items, newArray, _count);
            _items = newArray;
        }
    }
}
