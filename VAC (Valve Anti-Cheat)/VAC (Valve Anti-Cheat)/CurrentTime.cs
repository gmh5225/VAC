﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC
{
    public static class CurrentTime
    {
        public static string Get()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
