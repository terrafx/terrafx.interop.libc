// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System;

namespace TerraFX.Interop.LibC
{
    public unsafe partial struct mcontext_t
    {
        [NativeTypeName("gregset_t")]
        public fixed long gregs[23];

        [NativeTypeName("fpregset_t")]
        public IntPtr fpregs;

        [NativeTypeName("unsigned long long [8]")]
        public fixed ulong __reserved1[8];
    }
}
