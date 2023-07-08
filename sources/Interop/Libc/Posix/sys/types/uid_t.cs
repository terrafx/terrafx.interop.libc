// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public readonly unsafe partial struct uid_t : IComparable, IComparable<uid_t>, IEquatable<uid_t>, IFormattable
{
    public readonly uint Value;

    public uid_t(uint value)
    {
        Value = value;
    }

    public static bool operator ==(uid_t left, uid_t right) => left.Value == right.Value;

    public static bool operator !=(uid_t left, uid_t right) => left.Value != right.Value;

    public static bool operator <(uid_t left, uid_t right) => left.Value < right.Value;

    public static bool operator <=(uid_t left, uid_t right) => left.Value <= right.Value;

    public static bool operator >(uid_t left, uid_t right) => left.Value > right.Value;

    public static bool operator >=(uid_t left, uid_t right) => left.Value >= right.Value;

    public static implicit operator uid_t(byte value) => new uid_t(value);

    public static explicit operator byte(uid_t value) => (byte)(value.Value);

    public static explicit operator uid_t(short value) => new uid_t((uint)(value));

    public static explicit operator short(uid_t value) => (short)(value.Value);

    public static explicit operator uid_t(int value) => new uid_t((uint)(value));

    public static explicit operator int(uid_t value) => (int)(value.Value);

    public static explicit operator uid_t(long value) => new uid_t((uint)(value));

    public static implicit operator long(uid_t value) => value.Value;

    public static explicit operator uid_t(nint value) => new uid_t((uint)(value));

    public static explicit operator nint(uid_t value) => (nint)(value.Value);

    public static explicit operator uid_t(sbyte value) => new uid_t((uint)(value));

    public static explicit operator sbyte(uid_t value) => (sbyte)(value.Value);

    public static implicit operator uid_t(ushort value) => new uid_t(value);

    public static explicit operator ushort(uid_t value) => (ushort)(value.Value);

    public static implicit operator uid_t(uint value) => new uid_t(value);

    public static implicit operator uint(uid_t value) => value.Value;

    public static explicit operator uid_t(ulong value) => new uid_t((uint)(value));

    public static implicit operator ulong(uid_t value) => value.Value;

    public static explicit operator uid_t(nuint value) => new uid_t((uint)(value));

    public static implicit operator nuint(uid_t value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is uid_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of uid_t.");
    }

    public int CompareTo(uid_t other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is uid_t other) && Equals(other);

    public bool Equals(uid_t other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
