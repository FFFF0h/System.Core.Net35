#if FAT
?// <auto-generated />

using System;
using System.Collections.Generic;

namespace Theraot.Core
{
    class TupleEqualityComparer<T> : IEqualityComparer<Tuple<T>>
    {
        private static TupleEqualityComparer<T> _default;

        private IEqualityComparer<T> _comparer;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T>();
        }

        public TupleEqualityComparer(IEqualityComparer<T> comparer)
        {
            _comparer = comparer ?? EqualityComparerHelper<T>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer = EqualityComparerHelper<T>.Default;
        }

        public static TupleEqualityComparer<T> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T> x, Tuple<T> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer.Equals(x.Item1, y.Item1);
            }
        }

        public int GetHashCode(Tuple<T> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    _comparer.GetHashCode(obj.Item1);
            }
        }
    }

    class TupleEqualityComparer<T1, T2> : IEqualityComparer<Tuple<T1, T2>>
    {
        private static TupleEqualityComparer<T1, T2> _default;

        private IEqualityComparer<T1> _comparer1;
        private IEqualityComparer<T2> _comparer2;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T1, T2>();
        }

        public TupleEqualityComparer(IEqualityComparer<T1> comparer1, IEqualityComparer<T2> comparer2)
        {
            _comparer1 = comparer1 ?? EqualityComparerHelper<T1>.Default;
            _comparer2 = comparer2 ?? EqualityComparerHelper<T2>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer1 = EqualityComparerHelper<T1>.Default;
            _comparer2 = EqualityComparerHelper<T2>.Default;
        }

        public static TupleEqualityComparer<T1, T2> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T1, T2> x, Tuple<T1, T2> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer1.Equals(x.Item1, y.Item1) &&
                    _comparer2.Equals(x.Item2, y.Item2);
            }
        }

        public int GetHashCode(Tuple<T1, T2> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    (_comparer1.GetHashCode(obj.Item1) * 17) +
                    _comparer2.GetHashCode(obj.Item2);
            }
        }
    }

    class TupleEqualityComparer<T1, T2, T3> : IEqualityComparer<Tuple<T1, T2, T3>>
    {
        private static TupleEqualityComparer<T1, T2, T3> _default;

        private IEqualityComparer<T1> _comparer1;
        private IEqualityComparer<T2> _comparer2;
        private IEqualityComparer<T3> _comparer3;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T1, T2, T3>();
        }

        public TupleEqualityComparer(IEqualityComparer<T1> comparer1, IEqualityComparer<T2> comparer2, IEqualityComparer<T3> comparer3)
        {
            _comparer1 = comparer1 ?? EqualityComparerHelper<T1>.Default;
            _comparer2 = comparer2 ?? EqualityComparerHelper<T2>.Default;
            _comparer3 = comparer3 ?? EqualityComparerHelper<T3>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer1 = EqualityComparerHelper<T1>.Default;
            _comparer2 = EqualityComparerHelper<T2>.Default;
            _comparer3 = EqualityComparerHelper<T3>.Default;
        }

        public static TupleEqualityComparer<T1, T2, T3> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T1, T2, T3> x, Tuple<T1, T2, T3> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer1.Equals(x.Item1, y.Item1) &&
                    _comparer2.Equals(x.Item2, y.Item2) &&
                    _comparer3.Equals(x.Item3, y.Item3);
            }
        }

        public int GetHashCode(Tuple<T1, T2, T3> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    (_comparer1.GetHashCode(obj.Item1) * 17) +
                    (_comparer2.GetHashCode(obj.Item2) * 17) +
                    _comparer3.GetHashCode(obj.Item3);
            }
        }
    }

    class TupleEqualityComparer<T1, T2, T3, T4> : IEqualityComparer<Tuple<T1, T2, T3, T4>>
    {
        private static TupleEqualityComparer<T1, T2, T3, T4> _default;

        private IEqualityComparer<T1> _comparer1;
        private IEqualityComparer<T2> _comparer2;
        private IEqualityComparer<T3> _comparer3;
        private IEqualityComparer<T4> _comparer4;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T1, T2, T3, T4>();
        }

        public TupleEqualityComparer(IEqualityComparer<T1> comparer1, IEqualityComparer<T2> comparer2, IEqualityComparer<T3> comparer3, IEqualityComparer<T4> comparer4)
        {
            _comparer1 = comparer1 ?? EqualityComparerHelper<T1>.Default;
            _comparer2 = comparer2 ?? EqualityComparerHelper<T2>.Default;
            _comparer3 = comparer3 ?? EqualityComparerHelper<T3>.Default;
            _comparer4 = comparer4 ?? EqualityComparerHelper<T4>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer1 = EqualityComparerHelper<T1>.Default;
            _comparer2 = EqualityComparerHelper<T2>.Default;
            _comparer3 = EqualityComparerHelper<T3>.Default;
            _comparer4 = EqualityComparerHelper<T4>.Default;
        }

        public static TupleEqualityComparer<T1, T2, T3, T4> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T1, T2, T3, T4> x, Tuple<T1, T2, T3, T4> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer1.Equals(x.Item1, y.Item1) &&
                    _comparer2.Equals(x.Item2, y.Item2) &&
                    _comparer3.Equals(x.Item3, y.Item3) &&
                    _comparer4.Equals(x.Item4, y.Item4);
            }
        }

        public int GetHashCode(Tuple<T1, T2, T3, T4> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    (_comparer1.GetHashCode(obj.Item1) * 17) +
                    (_comparer2.GetHashCode(obj.Item2) * 17) +
                    (_comparer3.GetHashCode(obj.Item3) * 17) +
                    _comparer4.GetHashCode(obj.Item4);
            }
        }
    }

    class TupleEqualityComparer<T1, T2, T3, T4, T5> : IEqualityComparer<Tuple<T1, T2, T3, T4, T5>>
    {
        private static TupleEqualityComparer<T1, T2, T3, T4, T5> _default;

        private IEqualityComparer<T1> _comparer1;
        private IEqualityComparer<T2> _comparer2;
        private IEqualityComparer<T3> _comparer3;
        private IEqualityComparer<T4> _comparer4;
        private IEqualityComparer<T5> _comparer5;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T1, T2, T3, T4, T5>();
        }

        public TupleEqualityComparer(IEqualityComparer<T1> comparer1, IEqualityComparer<T2> comparer2, IEqualityComparer<T3> comparer3, IEqualityComparer<T4> comparer4, IEqualityComparer<T5> comparer5)
        {
            _comparer1 = comparer1 ?? EqualityComparerHelper<T1>.Default;
            _comparer2 = comparer2 ?? EqualityComparerHelper<T2>.Default;
            _comparer3 = comparer3 ?? EqualityComparerHelper<T3>.Default;
            _comparer4 = comparer4 ?? EqualityComparerHelper<T4>.Default;
            _comparer5 = comparer5 ?? EqualityComparerHelper<T5>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer1 = EqualityComparerHelper<T1>.Default;
            _comparer2 = EqualityComparerHelper<T2>.Default;
            _comparer3 = EqualityComparerHelper<T3>.Default;
            _comparer4 = EqualityComparerHelper<T4>.Default;
            _comparer5 = EqualityComparerHelper<T5>.Default;
        }

        public static TupleEqualityComparer<T1, T2, T3, T4, T5> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T1, T2, T3, T4, T5> x, Tuple<T1, T2, T3, T4, T5> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer1.Equals(x.Item1, y.Item1) &&
                    _comparer2.Equals(x.Item2, y.Item2) &&
                    _comparer3.Equals(x.Item3, y.Item3) &&
                    _comparer4.Equals(x.Item4, y.Item4) &&
                    _comparer5.Equals(x.Item5, y.Item5);
            }
        }

        public int GetHashCode(Tuple<T1, T2, T3, T4, T5> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    (_comparer1.GetHashCode(obj.Item1) * 17) +
                    (_comparer2.GetHashCode(obj.Item2) * 17) +
                    (_comparer3.GetHashCode(obj.Item3) * 17) +
                    (_comparer4.GetHashCode(obj.Item4) * 17) +
                    _comparer5.GetHashCode(obj.Item5);
            }
        }
    }

    class TupleEqualityComparer<T1, T2, T3, T4, T5, T6> : IEqualityComparer<Tuple<T1, T2, T3, T4, T5, T6>>
    {
        private static TupleEqualityComparer<T1, T2, T3, T4, T5, T6> _default;

        private IEqualityComparer<T1> _comparer1;
        private IEqualityComparer<T2> _comparer2;
        private IEqualityComparer<T3> _comparer3;
        private IEqualityComparer<T4> _comparer4;
        private IEqualityComparer<T5> _comparer5;
        private IEqualityComparer<T6> _comparer6;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T1, T2, T3, T4, T5, T6>();
        }

        public TupleEqualityComparer(IEqualityComparer<T1> comparer1, IEqualityComparer<T2> comparer2, IEqualityComparer<T3> comparer3, IEqualityComparer<T4> comparer4, IEqualityComparer<T5> comparer5, IEqualityComparer<T6> comparer6)
        {
            _comparer1 = comparer1 ?? EqualityComparerHelper<T1>.Default;
            _comparer2 = comparer2 ?? EqualityComparerHelper<T2>.Default;
            _comparer3 = comparer3 ?? EqualityComparerHelper<T3>.Default;
            _comparer4 = comparer4 ?? EqualityComparerHelper<T4>.Default;
            _comparer5 = comparer5 ?? EqualityComparerHelper<T5>.Default;
            _comparer6 = comparer6 ?? EqualityComparerHelper<T6>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer1 = EqualityComparerHelper<T1>.Default;
            _comparer2 = EqualityComparerHelper<T2>.Default;
            _comparer3 = EqualityComparerHelper<T3>.Default;
            _comparer4 = EqualityComparerHelper<T4>.Default;
            _comparer5 = EqualityComparerHelper<T5>.Default;
            _comparer6 = EqualityComparerHelper<T6>.Default;
        }

        public static TupleEqualityComparer<T1, T2, T3, T4, T5, T6> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T1, T2, T3, T4, T5, T6> x, Tuple<T1, T2, T3, T4, T5, T6> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer1.Equals(x.Item1, y.Item1) &&
                    _comparer2.Equals(x.Item2, y.Item2) &&
                    _comparer3.Equals(x.Item3, y.Item3) &&
                    _comparer4.Equals(x.Item4, y.Item4) &&
                    _comparer5.Equals(x.Item5, y.Item5) &&
                    _comparer6.Equals(x.Item6, y.Item6);
            }
        }

        public int GetHashCode(Tuple<T1, T2, T3, T4, T5, T6> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    (_comparer1.GetHashCode(obj.Item1) * 17) +
                    (_comparer2.GetHashCode(obj.Item2) * 17) +
                    (_comparer3.GetHashCode(obj.Item3) * 17) +
                    (_comparer4.GetHashCode(obj.Item4) * 17) +
                    (_comparer5.GetHashCode(obj.Item5) * 17) +
                    _comparer6.GetHashCode(obj.Item6);
            }
        }
    }

    class TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7> : IEqualityComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>>
    {
        private static TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7> _default;

        private IEqualityComparer<T1> _comparer1;
        private IEqualityComparer<T2> _comparer2;
        private IEqualityComparer<T3> _comparer3;
        private IEqualityComparer<T4> _comparer4;
        private IEqualityComparer<T5> _comparer5;
        private IEqualityComparer<T6> _comparer6;
        private IEqualityComparer<T7> _comparer7;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7>();
        }

        public TupleEqualityComparer(IEqualityComparer<T1> comparer1, IEqualityComparer<T2> comparer2, IEqualityComparer<T3> comparer3, IEqualityComparer<T4> comparer4, IEqualityComparer<T5> comparer5, IEqualityComparer<T6> comparer6, IEqualityComparer<T7> comparer7)
        {
            _comparer1 = comparer1 ?? EqualityComparerHelper<T1>.Default;
            _comparer2 = comparer2 ?? EqualityComparerHelper<T2>.Default;
            _comparer3 = comparer3 ?? EqualityComparerHelper<T3>.Default;
            _comparer4 = comparer4 ?? EqualityComparerHelper<T4>.Default;
            _comparer5 = comparer5 ?? EqualityComparerHelper<T5>.Default;
            _comparer6 = comparer6 ?? EqualityComparerHelper<T6>.Default;
            _comparer7 = comparer7 ?? EqualityComparerHelper<T7>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer1 = EqualityComparerHelper<T1>.Default;
            _comparer2 = EqualityComparerHelper<T2>.Default;
            _comparer3 = EqualityComparerHelper<T3>.Default;
            _comparer4 = EqualityComparerHelper<T4>.Default;
            _comparer5 = EqualityComparerHelper<T5>.Default;
            _comparer6 = EqualityComparerHelper<T6>.Default;
            _comparer7 = EqualityComparerHelper<T7>.Default;
        }

        public static TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T1, T2, T3, T4, T5, T6, T7> x, Tuple<T1, T2, T3, T4, T5, T6, T7> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer1.Equals(x.Item1, y.Item1) &&
                    _comparer2.Equals(x.Item2, y.Item2) &&
                    _comparer3.Equals(x.Item3, y.Item3) &&
                    _comparer4.Equals(x.Item4, y.Item4) &&
                    _comparer5.Equals(x.Item5, y.Item5) &&
                    _comparer6.Equals(x.Item6, y.Item6) &&
                    _comparer7.Equals(x.Item7, y.Item7);
            }
        }

        public int GetHashCode(Tuple<T1, T2, T3, T4, T5, T6, T7> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    (_comparer1.GetHashCode(obj.Item1) * 17) +
                    (_comparer2.GetHashCode(obj.Item2) * 17) +
                    (_comparer3.GetHashCode(obj.Item3) * 17) +
                    (_comparer4.GetHashCode(obj.Item4) * 17) +
                    (_comparer5.GetHashCode(obj.Item5) * 17) +
                    (_comparer6.GetHashCode(obj.Item6) * 17) +
                    _comparer7.GetHashCode(obj.Item7);
            }
        }
    }

    class TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7, T8> : IEqualityComparer<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        private static TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7, T8> _default;

        private IEqualityComparer<T1> _comparer1;
        private IEqualityComparer<T2> _comparer2;
        private IEqualityComparer<T3> _comparer3;
        private IEqualityComparer<T4> _comparer4;
        private IEqualityComparer<T5> _comparer5;
        private IEqualityComparer<T6> _comparer6;
        private IEqualityComparer<T7> _comparer7;
        private IEqualityComparer<T8> _comparer8;

        static TupleEqualityComparer()
        {
            _default = new TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7, T8>();
        }

        public TupleEqualityComparer(IEqualityComparer<T1> comparer1, IEqualityComparer<T2> comparer2, IEqualityComparer<T3> comparer3, IEqualityComparer<T4> comparer4, IEqualityComparer<T5> comparer5, IEqualityComparer<T6> comparer6, IEqualityComparer<T7> comparer7, IEqualityComparer<T8> comparer8)
        {
            _comparer1 = comparer1 ?? EqualityComparerHelper<T1>.Default;
            _comparer2 = comparer2 ?? EqualityComparerHelper<T2>.Default;
            _comparer3 = comparer3 ?? EqualityComparerHelper<T3>.Default;
            _comparer4 = comparer4 ?? EqualityComparerHelper<T4>.Default;
            _comparer5 = comparer5 ?? EqualityComparerHelper<T5>.Default;
            _comparer6 = comparer6 ?? EqualityComparerHelper<T6>.Default;
            _comparer7 = comparer7 ?? EqualityComparerHelper<T7>.Default;
            _comparer8 = comparer8 ?? EqualityComparerHelper<T8>.Default;
        }

        private TupleEqualityComparer()
        {
            _comparer1 = EqualityComparerHelper<T1>.Default;
            _comparer2 = EqualityComparerHelper<T2>.Default;
            _comparer3 = EqualityComparerHelper<T3>.Default;
            _comparer4 = EqualityComparerHelper<T4>.Default;
            _comparer5 = EqualityComparerHelper<T5>.Default;
            _comparer6 = EqualityComparerHelper<T6>.Default;
            _comparer7 = EqualityComparerHelper<T7>.Default;
            _comparer8 = EqualityComparerHelper<T8>.Default;
        }

        public static TupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7, T8> Default
        {
            get
            {
                return _default;
            }
        }

        public bool Equals(Tuple<T1, T2, T3, T4, T5, T6, T7, T8> x, Tuple<T1, T2, T3, T4, T5, T6, T7, T8> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            else if (ReferenceEquals(null, x) || ReferenceEquals(null, y))
            {
                return false;
            }
            else
            {
                return
                    _comparer1.Equals(x.Item1, y.Item1) &&
                    _comparer2.Equals(x.Item2, y.Item2) &&
                    _comparer3.Equals(x.Item3, y.Item3) &&
                    _comparer4.Equals(x.Item4, y.Item4) &&
                    _comparer5.Equals(x.Item5, y.Item5) &&
                    _comparer6.Equals(x.Item6, y.Item6) &&
                    _comparer7.Equals(x.Item7, y.Item7) &&
                    _comparer8.Equals(x.Rest, y.Rest);
            }
        }

        public int GetHashCode(Tuple<T1, T2, T3, T4, T5, T6, T7, T8> obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return EqualityComparer<object>.Default.GetHashCode(null);
            }
            else unchecked
            {
                return
                    (_comparer1.GetHashCode(obj.Item1) * 17) +
                    (_comparer2.GetHashCode(obj.Item2) * 17) +
                    (_comparer3.GetHashCode(obj.Item3) * 17) +
                    (_comparer4.GetHashCode(obj.Item4) * 17) +
                    (_comparer5.GetHashCode(obj.Item5) * 17) +
                    (_comparer6.GetHashCode(obj.Item6) * 17) +
                    (_comparer7.GetHashCode(obj.Item7) * 17) +
                    _comparer8.GetHashCode(obj.Rest);
            }
        }
    }
}
#endif