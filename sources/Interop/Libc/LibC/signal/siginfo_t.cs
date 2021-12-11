// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/signal.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    public partial struct siginfo_t
    {
        public int si_signo;

        public int si_errno;

        public int si_code;

        public int __pad0;

        [NativeTypeName("union (anonymous union at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:51:5)")]
        public __sifields_e__Union _sifields;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct __sifields_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int [28]")]
            public fixed int _pad[28];

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:56:2)")]
            public __kill_e__Struct _kill;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:63:2)")]
            public __timer_e__Struct _timer;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:71:2)")]
            public __rt_e__Struct _rt;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:79:2)")]
            public __sigchld_e__Struct _sigchld;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:89:2)")]
            public __sigfault_e__Struct _sigfault;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:108:2)")]
            public __sigpoll_e__Struct _sigpoll;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:116:2)")]
            public __sigsys_e__Struct _sigsys;

            public partial struct __kill_e__Struct
            {
                [NativeTypeName("__pid_t")]
                public int si_pid;

                [NativeTypeName("__uid_t")]
                public uint si_uid;
            }

            public partial struct __timer_e__Struct
            {
                public int si_tid;

                public int si_overrun;

                [NativeTypeName("__sigval_t")]
                public sigval_t si_sigval;
            }

            public partial struct __rt_e__Struct
            {
                [NativeTypeName("__pid_t")]
                public int si_pid;

                [NativeTypeName("__uid_t")]
                public uint si_uid;

                [NativeTypeName("__sigval_t")]
                public sigval_t si_sigval;
            }

            public partial struct __sigchld_e__Struct
            {
                [NativeTypeName("__pid_t")]
                public int si_pid;

                [NativeTypeName("__uid_t")]
                public uint si_uid;

                public int si_status;

                [NativeTypeName("__clock_t")]
                public nint si_utime;

                [NativeTypeName("__clock_t")]
                public nint si_stime;
            }

            public unsafe partial struct __sigfault_e__Struct
            {
                public void* si_addr;

                public short si_addr_lsb;

                [NativeTypeName("union (anonymous union at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:94:6)")]
                public __bounds_e__Union _bounds;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct __bounds_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("struct (anonymous struct at /usr/include/x86_64-linux-gnu/bits/types/siginfo_t.h:97:3)")]
                    public __addr_bnd_e__Struct _addr_bnd;

                    [FieldOffset(0)]
                    [NativeTypeName("__uint32_t")]
                    public uint _pkey;

                    public unsafe partial struct __addr_bnd_e__Struct
                    {
                        public void* _lower;

                        public void* _upper;
                    }
                }
            }

            public partial struct __sigpoll_e__Struct
            {
                [NativeTypeName("long")]
                public nint si_band;

                public int si_fd;
            }

            public unsafe partial struct __sigsys_e__Struct
            {
                public void* _call_addr;

                public int _syscall;

                [NativeTypeName("unsigned int")]
                public uint _arch;
            }
        }
    }
}
