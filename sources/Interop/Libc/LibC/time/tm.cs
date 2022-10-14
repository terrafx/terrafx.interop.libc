// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/time.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

namespace TerraFX.Interop.LibC;

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
