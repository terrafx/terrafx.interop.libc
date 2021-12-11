// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/x86_64-linux-gnu/sys/time.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    public static unsafe partial class LibC
    {
        [DllImport("libc", ExactSpelling = true)]
        public static extern int gettimeofday([NativeTypeName("struct timeval *__restrict")] timeval* __tv, [NativeTypeName("void *__restrict")] void* __tz);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int settimeofday([NativeTypeName("const struct timeval *")] timeval* __tv, [NativeTypeName("const struct timezone *")] timezone* __tz);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int adjtime([NativeTypeName("const struct timeval *")] timeval* __delta, [NativeTypeName("struct timeval *")] timeval* __olddelta);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int getitimer([NativeTypeName("__itimer_which_t")] int __which, [NativeTypeName("struct itimerval *")] itimerval* __value);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int setitimer([NativeTypeName("__itimer_which_t")] int __which, [NativeTypeName("const struct itimerval *__restrict")] itimerval* __new, [NativeTypeName("struct itimerval *__restrict")] itimerval* __old);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int utimes([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("const struct timeval [2]")] timeval* __tvp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int lutimes([NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("const struct timeval [2]")] timeval* __tvp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int futimes(int __fd, [NativeTypeName("const struct timeval [2]")] timeval* __tvp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int futimesat(int __fd, [NativeTypeName("const char *")] sbyte* __file, [NativeTypeName("const struct timeval [2]")] timeval* __tvp);
    }
}
