// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop.LibC
{
    public unsafe partial struct stack_t
    {
        public void* ss_sp;

        public int ss_flags;

        [NativeTypeName("size_t")]
        public nuint ss_size;
    }
}
