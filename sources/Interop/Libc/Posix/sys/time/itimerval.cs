// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop.LibC
{
    public partial struct itimerval
    {
        [NativeTypeName("struct timeval")]
        public timeval it_interval;

        [NativeTypeName("struct timeval")]
        public timeval it_value;
    }
}
