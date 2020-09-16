// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct sigevent
    {
        [NativeTypeName("__sigval_t")]
        public sigval sigev_value;

        public int sigev_signo;

        public int sigev_notify;

        [NativeTypeName("union (anonymous union at /usr/include/x86_64-linux-gnu/bits/types/sigevent_t.h:28:5)")]
        public __sigev_un_e__Union _sigev_un;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct __sigev_un_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int [12]")]
            public fixed int _pad[12];

            [FieldOffset(0)]
            [NativeTypeName("__pid_t")]
            public int _tid;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/sigevent_t.h:36:2)")]
            public __sigev_thread_e__Struct _sigev_thread;

            public unsafe partial struct __sigev_thread_e__Struct
            {
                [NativeTypeName("void (*)(__sigval_t)")]
                public delegate* unmanaged<sigval, void> _function;

                [NativeTypeName("pthread_attr_t *")]
                public IntPtr _attribute;
            }
        }
    }
}
