// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct sigval
    {
        [FieldOffset(0)]
        public int sival_int;

        [FieldOffset(0)]
        public void* sival_ptr;
    }
}
