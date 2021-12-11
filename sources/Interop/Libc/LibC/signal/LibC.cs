// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/signal.h and corresponding dependencies of Ubuntu 20.04
// Original source is Copyright © Free Software Foundation, Inc. Licensed under the GNU Lesser General Public License v2.1 or later.

// For the purposes of LGPL v3.0 this is a "Combined Work" where the "Application" (TerraFX.Interop.LibC) makes use of the "Library" (LibC)
// by dynamically linking to the "Library". The object code from of the "Application" incoroprates material from the source header files
// that are provided as part of the "Library" and is limited to numerical parameters, data structure layouts and accessors, small macros,
// and inline functions and templates (ten or fewer lines in length).

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    public static unsafe partial class LibC
    {
        public const int SI_ASYNCNL = -60;
        public const int SI_DETHREAD = -7;
        public const int SI_TKILL = -6;
        public const int SI_SIGIO = -5;
        public const int SI_ASYNCIO = -4;
        public const int SI_MESGQ = -3;
        public const int SI_TIMER = -2;
        public const int SI_QUEUE = -1;
        public const int SI_USER = 0;
        public const int SI_KERNEL = 0x80;

        public const uint ILL_ILLOPC = 1;
        public const uint ILL_ILLOPN = 2;
        public const uint ILL_ILLADR = 3;
        public const uint ILL_ILLTRP = 4;
        public const uint ILL_PRVOPC = 5;
        public const uint ILL_PRVREG = 6;
        public const uint ILL_COPROC = 7;
        public const uint ILL_BADSTK = 8;
        public const uint ILL_BADIADDR = 9;

        public const uint FPE_INTDIV = 1;
        public const uint FPE_INTOVF = 2;
        public const uint FPE_FLTDIV = 3;
        public const uint FPE_FLTOVF = 4;
        public const uint FPE_FLTUND = 5;
        public const uint FPE_FLTRES = 6;
        public const uint FPE_FLTINV = 7;
        public const uint FPE_FLTSUB = 8;
        public const uint FPE_FLTUNK = 14;
        public const uint FPE_CONDTRAP = 15;

        public const uint SEGV_MAPERR = 1;
        public const uint SEGV_ACCERR = 2;
        public const uint SEGV_BNDERR = 3;
        public const uint SEGV_PKUERR = 4;
        public const uint SEGV_ACCADI = 5;
        public const uint SEGV_ADIDERR = 6;
        public const uint SEGV_ADIPERR = 7;

        public const uint BUS_ADRALN = 1;
        public const uint BUS_ADRERR = 2;
        public const uint BUS_OBJERR = 3;
        public const uint BUS_MCEERR_AR = 4;
        public const uint BUS_MCEERR_AO = 5;

        public const uint TRAP_BRKPT = 1;
        public const uint TRAP_TRACE = 2;
        public const uint TRAP_BRANCH = 3;
        public const uint TRAP_HWBKPT = 4;
        public const uint TRAP_UNK = 5;

        public const uint CLD_EXITED = 1;
        public const uint CLD_KILLED = 2;
        public const uint CLD_DUMPED = 3;
        public const uint CLD_TRAPPED = 4;
        public const uint CLD_STOPPED = 5;
        public const uint CLD_CONTINUED = 6;

        public const uint POLL_IN = 1;
        public const uint POLL_OUT = 2;
        public const uint POLL_MSG = 3;
        public const uint POLL_ERR = 4;
        public const uint POLL_PRI = 5;
        public const uint POLL_HUP = 6;

        public const uint SIGEV_SIGNAL = 0;
        public const uint SIGEV_NONE = 1;
        public const uint SIGEV_THREAD = 2;
        public const uint SIGEV_THREAD_ID = 4;

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged<int, void> sysv_signal(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged<int, void> __handler);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged<int, void> signal(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged<int, void> __handler);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int kill([NativeTypeName("__pid_t")] int __pid, int __sig);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int killpg([NativeTypeName("__pid_t")] int __pgrp, int __sig);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int raise(int __sig);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged<int, void> ssignal(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged<int, void> __handler);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int gsignal(int __sig);

        [DllImport("libc", ExactSpelling = true)]
        public static extern void psignal(int __sig, [NativeTypeName("const char *")] sbyte* __s);

        [DllImport("libc", ExactSpelling = true)]
        public static extern void psiginfo([NativeTypeName("const siginfo_t *")] siginfo_t* __pinfo, [NativeTypeName("const char *")] sbyte* __s);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigpause(int __sig);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigblock(int __mask);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigsetmask(int __mask);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int siggetmask();

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigemptyset(sigset_t* __set);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigfillset(sigset_t* __set);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigaddset(sigset_t* __set, int __signo);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigdelset(sigset_t* __set, int __signo);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigismember([NativeTypeName("const sigset_t *")] sigset_t* __set, int __signo);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigisemptyset([NativeTypeName("const sigset_t *")] sigset_t* __set);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigandset(sigset_t* __set, [NativeTypeName("const sigset_t *")] sigset_t* __left, [NativeTypeName("const sigset_t *")] sigset_t* __right);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigorset(sigset_t* __set, [NativeTypeName("const sigset_t *")] sigset_t* __left, [NativeTypeName("const sigset_t *")] sigset_t* __right);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigprocmask(int __how, [NativeTypeName("const sigset_t *__restrict")] sigset_t* __set, [NativeTypeName("sigset_t *__restrict")] sigset_t* __oset);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigsuspend([NativeTypeName("const sigset_t *")] sigset_t* __set);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigaction(int __sig, [NativeTypeName("const struct sigaction *__restrict")] sigaction* __act, [NativeTypeName("struct sigaction *__restrict")] sigaction* __oact);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigpending(sigset_t* __set);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigwait([NativeTypeName("const sigset_t *__restrict")] sigset_t* __set, [NativeTypeName("int *__restrict")] int* __sig);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigwaitinfo([NativeTypeName("const sigset_t *__restrict")] sigset_t* __set, [NativeTypeName("siginfo_t *__restrict")] siginfo_t* __info);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigtimedwait([NativeTypeName("const sigset_t *__restrict")] sigset_t* __set, [NativeTypeName("siginfo_t *__restrict")] siginfo_t* __info, [NativeTypeName("const struct timespec *__restrict")] timespec* __timeout);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigqueue([NativeTypeName("__pid_t")] int __pid, int __sig, [NativeTypeName("const union sigval")] sigval_t __val);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigreturn([NativeTypeName("struct sigcontext *")] IntPtr __scp);

        public const uint REG_R8 = 0;
        public const uint REG_R9 = 1;
        public const uint REG_R10 = 2;
        public const uint REG_R11 = 3;
        public const uint REG_R12 = 4;
        public const uint REG_R13 = 5;
        public const uint REG_R14 = 6;
        public const uint REG_R15 = 7;
        public const uint REG_RDI = 8;
        public const uint REG_RSI = 9;
        public const uint REG_RBP = 10;
        public const uint REG_RBX = 11;
        public const uint REG_RDX = 12;
        public const uint REG_RAX = 13;
        public const uint REG_RCX = 14;
        public const uint REG_RSP = 15;
        public const uint REG_RIP = 16;
        public const uint REG_EFL = 17;
        public const uint REG_CSGSFS = 18;
        public const uint REG_ERR = 19;
        public const uint REG_TRAPNO = 20;
        public const uint REG_OLDMASK = 21;
        public const uint REG_CR2 = 22;

        [DllImport("libc", ExactSpelling = true)]
        public static extern int siginterrupt(int __sig, int __interrupt);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigaltstack([NativeTypeName("const stack_t *__restrict")] stack_t* __ss, [NativeTypeName("stack_t *__restrict")] stack_t* __oss);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sighold(int __sig);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigrelse(int __sig);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int sigignore(int __sig);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("__sighandler_t")]
        public static extern delegate* unmanaged<int, void> sigset(int __sig, [NativeTypeName("__sighandler_t")] delegate* unmanaged<int, void> __disp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int __libc_current_sigrtmin();

        [DllImport("libc", ExactSpelling = true)]
        public static extern int __libc_current_sigrtmax();

        [NativeTypeName("#define SIG_ERR ((__sighandler_t) -1)")]
        public static delegate* unmanaged<int, void> SIG_ERR => (delegate* unmanaged<int, void>)(-1);

        [NativeTypeName("#define SIG_DFL ((__sighandler_t)  0)")]
        public static delegate* unmanaged<int, void> SIG_DFL => (delegate* unmanaged<int, void>)(0);

        [NativeTypeName("#define SIG_IGN ((__sighandler_t)  1)")]
        public static delegate* unmanaged<int, void> SIG_IGN => (delegate* unmanaged<int, void>)(1);

        [NativeTypeName("#define SIG_HOLD ((__sighandler_t) 2)")]
        public static delegate* unmanaged<int, void> SIG_HOLD => (delegate* unmanaged<int, void>)(2);

        [NativeTypeName("#define SIGINT 2")]
        public const int SIGINT = 2;

        [NativeTypeName("#define SIGILL 4")]
        public const int SIGILL = 4;

        [NativeTypeName("#define SIGABRT 6")]
        public const int SIGABRT = 6;

        [NativeTypeName("#define SIGFPE 8")]
        public const int SIGFPE = 8;

        [NativeTypeName("#define SIGSEGV 11")]
        public const int SIGSEGV = 11;

        [NativeTypeName("#define SIGTERM 15")]
        public const int SIGTERM = 15;

        [NativeTypeName("#define SIGHUP 1")]
        public const int SIGHUP = 1;

        [NativeTypeName("#define SIGQUIT 3")]
        public const int SIGQUIT = 3;

        [NativeTypeName("#define SIGTRAP 5")]
        public const int SIGTRAP = 5;

        [NativeTypeName("#define SIGKILL 9")]
        public const int SIGKILL = 9;

        [NativeTypeName("#define SIGBUS 10")]
        public const int SIGBUS = 10;

        [NativeTypeName("#define SIGSYS 12")]
        public const int SIGSYS = 12;

        [NativeTypeName("#define SIGPIPE 13")]
        public const int SIGPIPE = 13;

        [NativeTypeName("#define SIGALRM 14")]
        public const int SIGALRM = 14;

        [NativeTypeName("#define SIGURG 16")]
        public const int SIGURG = 16;

        [NativeTypeName("#define SIGSTOP 17")]
        public const int SIGSTOP = 17;

        [NativeTypeName("#define SIGTSTP 18")]
        public const int SIGTSTP = 18;

        [NativeTypeName("#define SIGCONT 19")]
        public const int SIGCONT = 19;

        [NativeTypeName("#define SIGCHLD 20")]
        public const int SIGCHLD = 20;

        [NativeTypeName("#define SIGTTIN 21")]
        public const int SIGTTIN = 21;

        [NativeTypeName("#define SIGTTOU 22")]
        public const int SIGTTOU = 22;

        [NativeTypeName("#define SIGPOLL 23")]
        public const int SIGPOLL = 23;

        [NativeTypeName("#define SIGXCPU 24")]
        public const int SIGXCPU = 24;

        [NativeTypeName("#define SIGXFSZ 25")]
        public const int SIGXFSZ = 25;

        [NativeTypeName("#define SIGVTALRM 26")]
        public const int SIGVTALRM = 26;

        [NativeTypeName("#define SIGPROF 27")]
        public const int SIGPROF = 27;

        [NativeTypeName("#define SIGUSR1 30")]
        public const int SIGUSR1 = 30;

        [NativeTypeName("#define SIGUSR2 31")]
        public const int SIGUSR2 = 31;

        [NativeTypeName("#define SIGWINCH 28")]
        public const int SIGWINCH = 28;

        [NativeTypeName("#define SIGIO SIGPOLL")]
        public const int SIGIO = 29;

        [NativeTypeName("#define SIGIOT SIGABRT")]
        public const int SIGIOT = 6;

        [NativeTypeName("#define SIGCLD SIGCHLD")]
        public const int SIGCLD = 17;

        [NativeTypeName("#define SIGSTKFLT 16")]
        public const int SIGSTKFLT = 16;

        [NativeTypeName("#define SIGPWR 30")]
        public const int SIGPWR = 30;

        [NativeTypeName("#define NSIG _NSIG")]
        public const int NSIG = (64 + 1);

        [NativeTypeName("#define SA_NOCLDSTOP 1")]
        public const int SA_NOCLDSTOP = 1;

        [NativeTypeName("#define SA_NOCLDWAIT 2")]
        public const int SA_NOCLDWAIT = 2;

        [NativeTypeName("#define SA_SIGINFO 4")]
        public const int SA_SIGINFO = 4;

        [NativeTypeName("#define SA_ONSTACK 0x08000000")]
        public const int SA_ONSTACK = 0x08000000;

        [NativeTypeName("#define SA_RESTART 0x10000000")]
        public const int SA_RESTART = 0x10000000;

        [NativeTypeName("#define SA_NODEFER 0x40000000")]
        public const int SA_NODEFER = 0x40000000;

        [NativeTypeName("#define SA_RESETHAND 0x80000000")]
        public const uint SA_RESETHAND = 0x80000000;

        [NativeTypeName("#define SA_INTERRUPT 0x20000000")]
        public const int SA_INTERRUPT = 0x20000000;

        [NativeTypeName("#define SA_NOMASK SA_NODEFER")]
        public const int SA_NOMASK = 0x40000000;

        [NativeTypeName("#define SA_ONESHOT SA_RESETHAND")]
        public const uint SA_ONESHOT = 0x80000000;

        [NativeTypeName("#define SA_STACK SA_ONSTACK")]
        public const int SA_STACK = 0x08000000;

        [NativeTypeName("#define SIG_BLOCK 0")]
        public const int SIG_BLOCK = 0;

        [NativeTypeName("#define SIG_UNBLOCK 1")]
        public const int SIG_UNBLOCK = 1;

        [NativeTypeName("#define SIG_SETMASK 2")]
        public const int SIG_SETMASK = 2;

        [NativeTypeName("#define NGREG __NGREG")]
        public const int NGREG = 23;

        [NativeTypeName("#define SIGRTMIN (__libc_current_sigrtmin ())")]
        public static int SIGRTMIN => (__libc_current_sigrtmin());

        [NativeTypeName("#define SIGRTMAX (__libc_current_sigrtmax ())")]
        public static int SIGRTMAX => (__libc_current_sigrtmax());
    }
}
