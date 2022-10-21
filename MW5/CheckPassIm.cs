using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace emlic
{
    public class CheckPassIm
    {
        [DllImport("makepass.dll", EntryPoint = "verifyLicFile", CallingConvention = CallingConvention.Cdecl)]
        public extern static int verifyLicFile(string licfile, string content, string publickeypath);
               
        [DllImport("makepass.dll", EntryPoint = "decryptLicFile", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr decryptLicFile(string licfile, string publickeypath);

        [DllImport("diskid32.dll", EntryPoint = "getDisk0PhysicalSerial", CallingConvention = CallingConvention.StdCall, SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false)]
        public extern static IntPtr getDisk0PhysicalSerial();

        public static string trialtime;
        private static string diskserial;

        public static string Diskserial { get => Marshal.PtrToStringAnsi(getDisk0PhysicalSerial()); }

        //此处换成 自己的加密
        //0:正式许可  1:试用许可,状态正常 11:试用许可,已经过期    2:许可错误  3:系统文件丢失  4:许可文件不存在
        //true:许可OK  false:许可错误
        public static string getisok() //注册需要修改的地方===
        {
            try
            {
                IntPtr szdiskserial = getDisk0PhysicalSerial();
                diskserial = Marshal.PtrToStringAnsi(szdiskserial);

                string licFile = GetDLLPath() + "verifyLic/em.lic";
                string pubkeyfile = GetDLLPath() + "verifyLic/em-lic.key";
                string makepass = GetDLLPath() + "makepass.dll";
                string disk0serial = GetDLLPath() + "diskid32.dll";
                if (!File.Exists(licFile))
                {
                    return "缺少授权文件。\n";
                }

                if (!File.Exists(pubkeyfile) || !File.Exists(makepass) || !File.Exists(disk0serial))
                {
                    return "系统文件丢失，加载库失败\n";
                }

                IntPtr szdecrypt = decryptLicFile(licFile, pubkeyfile);
                string decrypt = Marshal.PtrToStringAnsi(szdecrypt);
                if (decrypt == null)
                {
                    return "授权文件不匹配";
                }
                if (decrypt.CompareTo(Diskserial) == 0)
                    return string.Empty;
                string starwith = Diskserial + "@";
                if (decrypt.StartsWith(starwith)){
                    string time =  decrypt.Substring(starwith.Length);
                    DateTime lictime = new DateTime();
                    bool b0 = DateTime.TryParse(time,out lictime);
                    if (b0) {
                        System.DateTime currentTime = new System.DateTime();
                        if (currentTime < lictime)
                            return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "授权检查失败!";
        }

        
        public static string GetDLLPath()
        {
            string _CodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;

            _CodeBase = _CodeBase.Substring(8, _CodeBase.Length - 8);    // 8是 file:// 的长度

            string[] arrSection = _CodeBase.Split(new char[] { '/' });

            string _FolderPath = "";
            for (int i = 0; i < arrSection.Length - 1; i++)
            {
                _FolderPath += arrSection[i] + "/";
            }

            return _FolderPath;
        }


    }
}
