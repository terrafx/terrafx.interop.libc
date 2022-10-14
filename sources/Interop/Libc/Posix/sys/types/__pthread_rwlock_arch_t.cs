// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

namespace TerraFX.Interop.LibC;

public unsafe partial struct __pthread_rwlock_arch_t
{
    [NativeTypeName("unsigned int")]
    public uint __readers;

    [NativeTypeName("unsigned int")]
    public uint __writers;

    [NativeTypeName("unsigned int")]
    public uint __wrphase_futex;

    [NativeTypeName("unsigned int")]
    public uint __writers_futex;

    [NativeTypeName("unsigned int")]
    public uint __pad3;

    [NativeTypeName("unsigned int")]
    public uint __pad4;

    public int __cur_writer;

    public int __shared;

    [NativeTypeName("signed char")]
    public sbyte __rwelision;

    [NativeTypeName("unsigned char [7]")]
    public fixed byte __pad1[7];

    [NativeTypeName("unsigned long int")]
    public nuint __pad2;

    [NativeTypeName("unsigned int")]
    public uint __flags;
}
