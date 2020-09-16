// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/locale.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Libc
    {
        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* setlocale(int __category, [NativeTypeName("const char *")] sbyte* __locale);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("struct lconv *")]
        public static extern lconv* localeconv();

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("locale_t")]
        public static extern IntPtr newlocale(int __category_mask, [NativeTypeName("const char *")] sbyte* __locale, [NativeTypeName("locale_t")] IntPtr __base);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("locale_t")]
        public static extern IntPtr duplocale([NativeTypeName("locale_t")] IntPtr __dataset);

        [DllImport("libc", ExactSpelling = true)]
        public static extern void freelocale([NativeTypeName("locale_t")] IntPtr __dataset);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("locale_t")]
        public static extern IntPtr uselocale([NativeTypeName("locale_t")] IntPtr __dataset);

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
        public static readonly IntPtr LC_GLOBAL_LOCALE = ((IntPtr)(-1));
    }
}
