// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    public unsafe partial struct __pthread_cond_s
    {
        public _Anonymous1_e__Union Anonymous1;

        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("unsigned int [2]")]
        public fixed uint __g_refs[2];

        [NativeTypeName("unsigned int [2]")]
        public fixed uint __g_size[2];

        [NativeTypeName("unsigned int")]
        public uint __g1_orig_size;

        [NativeTypeName("unsigned int")]
        public uint __wrefs;

        [NativeTypeName("unsigned int [2]")]
        public fixed uint __g_signals[2];

        public ref ulong __wseq
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.__wseq, 1));
            }
        }

        public ref _Anonymous1_e__Union.___wseq32_e__Struct __wseq32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.__wseq32, 1));
            }
        }

        public ref ulong __g1_start
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.__g1_start, 1));
            }
        }

        public ref _Anonymous2_e__Union.___g1_start32_e__Struct __g1_start32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.__g1_start32, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("unsigned long long int")]
            public ulong __wseq;

            [FieldOffset(0)]
            public ___wseq32_e__Struct __wseq32;

            public partial struct ___wseq32_e__Struct
            {
                [NativeTypeName("unsigned int")]
                public uint __low;

                [NativeTypeName("unsigned int")]
                public uint __high;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("unsigned long long int")]
            public ulong __g1_start;

            [FieldOffset(0)]
            public ___g1_start32_e__Struct __g1_start32;

            public partial struct ___g1_start32_e__Struct
            {
                [NativeTypeName("unsigned int")]
                public uint __low;

                [NativeTypeName("unsigned int")]
                public uint __high;
            }
        }
    }
}
