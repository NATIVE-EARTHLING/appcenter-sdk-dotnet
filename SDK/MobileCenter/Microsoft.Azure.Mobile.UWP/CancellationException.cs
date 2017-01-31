﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Mobile.UWP
{
    public class CancellationException : Exception
    {
        public CancellationException() : base("Request cancelled because channel is disabled.") { }
    }
}
