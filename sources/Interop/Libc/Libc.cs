// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Libc
    {
        private const string libraryPath = "libc";

        static Libc()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), ResolveLibrary);
        }

        private static IntPtr ResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (!NativeLibrary.TryLoad("libc.so", assembly, searchPath, out var nativeLibrary))
            {
                nativeLibrary = NativeLibrary.Load("libc.so.6", assembly, searchPath);
            }

            return nativeLibrary;
        }
    }
}
