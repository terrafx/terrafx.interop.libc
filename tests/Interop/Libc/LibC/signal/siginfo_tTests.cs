// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests;

/// <summary>Provides validation of the <see cref="siginfo_t" /> struct.</summary>
public static unsafe partial class siginfo_tTests
{
    /// <summary>Validates that the <see cref="siginfo_t" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<siginfo_t>(), Is.EqualTo(sizeof(siginfo_t)));
    }

    /// <summary>Validates that the <see cref="siginfo_t" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(siginfo_t).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="siginfo_t" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(siginfo_t), Is.EqualTo(128));
    }
}
