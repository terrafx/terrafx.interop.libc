// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/pthread.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC;

public static unsafe partial class LibC
{
    public const int PTHREAD_CREATE_JOINABLE = 0;
    public const int PTHREAD_CREATE_DETACHED = 1;

    public const int PTHREAD_MUTEX_TIMED_NP = 0;
    public const int PTHREAD_MUTEX_RECURSIVE_NP = 1;
    public const int PTHREAD_MUTEX_ERRORCHECK_NP = 2;
    public const int PTHREAD_MUTEX_ADAPTIVE_NP = 3;
    public const int PTHREAD_MUTEX_NORMAL = PTHREAD_MUTEX_TIMED_NP;
    public const int PTHREAD_MUTEX_RECURSIVE = PTHREAD_MUTEX_RECURSIVE_NP;
    public const int PTHREAD_MUTEX_ERRORCHECK = PTHREAD_MUTEX_ERRORCHECK_NP;
    public const int PTHREAD_MUTEX_DEFAULT = PTHREAD_MUTEX_NORMAL;
    public const int PTHREAD_MUTEX_FAST_NP = PTHREAD_MUTEX_TIMED_NP;

    public const int PTHREAD_MUTEX_STALLED = 0;
    public const int PTHREAD_MUTEX_STALLED_NP = PTHREAD_MUTEX_STALLED;
    public const int PTHREAD_MUTEX_ROBUST = 1;
    public const int PTHREAD_MUTEX_ROBUST_NP = PTHREAD_MUTEX_ROBUST;

