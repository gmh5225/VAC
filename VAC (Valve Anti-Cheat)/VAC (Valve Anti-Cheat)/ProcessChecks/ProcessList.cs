using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAC.ProcessChecks;
using static VAC.Processes;
using static VAC.ConsoleHelper;
using System.Threading;

namespace VAC
{
    public static class ProcessList
    {
        public static void ScanAll()
        {
            rescan:

            for (Process[] processlist = Process.GetProcesses(); ;)
            {
                try
                {
                    _0 = processlist[0].ProcessName;
                    try { check(processlist[0].MainModule.FileName); } catch { }

                    _1 = processlist[1].ProcessName;
                    try { check(processlist[1].MainModule.FileName); } catch { }

                    _2 = processlist[2].ProcessName;
                    try { check(processlist[2].MainModule.FileName); } catch { }

                    _3 = processlist[3].ProcessName;
                    try { check(processlist[3].MainModule.FileName); } catch { }

                    _4 = processlist[4].ProcessName;
                    try { check(processlist[4].MainModule.FileName); } catch { }

                    _5 = processlist[5].ProcessName;
                    try { check(processlist[5].MainModule.FileName); } catch { }

                    _6 = processlist[6].ProcessName;
                    try { check(processlist[6].MainModule.FileName); } catch { }

                    _7 = processlist[7].ProcessName;
                    try { check(processlist[7].MainModule.FileName); } catch { }

                    _8 = processlist[8].ProcessName;
                    try { check(processlist[8].MainModule.FileName); } catch { }

                    _9 = processlist[9].ProcessName;
                    try { check(processlist[9].MainModule.FileName); } catch { }

                    _10 = processlist[10].ProcessName;
                    try { check(processlist[10].MainModule.FileName); } catch { }

                    _11 = processlist[11].ProcessName;
                    try { check(processlist[11].MainModule.FileName); } catch { }

                    _12 = processlist[12].ProcessName;
                    try { check(processlist[12].MainModule.FileName); } catch { }

                    _13 = processlist[13].ProcessName;
                    try { check(processlist[13].MainModule.FileName); } catch { }

                    _14 = processlist[14].ProcessName;
                    try { check(processlist[14].MainModule.FileName); } catch { }

                    _15 = processlist[15].ProcessName;
                    try { check(processlist[15].MainModule.FileName); } catch { }

                    _16 = processlist[16].ProcessName;
                    try { check(processlist[16].MainModule.FileName); } catch { }

                    _17 = processlist[17].ProcessName;
                    try { check(processlist[17].MainModule.FileName); } catch { }

                    _18 = processlist[18].ProcessName;
                    try { check(processlist[18].MainModule.FileName); } catch { }

                    _19 = processlist[19].ProcessName;
                    try { check(processlist[19].MainModule.FileName); } catch { }

                    _20 = processlist[20].ProcessName;
                    try { check(processlist[20].MainModule.FileName); } catch { }

                    _21 = processlist[21].ProcessName;
                    try { check(processlist[21].MainModule.FileName); } catch { }

                    _22 = processlist[22].ProcessName;
                    try { check(processlist[22].MainModule.FileName); } catch { }

                    _23 = processlist[23].ProcessName;
                    try { check(processlist[23].MainModule.FileName); } catch { }

                    _24 = processlist[24].ProcessName;
                    try { check(processlist[24].MainModule.FileName); } catch { }

                    _25 = processlist[25].ProcessName;
                    try { check(processlist[25].MainModule.FileName); } catch { }

                    _26 = processlist[26].ProcessName;
                    try { check(processlist[26].MainModule.FileName); } catch { }

                    _27 = processlist[27].ProcessName;
                    try { check(processlist[27].MainModule.FileName); } catch { }

                    _28 = processlist[28].ProcessName;
                    try { check(processlist[28].MainModule.FileName); } catch { }

                    _29 = processlist[29].ProcessName;
                    try { check(processlist[29].MainModule.FileName); } catch { }

                    _30 = processlist[30].ProcessName;
                    try { check(processlist[30].MainModule.FileName); } catch { }

                    _31 = processlist[31].ProcessName;
                    try { check(processlist[31].MainModule.FileName); } catch { }

                    _32 = processlist[32].ProcessName;
                    try { check(processlist[32].MainModule.FileName); } catch { }

                    _33 = processlist[33].ProcessName;
                    try { check(processlist[33].MainModule.FileName); } catch { }

                    _34 = processlist[34].ProcessName;
                    try { check(processlist[34].MainModule.FileName); } catch { }

                    _35 = processlist[35].ProcessName;
                    try { check(processlist[35].MainModule.FileName); } catch { }

                    _36 = processlist[36].ProcessName;
                    try { check(processlist[36].MainModule.FileName); } catch { }

                    _37 = processlist[37].ProcessName;
                    try { check(processlist[37].MainModule.FileName); } catch { }

                    _38 = processlist[38].ProcessName;
                    try { check(processlist[38].MainModule.FileName); } catch { }

                    _39 = processlist[39].ProcessName;
                    try { check(processlist[39].MainModule.FileName); } catch { }

                    _40 = processlist[40].ProcessName;
                    try { check(processlist[40].MainModule.FileName); } catch { }

                    _41 = processlist[41].ProcessName;
                    try { check(processlist[41].MainModule.FileName); } catch { }

                    _42 = processlist[42].ProcessName;
                    try { check(processlist[42].MainModule.FileName); } catch { }

                    _43 = processlist[43].ProcessName;
                    try { check(processlist[43].MainModule.FileName); } catch { }

                    _44 = processlist[44].ProcessName;
                    try { check(processlist[44].MainModule.FileName); } catch { }

                    _45 = processlist[45].ProcessName;
                    try { check(processlist[45].MainModule.FileName); } catch { }

                    _46 = processlist[46].ProcessName;
                    try { check(processlist[46].MainModule.FileName); } catch { }

                    _47 = processlist[47].ProcessName;
                    try { check(processlist[47].MainModule.FileName); } catch { }

                    _48 = processlist[48].ProcessName;
                    try { check(processlist[48].MainModule.FileName); } catch { }

                    _49 = processlist[49].ProcessName;
                    try { check(processlist[49].MainModule.FileName); } catch { }

                    _50 = processlist[50].ProcessName;
                    try { check(processlist[50].MainModule.FileName); } catch { }

                    _51 = processlist[51].ProcessName;
                    try { check(processlist[51].MainModule.FileName); } catch { }

                    _52 = processlist[52].ProcessName;
                    try { check(processlist[52].MainModule.FileName); } catch { }

                    _53 = processlist[53].ProcessName;
                    try { check(processlist[53].MainModule.FileName); } catch { }

                    _54 = processlist[54].ProcessName;
                    try { check(processlist[54].MainModule.FileName); } catch { }

                    _55 = processlist[55].ProcessName;
                    try { check(processlist[55].MainModule.FileName); } catch { }

                    _56 = processlist[56].ProcessName;
                    try { check(processlist[56].MainModule.FileName); } catch { }

                    _57 = processlist[57].ProcessName;
                    try { check(processlist[57].MainModule.FileName); } catch { }

                    _58 = processlist[58].ProcessName;
                    try { check(processlist[58].MainModule.FileName); } catch { }

                    _59 = processlist[59].ProcessName;
                    try { check(processlist[59].MainModule.FileName); } catch { }

                    _60 = processlist[60].ProcessName;
                    try { check(processlist[60].MainModule.FileName); } catch { }

                    _61 = processlist[61].ProcessName;
                    try { check(processlist[61].MainModule.FileName); } catch { }

                    _62 = processlist[62].ProcessName;
                    try { check(processlist[62].MainModule.FileName); } catch { }

                    _63 = processlist[63].ProcessName;
                    try { check(processlist[63].MainModule.FileName); } catch { }

                    _64 = processlist[64].ProcessName;
                    try { check(processlist[64].MainModule.FileName); } catch { }

                    _65 = processlist[65].ProcessName;
                    try { check(processlist[65].MainModule.FileName); } catch { }

                    _66 = processlist[66].ProcessName;
                    try { check(processlist[66].MainModule.FileName); } catch { }

                    _67 = processlist[67].ProcessName;
                    try { check(processlist[67].MainModule.FileName); } catch { }

                    _68 = processlist[68].ProcessName;
                    try { check(processlist[68].MainModule.FileName); } catch { }

                    _69 = processlist[69].ProcessName;
                    try { check(processlist[69].MainModule.FileName); } catch { }

                    _70 = processlist[70].ProcessName;
                    try { check(processlist[70].MainModule.FileName); } catch { }

                    _71 = processlist[71].ProcessName;
                    try { check(processlist[71].MainModule.FileName); } catch { }

                    _72 = processlist[72].ProcessName;
                    try { check(processlist[72].MainModule.FileName); } catch { }

                    _73 = processlist[73].ProcessName;
                    try { check(processlist[73].MainModule.FileName); } catch { }

                    _74 = processlist[74].ProcessName;
                    try { check(processlist[74].MainModule.FileName); } catch { }

                    _75 = processlist[75].ProcessName;
                    try { check(processlist[75].MainModule.FileName); } catch { }

                    _76 = processlist[76].ProcessName;
                    try { check(processlist[76].MainModule.FileName); } catch { }

                    _77 = processlist[77].ProcessName;
                    try { check(processlist[77].MainModule.FileName); } catch { }

                    _78 = processlist[78].ProcessName;
                    try { check(processlist[78].MainModule.FileName); } catch { }

                    _79 = processlist[79].ProcessName;
                    try { check(processlist[79].MainModule.FileName); } catch { }

                    _80 = processlist[80].ProcessName;
                    try { check(processlist[80].MainModule.FileName); } catch { }

                    _81 = processlist[81].ProcessName;
                    try { check(processlist[81].MainModule.FileName); } catch { }

                    _82 = processlist[82].ProcessName;
                    try { check(processlist[82].MainModule.FileName); } catch { }

                    _83 = processlist[83].ProcessName;
                    try { check(processlist[83].MainModule.FileName); } catch { }

                    _84 = processlist[84].ProcessName;
                    try { check(processlist[84].MainModule.FileName); } catch { }

                    _85 = processlist[85].ProcessName;
                    try { check(processlist[85].MainModule.FileName); } catch { }

                    _86 = processlist[86].ProcessName;
                    try { check(processlist[86].MainModule.FileName); } catch { }

                    _87 = processlist[87].ProcessName;
                    try { check(processlist[87].MainModule.FileName); } catch { }

                    _88 = processlist[88].ProcessName;
                    try { check(processlist[88].MainModule.FileName); } catch { }

                    _89 = processlist[89].ProcessName;
                    try { check(processlist[89].MainModule.FileName); } catch { }

                    _90 = processlist[90].ProcessName;
                    try { check(processlist[90].MainModule.FileName); } catch { }

                    _91 = processlist[91].ProcessName;
                    try { check(processlist[91].MainModule.FileName); } catch { }

                    _92 = processlist[92].ProcessName;
                    try { check(processlist[92].MainModule.FileName); } catch { }

                    _93 = processlist[93].ProcessName;
                    try { check(processlist[93].MainModule.FileName); } catch { }

                    _94 = processlist[94].ProcessName;
                    try { check(processlist[94].MainModule.FileName); } catch { }

                    _95 = processlist[95].ProcessName;
                    try { check(processlist[95].MainModule.FileName); } catch { }

                    _96 = processlist[96].ProcessName;
                    try { check(processlist[96].MainModule.FileName); } catch { }

                    _97 = processlist[97].ProcessName;
                    try { check(processlist[97].MainModule.FileName); } catch { }

                    _98 = processlist[98].ProcessName;
                    try { check(processlist[98].MainModule.FileName); } catch { }

                    _99 = processlist[99].ProcessName;
                    try { check(processlist[99].MainModule.FileName); } catch { }

                    _100 = processlist[100].ProcessName;
                    try { check(processlist[100].MainModule.FileName); } catch { }

                    _101 = processlist[101].ProcessName;
                    try { check(processlist[101].MainModule.FileName); } catch { }

                    _102 = processlist[102].ProcessName;
                    try { check(processlist[102].MainModule.FileName); } catch { }

                    _103 = processlist[103].ProcessName;
                    try { check(processlist[103].MainModule.FileName); } catch { }

                    _104 = processlist[104].ProcessName;
                    try { check(processlist[104].MainModule.FileName); } catch { }

                    _105 = processlist[105].ProcessName;
                    try { check(processlist[105].MainModule.FileName); } catch { }

                    _106 = processlist[106].ProcessName;
                    try { check(processlist[106].MainModule.FileName); } catch { }

                    _107 = processlist[107].ProcessName;
                    try { check(processlist[107].MainModule.FileName); } catch { }

                    _108 = processlist[108].ProcessName;
                    try { check(processlist[108].MainModule.FileName); } catch { }

                    _109 = processlist[109].ProcessName;
                    try { check(processlist[109].MainModule.FileName); } catch { }

                    _110 = processlist[110].ProcessName;
                    try { check(processlist[110].MainModule.FileName); } catch { }

                    _111 = processlist[111].ProcessName;
                    try { check(processlist[111].MainModule.FileName); } catch { }

                    _112 = processlist[112].ProcessName;
                    try { check(processlist[112].MainModule.FileName); } catch { }

                    _113 = processlist[113].ProcessName;
                    try { check(processlist[113].MainModule.FileName); } catch { }

                    _114 = processlist[114].ProcessName;
                    try { check(processlist[114].MainModule.FileName); } catch { }

                    _115 = processlist[115].ProcessName;
                    try { check(processlist[115].MainModule.FileName); } catch { }

                    _116 = processlist[116].ProcessName;
                    try { check(processlist[116].MainModule.FileName); } catch { }

                    _117 = processlist[117].ProcessName;
                    try { check(processlist[117].MainModule.FileName); } catch { }

                    _118 = processlist[118].ProcessName;
                    try { check(processlist[118].MainModule.FileName); } catch { }

                    _119 = processlist[119].ProcessName;
                    try { check(processlist[119].MainModule.FileName); } catch { }

                    _120 = processlist[120].ProcessName;
                    try { check(processlist[120].MainModule.FileName); } catch { }

                    _121 = processlist[121].ProcessName;
                    try { check(processlist[121].MainModule.FileName); } catch { }

                    _122 = processlist[122].ProcessName;
                    try { check(processlist[122].MainModule.FileName); } catch { }

                    _123 = processlist[123].ProcessName;
                    try { check(processlist[123].MainModule.FileName); } catch { }

                    _124 = processlist[124].ProcessName;
                    try { check(processlist[124].MainModule.FileName); } catch { }

                    _125 = processlist[125].ProcessName;
                    try { check(processlist[125].MainModule.FileName); } catch { }

                    _126 = processlist[126].ProcessName;
                    try { check(processlist[126].MainModule.FileName); } catch { }

                    _127 = processlist[127].ProcessName;
                    try { check(processlist[27].MainModule.FileName); } catch { }

                    _128 = processlist[128].ProcessName;
                    try { check(processlist[128].MainModule.FileName); } catch { }

                    _129 = processlist[129].ProcessName;
                    try { check(processlist[129].MainModule.FileName); } catch { }

                    _130 = processlist[130].ProcessName;
                    try { check(processlist[130].MainModule.FileName); } catch { }

                    _131 = processlist[131].ProcessName;
                    try { check(processlist[131].MainModule.FileName); } catch { }

                    _132 = processlist[132].ProcessName;
                    try { check(processlist[132].MainModule.FileName); } catch { }

                    _133 = processlist[133].ProcessName;
                    try { check(processlist[133].MainModule.FileName); } catch { }

                    _134 = processlist[134].ProcessName;
                    try { check(processlist[134].MainModule.FileName); } catch { }

                    _135 = processlist[135].ProcessName;
                    try { check(processlist[135].MainModule.FileName); } catch { }

                    _136 = processlist[136].ProcessName;
                    try { check(processlist[136].MainModule.FileName); } catch { }

                    _137 = processlist[137].ProcessName;
                    try { check(processlist[137].MainModule.FileName); } catch { }

                    _138 = processlist[138].ProcessName;
                    try { check(processlist[38].MainModule.FileName); } catch { }

                    _139 = processlist[139].ProcessName;
                    try { check(processlist[139].MainModule.FileName); } catch { }

                    _140 = processlist[140].ProcessName;
                    try { check(processlist[140].MainModule.FileName); } catch { }

                    _141 = processlist[141].ProcessName;
                    try { check(processlist[141].MainModule.FileName); } catch { }

                    _142 = processlist[142].ProcessName;
                    try { check(processlist[142].MainModule.FileName); } catch { }

                    _143 = processlist[143].ProcessName;
                    try { check(processlist[143].MainModule.FileName); } catch { }

                    _144 = processlist[144].ProcessName;
                    try { check(processlist[144].MainModule.FileName); } catch { }

                    _145 = processlist[145].ProcessName;
                    try { check(processlist[145].MainModule.FileName); } catch { }

                    _146 = processlist[146].ProcessName;
                    try { check(processlist[146].MainModule.FileName); } catch { }

                    _147 = processlist[147].ProcessName;
                    try { check(processlist[147].MainModule.FileName); } catch { }

                    _148 = processlist[148].ProcessName;
                    try { check(processlist[148].MainModule.FileName); } catch { }

                    _149 = processlist[149].ProcessName;
                    try { check(processlist[149].MainModule.FileName); } catch { }

                    _150 = processlist[150].ProcessName;
                    try { check(processlist[150].MainModule.FileName); } catch { }

                    _151 = processlist[151].ProcessName;
                    try { check(processlist[151].MainModule.FileName); } catch { }

                    _152 = processlist[152].ProcessName;
                    try { check(processlist[152].MainModule.FileName); } catch { }

                    _153 = processlist[153].ProcessName;
                    try { check(processlist[153].MainModule.FileName); } catch { }

                    _154 = processlist[154].ProcessName;
                    try { check(processlist[154].MainModule.FileName); } catch { }

                    _155 = processlist[155].ProcessName;
                    try { check(processlist[155].MainModule.FileName); } catch { }

                    _156 = processlist[156].ProcessName;
                    try { check(processlist[156].MainModule.FileName); } catch { }

                    _157 = processlist[157].ProcessName;
                    try { check(processlist[157].MainModule.FileName); } catch { }

                    _158 = processlist[158].ProcessName;
                    try { check(processlist[158].MainModule.FileName); } catch { }

                    _159 = processlist[159].ProcessName;
                    try { check(processlist[159].MainModule.FileName); } catch { }

                    _160 = processlist[160].ProcessName;
                    try { check(processlist[160].MainModule.FileName); } catch { }

                    _161 = processlist[161].ProcessName;
                    try { check(processlist[161].MainModule.FileName); } catch { }

                    _162 = processlist[162].ProcessName;
                    try { check(processlist[162].MainModule.FileName); } catch { }

                    _163 = processlist[163].ProcessName;
                    try { check(processlist[163].MainModule.FileName); } catch { }

                    _164 = processlist[164].ProcessName;
                    try { check(processlist[164].MainModule.FileName); } catch { }

                    _165 = processlist[165].ProcessName;
                    try { check(processlist[165].MainModule.FileName); } catch { }

                    _166 = processlist[166].ProcessName;
                    try { check(processlist[166].MainModule.FileName); } catch { }

                    _167 = processlist[167].ProcessName;
                    try { check(processlist[167].MainModule.FileName); } catch { }

                    _168 = processlist[168].ProcessName;
                    try { check(processlist[168].MainModule.FileName); } catch { }

                    _169 = processlist[169].ProcessName;
                    try { check(processlist[169].MainModule.FileName); } catch { }

                    _170 = processlist[170].ProcessName;
                    try { check(processlist[170].MainModule.FileName); } catch { }

                    _171 = processlist[171].ProcessName;
                    try { check(processlist[171].MainModule.FileName); } catch { }

                    _172 = processlist[172].ProcessName;
                    try { check(processlist[172].MainModule.FileName); } catch { }

                    _173 = processlist[173].ProcessName;
                    try { check(processlist[173].MainModule.FileName); } catch { }

                    _174 = processlist[174].ProcessName;
                    try { check(processlist[174].MainModule.FileName); } catch { }

                    _175 = processlist[175].ProcessName;
                    try { check(processlist[175].MainModule.FileName); } catch { }

                    _176 = processlist[176].ProcessName;
                    try { check(processlist[176].MainModule.FileName); } catch { }

                    _177 = processlist[177].ProcessName;
                    try { check(processlist[177].MainModule.FileName); } catch { }

                    _178 = processlist[178].ProcessName;
                    try { check(processlist[178].MainModule.FileName); } catch { }

                    _179 = processlist[179].ProcessName;
                    try { check(processlist[179].MainModule.FileName); } catch { }

                    _180 = processlist[180].ProcessName;
                    try { check(processlist[180].MainModule.FileName); } catch { }

                    _181 = processlist[181].ProcessName;
                    try { check(processlist[181].MainModule.FileName); } catch { }

                    _182 = processlist[182].ProcessName;
                    try { check(processlist[182].MainModule.FileName); } catch { }

                    _183 = processlist[183].ProcessName;
                    try { check(processlist[183].MainModule.FileName); } catch { }

                    _184 = processlist[184].ProcessName;
                    try { check(processlist[184].MainModule.FileName); } catch { }

                    _185 = processlist[185].ProcessName;
                    try { check(processlist[185].MainModule.FileName); } catch { }

                    _186 = processlist[186].ProcessName;
                    try { check(processlist[186].MainModule.FileName); } catch { }

                    _187 = processlist[187].ProcessName;
                    try { check(processlist[187].MainModule.FileName); } catch { }

                    _188 = processlist[188].ProcessName;
                    try { check(processlist[188].MainModule.FileName); } catch { }

                    _189 = processlist[189].ProcessName;
                    try { check(processlist[189].MainModule.FileName); } catch { }

                    _190 = processlist[190].ProcessName;
                    try { check(processlist[190].MainModule.FileName); } catch { }

                    _191 = processlist[191].ProcessName;
                    try { check(processlist[191].MainModule.FileName); } catch { }

                    _192 = processlist[192].ProcessName;
                    try { check(processlist[192].MainModule.FileName); } catch { }

                    _193 = processlist[193].ProcessName;
                    try { check(processlist[193].MainModule.FileName); } catch { }

                    _194 = processlist[194].ProcessName;
                    try { check(processlist[94].MainModule.FileName); } catch { }

                    _195 = processlist[195].ProcessName;
                    try { check(processlist[195].MainModule.FileName); } catch { }

                    _196 = processlist[196].ProcessName;
                    try { check(processlist[196].MainModule.FileName); } catch { }

                    _197 = processlist[197].ProcessName;
                    try { check(processlist[197].MainModule.FileName); } catch { }

                    _198 = processlist[198].ProcessName;
                    try { check(processlist[198].MainModule.FileName); } catch { }

                    _199 = processlist[199].ProcessName;
                    try { check(processlist[199].MainModule.FileName); } catch { }

                    _200 = processlist[200].ProcessName;
                    try { check(processlist[200].MainModule.FileName); } catch { }
                }
                catch (Exception ex)
                {
                    Error("\nError while getting process: \n" + ex.Message + "\n");
                }

                new Thread(() =>
                {
                    Thread.Sleep(1500);
                    Console.WriteLine("Scan ended. Press enter for rescan.");
                }).Start();
                
                Thread.Sleep(2750);
                Console.ReadKey();
                Clear(); goto rescan;
            }
        }

