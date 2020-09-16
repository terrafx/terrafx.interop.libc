// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_libc_fpstate" /> struct.</summary>
    public static unsafe class _libc_fpstateTests
    {
        /// <summary>Validates that the <see cref="_libc_fpstate" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_libc_fpstate>(), Is.EqualTo(sizeof(_libc_fpstate)));
        }

        /// <summary>Validates that the <see cref="_libc_fpstate" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_libc_fpstate).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_libc_fpstate" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(_libc_fpstate), Is.EqualTo(512));
            }
            else
            {
                Assert.That(sizeof(_libc_fpstate), Is.EqualTo(504));
            }
        }
    }
}
