using System.Collections;
using System.Collections.Generic;

namespace LinkedListLibrary
{
    public class Set<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly List<T> _items = new List<T>();

        public Set()
        {
        }

        public Set(IEnumerable<T> items)
        {
            AddRange(items);
        }

        public void Add(T item)
        {
            if (!Contains(item))
            {
                _items.Add(item);
            }
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public bool Contains(T item)
        {
            foreach (var existing in _items)
            {
                if (existing.CompareTo(item) == 0)
                    return true;
            }
            return false;
        }

        public int Count => _items.Count;

 
        public Set<T> Union(Set<T> other)
        {
            var result = new Set<T>(_items);

            foreach (var item in other)
            {
                result.Add(item);
            }

            return result;
        }


        public Set<T> Intersection(Set<T> other)
        {
            var result = new Set<T>();

            foreach (var item in _items)
            {
                if (other.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Set<T> Difference(Set<T> other)
        {
            var result = new Set<T>();

            foreach (var item in _items)
            {
                if (!other.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Set<T> SymmetricDifference(Set<T> other)
        {
            var result = new Set<T>();

            foreach (var item in _items)
            {
                if (!other.Contains(item))
                {
                    result.Add(item);
                }
            }

            foreach (var item in other)
            {
                if (!this.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}