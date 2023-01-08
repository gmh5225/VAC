using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VAC.InternalDedection
{
    public static class AntiInject
    {
        static class imports
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern IntPtr GetModuleHandle(string lib);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern IntPtr GetProcAddress(IntPtr ModuleHandle, string Function);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool WriteProcessMemory(IntPtr ProcHandle, IntPtr BaseAddress, byte[] Buffer, uint size, int NumOfBytes);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool SetProcessMitigationPolicy(int policy, ref Structs.PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY lpBuffer, int size);
        }

        public static string PatchLoadLibraryA()
        {
            IntPtr KernelModule = imports.GetModuleHandle("kernelbase.dll");
            IntPtr LoadLibraryA = imports.GetProcAddress(KernelModule, "LoadLibraryA");
            byte[] HookedCode = { 0xC2, 0x04, 0x00 };
            bool Status = imports.WriteProcessMemory(Process.GetCurrentProcess().Handle /*current process yerine csgo..*/, LoadLibraryA, HookedCode, 3, 0);
            if (Status)
                return "Success";
            return "Failed";
        }

        public static string PatchLoadLibraryW()
        {
            IntPtr KernelModule = imports.GetModuleHandle("kernelbase.dll");
            IntPtr LoadLibraryW = imports.GetProcAddress(KernelModule, "LoadLibraryW");
            byte[] HookedCode = { 0xC2, 0x04, 0x00 };
            bool Status = imports.WriteProcessMemory(Process.GetCurrentProcess().Handle /*current process yerine csgo..*/, LoadLibraryW, HookedCode, 3, 0);
            if (Status)
                return "Success";
            return "Failed";
        }

        public static string BinaryImageSignatureMitigationAntiDllInjection()
        {
            Structs.PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY OnlyMicrosoftBinaries = new Structs.PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY();
            OnlyMicrosoftBinaries.MicrosoftSignedOnly = 1;
            if (imports.SetProcessMitigationPolicy(8, ref OnlyMicrosoftBinaries, Marshal.SizeOf(typeof(Structs.PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY))))
                return "Success";
            return "Failed";
        }

        public static void patch()
        {
            PatchLoadLibraryA();
            PatchLoadLibraryW();
            BinaryImageSignatureMitigationAntiDllInjection();
        }
    }
}
