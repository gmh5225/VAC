using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace VAC.UserInformation
{
    public static class DISCorUSB
    {
        public static string Get()
        {
            ManagementObjectSearcher Drive = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection GetDrive = Drive.Get();

            foreach (ManagementObject GetHWID in GetDrive)
            {
                return GetHWID["Model"].ToString() + GetHWID["SerialNumber"].ToString() + GetHWID["Signature"].ToString() + GetHWID["Manufacturer"].ToString();
            }

            return null;
        }
    }
}
