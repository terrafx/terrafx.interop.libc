// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop
{
    public unsafe partial struct tm
    {
        public int tm_sec;

        public int tm_min;

        public int tm_hour;

        public int tm_mday;

        public int tm_mon;

        public int tm_year;

        public int tm_wday;

        public int tm_yday;

        public int tm_isdst;

        [NativeTypeName("long")]
        public nint tm_gmtoff;

        [NativeTypeName("const char *")]
        public sbyte* tm_zone;
    }
}
