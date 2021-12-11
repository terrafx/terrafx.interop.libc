// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public unsafe partial struct pid_t : IComparable, IComparable<pid_t>, IEquatable<pid_t>, IFormattable
{
    public readonly int Value;

    public pid_t(int value)
    {
        Value = value;
    }

    public static bool operator ==(pid_t left, pid_t right) => left.Value == right.Value;

    public static bool operator !=(pid_t left, pid_t right) => left.Value != right.Value;

    public static bool operator <(pid_t left, pid_t right) => left.Value < right.Value;

    public static bool operator <=(pid_t left, pid_t right) => left.Value <= right.Value;

    public static bool operator >(pid_t left, pid_t right) => left.Value > right.Value;

    public static bool operator >=(pid_t left, pid_t right) => left.Value >= right.Value;

    public static implicit operator pid_t(byte value) => new pid_t(value);

    public static explicit operator byte(pid_t value) => (byte)(value.Value);

    public static implicit operator pid_t(short value) => new pid_t(value);

    public static explicit operator short(pid_t value) => (short)(value.Value);

    public static implicit operator pid_t(int value) => new pid_t(value);

    public static implicit operator int(pid_t value) => value.Value;

    public static explicit operator pid_t(long value) => new pid_t((int)(value));

    public static implicit operator long(pid_t value) => value.Value;

    public static explicit operator pid_t(nint value) => new pid_t((int)(value));

    public static implicit operator nint(pid_t value) => value.Value;

    public static implicit operator pid_t(sbyte value) => new pid_t(value);

    public static explicit operator sbyte(pid_t value) => (sbyte)(value.Value);

    public static implicit operator pid_t(ushort value) => new pid_t(value);

    public static explicit operator ushort(pid_t value) => (ushort)(value.Value);

    public static explicit operator pid_t(uint value) => new pid_t((int)(value));

    public static explicit operator uint(pid_t value) => (uint)(value.Value);

    public static explicit operator pid_t(ulong value) => new pid_t((int)(value));

    public static explicit operator ulong(pid_t value) => (ulong)(value.Value);

    public static explicit operator pid_t(nuint value) => new pid_t((int)(value));

    public static explicit operator nuint(pid_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is pid_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of pid_t.");
    }

    public int CompareTo(pid_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is pid_t other) && Equals(other);

    public bool Equals(pid_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
