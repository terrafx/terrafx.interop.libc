// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/types.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="__pthread_cond_s" /> struct.</summary>
    public static unsafe class __pthread_cond_sTests
    {
        /// <summary>Validates that the <see cref="__pthread_cond_s" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<__pthread_cond_s>(), Is.EqualTo(sizeof(__pthread_cond_s)));
        }

        /// <summary>Validates that the <see cref="__pthread_cond_s" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(__pthread_cond_s).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="__pthread_cond_s" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(__pthread_cond_s), Is.EqualTo(48));
        }
    }
}
