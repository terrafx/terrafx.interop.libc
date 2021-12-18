// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from /usr/include/time.h and corresponding dependencies of Ubuntu 20.04
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
        public static extern int clock_adjtime(clockid_t __clock_id, [NativeTypeName("struct timex *")] timex* __utx);

        [DllImport("libc", ExactSpelling = true)]
        public static extern clock_t clock();

        [DllImport("libc", ExactSpelling = true)]
        public static extern time_t time(time_t* __timer);

        [DllImport("libc", ExactSpelling = true)]
        public static extern double difftime(time_t __time1, time_t __time0);

        [DllImport("libc", ExactSpelling = true)]
        public static extern time_t mktime([NativeTypeName("struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strftime([NativeTypeName("char *")] sbyte* __s, [NativeTypeName("size_t")] nuint __maxsize, [NativeTypeName("const char *")] sbyte* __format, [NativeTypeName("const struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strptime([NativeTypeName("const char *")] sbyte* __s, [NativeTypeName("const char *")] sbyte* __fmt, [NativeTypeName("struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strftime_l([NativeTypeName("char *")] sbyte* __s, [NativeTypeName("size_t")] nuint __maxsize, [NativeTypeName("const char *")] sbyte* __format, [NativeTypeName("const struct tm *")] tm* __tp, locale_t __loc);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strptime_l([NativeTypeName("const char *")] sbyte* __s, [NativeTypeName("const char *")] sbyte* __fmt, [NativeTypeName("struct tm *")] tm* __tp, locale_t __loc);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("struct tm *")]
        public static extern tm* gmtime([NativeTypeName("const time_t *")] time_t* __timer);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("struct tm *")]
        public static extern tm* localtime([NativeTypeName("const time_t *")] time_t* __timer);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("struct tm *")]
        public static extern tm* gmtime_r([NativeTypeName("const time_t *")] time_t* __timer, [NativeTypeName("struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("struct tm *")]
        public static extern tm* localtime_r([NativeTypeName("const time_t *")] time_t* __timer, [NativeTypeName("struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* asctime([NativeTypeName("const struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* ctime([NativeTypeName("const time_t *")] time_t* __timer);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* asctime_r([NativeTypeName("const struct tm *")] tm* __tp, [NativeTypeName("char *")] sbyte* __buf);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* ctime_r([NativeTypeName("const time_t *")] time_t* __timer, [NativeTypeName("char *")] sbyte* __buf);

        [DllImport("libc", ExactSpelling = true)]
        public static extern void tzset();

        [DllImport("libc", ExactSpelling = true)]
        public static extern time_t timegm([NativeTypeName("struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern time_t timelocal([NativeTypeName("struct tm *")] tm* __tp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int dysize(int __year);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int nanosleep([NativeTypeName("const struct timespec *")] timespec* __requested_time, [NativeTypeName("struct timespec *")] timespec* __remaining);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int clock_getres(clockid_t __clock_id, [NativeTypeName("struct timespec *")] timespec* __res);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int clock_gettime(clockid_t __clock_id, [NativeTypeName("struct timespec *")] timespec* __tp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int clock_settime(clockid_t __clock_id, [NativeTypeName("const struct timespec *")] timespec* __tp);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int clock_nanosleep(clockid_t __clock_id, int __flags, [NativeTypeName("const struct timespec *")] timespec* __req, [NativeTypeName("struct timespec *")] timespec* __rem);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int clock_getcpuclockid(pid_t __pid, clockid_t* __clock_id);

        [DllImport("librt", ExactSpelling = true)]
        public static extern int timer_create(clockid_t __clock_id, [NativeTypeName("struct sigevent *")] sigevent_t* __evp, timer_t* __timerid);

        [DllImport("librt", ExactSpelling = true)]
        public static extern int timer_delete(timer_t __timerid);

        [DllImport("librt", ExactSpelling = true)]
        public static extern int timer_settime(timer_t __timerid, int __flags, [NativeTypeName("const struct itimerspec *")] itimerspec* __value, [NativeTypeName("struct itimerspec *")] itimerspec* __ovalue);

        [DllImport("librt", ExactSpelling = true)]
        public static extern int timer_gettime(timer_t __timerid, [NativeTypeName("struct itimerspec *")] itimerspec* __value);

        [DllImport("librt", ExactSpelling = true)]
        public static extern int timer_getoverrun(timer_t __timerid);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int timespec_get([NativeTypeName("struct timespec *")] timespec* __ts, int __base);

        [DllImport("libc", ExactSpelling = true)]
        [return: NativeTypeName("struct tm *")]
        public static extern tm* getdate([NativeTypeName("const char *")] sbyte* __string);

        [DllImport("libc", ExactSpelling = true)]
        public static extern int getdate_r([NativeTypeName("const char *")] sbyte* __string, [NativeTypeName("struct tm *")] tm* __resbufp);

        [NativeTypeName("#define CLOCKS_PER_SEC ((__clock_t) 1000000)")]
        public static clock_t CLOCKS_PER_SEC => ((clock_t)(1000000));

        [NativeTypeName("#define CLOCK_REALTIME 0")]
        public const int CLOCK_REALTIME = 0;

        [NativeTypeName("#define CLOCK_MONOTONIC 1")]
        public const int CLOCK_MONOTONIC = 1;

        [NativeTypeName("#define CLOCK_PROCESS_CPUTIME_ID 2")]
        public const int CLOCK_PROCESS_CPUTIME_ID = 2;

        [NativeTypeName("#define CLOCK_THREAD_CPUTIME_ID 3")]
        public const int CLOCK_THREAD_CPUTIME_ID = 3;

        [NativeTypeName("#define CLOCK_MONOTONIC_RAW 4")]
        public const int CLOCK_MONOTONIC_RAW = 4;

        [NativeTypeName("#define CLOCK_REALTIME_COARSE 5")]
        public const int CLOCK_REALTIME_COARSE = 5;

        [NativeTypeName("#define CLOCK_MONOTONIC_COARSE 6")]
        public const int CLOCK_MONOTONIC_COARSE = 6;

        [NativeTypeName("#define CLOCK_BOOTTIME 7")]
        public const int CLOCK_BOOTTIME = 7;

        [NativeTypeName("#define CLOCK_REALTIME_ALARM 8")]
        public const int CLOCK_REALTIME_ALARM = 8;

        [NativeTypeName("#define CLOCK_BOOTTIME_ALARM 9")]
        public const int CLOCK_BOOTTIME_ALARM = 9;

        [NativeTypeName("#define CLOCK_TAI 11")]
        public const int CLOCK_TAI = 11;

        [NativeTypeName("#define TIMER_ABSTIME 1")]
        public const int TIMER_ABSTIME = 1;

        [NativeTypeName("#define ADJ_OFFSET 0x0001")]
        public const int ADJ_OFFSET = 0x0001;

        [NativeTypeName("#define ADJ_FREQUENCY 0x0002")]
        public const int ADJ_FREQUENCY = 0x0002;

        [NativeTypeName("#define ADJ_MAXERROR 0x0004")]
        public const int ADJ_MAXERROR = 0x0004;

        [NativeTypeName("#define ADJ_ESTERROR 0x0008")]
        public const int ADJ_ESTERROR = 0x0008;

        [NativeTypeName("#define ADJ_STATUS 0x0010")]
        public const int ADJ_STATUS = 0x0010;

        [NativeTypeName("#define ADJ_TIMECONST 0x0020")]
        public const int ADJ_TIMECONST = 0x0020;

        [NativeTypeName("#define ADJ_TAI 0x0080")]
        public const int ADJ_TAI = 0x0080;

        [NativeTypeName("#define ADJ_SETOFFSET 0x0100")]
        public const int ADJ_SETOFFSET = 0x0100;

        [NativeTypeName("#define ADJ_MICRO 0x1000")]
        public const int ADJ_MICRO = 0x1000;

        [NativeTypeName("#define ADJ_NANO 0x2000")]
        public const int ADJ_NANO = 0x2000;

        [NativeTypeName("#define ADJ_TICK 0x4000")]
        public const int ADJ_TICK = 0x4000;

        [NativeTypeName("#define ADJ_OFFSET_SINGLESHOT 0x8001")]
        public const int ADJ_OFFSET_SINGLESHOT = 0x8001;

        [NativeTypeName("#define ADJ_OFFSET_SS_READ 0xa001")]
        public const int ADJ_OFFSET_SS_READ = 0xa001;

        [NativeTypeName("#define MOD_OFFSET ADJ_OFFSET")]
        public const int MOD_OFFSET = 0x0001;

        [NativeTypeName("#define MOD_FREQUENCY ADJ_FREQUENCY")]
        public const int MOD_FREQUENCY = 0x0002;

        [NativeTypeName("#define MOD_MAXERROR ADJ_MAXERROR")]
        public const int MOD_MAXERROR = 0x0004;

        [NativeTypeName("#define MOD_ESTERROR ADJ_ESTERROR")]
        public const int MOD_ESTERROR = 0x0008;

        [NativeTypeName("#define MOD_STATUS ADJ_STATUS")]
        public const int MOD_STATUS = 0x0010;

        [NativeTypeName("#define MOD_TIMECONST ADJ_TIMECONST")]
        public const int MOD_TIMECONST = 0x0020;

        [NativeTypeName("#define MOD_CLKB ADJ_TICK")]
        public const int MOD_CLKB = 0x4000;

        [NativeTypeName("#define MOD_CLKA ADJ_OFFSET_SINGLESHOT")]
        public const int MOD_CLKA = 0x8001;

        [NativeTypeName("#define MOD_TAI ADJ_TAI")]
        public const int MOD_TAI = 0x0080;

        [NativeTypeName("#define MOD_MICRO ADJ_MICRO")]
        public const int MOD_MICRO = 0x1000;

        [NativeTypeName("#define MOD_NANO ADJ_NANO")]
        public const int MOD_NANO = 0x2000;

        [NativeTypeName("#define STA_PLL 0x0001")]
        public const int STA_PLL = 0x0001;

        [NativeTypeName("#define STA_PPSFREQ 0x0002")]
        public const int STA_PPSFREQ = 0x0002;

        [NativeTypeName("#define STA_PPSTIME 0x0004")]
        public const int STA_PPSTIME = 0x0004;

        [NativeTypeName("#define STA_FLL 0x0008")]
        public const int STA_FLL = 0x0008;

        [NativeTypeName("#define STA_INS 0x0010")]
        public const int STA_INS = 0x0010;

        [NativeTypeName("#define STA_DEL 0x0020")]
        public const int STA_DEL = 0x0020;

        [NativeTypeName("#define STA_UNSYNC 0x0040")]
        public const int STA_UNSYNC = 0x0040;

        [NativeTypeName("#define STA_FREQHOLD 0x0080")]
        public const int STA_FREQHOLD = 0x0080;

        [NativeTypeName("#define STA_PPSSIGNAL 0x0100")]
        public const int STA_PPSSIGNAL = 0x0100;

        [NativeTypeName("#define STA_PPSJITTER 0x0200")]
        public const int STA_PPSJITTER = 0x0200;

        [NativeTypeName("#define STA_PPSWANDER 0x0400")]
        public const int STA_PPSWANDER = 0x0400;

        [NativeTypeName("#define STA_PPSERROR 0x0800")]
        public const int STA_PPSERROR = 0x0800;

        [NativeTypeName("#define STA_CLOCKERR 0x1000")]
        public const int STA_CLOCKERR = 0x1000;

        [NativeTypeName("#define STA_NANO 0x2000")]
        public const int STA_NANO = 0x2000;

        [NativeTypeName("#define STA_MODE 0x4000")]
        public const int STA_MODE = 0x4000;

        [NativeTypeName("#define STA_CLK 0x8000")]
        public const int STA_CLK = 0x8000;

        [NativeTypeName("#define STA_RONLY (STA_PPSSIGNAL | STA_PPSJITTER | STA_PPSWANDER \\\n    | STA_PPSERROR | STA_CLOCKERR | STA_NANO | STA_MODE | STA_CLK)")]
        public const int STA_RONLY = (0x0100 | 0x0200 | 0x0400 | 0x0800 | 0x1000 | 0x2000 | 0x4000 | 0x8000);

        [NativeTypeName("#define TIME_UTC 1")]
        public const int TIME_UTC = 1;
    }
}
