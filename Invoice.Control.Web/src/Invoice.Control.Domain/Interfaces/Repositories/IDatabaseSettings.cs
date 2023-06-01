﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Control.Domain.Interfaces.Repositories
{
    public interface IDatabaseSettings
    {
        string GetDefaultConnection();
        string GetIdentityConnection();
    }
}