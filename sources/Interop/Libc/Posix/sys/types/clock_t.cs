// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public unsafe partial struct clock_t : IComparable, IComparable<clock_t>, IEquatable<clock_t>, IFormattable
{
    public readonly nint Value;

    public clock_t(nint value)
    {
        Value = value;
    }

    public static bool operator ==(clock_t left, clock_t right) => left.Value == right.Value;

    public static bool operator !=(clock_t left, clock_t right) => left.Value != right.Value;

    public static bool operator <(clock_t left, clock_t right) => left.Value < right.Value;

    public static bool operator <=(clock_t left, clock_t right) => left.Value <= right.Value;

    public static bool operator >(clock_t left, clock_t right) => left.Value > right.Value;

    public static bool operator >=(clock_t left, clock_t right) => left.Value >= right.Value;

    public static implicit operator clock_t(byte value) => new clock_t(value);

    public static explicit operator byte(clock_t value) => (byte)(value.Value);

    public static implicit operator clock_t(short value) => new clock_t(value);

    public static explicit operator short(clock_t value) => (short)(value.Value);

    public static implicit operator clock_t(int value) => new clock_t(value);

    public static explicit operator int(clock_t value) => (int)(value.Value);

    public static explicit operator clock_t(long value) => new clock_t((nint)(value));

    public static implicit operator long(clock_t value) => value.Value;

    public static implicit operator clock_t(nint value) => new clock_t(value);

    public static implicit operator nint(clock_t value) => value.Value;

    public static implicit operator clock_t(sbyte value) => new clock_t(value);

    public static explicit operator sbyte(clock_t value) => (sbyte)(value.Value);

    public static implicit operator clock_t(ushort value) => new clock_t(value);

    public static explicit operator ushort(clock_t value) => (ushort)(value.Value);

    public static explicit operator clock_t(uint value) => new clock_t((nint)(value));

    public static explicit operator uint(clock_t value) => (uint)(value.Value);

    public static explicit operator clock_t(ulong value) => new clock_t((nint)(value));

    public static explicit operator ulong(clock_t value) => (ulong)(value.Value);

    public static explicit operator clock_t(nuint value) => new clock_t((nint)(value));

    public static explicit operator nuint(clock_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is clock_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of clock_t.");
    }

    public int CompareTo(clock_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is clock_t other) && Equals(other);

    public bool Equals(clock_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
