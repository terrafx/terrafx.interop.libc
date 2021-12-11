// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/time.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.LibC
{
    public partial struct timex
    {
        [NativeTypeName("unsigned int")]
        public uint modes;

        [NativeTypeName("__syscall_slong_t")]
        public nint offset;

        [NativeTypeName("__syscall_slong_t")]
        public nint freq;

        [NativeTypeName("__syscall_slong_t")]
        public nint maxerror;

        [NativeTypeName("__syscall_slong_t")]
        public nint esterror;

        public int status;

        [NativeTypeName("__syscall_slong_t")]
        public nint constant;

        [NativeTypeName("__syscall_slong_t")]
        public nint precision;

        [NativeTypeName("__syscall_slong_t")]
        public nint tolerance;

        [NativeTypeName("struct timeval")]
        public timeval time;

        [NativeTypeName("__syscall_slong_t")]
        public nint tick;

        [NativeTypeName("__syscall_slong_t")]
        public nint ppsfreq;

        [NativeTypeName("__syscall_slong_t")]
        public nint jitter;

        public int shift;

        [NativeTypeName("__syscall_slong_t")]
        public nint stabil;

        [NativeTypeName("__syscall_slong_t")]
        public nint jitcnt;

        [NativeTypeName("__syscall_slong_t")]
        public nint calcnt;

        [NativeTypeName("__syscall_slong_t")]
        public nint errcnt;

        [NativeTypeName("__syscall_slong_t")]
        public nint stbcnt;

        public int tai;

        public int _bitfield1;

        [NativeTypeName("int : 32")]
        public int Anonymous1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield1 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield2;

        [NativeTypeName("int : 32")]
        public int Anonymous2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield2 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield3;

        [NativeTypeName("int : 32")]
        public int Anonymous3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield3 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield3 = (_bitfield3 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield4;

        [NativeTypeName("int : 32")]
        public int Anonymous4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield4 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield4 = (_bitfield4 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield5;

        [NativeTypeName("int : 32")]
        public int Anonymous5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield5 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield5 = (_bitfield5 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield6;

        [NativeTypeName("int : 32")]
        public int Anonymous6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield6 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield6 = (_bitfield6 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield7;

        [NativeTypeName("int : 32")]
        public int Anonymous7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield7 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield7 = (_bitfield7 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield8;

        [NativeTypeName("int : 32")]
        public int Anonymous8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield8 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield8 = (_bitfield8 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield9;

        [NativeTypeName("int : 32")]
        public int Anonymous9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield9 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield9 = (_bitfield9 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield10;

        [NativeTypeName("int : 32")]
        public int Anonymous10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield10 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield10 = (_bitfield10 & ~0x0) | (value & 0x0);
            }
        }

        public int _bitfield11;

        [NativeTypeName("int : 32")]
        public int Anonymous11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield11 & 0x0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield11 = (_bitfield11 & ~0x0) | (value & 0x0);
            }
        }
    }
}
