// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop
{
    public partial struct itimerspec
    {
        [NativeTypeName("struct timespec")]
        public timespec it_interval;

        [NativeTypeName("struct timespec")]
        public timespec it_value;
    }
}
