﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Fluid.Core.Network
{
    public class ClientSyn
    {
        public ClientSyn(TcpClient client)
        {
            this.NetworkClient = client;
        }

        public TcpClient NetworkClient { get; set; }

        public short Ping { get; internal set; }
    }
}
