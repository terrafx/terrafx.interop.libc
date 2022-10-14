// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests;

/// <summary>Provides validation of the <see cref="itimerspec" /> struct.</summary>
public static unsafe partial class itimerspecTests
{
    /// <summary>Validates that the <see cref="itimerspec" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<itimerspec>(), Is.EqualTo(sizeof(itimerspec)));
    }

    /// <summary>Validates that the <see cref="itimerspec" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(itimerspec).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="itimerspec" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(itimerspec), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(itimerspec), Is.EqualTo(16));
        }
    }
}