        public static bool check(string process)
        {
            if (process == null || process == "") return false;

            return dedect(process);
        }

        public static bool dedect(string filename)
        {
            byte[] bytes = File.ReadAllBytes(filename);
            string value = new ASCIIEncoding().GetString(bytes);

            bool dedected = false;
            string reason = "";

            if (value.Contains("csgo") && value.Contains("OpenProcess"))
            {
                //MessageBox.Show("Dedected -> csgo handle");
                reason = reason + "Handling game with openprocess. -> " + filename;
                dedected = true;
            }
            if (value.Contains("client.dll"))
            {
                //MessageBox.Show("Dedected -> client handle");
                reason = "\n" + reason + "Game client found in external program. -> " + filename;
                dedected = true;
            }
            if (value.Contains("hack") || value.Contains("cheat") || value.Contains("ware"))
            {
                //MessageBox.Show("Dedected -> hack");
                reason = "\n" + reason + "Bad words found in a external program. -> " + filename;
                dedected = true;
            }
            if (value.Contains("ReadProcessMemory") && value.Contains("csgo"))
            {
                //MessageBox.Show("Dedected -> ReadProcessMemory");
                reason = "\n" + reason + "Reading csgo memory. -> " + filename;
                dedected = true;
            }
            if (value.Contains("WriteProcessMemory") && value.Contains("csgo"))
            {
                //MessageBox.Show("Dedected -> WriteProcessMemory");
                reason = "\n" + reason + "Writing csgo memory. -> " + filename;
                dedected = true;
            }
            if (value.Contains("WorldToScreen"))
            {
                //MessageBox.Show("Dedected -> WriteProcessMemory");
                reason = "\n" + reason + "using WorldToScreen function. -> " + filename;
                dedected = true;
            }

            if (dedected == true)
            {
                //MessageBox.Show(reason);
                Dedected(reason);
                return true;
            }

            return false;
        }
    }
}
