// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct sigaction
    {
        [NativeTypeName("union (anonymous union at /usr/include/x86_64-linux-gnu/bits/sigaction.h:31:5)")]
        public ___sigaction_handler_e__Union __sigaction_handler;

        [NativeTypeName("__sigset_t")]
        public sigset_t sa_mask;

        public int sa_flags;

        [NativeTypeName("void (*)()")]
        public delegate* unmanaged<void> sa_restorer;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct ___sigaction_handler_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__sighandler_t")]
            public delegate* unmanaged<int, void> sa_handler;

            [FieldOffset(0)]
            [NativeTypeName("void (*)(int, siginfo_t *, void *)")]
            public delegate* unmanaged<int, siginfo_t*, void*, void> sa_sigaction;
        }
    }
}
