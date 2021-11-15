// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/sys/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

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
