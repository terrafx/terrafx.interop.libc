// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/locale.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

namespace TerraFX.Interop.LibC
{
    public unsafe partial struct lconv
    {
        [NativeTypeName("char *")]
        public sbyte* decimal_point;

        [NativeTypeName("char *")]
        public sbyte* thousands_sep;

        [NativeTypeName("char *")]
        public sbyte* grouping;

        [NativeTypeName("char *")]
        public sbyte* int_curr_symbol;

        [NativeTypeName("char *")]
        public sbyte* currency_symbol;

        [NativeTypeName("char *")]
        public sbyte* mon_decimal_point;

        [NativeTypeName("char *")]
        public sbyte* mon_thousands_sep;

        [NativeTypeName("char *")]
        public sbyte* mon_grouping;

        [NativeTypeName("char *")]
        public sbyte* positive_sign;

        [NativeTypeName("char *")]
        public sbyte* negative_sign;

        [NativeTypeName("char")]
        public sbyte int_frac_digits;

        [NativeTypeName("char")]
        public sbyte frac_digits;

        [NativeTypeName("char")]
        public sbyte p_cs_precedes;

        [NativeTypeName("char")]
        public sbyte p_sep_by_space;

        [NativeTypeName("char")]
        public sbyte n_cs_precedes;

        [NativeTypeName("char")]
        public sbyte n_sep_by_space;

        [NativeTypeName("char")]
        public sbyte p_sign_posn;

        [NativeTypeName("char")]
        public sbyte n_sign_posn;

        [NativeTypeName("char")]
        public sbyte int_p_cs_precedes;

        [NativeTypeName("char")]
        public sbyte int_p_sep_by_space;

        [NativeTypeName("char")]
        public sbyte int_n_cs_precedes;

        [NativeTypeName("char")]
        public sbyte int_n_sep_by_space;

        [NativeTypeName("char")]
        public sbyte int_p_sign_posn;

        [NativeTypeName("char")]
        public sbyte int_n_sign_posn;
    }
}
