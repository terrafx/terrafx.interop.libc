// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public unsafe partial struct clockid_t : IComparable, IComparable<clockid_t>, IEquatable<clockid_t>, IFormattable
{
    public readonly int Value;

    public clockid_t(int value)
    {
        Value = value;
    }

    public static bool operator ==(clockid_t left, clockid_t right) => left.Value == right.Value;

    public static bool operator !=(clockid_t left, clockid_t right) => left.Value != right.Value;

    public static bool operator <(clockid_t left, clockid_t right) => left.Value < right.Value;

    public static bool operator <=(clockid_t left, clockid_t right) => left.Value <= right.Value;

    public static bool operator >(clockid_t left, clockid_t right) => left.Value > right.Value;

    public static bool operator >=(clockid_t left, clockid_t right) => left.Value >= right.Value;

    public static implicit operator clockid_t(byte value) => new clockid_t(value);

    public static explicit operator byte(clockid_t value) => (byte)(value.Value);

    public static implicit operator clockid_t(short value) => new clockid_t(value);

    public static explicit operator short(clockid_t value) => (short)(value.Value);

    public static implicit operator clockid_t(int value) => new clockid_t(value);

    public static implicit operator int(clockid_t value) => value.Value;

    public static explicit operator clockid_t(long value) => new clockid_t((int)(value));

    public static implicit operator long(clockid_t value) => value.Value;

    public static explicit operator clockid_t(nint value) => new clockid_t((int)(value));

    public static implicit operator nint(clockid_t value) => value.Value;

    public static implicit operator clockid_t(sbyte value) => new clockid_t(value);

    public static explicit operator sbyte(clockid_t value) => (sbyte)(value.Value);

    public static implicit operator clockid_t(ushort value) => new clockid_t(value);

    public static explicit operator ushort(clockid_t value) => (ushort)(value.Value);

    public static explicit operator clockid_t(uint value) => new clockid_t((int)(value));

    public static explicit operator uint(clockid_t value) => (uint)(value.Value);

    public static explicit operator clockid_t(ulong value) => new clockid_t((int)(value));

    public static explicit operator ulong(clockid_t value) => (ulong)(value.Value);

    public static explicit operator clockid_t(nuint value) => new clockid_t((int)(value));

    public static explicit operator nuint(clockid_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is clockid_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of clockid_t.");
    }

    public int CompareTo(clockid_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is clockid_t other) && Equals(other);

    public bool Equals(clockid_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
