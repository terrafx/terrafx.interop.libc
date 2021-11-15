// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/select.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    public static unsafe partial class LibC
    {
        [DllImport("libc", ExactSpelling = true)]
        public static extern int select(int __nfds, [NativeTypeName("fd_set *__restrict")] fd_set* __readfds, [NativeTypeName("fd_set *__restrict")] fd_set* __writefds, [NativeTypeName("fd_set *__restrict")] fd_set* __exceptfds, [NativeTypeName("struct timeval *__restrict")] timeval* __timeout);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int pselect(int __nfds, [NativeTypeName("fd_set *__restrict")] fd_set* __readfds, [NativeTypeName("fd_set *__restrict")] fd_set* __writefds, [NativeTypeName("fd_set *__restrict")] fd_set* __exceptfds, [NativeTypeName("const struct timespec *__restrict")] timespec* __timeout, [NativeTypeName("const __sigset_t *__restrict")] sigset_t* __sigmask);

        [NativeTypeName("#define __FD_ZERO_STOS \"stosq\"")]
        public static ReadOnlySpan<byte> __FD_ZERO_STOS => new byte[] { 0x73, 0x74, 0x6F, 0x73, 0x71, 0x00 };

        [NativeTypeName("#define FD_SETSIZE __FD_SETSIZE")]
        public const int FD_SETSIZE = 1024;

        [NativeTypeName("#define NFDBITS __NFDBITS")]
        public static int NFDBITS => (8 * (int)(sizeof(nint)));
    }
}
