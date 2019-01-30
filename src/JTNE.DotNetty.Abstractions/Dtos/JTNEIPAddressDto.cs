﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JTNE.DotNetty.Abstractions.Dtos
{
    public class JTNEIPAddressDto
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public EndPoint endPoint;

        public EndPoint EndPoint
        {
            get
            {
                if (endPoint == null)
                {
                    if (IPAddress.TryParse(Host, out IPAddress ip))
                    {
                        endPoint = new IPEndPoint(ip, Port);
                    }
                    else
                    {
                        endPoint = new DnsEndPoint(Host, Port);
                    }
                }
                return endPoint;
            }
        }
    }
}