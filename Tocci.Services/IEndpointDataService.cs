﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tocci.Services.Models;

namespace Tocci.Services
{
    public interface IEndpointDataServiceProxy
    {
        Task<ServiceReport> GetEndpointReport(string endPointAddress, string reportID, int? endPointPort = null);
    }
}
