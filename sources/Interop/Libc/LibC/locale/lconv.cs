// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/locale.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

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
