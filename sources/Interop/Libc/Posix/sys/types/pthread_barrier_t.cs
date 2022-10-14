// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System.Runtime.InteropServices;
using static TerraFX.Interop.LibC.LibC;

namespace TerraFX.Interop.LibC;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct pthread_barrier_t
{
    [FieldOffset(0)]
    [NativeTypeName("char [__SIZEOF_PTHREAD_BARRIER_T]")]
    public fixed sbyte __size[__SIZEOF_PTHREAD_BARRIER_T];

    [FieldOffset(0)]
    [NativeTypeName("long int")]
    public nint __align;
}
