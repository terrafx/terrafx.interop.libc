// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public readonly unsafe partial struct timer_t : IComparable, IComparable<timer_t>, IEquatable<timer_t>, IFormattable
{
    public readonly void* Value;

    public timer_t(void* value)
    {
        Value = value;
    }

    public static timer_t NULL => new timer_t(null);

    public static bool operator ==(timer_t left, timer_t right) => left.Value == right.Value;

    public static bool operator !=(timer_t left, timer_t right) => left.Value != right.Value;

    public static bool operator <(timer_t left, timer_t right) => left.Value < right.Value;

    public static bool operator <=(timer_t left, timer_t right) => left.Value <= right.Value;

    public static bool operator >(timer_t left, timer_t right) => left.Value > right.Value;

    public static bool operator >=(timer_t left, timer_t right) => left.Value >= right.Value;

    public static explicit operator timer_t(void* value) => new timer_t(value);

    public static implicit operator void*(timer_t value) => value.Value;

    public static explicit operator timer_t(byte value) => new timer_t((void*)(value));

    public static explicit operator byte(timer_t value) => (byte)(value.Value);

    public static explicit operator timer_t(short value) => new timer_t((void*)(value));

    public static explicit operator short(timer_t value) => (short)(value.Value);

    public static explicit operator timer_t(int value) => new timer_t((void*)(value));

    public static explicit operator int(timer_t value) => (int)(value.Value);

    public static explicit operator timer_t(long value) => new timer_t((void*)(value));

    public static explicit operator long(timer_t value) => (long)(value.Value);

    public static explicit operator timer_t(nint value) => new timer_t((void*)(value));

    public static implicit operator nint(timer_t value) => (nint)(value.Value);

    public static explicit operator timer_t(sbyte value) => new timer_t((void*)(value));

    public static explicit operator sbyte(timer_t value) => (sbyte)(value.Value);

    public static explicit operator timer_t(ushort value) => new timer_t((void*)(value));

    public static explicit operator ushort(timer_t value) => (ushort)(value.Value);

    public static explicit operator timer_t(uint value) => new timer_t((void*)(value));

    public static explicit operator uint(timer_t value) => (uint)(value.Value);

    public static explicit operator timer_t(ulong value) => new timer_t((void*)(value));

    public static explicit operator ulong(timer_t value) => (ulong)(value.Value);

    public static explicit operator timer_t(nuint value) => new timer_t((void*)(value));

    public static implicit operator nuint(timer_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is timer_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of timer_t.");
    }

    public int CompareTo(timer_t other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is timer_t other) && Equals(other);

    public bool Equals(timer_t other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
