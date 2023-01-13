﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Utilities
    {
        public static bool IsInternetConnected => NetworkInterface.GetIsNetworkAvailable();
    }
}
