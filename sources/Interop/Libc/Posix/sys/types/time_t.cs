// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public readonly unsafe partial struct time_t : IComparable, IComparable<time_t>, IEquatable<time_t>, IFormattable
{
    public readonly nint Value;

    public time_t(nint value)
    {
        Value = value;
    }

    public static bool operator ==(time_t left, time_t right) => left.Value == right.Value;

    public static bool operator !=(time_t left, time_t right) => left.Value != right.Value;

    public static bool operator <(time_t left, time_t right) => left.Value < right.Value;

    public static bool operator <=(time_t left, time_t right) => left.Value <= right.Value;

    public static bool operator >(time_t left, time_t right) => left.Value > right.Value;

    public static bool operator >=(time_t left, time_t right) => left.Value >= right.Value;

    public static implicit operator time_t(byte value) => new time_t(value);

    public static explicit operator byte(time_t value) => (byte)(value.Value);

    public static implicit operator time_t(short value) => new time_t(value);

    public static explicit operator short(time_t value) => (short)(value.Value);

    public static implicit operator time_t(int value) => new time_t(value);

    public static explicit operator int(time_t value) => (int)(value.Value);

    public static explicit operator time_t(long value) => new time_t((nint)(value));

    public static implicit operator long(time_t value) => value.Value;

    public static implicit operator time_t(nint value) => new time_t(value);

    public static implicit operator nint(time_t value) => value.Value;

    public static implicit operator time_t(sbyte value) => new time_t(value);

    public static explicit operator sbyte(time_t value) => (sbyte)(value.Value);

    public static implicit operator time_t(ushort value) => new time_t(value);

    public static explicit operator ushort(time_t value) => (ushort)(value.Value);

    public static explicit operator time_t(uint value) => new time_t((nint)(value));

    public static explicit operator uint(time_t value) => (uint)(value.Value);

    public static explicit operator time_t(ulong value) => new time_t((nint)(value));

    public static explicit operator ulong(time_t value) => (ulong)(value.Value);

    public static explicit operator time_t(nuint value) => new time_t((nint)(value));

    public static explicit operator nuint(time_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is time_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of time_t.");
    }

    public int CompareTo(time_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is time_t other) && Equals(other);

    public bool Equals(time_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
