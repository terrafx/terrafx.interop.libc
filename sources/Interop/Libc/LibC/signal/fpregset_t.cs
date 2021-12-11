// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/types.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;

namespace TerraFX.Interop.LibC;

public unsafe partial struct fpregset_t : IComparable, IComparable<fpregset_t>, IEquatable<fpregset_t>, IFormattable
{
    public readonly void* Value;

    public fpregset_t(void* value)
    {
        Value = value;
    }

    public static fpregset_t NULL => new fpregset_t(null);

    public static bool operator ==(fpregset_t left, fpregset_t right) => left.Value == right.Value;

    public static bool operator !=(fpregset_t left, fpregset_t right) => left.Value != right.Value;

    public static bool operator <(fpregset_t left, fpregset_t right) => left.Value < right.Value;

    public static bool operator <=(fpregset_t left, fpregset_t right) => left.Value <= right.Value;

    public static bool operator >(fpregset_t left, fpregset_t right) => left.Value > right.Value;

    public static bool operator >=(fpregset_t left, fpregset_t right) => left.Value >= right.Value;

    public static explicit operator fpregset_t(void* value) => new fpregset_t(value);

    public static implicit operator void*(fpregset_t value) => value.Value;

    public static explicit operator fpregset_t(byte value) => new fpregset_t((void*)(value));

    public static explicit operator byte(fpregset_t value) => (byte)(value.Value);

    public static explicit operator fpregset_t(short value) => new fpregset_t((void*)(value));

    public static explicit operator short(fpregset_t value) => (short)(value.Value);

    public static explicit operator fpregset_t(int value) => new fpregset_t((void*)(value));

    public static explicit operator int(fpregset_t value) => (int)(value.Value);

    public static explicit operator fpregset_t(long value) => new fpregset_t((void*)(value));

    public static explicit operator long(fpregset_t value) => (long)(value.Value);

    public static explicit operator fpregset_t(nint value) => new fpregset_t((void*)(value));

    public static implicit operator nint(fpregset_t value) => (nint)(value.Value);

    public static explicit operator fpregset_t(sbyte value) => new fpregset_t((void*)(value));

    public static explicit operator sbyte(fpregset_t value) => (sbyte)(value.Value);

    public static explicit operator fpregset_t(ushort value) => new fpregset_t((void*)(value));

    public static explicit operator ushort(fpregset_t value) => (ushort)(value.Value);

    public static explicit operator fpregset_t(uint value) => new fpregset_t((void*)(value));

    public static explicit operator uint(fpregset_t value) => (uint)(value.Value);

    public static explicit operator fpregset_t(ulong value) => new fpregset_t((void*)(value));

    public static explicit operator ulong(fpregset_t value) => (ulong)(value.Value);

    public static explicit operator fpregset_t(nuint value) => new fpregset_t((void*)(value));

    public static implicit operator nuint(fpregset_t value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is fpregset_t other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of fpregset_t.");
    }

    public int CompareTo(fpregset_t other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is fpregset_t other) && Equals(other);

    public bool Equals(fpregset_t other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
