﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tocci.Services.Models;

namespace Tocci.Services
{
    public abstract class EndpointServiceProxyBase : IEndpointDataServiceProxy
    {
        public abstract string ServiceAddress { get; set; }
        public abstract int ServicePort { get; set; }
        public abstract string Name { get; }
        public abstract Services.Models.ServiceType Type { get;  }
        public abstract Task<ServiceReport> GetEndpointReport(string endPointAddress, string reportID, int? endPointPort = null);

        public EndpointServiceProxyBase() { }

    }
}
