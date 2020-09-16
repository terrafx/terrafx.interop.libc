// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct _libc_fpstate
    {
        [NativeTypeName("__uint16_t")]
        public ushort cwd;

        [NativeTypeName("__uint16_t")]
        public ushort swd;

        [NativeTypeName("__uint16_t")]
        public ushort ftw;

        [NativeTypeName("__uint16_t")]
        public ushort fop;

        [NativeTypeName("__uint64_t")]
        public nuint rip;

        [NativeTypeName("__uint64_t")]
        public nuint rdp;

        [NativeTypeName("__uint32_t")]
        public uint mxcsr;

        [NativeTypeName("__uint32_t")]
        public uint mxcr_mask;

        [NativeTypeName("struct _libc_fpxreg [8]")]
        public __st_e__FixedBuffer _st;

        [NativeTypeName("struct _libc_xmmreg [16]")]
        public __xmm_e__FixedBuffer _xmm;

        [NativeTypeName("__uint32_t [24]")]
        public fixed uint __glibc_reserved1[24];

        public partial struct __st_e__FixedBuffer
        {
            public _libc_fpxreg e0;
            public _libc_fpxreg e1;
            public _libc_fpxreg e2;
            public _libc_fpxreg e3;
            public _libc_fpxreg e4;
            public _libc_fpxreg e5;
            public _libc_fpxreg e6;
            public _libc_fpxreg e7;

            public ref _libc_fpxreg this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<_libc_fpxreg> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }

        public partial struct __xmm_e__FixedBuffer
        {
            public _libc_xmmreg e0;
            public _libc_xmmreg e1;
            public _libc_xmmreg e2;
            public _libc_xmmreg e3;
            public _libc_xmmreg e4;
            public _libc_xmmreg e5;
            public _libc_xmmreg e6;
            public _libc_xmmreg e7;
            public _libc_xmmreg e8;
            public _libc_xmmreg e9;
            public _libc_xmmreg e10;
            public _libc_xmmreg e11;
            public _libc_xmmreg e12;
            public _libc_xmmreg e13;
            public _libc_xmmreg e14;
            public _libc_xmmreg e15;

            public ref _libc_xmmreg this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<_libc_xmmreg> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
