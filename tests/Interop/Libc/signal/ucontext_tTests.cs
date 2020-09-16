// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/signal.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ucontext_t" /> struct.</summary>
    public static unsafe class ucontext_tTests
    {
        /// <summary>Validates that the <see cref="ucontext_t" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ucontext_t>(), Is.EqualTo(sizeof(ucontext_t)));
        }

        /// <summary>Validates that the <see cref="ucontext_t" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ucontext_t).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ucontext_t" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ucontext_t), Is.EqualTo(968));
            }
            else
            {
                Assert.That(sizeof(ucontext_t), Is.EqualTo(880));
            }
        }
    }
}
