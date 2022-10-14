// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/signal.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC;

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
