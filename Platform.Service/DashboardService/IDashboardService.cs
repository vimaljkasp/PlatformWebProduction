﻿using Platform.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service
{
    public interface IDashboardService
    {
        DashboardDTO GetDashboardDetails();
    }
}