    public const int PTHREAD_PRIO_NONE = 0;
    public const int PTHREAD_PRIO_INHERIT = 1;
    public const int PTHREAD_PRIO_PROTECT = 2;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static pthread_mutex_t PTHREAD_MUTEX_INITIALIZER()
    {
        return new pthread_mutex_t {
            __data = __PTHREAD_MUTEX_INITIALIZER(PTHREAD_MUTEX_TIMED_NP),
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static pthread_mutex_t PTHREAD_RECURSIVE_MUTEX_INITIALIZER_NP()
    {
        return new pthread_mutex_t {
            __data = __PTHREAD_MUTEX_INITIALIZER(PTHREAD_MUTEX_RECURSIVE_NP),
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static pthread_mutex_t PTHREAD_ERRORCHECK_MUTEX_INITIALIZER_NP()
    {
        return new pthread_mutex_t {
            __data = __PTHREAD_MUTEX_INITIALIZER(PTHREAD_MUTEX_ERRORCHECK_NP),
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static pthread_mutex_t PTHREAD_ADAPTIVE_MUTEX_INITIALIZER_NP()
    {
        return new pthread_mutex_t {
            __data = __PTHREAD_MUTEX_INITIALIZER(PTHREAD_MUTEX_ADAPTIVE_NP),
        };
    }

    public const int PTHREAD_RWLOCK_PREFER_READER_NP = 0;
    public const int PTHREAD_RWLOCK_PREFER_WRITER_NP = 1;
    public const int PTHREAD_RWLOCK_PREFER_WRITER_NONRECURSIVE_NP = 2;
    public const int PTHREAD_RWLOCK_DEFAULT_NP = PTHREAD_RWLOCK_PREFER_READER_NP;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static pthread_rwlock_t PTHREAD_RWLOCK_INITIALIZER()
    {
        return new pthread_rwlock_t {
            __data = __PTHREAD_RWLOCK_INITIALIZER(PTHREAD_RWLOCK_DEFAULT_NP),
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static pthread_rwlock_t PTHREAD_RWLOCK_WRITER_NONRECURSIVE_INITIALIZER_NP()
    {
        return new pthread_rwlock_t {
            __data = __PTHREAD_RWLOCK_INITIALIZER(PTHREAD_RWLOCK_PREFER_WRITER_NONRECURSIVE_NP),
        };
    }

    public const int PTHREAD_INHERIT_SCHED = 0;
    public const int PTHREAD_EXPLICIT_SCHED = 1;

    public const int PTHREAD_SCOPE_SYSTEM = 0;
    public const int PTHREAD_SCOPE_PROCESS = 1;

    public const int PTHREAD_PROCESS_PRIVATE = 0;
    public const int PTHREAD_PROCESS_SHARED = 1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static pthread_cond_t PTHREAD_COND_INITIALIZER()
    {
        return new pthread_cond_t();
    }

    public const int PTHREAD_CANCEL_ENABLE = 0;
    public const int PTHREAD_CANCEL_DISABLE = 1;

    public const int PTHREAD_CANCEL_DEFERRED = 0;
    public const int PTHREAD_CANCEL_ASYNCHRONOUS = 1;

    [NativeTypeName("#define PTHREAD_CANCELED ((void*) -1)")]
    public static void* PTHREAD_CANCELED => ((void*)(-1));

    [NativeTypeName("#define PTHREAD_ONCE_INIT 0")]
    public const int PTHREAD_ONCE_INIT = 0;

    [NativeTypeName("#define PTHREAD_BARRIER_SERIAL_THREAD -1")]
    public const int PTHREAD_BARRIER_SERIAL_THREAD = -1;

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_create(pthread_t* __newthread, [NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, delegate* unmanaged<void*, void*> __start_routine, void* __arg);

    [DoesNotReturn]
    [DllImport("libc", ExactSpelling = true)]
    public static extern void pthread_exit(void* __retval);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_join(pthread_t __th, void** __thread_return);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_tryjoin_np(pthread_t __th, void** __thread_return);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_timedjoin_np(pthread_t __th, void** __thread_return, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_clockjoin_np(pthread_t __th, void** __thread_return, clockid_t __clockid, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_detach(pthread_t __th);

    [DllImport("libc", ExactSpelling = true)]
    public static extern pthread_t pthread_self();

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_equal(pthread_t __thread1, pthread_t __thread2);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_init(pthread_attr_t* __attr);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_destroy(pthread_attr_t* __attr);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_getdetachstate([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, int* __detachstate);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_setdetachstate(pthread_attr_t* __attr, int __detachstate);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_getguardsize([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, [NativeTypeName("size_t*")] nuint* __guardsize);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_setguardsize(pthread_attr_t* __attr, [NativeTypeName("size_t")] nuint __guardsize);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_getschedparam([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, [NativeTypeName("struct sched_param*")] sched_param* __param);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_setschedparam(pthread_attr_t* __attr, [NativeTypeName("const struct sched_param*")] sched_param* __param);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_getschedpolicy([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, int* __policy);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_setschedpolicy(pthread_attr_t* __attr, int __policy);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_getinheritsched([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, int* __inherit);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_setinheritsched(pthread_attr_t* __attr, int __inherit);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_getscope([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, int* __scope);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_attr_setscope(pthread_attr_t* __attr, int __scope);

    [Obsolete]
    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_getstackaddr([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, void** __stackaddr);

    [Obsolete]
    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_setstackaddr(pthread_attr_t* __attr, void* __stackaddr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_getstacksize([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, [NativeTypeName("size_t*")] nuint* __stacksize);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_setstacksize(pthread_attr_t* __attr, [NativeTypeName("size_t")] nuint __stacksize);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_getstack([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, void** __stackaddr, [NativeTypeName("size_t*")] nuint* __stacksize);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_setstack(pthread_attr_t* __attr, void* __stackaddr, [NativeTypeName("size_t")] nuint __stacksize);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_setaffinity_np(pthread_attr_t* __attr, [NativeTypeName("size_t")] nuint __cpusetsize, [NativeTypeName("const cpu_set_t*")] cpu_set_t* __cpuset);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_attr_getaffinity_np([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr, [NativeTypeName("size_t")] nuint __cpusetsize, cpu_set_t* __cpuset);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_getattr_default_np(pthread_attr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_setattr_default_np([NativeTypeName("const pthread_attr_t*")] pthread_attr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_getattr_np(pthread_t __th, pthread_attr_t* __attr);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_setschedparam(pthread_t __target_thread, int __policy, [NativeTypeName("const struct sched_param*")] sched_param* __param);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_getschedparam(pthread_t __target_thread, int* __policy, [NativeTypeName("struct sched_param*")] sched_param* __param);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_setschedprio(pthread_t __target_thread, int __prio);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_getname_np(pthread_t __target_thread, char* __buf, [NativeTypeName("size_t")] nuint __buflen);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_setname_np(pthread_t __target_thread, [NativeTypeName("const sbyte*")] sbyte* __name);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_getconcurrency();

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_setconcurrency(int __level);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_yield();

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_setaffinity_np(pthread_t __th, [NativeTypeName("size_t")] nuint __cpusetsize, [NativeTypeName("const cpu_set_t*")] cpu_set_t* __cpuset);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_getaffinity_np(pthread_t __th, [NativeTypeName("size_t")] nuint __cpusetsize, cpu_set_t* __cpuset);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_once(pthread_once_t* __once_control, delegate* unmanaged<void> __init_routine);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_setcancelstate(int __state, int* __oldstate);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_setcanceltype(int __type, int* __oldtype);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_cancel(pthread_t __th);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern void pthread_testcancel();

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_mutex_init(pthread_mutex_t* __mutex, [NativeTypeName("const pthread_mutexattr_t *")] pthread_mutexattr_t* __mutexattr);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_mutex_destroy(pthread_mutex_t* __mutex);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutex_trylock(pthread_mutex_t* __mutex);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_mutex_lock(pthread_mutex_t* __mutex);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutex_timedlock(pthread_mutex_t* __mutex, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutex_clocklock(pthread_mutex_t* __mutex, clockid_t __clockid, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_mutex_unlock(pthread_mutex_t* __mutex);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutex_getprioceiling([NativeTypeName("const pthread_mutex_t*")] pthread_mutex_t* __mutex, int* __prioceiling);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutex_setprioceiling(pthread_mutex_t* __mutex, int __prioceiling, int* __old_ceiling);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutex_consistent(pthread_mutex_t* __mutex);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutex_consistent_np(pthread_mutex_t* __mutex);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_init(pthread_mutexattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_destroy(pthread_mutexattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_getpshared([NativeTypeName("const pthread_mutexattr_t *")] pthread_mutexattr_t* __attr, int* __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_setpshared(pthread_mutexattr_t* __attr, int __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_gettype([NativeTypeName("const pthread_mutexattr_t*")] pthread_mutexattr_t* __attr, int* __kind);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_settype(pthread_mutexattr_t* __attr, int __kind);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_getprotocol([NativeTypeName("const pthread_mutexattr_t *")] pthread_mutexattr_t* __attr, int* __protocol);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_setprotocol(pthread_mutexattr_t* __attr, int __protocol);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_getprioceiling([NativeTypeName("const pthread_mutexattr_t *")] pthread_mutexattr_t* __attr, int* __prioceiling);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_setprioceiling(pthread_mutexattr_t* __attr, int __prioceiling);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_getrobust([NativeTypeName("const pthread_mutexattr_t *")] pthread_mutexattr_t* __attr, int* __robustness);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_getrobust_np([NativeTypeName("const pthread_mutexattr_t *")] pthread_mutexattr_t* __attr, int* __robustness);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_setrobust(pthread_mutexattr_t* __attr, int __robustness);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_mutexattr_setrobust_np(pthread_mutexattr_t* __attr, int __robustness);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_init(pthread_rwlock_t* __rwlock, [NativeTypeName("const pthread_rwlockattr_t *")] pthread_rwlockattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_destroy(pthread_rwlock_t* __rwlock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_rdlock(pthread_rwlock_t* __rwlock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_tryrdlock(pthread_rwlock_t* __rwlock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_timedrdlock(pthread_rwlock_t* __rwlock, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_clockrdlock(pthread_rwlock_t* __rwlock, clockid_t __clockid, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_wrlock(pthread_rwlock_t* __rwlock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_trywrlock(pthread_rwlock_t* __rwlock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_timedwrlock(pthread_rwlock_t* __rwlock, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_clockwrlock(pthread_rwlock_t* __rwlock, clockid_t __clockid, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlock_unlock(pthread_rwlock_t* __rwlock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlockattr_init(pthread_rwlockattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlockattr_destroy(pthread_rwlockattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlockattr_getpshared([NativeTypeName("const pthread_rwlockattr_t *")] pthread_rwlockattr_t* __attr, int* __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlockattr_setpshared(pthread_rwlockattr_t* __attr, int __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlockattr_getkind_np([NativeTypeName("const pthread_rwlockattr_t *")] pthread_rwlockattr_t* __attr, int* __pref);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_rwlockattr_setkind_np(pthread_rwlockattr_t* __attr, int __pref);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_cond_init(pthread_cond_t* __cond, [NativeTypeName("const pthread_condattr_t *")] pthread_condattr_t* __cond_attr);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_cond_destroy(pthread_cond_t* __cond);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_cond_signal(pthread_cond_t* __cond);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_cond_broadcast(pthread_cond_t* __cond);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_cond_wait(pthread_cond_t* __cond, pthread_mutex_t* __mutex);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_cond_timedwait(pthread_cond_t* __cond, pthread_mutex_t* __mutex, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_cond_clockwait(pthread_cond_t* __cond, pthread_mutex_t* __mutex, [NativeTypeName("__clockid_t")] clockid_t __clock_id, [NativeTypeName("const struct timespec*")] timespec* __abstime);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_condattr_init(pthread_condattr_t* __attr);

    [DllImport("libc", ExactSpelling = true)]
    public static extern int pthread_condattr_destroy(pthread_condattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_condattr_getpshared([NativeTypeName("const pthread_condattr_t *")] pthread_condattr_t* __attr, int* __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_condattr_setpshared(pthread_condattr_t* __attr, int __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_condattr_getclock([NativeTypeName("const pthread_condattr_t *")] pthread_condattr_t* __attr, [NativeTypeName("__clockid_t *")] clockid_t* __clock_id);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_condattr_setclock(pthread_condattr_t* __attr, [NativeTypeName("__clockid_t")] clockid_t __clock_id);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_spin_init(pthread_spinlock_t* __lock, int __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_spin_destroy(pthread_spinlock_t* __lock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_spin_lock(pthread_spinlock_t* __lock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_spin_trylock(pthread_spinlock_t* __lock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_spin_unlock(pthread_spinlock_t* __lock);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_barrier_init(pthread_barrier_t* __barrier, [NativeTypeName("const pthread_barrierattr_t *")] pthread_barrierattr_t* __attr, [NativeTypeName("unsigned int")] uint __count);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_barrier_destroy(pthread_barrier_t* __barrier);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_barrier_wait(pthread_barrier_t* __barrier);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_barrierattr_init(pthread_barrierattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_barrierattr_destroy(pthread_barrierattr_t* __attr);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_barrierattr_getpshared([NativeTypeName("const pthread_barrierattr_t *")] pthread_barrierattr_t* __attr, int* __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_barrierattr_setpshared(pthread_barrierattr_t* __attr, int __pshared);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_key_create(pthread_key_t* __key, delegate* unmanaged<void*, void> __destr_function);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_key_delete(pthread_key_t __key);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern void* pthread_getspecific(pthread_key_t __key);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_setspecific(pthread_key_t __key, [NativeTypeName("const void *")] void* __pointer);

    [DllImport("libpthread", ExactSpelling = true)]
    public static extern int pthread_getcpuclockid(pthread_t __thread_id, [NativeTypeName("__clockid_t *")] clockid_t* __clock_id);
}
