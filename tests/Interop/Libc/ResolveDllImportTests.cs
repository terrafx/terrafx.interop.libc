// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

#pragma warning disable IL2026
#pragma warning disable IL2070

namespace TerraFX.Interop.LibC.UnitTests;

/// <summary>Provides validation that the <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
public static unsafe partial class ResolveDllImportTests
{
    /// <summary>Validates that thhe <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
    [Test]
    [Platform("Linux")]
    public static void ResolveDllImportTest()
    {
        Assert.Multiple(() => {
            var assembly = typeof(LibC).Assembly;
            ProcessAssembly(assembly);
        });
    }

    private static void ProcessAssembly(Assembly assembly)
    {
        foreach (var type in assembly.GetTypes())
        {
            ProcessType(type);
        }
    }

    private static void ProcessMethod(MethodInfo method)
    {
        if (!method.Attributes.HasFlag(MethodAttributes.PinvokeImpl))
        {
            return;
        }

        try
        {
            Marshal.Prelink(method);
        }
        catch (Exception exception)
        {
            switch (method.Name)
            {
                case "pthread_attr_getstackaddr":
                case "pthread_attr_setstackaddr":
                case "pthread_mutexattr_getrobust_np":
                case "pthread_mutexattr_setrobust_np":
                case "pthread_mutex_consistent_np":
                case "pthread_yield":
                {
                    Assert.Warn($"Obsoleted: {exception.Message}");
                    break;
                }

                default:
                {
                    Assert.Fail($"Fail: {exception.Message}");
                    break;
                }
            }
        }
    }

    private static void ProcessType(Type type)
    {
        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            ProcessMethod(method);
        }

        foreach (var nestedType in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
        {
            ProcessType(nestedType);
        }
    }
}
