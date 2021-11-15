// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests
{
    /// <summary>Provides validation of the <see cref="tm" /> struct.</summary>
    public static unsafe partial class tmTests
    {
        /// <summary>Validates that the <see cref="tm" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<tm>(), Is.EqualTo(sizeof(tm)));
        }

        /// <summary>Validates that the <see cref="tm" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(tm).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="tm" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(tm), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(tm), Is.EqualTo(44));
            }
        }
    }
}
