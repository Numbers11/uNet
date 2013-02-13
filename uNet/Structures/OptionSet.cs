﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uNet.Structures
{
    public class OptionSet
    {
        public bool VerifyPackets { get; set; }
        public ICryptoScheme CryptoScheme { get; set; }

        public OptionSet(bool verifyPackets, ICryptoScheme cryptoScheme)
        {
            VerifyPackets = verifyPackets;
            CryptoScheme = cryptoScheme;
        }
    }
}