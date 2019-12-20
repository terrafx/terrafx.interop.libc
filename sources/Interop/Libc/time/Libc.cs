// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Libc
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl, EntryPoint = "clock_getres", ExactSpelling = true, SetLastError = true)]
        public static extern int clock_getres([NativeTypeName("clockid_t")] int clock_id, [NativeTypeName("struct timespec *")] timespec* res);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl, EntryPoint = "clock_gettime", ExactSpelling = true, SetLastError = true)]
        public static extern int clock_gettime([NativeTypeName("clockid_t")] int clock_id, [NativeTypeName("struct timespec *")] timespec* tp);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl, EntryPoint = "clock_settime", ExactSpelling = true, SetLastError = true)]
        public static extern int clock_settime([NativeTypeName("clockid_t")] int clock_id, [NativeTypeName("struct timespec *")] timespec* tp);
    }
}
