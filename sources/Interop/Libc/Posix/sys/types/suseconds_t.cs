// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public readonly unsafe partial struct suseconds_t : IComparable, IComparable<suseconds_t>, IEquatable<suseconds_t>, IFormattable
{
    public readonly nint Value;

    public suseconds_t(nint value)
    {
        Value = value;
    }

    public static bool operator ==(suseconds_t left, suseconds_t right) => left.Value == right.Value;

    public static bool operator !=(suseconds_t left, suseconds_t right) => left.Value != right.Value;

    public static bool operator <(suseconds_t left, suseconds_t right) => left.Value < right.Value;

    public static bool operator <=(suseconds_t left, suseconds_t right) => left.Value <= right.Value;

    public static bool operator >(suseconds_t left, suseconds_t right) => left.Value > right.Value;

    public static bool operator >=(suseconds_t left, suseconds_t right) => left.Value >= right.Value;

    public static implicit operator suseconds_t(byte value) => new suseconds_t(value);

    public static explicit operator byte(suseconds_t value) => (byte)(value.Value);

    public static implicit operator suseconds_t(short value) => new suseconds_t(value);

    public static explicit operator short(suseconds_t value) => (short)(value.Value);

    public static implicit operator suseconds_t(int value) => new suseconds_t(value);

    public static explicit operator int(suseconds_t value) => (int)(value.Value);

    public static explicit operator suseconds_t(long value) => new suseconds_t((nint)(value));

    public static implicit operator long(suseconds_t value) => value.Value;

    public static implicit operator suseconds_t(nint value) => new suseconds_t(value);

    public static implicit operator nint(suseconds_t value) => value.Value;

    public static implicit operator suseconds_t(sbyte value) => new suseconds_t(value);

    public static explicit operator sbyte(suseconds_t value) => (sbyte)(value.Value);

    public static implicit operator suseconds_t(ushort value) => new suseconds_t(value);

    public static explicit operator ushort(suseconds_t value) => (ushort)(value.Value);

    public static explicit operator suseconds_t(uint value) => new suseconds_t((nint)(value));

    public static explicit operator uint(suseconds_t value) => (uint)(value.Value);

    public static explicit operator suseconds_t(ulong value) => new suseconds_t((nint)(value));

    public static explicit operator ulong(suseconds_t value) => (ulong)(value.Value);

    public static explicit operator suseconds_t(nuint value) => new suseconds_t((nint)(value));

    public static explicit operator nuint(suseconds_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is suseconds_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of suseconds_t.");
    }

    public int CompareTo(suseconds_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is suseconds_t other) && Equals(other);

    public bool Equals(suseconds_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
