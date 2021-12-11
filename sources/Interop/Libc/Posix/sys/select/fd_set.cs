// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/select.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
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
