// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC.UnitTests
{
    /// <summary>Provides validation of the <see cref="sigval_t" /> struct.</summary>
    public static unsafe partial class sigval_tTests
    {
        /// <summary>Validates that the <see cref="sigval_t" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<sigval_t>(), Is.EqualTo(sizeof(sigval_t)));
        }

        /// <summary>Validates that the <see cref="sigval_t" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(sigval_t).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="sigval_t" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(sigval_t), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(sigval_t), Is.EqualTo(4));
            }
        }
    }
}
