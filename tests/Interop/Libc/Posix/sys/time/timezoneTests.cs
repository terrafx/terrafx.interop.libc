// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests
{
    /// <summary>Provides validation of the <see cref="timezone" /> struct.</summary>
    public static unsafe partial class timezoneTests
    {
        /// <summary>Validates that the <see cref="timezone" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<timezone>(), Is.EqualTo(sizeof(timezone)));
        }

        /// <summary>Validates that the <see cref="timezone" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(timezone).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="timezone" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(timezone), Is.EqualTo(8));
        }
    }
}
