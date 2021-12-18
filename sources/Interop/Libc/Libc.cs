// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    public static unsafe partial class LibC
    {
        public static event DllImportResolver? ResolveLibrary;

        static LibC()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), OnDllImport);
        }

        private static IntPtr OnDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (TryResolveLibrary(libraryName, assembly, searchPath, out var nativeLibrary))
            {
                return nativeLibrary;
            }

            if (libraryName.Equals("libc") && TryResolveLibc(assembly, searchPath, out nativeLibrary))
            {
                return nativeLibrary;
            }

            if (libraryName.Equals("libpthread") && TryResolveLibpthread(assembly, searchPath, out nativeLibrary))
            {
                return nativeLibrary;
            }

            if (libraryName.Equals("librt") && TryResolveLibrt(assembly, searchPath, out nativeLibrary))
            {
                return nativeLibrary;
            }

            return IntPtr.Zero;
        }

        private static bool TryResolveLibc(Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (NativeLibrary.TryLoad("libc.so.6", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }
            }

            return NativeLibrary.TryLoad("libc", assembly, searchPath, out nativeLibrary);
        }

        private static bool TryResolveLibpthread(Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (NativeLibrary.TryLoad("libpthread.so.0", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }
            }

            return NativeLibrary.TryLoad("libpthread", assembly, searchPath, out nativeLibrary);
        }

        private static bool TryResolveLibrt(Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (NativeLibrary.TryLoad("librt.so.1", assembly, searchPath, out nativeLibrary))
                {
                    return true;
                }
            }

            return NativeLibrary.TryLoad("librt", assembly, searchPath, out nativeLibrary);
        }

        private static bool TryResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            var resolveLibrary = ResolveLibrary;

            if (resolveLibrary != null)
            {
                var resolvers = resolveLibrary.GetInvocationList();

                foreach (DllImportResolver resolver in resolvers)
                {
                    nativeLibrary = resolver(libraryName, assembly, searchPath);

                    if (nativeLibrary != IntPtr.Zero)
                    {
                        return true;
                    }
                }
            }

            nativeLibrary = IntPtr.Zero;
            return false;
        }
    }
}
