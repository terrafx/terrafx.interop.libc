// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop
{
    public unsafe partial struct _libc_fpxreg
    {
        [NativeTypeName("unsigned short [4]")]
        public fixed ushort significand[4];

        [NativeTypeName("unsigned short")]
        public ushort exponent;

        [NativeTypeName("unsigned short [3]")]
        public fixed ushort __glibc_reserved1[3];
    }
}
