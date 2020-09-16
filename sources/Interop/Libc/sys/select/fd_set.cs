// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/select.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct fd_set
    {
        [NativeTypeName("__fd_mask [16]")]
        public _fds_bits_e__FixedBuffer fds_bits;

        public partial struct _fds_bits_e__FixedBuffer
        {
            public nint e0;
            public nint e1;
            public nint e2;
            public nint e3;
            public nint e4;
            public nint e5;
            public nint e6;
            public nint e7;
            public nint e8;
            public nint e9;
            public nint e10;
            public nint e11;
            public nint e12;
            public nint e13;
            public nint e14;
            public nint e15;

            public ref nint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<nint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
