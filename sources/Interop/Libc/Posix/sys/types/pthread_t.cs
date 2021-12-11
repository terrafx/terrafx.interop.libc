// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public unsafe partial struct pthread_t : IComparable, IComparable<pthread_t>, IEquatable<pthread_t>, IFormattable
{
    [NativeTypeName("unsigned long int")]
    public readonly nuint Value;

    public pthread_t(nuint value)
    {
        Value = value;
    }

    public static bool operator ==(pthread_t left, pthread_t right) => left.Value == right.Value;

    public static bool operator !=(pthread_t left, pthread_t right) => left.Value != right.Value;

    public static bool operator <(pthread_t left, pthread_t right) => left.Value < right.Value;

    public static bool operator <=(pthread_t left, pthread_t right) => left.Value <= right.Value;

    public static bool operator >(pthread_t left, pthread_t right) => left.Value > right.Value;

    public static bool operator >=(pthread_t left, pthread_t right) => left.Value >= right.Value;

    public static implicit operator pthread_t(byte value) => new pthread_t(value);

    public static explicit operator byte(pthread_t value) => (byte)(value.Value);

    public static explicit operator pthread_t(short value) => new pthread_t((nuint)(value));

    public static explicit operator short(pthread_t value) => (short)(value.Value);

    public static explicit operator pthread_t(int value) => new pthread_t((nuint)(value));

    public static explicit operator int(pthread_t value) => (int)(value.Value);

    public static explicit operator pthread_t(long value) => new pthread_t((nuint)(value));

    public static explicit operator long(pthread_t value) => (long)(value.Value);

    public static explicit operator pthread_t(nint value) => new pthread_t((nuint)(value));

    public static explicit operator nint(pthread_t value) => (nint)(value.Value);

    public static explicit operator pthread_t(sbyte value) => new pthread_t((nuint)(value));

    public static explicit operator sbyte(pthread_t value) => (sbyte)(value.Value);

    public static implicit operator pthread_t(ushort value) => new pthread_t(value);

    public static explicit operator ushort(pthread_t value) => (ushort)(value.Value);

    public static implicit operator pthread_t(uint value) => new pthread_t(value);

    public static explicit operator uint(pthread_t value) => (uint)(value.Value);

    public static explicit operator pthread_t(ulong value) => new pthread_t((nuint)(value));

    public static implicit operator ulong(pthread_t value) => value.Value;

    public static implicit operator pthread_t(nuint value) => new pthread_t(value);

    public static implicit operator nuint(pthread_t value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is pthread_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of pthread_t.");
    }

    public int CompareTo(pthread_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is pthread_t other) && Equals(other);

    public bool Equals(pthread_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
