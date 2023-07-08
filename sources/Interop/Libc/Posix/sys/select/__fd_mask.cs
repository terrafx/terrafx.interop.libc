// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/select.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public readonly unsafe partial struct __fd_mask : IComparable, IComparable<__fd_mask>, IEquatable<__fd_mask>, IFormattable
{
    public readonly nint Value;

    public __fd_mask(nint value)
    {
        Value = value;
    }

    public static bool operator ==(__fd_mask left, __fd_mask right) => left.Value == right.Value;

    public static bool operator !=(__fd_mask left, __fd_mask right) => left.Value != right.Value;

    public static bool operator <(__fd_mask left, __fd_mask right) => left.Value < right.Value;

    public static bool operator <=(__fd_mask left, __fd_mask right) => left.Value <= right.Value;

    public static bool operator >(__fd_mask left, __fd_mask right) => left.Value > right.Value;

    public static bool operator >=(__fd_mask left, __fd_mask right) => left.Value >= right.Value;

    public static implicit operator __fd_mask(byte value) => new __fd_mask(value);

    public static explicit operator byte(__fd_mask value) => (byte)(value.Value);

    public static implicit operator __fd_mask(short value) => new __fd_mask(value);

    public static explicit operator short(__fd_mask value) => (short)(value.Value);

    public static implicit operator __fd_mask(int value) => new __fd_mask(value);

    public static explicit operator int(__fd_mask value) => (int)(value.Value);

    public static explicit operator __fd_mask(long value) => new __fd_mask((nint)(value));

    public static implicit operator long(__fd_mask value) => value.Value;

    public static implicit operator __fd_mask(nint value) => new __fd_mask(value);

    public static implicit operator nint(__fd_mask value) => value.Value;

    public static implicit operator __fd_mask(sbyte value) => new __fd_mask(value);

    public static explicit operator sbyte(__fd_mask value) => (sbyte)(value.Value);

    public static implicit operator __fd_mask(ushort value) => new __fd_mask(value);

    public static explicit operator ushort(__fd_mask value) => (ushort)(value.Value);

    public static explicit operator __fd_mask(uint value) => new __fd_mask((nint)(value));

    public static explicit operator uint(__fd_mask value) => (uint)(value.Value);

    public static explicit operator __fd_mask(ulong value) => new __fd_mask((nint)(value));

    public static explicit operator ulong(__fd_mask value) => (ulong)(value.Value);

    public static explicit operator __fd_mask(nuint value) => new __fd_mask((nint)(value));

    public static explicit operator nuint(__fd_mask value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is __fd_mask other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of __fd_mask.");
    }

    public int CompareTo(__fd_mask other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is __fd_mask other) && Equals(other);

    public bool Equals(__fd_mask other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
