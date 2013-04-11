#if FAT
using System;
using System.Collections.Generic;
using System.Linq;

using Theraot.Core;

namespace Theraot.Collections
{
    [System.Serializable]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [System.Diagnostics.DebuggerDisplay("Count={Count}")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Justification = "By Design")]
    public sealed class ExtendedList<T> : IExtendedList<T>, IList<T>, ICollection<T>, IEnumerable<T>, ICloneable, ICloneable<ExtendedList<T>>
    {
        private readonly IEqualityComparer<T> _comparer;
        private readonly IExtendedReadOnlyList<T> _readOnly;
        private readonly List<T> _wrapped;

        public ExtendedList()
        {
            _comparer = EqualityComparer<T>.Default;
            _wrapped = new List<T>();
            _readOnly = CreateReadOnly();
        }

        public ExtendedList(IEnumerable<T> prototype)
        {
            _comparer = EqualityComparer<T>.Default;
            _wrapped = new List<T>();
            _readOnly = CreateReadOnly();
            this.AddRange(Check.NotNullArgument(prototype, "prototype"));
        }

        public ExtendedList(IEnumerable<T> prototype, IEqualityComparer<T> comparer)
        {
            _comparer = Check.NotNullArgument(comparer, "comparer");
            _wrapped = new List<T>();
            _readOnly = CreateReadOnly();
            this.AddRange(Check.NotNullArgument(prototype, "prototype"));
        }

        public ExtendedList(IEqualityComparer<T> comparer)
        {
            _comparer = Check.NotNullArgument(comparer, "comparer");
            _wrapped = new List<T>();
            _readOnly = CreateReadOnly();
        }

        public IReadOnlyList<T> AsReadOnly
        {
            get
            {
                return _readOnly;
            }
        }

        public int Count
        {
            get
            {
                return _wrapped.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        IReadOnlyCollection<T> IExtendedCollection<T>.AsReadOnly
        {
            get
            {
                return _readOnly;
            }
        }

        public T this[int index]
        {
            get
            {
                return _wrapped[index];
            }
            set
            {
                _wrapped[index] = value;
            }
        }

        public void Add(T item)
        {
            _wrapped.Add(item);
        }

        public void Clear()
        {
            _wrapped.Clear();
        }

        public ExtendedList<T> Clone()
        {
            return new ExtendedList<T>(this);
        }

        public bool Contains(T item)
        {
            return _wrapped.Exists(input => _comparer.Equals(input, item));
        }

        public bool Contains(T item, IEqualityComparer<T> comparer)
        {
            return Enumerable.Contains(_wrapped, item, comparer);
        }

        public void CopyTo(T[] array)
        {
            _wrapped.CopyTo(array, 0);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _wrapped.CopyTo(array, arrayIndex);
        }

        public void CopyTo(T[] array, int arrayIndex, int countLimit)
        {
            Extensions.CanCopyTo(array, arrayIndex, countLimit);
            _wrapped.CopyTo(array, arrayIndex, countLimit);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _wrapped.GetEnumerator();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return Extensions.IndexOf(_wrapped, item, _comparer);
        }

        public void Insert(int index, T item)
        {
            _wrapped.Insert(index, item);
        }

        public void Move(int indexSource, int indexDestination)
        {
            Extensions.Move(_wrapped, indexSource, indexDestination);
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            var _other = Check.NotNullArgument(other, "other");
            if (Count == 0)
            {
                return false;
            }
            foreach (T item in _other)
            {
                if (Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(T item)
        {
            foreach (var _item in Extensions.RemoveWhereEnumerable(_wrapped, input => _comparer.Equals(input, item)))
            {
                GC.KeepAlive(_item);
                return true;
            }
            return false;
        }

        public bool Remove(T item, IEqualityComparer<T> comparer)
        {
            var __comparer = Check.NotNullArgument(comparer, "comparer");
            foreach (var _item in Extensions.RemoveWhereEnumerable(_wrapped, input => __comparer.Equals(input, item)))
            {
                GC.KeepAlive(_item);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            _wrapped.RemoveAt(index);
        }

        public void RemoveRange(int index, int count)
        {
            for (; count > 0; count--)
            {
                _wrapped.RemoveAt(index);
            }
        }

        public void Reverse()
        {
            _wrapped.Reverse();
        }

        public void Reverse(int index, int count)
        {
            _wrapped.Reverse(index, count);
        }

        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
        public bool SetEquals(IEnumerable<T> other)
        {
            var that = new ProgressiveSet<T>(Enumerable.Distinct(Check.NotNullArgument(other, "other")));
            foreach (var item in Extensions.WhereMatch(that, input => !Contains(input)))
            {
                GC.KeepAlive(item);
                return false;
            }
            foreach (var item in Extensions.WhereMatch(this, input => !that.Contains(input)))
            {
                return false;
            }
            return true;
        }

        public void Sort(IComparer<T> comparer)
        {
            _wrapped.Sort(comparer);
        }

        public void Sort(int index, int count, IComparer<T> comparer)
        {
            _wrapped.Sort(index, count, comparer);
        }

        public void Swap(int indexA, int indexB)
        {
            Extensions.Swap(_wrapped, indexA, indexB);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private ExtendedReadOnlyList<T> CreateReadOnly()
        {
            return new ExtendedReadOnlyList<T>(this);
        }
    }
}
#endif