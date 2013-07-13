﻿using System;
using System.Globalization;

using Theraot.Core;

namespace Theraot.Threading.Needles
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    public static class NeedleHelper
    {
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "False Positive")]
        public static bool CanCreateNeedle<T, TNeedle>()
            where TNeedle : INeedle<T>
        {
            return NeedleCreator<T, TNeedle>.CanCreate;
        }

        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "False Positive")]
        public static bool CanCreateReadOnlyNeedle<T, TNeedle>()
            where TNeedle : IReadOnlyNeedle<T>
        {
            return ReadOnlyNeedleCreator<T, TNeedle>.CanCreate;
        }

        public static TNeedle CreateNeedle<T, TNeedle>(T target)
            where TNeedle : INeedle<T>
        {
            return NeedleCreator<T, TNeedle>.Create(target);
        }

        public static TNeedle CreateReadOnlyNeedle<T, TNeedle>(T target)
            where TNeedle : IReadOnlyNeedle<T>
        {
            return ReadOnlyNeedleCreator<T, TNeedle>.Create(target);
        }

        public static LazyDisposableNeedle<T> Deferred<T>(this Func<T> disposable)
            where T : IDisposable
        {
            return new LazyDisposableNeedle<T>(disposable);
        }

        public static bool TryGet<T>(this IReadOnlyNeedle<T> needle, out T target)
        {
            var _needle = Check.NotNullArgument(needle, "needle");
            target = _needle.Value;
            return _needle.IsAlive;
        }

        private static class DeferredNeedleCreator<T, TNeedle>
            where TNeedle : INeedle<T>
        {
            private static bool _canCreate;
            private static Func<Func<T>, TNeedle> _create;

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "Expensive Initialization")]
            static DeferredNeedleCreator()
            {
                _canCreate = TypeHelper.TryGetCreate<Func<T>, TNeedle>(out _create);
                if (!_canCreate)
                {
                    _create =
                    _ =>
                    {
                        throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Unable to find a way to create {0}", typeof(TNeedle).Name));
                    };
                }
            }

            public static bool CanCreate
            {
                get
                {
                    return _canCreate;
                }
            }

            public static TNeedle Create(Func<T> target)
            {
                return _create.Invoke(target);
            }
        }

        private static class DeferredReadOnlyNeedleCreator<T, TNeedle>
            where TNeedle : IReadOnlyNeedle<T>
        {
            private static bool _canCreate;
            private static Func<Func<T>, TNeedle> _create;

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "Expensive Initialization")]
            static DeferredReadOnlyNeedleCreator()
            {
                _canCreate = TypeHelper.TryGetCreate<Func<T>, TNeedle>(out _create);
                if (!_canCreate)
                {
                    _create =
                    _ =>
                    {
                        throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Unable to find a way to create {0}", typeof(TNeedle).Name));
                    };
                }
            }

            public static bool CanCreate
            {
                get
                {
                    return _canCreate;
                }
            }

            public static TNeedle Create(Func<T> target)
            {
                return _create.Invoke(target);
            }
        }

        private static class NeedleCreator<T, TNeedle>
            where TNeedle : INeedle<T>
        {
            private static bool _canCreate;
            private static Func<T, TNeedle> _create;

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "Expensive Initialization")]
            static NeedleCreator()
            {
                _canCreate = TypeHelper.TryGetCreate<T, TNeedle>(out _create);
                if (!_canCreate)
                {
                    Func<TNeedle> create;
                    _canCreate = TypeHelper.TryGetCreate<TNeedle>(out create);
                    if (_canCreate)
                    {
                        _create =
                        (target) =>
                        {
                            var needle = create();
                            needle.Value = target;
                            return needle;
                        };
                    }
                    else
                    {
                        _create =
                        _ =>
                        {
                            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Unable to find a way to create {0}", typeof(TNeedle).Name));
                        };
                        _canCreate = false;
                    }
                }
            }

            public static bool CanCreate
            {
                get
                {
                    return _canCreate;
                }
            }

            public static TNeedle Create(T target)
            {
                return _create.Invoke(target);
            }
        }

        private static class ReadOnlyNeedleCreator<T, TNeedle>
            where TNeedle : IReadOnlyNeedle<T>
        {
            private static bool _canCreate;
            private static Func<T, TNeedle> _create;

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "Expensive Initialization")]
            static ReadOnlyNeedleCreator()
            {
                _canCreate = TypeHelper.TryGetCreate<T, TNeedle>(out _create);
                if (!_canCreate)
                {
                    _create =
                    _ =>
                    {
                        throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Unable to find a way to create {0}", typeof(TNeedle).Name));
                    };
                    _canCreate = false;
                }
            }

            public static bool CanCreate
            {
                get
                {
                    return _canCreate;
                }
            }

            public static TNeedle Create(T target)
            {
                return _create.Invoke(target);
            }
        }
    }
}