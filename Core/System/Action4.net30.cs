﻿#if NET20 || NET30

namespace System
{
    public delegate void Action<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
}

#endif