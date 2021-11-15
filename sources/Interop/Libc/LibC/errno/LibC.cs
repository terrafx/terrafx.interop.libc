// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/errno.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.LibC
{
    public static unsafe partial class LibC
    {
        [DllImport("libc", ExactSpelling = true)]
        public static extern int* __errno_location();

        [NativeTypeName("#define EPERM 1")]
        public const int EPERM = 1;

        [NativeTypeName("#define ENOENT 2")]
        public const int ENOENT = 2;

        [NativeTypeName("#define ESRCH 3")]
        public const int ESRCH = 3;

        [NativeTypeName("#define EINTR 4")]
        public const int EINTR = 4;

        [NativeTypeName("#define EIO 5")]
        public const int EIO = 5;

        [NativeTypeName("#define ENXIO 6")]
        public const int ENXIO = 6;

        [NativeTypeName("#define E2BIG 7")]
        public const int E2BIG = 7;

        [NativeTypeName("#define ENOEXEC 8")]
        public const int ENOEXEC = 8;

        [NativeTypeName("#define EBADF 9")]
        public const int EBADF = 9;

        [NativeTypeName("#define ECHILD 10")]
        public const int ECHILD = 10;

        [NativeTypeName("#define EAGAIN 11")]
        public const int EAGAIN = 11;

        [NativeTypeName("#define ENOMEM 12")]
        public const int ENOMEM = 12;

        [NativeTypeName("#define EACCES 13")]
        public const int EACCES = 13;

        [NativeTypeName("#define EFAULT 14")]
        public const int EFAULT = 14;

        [NativeTypeName("#define ENOTBLK 15")]
        public const int ENOTBLK = 15;

        [NativeTypeName("#define EBUSY 16")]
        public const int EBUSY = 16;

        [NativeTypeName("#define EEXIST 17")]
        public const int EEXIST = 17;

        [NativeTypeName("#define EXDEV 18")]
        public const int EXDEV = 18;

        [NativeTypeName("#define ENODEV 19")]
        public const int ENODEV = 19;

        [NativeTypeName("#define ENOTDIR 20")]
        public const int ENOTDIR = 20;

        [NativeTypeName("#define EISDIR 21")]
        public const int EISDIR = 21;

        [NativeTypeName("#define EINVAL 22")]
        public const int EINVAL = 22;

        [NativeTypeName("#define ENFILE 23")]
        public const int ENFILE = 23;

        [NativeTypeName("#define EMFILE 24")]
        public const int EMFILE = 24;

        [NativeTypeName("#define ENOTTY 25")]
        public const int ENOTTY = 25;

        [NativeTypeName("#define ETXTBSY 26")]
        public const int ETXTBSY = 26;

        [NativeTypeName("#define EFBIG 27")]
        public const int EFBIG = 27;

        [NativeTypeName("#define ENOSPC 28")]
        public const int ENOSPC = 28;

        [NativeTypeName("#define ESPIPE 29")]
        public const int ESPIPE = 29;

        [NativeTypeName("#define EROFS 30")]
        public const int EROFS = 30;

        [NativeTypeName("#define EMLINK 31")]
        public const int EMLINK = 31;

        [NativeTypeName("#define EPIPE 32")]
        public const int EPIPE = 32;

        [NativeTypeName("#define EDOM 33")]
        public const int EDOM = 33;

        [NativeTypeName("#define ERANGE 34")]
        public const int ERANGE = 34;

        [NativeTypeName("#define EDEADLK 35")]
        public const int EDEADLK = 35;

        [NativeTypeName("#define ENAMETOOLONG 36")]
        public const int ENAMETOOLONG = 36;

        [NativeTypeName("#define ENOLCK 37")]
        public const int ENOLCK = 37;

        [NativeTypeName("#define ENOSYS 38")]
        public const int ENOSYS = 38;

        [NativeTypeName("#define ENOTEMPTY 39")]
        public const int ENOTEMPTY = 39;

        [NativeTypeName("#define ELOOP 40")]
        public const int ELOOP = 40;

        [NativeTypeName("#define EWOULDBLOCK EAGAIN")]
        public const int EWOULDBLOCK = 11;

        [NativeTypeName("#define ENOMSG 42")]
        public const int ENOMSG = 42;

        [NativeTypeName("#define EIDRM 43")]
        public const int EIDRM = 43;

        [NativeTypeName("#define ECHRNG 44")]
        public const int ECHRNG = 44;

        [NativeTypeName("#define EL2NSYNC 45")]
        public const int EL2NSYNC = 45;

        [NativeTypeName("#define EL3HLT 46")]
        public const int EL3HLT = 46;

        [NativeTypeName("#define EL3RST 47")]
        public const int EL3RST = 47;

        [NativeTypeName("#define ELNRNG 48")]
        public const int ELNRNG = 48;

        [NativeTypeName("#define EUNATCH 49")]
        public const int EUNATCH = 49;

        [NativeTypeName("#define ENOCSI 50")]
        public const int ENOCSI = 50;

        [NativeTypeName("#define EL2HLT 51")]
        public const int EL2HLT = 51;

        [NativeTypeName("#define EBADE 52")]
        public const int EBADE = 52;

        [NativeTypeName("#define EBADR 53")]
        public const int EBADR = 53;

        [NativeTypeName("#define EXFULL 54")]
        public const int EXFULL = 54;

        [NativeTypeName("#define ENOANO 55")]
        public const int ENOANO = 55;

        [NativeTypeName("#define EBADRQC 56")]
        public const int EBADRQC = 56;

        [NativeTypeName("#define EBADSLT 57")]
        public const int EBADSLT = 57;

        [NativeTypeName("#define EDEADLOCK EDEADLK")]
        public const int EDEADLOCK = 35;

        [NativeTypeName("#define EBFONT 59")]
        public const int EBFONT = 59;

        [NativeTypeName("#define ENOSTR 60")]
        public const int ENOSTR = 60;

        [NativeTypeName("#define ENODATA 61")]
        public const int ENODATA = 61;

        [NativeTypeName("#define ETIME 62")]
        public const int ETIME = 62;

        [NativeTypeName("#define ENOSR 63")]
        public const int ENOSR = 63;

        [NativeTypeName("#define ENONET 64")]
        public const int ENONET = 64;

        [NativeTypeName("#define ENOPKG 65")]
        public const int ENOPKG = 65;

        [NativeTypeName("#define EREMOTE 66")]
        public const int EREMOTE = 66;

        [NativeTypeName("#define ENOLINK 67")]
        public const int ENOLINK = 67;

        [NativeTypeName("#define EADV 68")]
        public const int EADV = 68;

        [NativeTypeName("#define ESRMNT 69")]
        public const int ESRMNT = 69;

        [NativeTypeName("#define ECOMM 70")]
        public const int ECOMM = 70;

        [NativeTypeName("#define EPROTO 71")]
        public const int EPROTO = 71;

        [NativeTypeName("#define EMULTIHOP 72")]
        public const int EMULTIHOP = 72;

        [NativeTypeName("#define EDOTDOT 73")]
        public const int EDOTDOT = 73;

        [NativeTypeName("#define EBADMSG 74")]
        public const int EBADMSG = 74;

        [NativeTypeName("#define EOVERFLOW 75")]
        public const int EOVERFLOW = 75;

        [NativeTypeName("#define ENOTUNIQ 76")]
        public const int ENOTUNIQ = 76;

        [NativeTypeName("#define EBADFD 77")]
        public const int EBADFD = 77;

        [NativeTypeName("#define EREMCHG 78")]
        public const int EREMCHG = 78;

        [NativeTypeName("#define ELIBACC 79")]
        public const int ELIBACC = 79;

        [NativeTypeName("#define ELIBBAD 80")]
        public const int ELIBBAD = 80;

        [NativeTypeName("#define ELIBSCN 81")]
        public const int ELIBSCN = 81;

        [NativeTypeName("#define ELIBMAX 82")]
        public const int ELIBMAX = 82;

        [NativeTypeName("#define ELIBEXEC 83")]
        public const int ELIBEXEC = 83;

        [NativeTypeName("#define EILSEQ 84")]
        public const int EILSEQ = 84;

        [NativeTypeName("#define ERESTART 85")]
        public const int ERESTART = 85;

        [NativeTypeName("#define ESTRPIPE 86")]
        public const int ESTRPIPE = 86;

        [NativeTypeName("#define EUSERS 87")]
        public const int EUSERS = 87;

        [NativeTypeName("#define ENOTSOCK 88")]
        public const int ENOTSOCK = 88;

        [NativeTypeName("#define EDESTADDRREQ 89")]
        public const int EDESTADDRREQ = 89;

        [NativeTypeName("#define EMSGSIZE 90")]
        public const int EMSGSIZE = 90;

        [NativeTypeName("#define EPROTOTYPE 91")]
        public const int EPROTOTYPE = 91;

        [NativeTypeName("#define ENOPROTOOPT 92")]
        public const int ENOPROTOOPT = 92;

        [NativeTypeName("#define EPROTONOSUPPORT 93")]
        public const int EPROTONOSUPPORT = 93;

        [NativeTypeName("#define ESOCKTNOSUPPORT 94")]
        public const int ESOCKTNOSUPPORT = 94;

        [NativeTypeName("#define EOPNOTSUPP 95")]
        public const int EOPNOTSUPP = 95;

        [NativeTypeName("#define EPFNOSUPPORT 96")]
        public const int EPFNOSUPPORT = 96;

        [NativeTypeName("#define EAFNOSUPPORT 97")]
        public const int EAFNOSUPPORT = 97;

        [NativeTypeName("#define EADDRINUSE 98")]
        public const int EADDRINUSE = 98;

        [NativeTypeName("#define EADDRNOTAVAIL 99")]
        public const int EADDRNOTAVAIL = 99;

        [NativeTypeName("#define ENETDOWN 100")]
        public const int ENETDOWN = 100;

        [NativeTypeName("#define ENETUNREACH 101")]
        public const int ENETUNREACH = 101;

        [NativeTypeName("#define ENETRESET 102")]
        public const int ENETRESET = 102;

        [NativeTypeName("#define ECONNABORTED 103")]
        public const int ECONNABORTED = 103;

        [NativeTypeName("#define ECONNRESET 104")]
        public const int ECONNRESET = 104;

        [NativeTypeName("#define ENOBUFS 105")]
        public const int ENOBUFS = 105;

        [NativeTypeName("#define EISCONN 106")]
        public const int EISCONN = 106;

        [NativeTypeName("#define ENOTCONN 107")]
        public const int ENOTCONN = 107;

        [NativeTypeName("#define ESHUTDOWN 108")]
        public const int ESHUTDOWN = 108;

        [NativeTypeName("#define ETOOMANYREFS 109")]
        public const int ETOOMANYREFS = 109;

        [NativeTypeName("#define ETIMEDOUT 110")]
        public const int ETIMEDOUT = 110;

        [NativeTypeName("#define ECONNREFUSED 111")]
        public const int ECONNREFUSED = 111;

        [NativeTypeName("#define EHOSTDOWN 112")]
        public const int EHOSTDOWN = 112;

        [NativeTypeName("#define EHOSTUNREACH 113")]
        public const int EHOSTUNREACH = 113;

        [NativeTypeName("#define EALREADY 114")]
        public const int EALREADY = 114;

        [NativeTypeName("#define EINPROGRESS 115")]
        public const int EINPROGRESS = 115;

        [NativeTypeName("#define ESTALE 116")]
        public const int ESTALE = 116;

        [NativeTypeName("#define EUCLEAN 117")]
        public const int EUCLEAN = 117;

        [NativeTypeName("#define ENOTNAM 118")]
        public const int ENOTNAM = 118;

        [NativeTypeName("#define ENAVAIL 119")]
        public const int ENAVAIL = 119;

        [NativeTypeName("#define EISNAM 120")]
        public const int EISNAM = 120;

        [NativeTypeName("#define EREMOTEIO 121")]
        public const int EREMOTEIO = 121;

        [NativeTypeName("#define EDQUOT 122")]
        public const int EDQUOT = 122;

        [NativeTypeName("#define ENOMEDIUM 123")]
        public const int ENOMEDIUM = 123;

        [NativeTypeName("#define EMEDIUMTYPE 124")]
        public const int EMEDIUMTYPE = 124;

        [NativeTypeName("#define ECANCELED 125")]
        public const int ECANCELED = 125;

        [NativeTypeName("#define ENOKEY 126")]
        public const int ENOKEY = 126;

        [NativeTypeName("#define EKEYEXPIRED 127")]
        public const int EKEYEXPIRED = 127;

        [NativeTypeName("#define EKEYREVOKED 128")]
        public const int EKEYREVOKED = 128;

        [NativeTypeName("#define EKEYREJECTED 129")]
        public const int EKEYREJECTED = 129;

        [NativeTypeName("#define EOWNERDEAD 130")]
        public const int EOWNERDEAD = 130;

        [NativeTypeName("#define ENOTRECOVERABLE 131")]
        public const int ENOTRECOVERABLE = 131;

        [NativeTypeName("#define ERFKILL 132")]
        public const int ERFKILL = 132;

        [NativeTypeName("#define EHWPOISON 133")]
        public const int EHWPOISON = 133;

        [NativeTypeName("#define ENOTSUP EOPNOTSUPP")]
        public const int ENOTSUP = 95;

        [NativeTypeName("#define errno (*__errno_location ())")]
        public static int errno => (*__errno_location());
    }
}
