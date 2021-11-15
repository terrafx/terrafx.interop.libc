// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests
{
    /// <summary>Provides validation of the <see cref="sigset_t" /> struct.</summary>
    public static unsafe partial class sigset_tTests
    {
        /// <summary>Validates that the <see cref="sigset_t" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<sigset_t>(), Is.EqualTo(sizeof(sigset_t)));
        }

        /// <summary>Validates that the <see cref="sigset_t" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(sigset_t).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="sigset_t" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(sigset_t), Is.EqualTo(128));
            }
            else
            {
                Assert.That(sizeof(sigset_t), Is.EqualTo(64));
            }
        }
    }
}
