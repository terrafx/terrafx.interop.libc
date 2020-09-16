// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct sigset_t
    {
        [NativeTypeName("unsigned long [16]")]
        public ___val_e__FixedBuffer __val;

        public partial struct ___val_e__FixedBuffer
        {
            public nuint e0;
            public nuint e1;
            public nuint e2;
            public nuint e3;
            public nuint e4;
            public nuint e5;
            public nuint e6;
            public nuint e7;
            public nuint e8;
            public nuint e9;
            public nuint e10;
            public nuint e11;
            public nuint e12;
            public nuint e13;
            public nuint e14;
            public nuint e15;

            public ref nuint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
