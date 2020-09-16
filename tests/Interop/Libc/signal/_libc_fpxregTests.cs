// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_libc_fpxreg" /> struct.</summary>
    public static unsafe class _libc_fpxregTests
    {
        /// <summary>Validates that the <see cref="_libc_fpxreg" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_libc_fpxreg>(), Is.EqualTo(sizeof(_libc_fpxreg)));
        }

        /// <summary>Validates that the <see cref="_libc_fpxreg" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_libc_fpxreg).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_libc_fpxreg" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(_libc_fpxreg), Is.EqualTo(16));
        }
    }
}
