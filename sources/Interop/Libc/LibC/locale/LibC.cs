// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/locale.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC;

public static unsafe partial class LibC
{
    [DllImport("libc", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* setlocale(int __category, [NativeTypeName("const char *")] sbyte* __locale);

    [DllImport("libc", ExactSpelling = true)]
    [return: NativeTypeName("struct lconv *")]
    public static extern lconv* localeconv();

    [DllImport("libc", ExactSpelling = true)]
    public static extern locale_t newlocale(int __category_mask, [NativeTypeName("const char *")] sbyte* __locale, locale_t __base);

    [DllImport("libc", ExactSpelling = true)]
    public static extern locale_t duplocale(locale_t __dataset);

    [DllImport("libc", ExactSpelling = true)]
    public static extern void freelocale(locale_t __dataset);

    [DllImport("libc", ExactSpelling = true)]
    public static extern locale_t uselocale(locale_t __dataset);

    [NativeTypeName("#define LC_CTYPE __LC_CTYPE")]
    public const int LC_CTYPE = 0;

    [NativeTypeName("#define LC_NUMERIC __LC_NUMERIC")]
    public const int LC_NUMERIC = 1;

    [NativeTypeName("#define LC_TIME __LC_TIME")]
    public const int LC_TIME = 2;

    [NativeTypeName("#define LC_COLLATE __LC_COLLATE")]
    public const int LC_COLLATE = 3;

    [NativeTypeName("#define LC_MONETARY __LC_MONETARY")]
    public const int LC_MONETARY = 4;

    [NativeTypeName("#define LC_MESSAGES __LC_MESSAGES")]
    public const int LC_MESSAGES = 5;

    [NativeTypeName("#define LC_ALL __LC_ALL")]
    public const int LC_ALL = 6;

    [NativeTypeName("#define LC_PAPER __LC_PAPER")]
    public const int LC_PAPER = 7;

    [NativeTypeName("#define LC_NAME __LC_NAME")]
    public const int LC_NAME = 8;

    [NativeTypeName("#define LC_ADDRESS __LC_ADDRESS")]
    public const int LC_ADDRESS = 9;

    [NativeTypeName("#define LC_TELEPHONE __LC_TELEPHONE")]
    public const int LC_TELEPHONE = 10;

    [NativeTypeName("#define LC_MEASUREMENT __LC_MEASUREMENT")]
    public const int LC_MEASUREMENT = 11;

    [NativeTypeName("#define LC_IDENTIFICATION __LC_IDENTIFICATION")]
    public const int LC_IDENTIFICATION = 12;

    [NativeTypeName("#define LC_CTYPE_MASK (1 << __LC_CTYPE)")]
    public const int LC_CTYPE_MASK = (1 << 0);

    [NativeTypeName("#define LC_NUMERIC_MASK (1 << __LC_NUMERIC)")]
    public const int LC_NUMERIC_MASK = (1 << 1);

    [NativeTypeName("#define LC_TIME_MASK (1 << __LC_TIME)")]
    public const int LC_TIME_MASK = (1 << 2);

    [NativeTypeName("#define LC_COLLATE_MASK (1 << __LC_COLLATE)")]
    public const int LC_COLLATE_MASK = (1 << 3);

    [NativeTypeName("#define LC_MONETARY_MASK (1 << __LC_MONETARY)")]
    public const int LC_MONETARY_MASK = (1 << 4);

    [NativeTypeName("#define LC_MESSAGES_MASK (1 << __LC_MESSAGES)")]
    public const int LC_MESSAGES_MASK = (1 << 5);

    [NativeTypeName("#define LC_PAPER_MASK (1 << __LC_PAPER)")]
    public const int LC_PAPER_MASK = (1 << 7);

    [NativeTypeName("#define LC_NAME_MASK (1 << __LC_NAME)")]
    public const int LC_NAME_MASK = (1 << 8);

    [NativeTypeName("#define LC_ADDRESS_MASK (1 << __LC_ADDRESS)")]
    public const int LC_ADDRESS_MASK = (1 << 9);

    [NativeTypeName("#define LC_TELEPHONE_MASK (1 << __LC_TELEPHONE)")]
    public const int LC_TELEPHONE_MASK = (1 << 10);

    [NativeTypeName("#define LC_MEASUREMENT_MASK (1 << __LC_MEASUREMENT)")]
    public const int LC_MEASUREMENT_MASK = (1 << 11);

    [NativeTypeName("#define LC_IDENTIFICATION_MASK (1 << __LC_IDENTIFICATION)")]
    public const int LC_IDENTIFICATION_MASK = (1 << 12);

    [NativeTypeName("#define LC_ALL_MASK (LC_CTYPE_MASK \\\n\t\t\t\t | LC_NUMERIC_MASK \\\n\t\t\t\t | LC_TIME_MASK \\\n\t\t\t\t | LC_COLLATE_MASK \\\n\t\t\t\t | LC_MONETARY_MASK \\\n\t\t\t\t | LC_MESSAGES_MASK \\\n\t\t\t\t | LC_PAPER_MASK \\\n\t\t\t\t | LC_NAME_MASK \\\n\t\t\t\t | LC_ADDRESS_MASK \\\n\t\t\t\t | LC_TELEPHONE_MASK \\\n\t\t\t\t | LC_MEASUREMENT_MASK \\\n\t\t\t\t | LC_IDENTIFICATION_MASK \\\n\t\t\t\t )")]
    public const int LC_ALL_MASK = ((1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12));

    [NativeTypeName("#define LC_GLOBAL_LOCALE ((locale_t) -1L)")]
    public static locale_t LC_GLOBAL_LOCALE => ((locale_t)(-1));
}
