// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/signal.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
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

                public IntPtr _attribute;
            }
        }
    }
}
