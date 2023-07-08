// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/locale.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public readonly unsafe partial struct locale_t : IComparable, IComparable<locale_t>, IEquatable<locale_t>, IFormattable
{
    public readonly void* Value;

    public locale_t(void* value)
    {
        Value = value;
    }

    public static locale_t NULL => new locale_t(null);

    public static bool operator ==(locale_t left, locale_t right) => left.Value == right.Value;

    public static bool operator !=(locale_t left, locale_t right) => left.Value != right.Value;

    public static bool operator <(locale_t left, locale_t right) => left.Value < right.Value;

    public static bool operator <=(locale_t left, locale_t right) => left.Value <= right.Value;

    public static bool operator >(locale_t left, locale_t right) => left.Value > right.Value;

    public static bool operator >=(locale_t left, locale_t right) => left.Value >= right.Value;

    public static explicit operator locale_t(void* value) => new locale_t(value);

    public static implicit operator void*(locale_t value) => value.Value;

    public static explicit operator locale_t(byte value) => new locale_t((void*)(value));

    public static explicit operator byte(locale_t value) => (byte)(value.Value);

    public static explicit operator locale_t(short value) => new locale_t((void*)(value));

    public static explicit operator short(locale_t value) => (short)(value.Value);

    public static explicit operator locale_t(int value) => new locale_t((void*)(value));

    public static explicit operator int(locale_t value) => (int)(value.Value);

    public static explicit operator locale_t(long value) => new locale_t((void*)(value));

    public static explicit operator long(locale_t value) => (long)(value.Value);

    public static explicit operator locale_t(nint value) => new locale_t((void*)(value));

    public static implicit operator nint(locale_t value) => (nint)(value.Value);

    public static explicit operator locale_t(sbyte value) => new locale_t((void*)(value));

    public static explicit operator sbyte(locale_t value) => (sbyte)(value.Value);

    public static explicit operator locale_t(ushort value) => new locale_t((void*)(value));

    public static explicit operator ushort(locale_t value) => (ushort)(value.Value);

    public static explicit operator locale_t(uint value) => new locale_t((void*)(value));

    public static explicit operator uint(locale_t value) => (uint)(value.Value);

    public static explicit operator locale_t(ulong value) => new locale_t((void*)(value));

    public static explicit operator ulong(locale_t value) => (ulong)(value.Value);

    public static explicit operator locale_t(nuint value) => new locale_t((void*)(value));

    public static implicit operator nuint(locale_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is locale_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of locale_t.");
    }

    public int CompareTo(locale_t other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is locale_t other) && Equals(other);

    public bool Equals(locale_t other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
