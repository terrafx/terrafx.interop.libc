// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/select.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests;

/// <summary>Provides validation of the <see cref="fd_set" /> struct.</summary>
public static unsafe partial class fd_setTests
{
    /// <summary>Validates that the <see cref="fd_set" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<fd_set>(), Is.EqualTo(sizeof(fd_set)));
    }

    /// <summary>Validates that the <see cref="fd_set" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(fd_set).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="fd_set" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(fd_set), Is.EqualTo(128));
        }
        else
        {
            Assert.That(sizeof(fd_set), Is.EqualTo(64));
        }
    }
}
