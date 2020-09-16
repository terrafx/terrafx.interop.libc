// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/types.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct __pthread_cond_s
    {
        [NativeTypeName("__pthread_cond_s::(anonymous union at /usr/include/x86_64-linux-gnu/bits/thread-shared-types.h:94:17)")]
        public _Anonymous1_e__Union Anonymous1;

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

        [NativeTypeName("__pthread_cond_s::(anonymous union at /usr/include/x86_64-linux-gnu/bits/thread-shared-types.h:103:17)")]
        public _Anonymous2_e__Union Anonymous2;

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

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("unsigned long long")]
            public ulong __wseq;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/thread-shared-types.h:97:5)")]
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
            [NativeTypeName("unsigned long long")]
            public ulong __g1_start;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/thread-shared-types.h:106:5)")]
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
