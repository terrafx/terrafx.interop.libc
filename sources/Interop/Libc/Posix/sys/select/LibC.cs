// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/select.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC;

public static unsafe partial class LibC
{
    [DllImport("libc", ExactSpelling = true)]
    public static extern int select(int __nfds, fd_set* __readfds, fd_set* __writefds, fd_set* __exceptfds, [NativeTypeName("struct timeval *")] timeval* __timeout);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pselect(int __nfds, fd_set* __readfds, fd_set* __writefds,  fd_set* __exceptfds, [NativeTypeName("const struct timespec *")] timespec* __timeout, [NativeTypeName("const __sigset_t *")] sigset_t* __sigmask);

    [NativeTypeName("#define __FD_ZERO_STOS \"stosq\"")]
    public static ReadOnlySpan<byte> __FD_ZERO_STOS => [0x73, 0x74, 0x6F, 0x73, 0x71, 0x00];

    [NativeTypeName("#define FD_SETSIZE __FD_SETSIZE")]
    public const int FD_SETSIZE = 1024;

    [NativeTypeName("#define NFDBITS __NFDBITS")]
    public static int NFDBITS => (8 * (int)(sizeof(nint)));
}
