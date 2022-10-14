// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests;

/// <summary>Provides validation of the <see cref="timespec" /> struct.</summary>
public static unsafe partial class timespecTests
{
    /// <summary>Validates that the <see cref="timespec" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<timespec>(), Is.EqualTo(sizeof(timespec)));
    }

    /// <summary>Validates that the <see cref="timespec" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(timespec).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="timespec" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(timespec), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(timespec), Is.EqualTo(8));
        }
    }
}
