// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop
{
    public unsafe partial struct ucontext_t
    {
        [NativeTypeName("unsigned long")]
        public nuint uc_flags;

        [NativeTypeName("struct ucontext_t *")]
        public ucontext_t* uc_link;

        public stack_t uc_stack;

        public mcontext_t uc_mcontext;

        public sigset_t uc_sigmask;

        [NativeTypeName("struct _libc_fpstate")]
        public _libc_fpstate __fpregs_mem;

        [NativeTypeName("unsigned long long [4]")]
        public fixed ulong __ssp[4];
    }
}
