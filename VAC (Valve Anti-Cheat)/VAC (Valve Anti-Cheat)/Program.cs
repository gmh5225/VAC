using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAC.InternalDedection;
using VAC.UserInformation;
using static VAC.ConsoleHelper;

namespace VAC
{
    public static class Program
    {
        public static void Main()
        {
            Title("VAC");

            new Thread(() =>
            {
                Scan.Do();
                AntiInject.patch();
            }).Start();
            Console.ReadKey();

            if (!IsAdministor.check())
            {
                Warning("Restarting as administor...");
                Thread.Sleep(1600);
                RestartAsAdministor.Start();
            }

            new Thread(() =>
            {
                ScanProcess.Do();
            }).Start();

            new Thread(() =>
            {
                AimbotDedection.Control.Do();
            }).Start();
        }






        /*
        // REQUIRED CONSTS

        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int MEM_COMMIT = 0x00001000;
        const int PAGE_READWRITE = 0x04;
        const int PROCESS_WM_READ = 0x0010;

        // REQUIRED METHODS

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess
             (int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory
        (int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int VirtualQueryEx(IntPtr hProcess,
        IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);


        // REQUIRED STRUCTS

        public struct MEMORY_BASIC_INFORMATION
        {
            public int BaseAddress;
            public int AllocationBase;
            public int AllocationProtect;
            public int RegionSize;
            public int State;
            public int Protect;
            public int lType;
        }

        public struct SYSTEM_INFO
        {
            public ushort processorArchitecture;
            ushort reserved;
            public uint pageSize;
            public IntPtr minimumApplicationAddress;
            public IntPtr maximumApplicationAddress;
            public IntPtr activeProcessorMask;
            public uint numberOfProcessors;
            public uint processorType;
            public uint allocationGranularity;
            public ushort processorLevel;
            public ushort processorRevision;
        }

        public static void test()
        {
            SYSTEM_INFO sys_info = new SYSTEM_INFO();
            GetSystemInfo(out sys_info);

            IntPtr proc_min_address = sys_info.minimumApplicationAddress;

            // notepad better be runnin'
            Process process = Process.GetProcessesByName("csgo")[0];
            if (process.Id == 0) Console.WriteLine("Error");

            // opening the process with desired access level
            IntPtr processHandle =
            OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_WM_READ, false, process.Id);

            StreamWriter sw = new StreamWriter("dump.txt");

            // this will store any information we get from VirtualQueryEx()
            MEMORY_BASIC_INFORMATION mem_basic_info = new MEMORY_BASIC_INFORMATION();

            int bytesRead = 0;  // number of bytes read with ReadProcessMemory

            // 28 = sizeof(MEMORY_BASIC_INFORMATION)
            VirtualQueryEx(processHandle, proc_min_address, out mem_basic_info, 28);

            byte[] buffer = new byte[mem_basic_info.RegionSize];

            // read everything in the buffer above
            ReadProcessMemory((int)processHandle,
            mem_basic_info.BaseAddress, buffer, mem_basic_info.RegionSize, ref bytesRead);

            Console.WriteLine("mem_basic_info.BaseAddress: " + mem_basic_info.BaseAddress);
            Console.WriteLine("1: " + mem_basic_info.AllocationBase);
            Console.WriteLine("2: " + mem_basic_info.RegionSize);
            Console.WriteLine("3: " + mem_basic_info.Protect);
            Console.WriteLine("4: " + mem_basic_info.AllocationProtect);
            Console.WriteLine("5: " + mem_basic_info.State);

            BinaryReader br = new BinaryReader(File.OpenRead("C:\\csgo.exe"));
            byte[] buf = br.ReadBytes(4);
            Array.Reverse(buf);
            string test;
            test = (BitConverter.ToInt32(buf, 0).ToString("X"));
            sw.WriteLine(test);
            br.Dispose();

            sw.Close();

            Console.ReadLine();
        }
        */
    }
}
