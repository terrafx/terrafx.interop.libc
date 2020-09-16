// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="sigval" /> struct.</summary>
    public static unsafe class sigvalTests
    {
        /// <summary>Validates that the <see cref="sigval" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<sigval>(), Is.EqualTo(sizeof(sigval)));
        }

        /// <summary>Validates that the <see cref="sigval" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(sigval).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="sigval" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(sigval), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(sigval), Is.EqualTo(4));
            }
        }
    }
}
