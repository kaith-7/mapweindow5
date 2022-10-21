﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Model;

namespace MW5.Data.Repository
{
    public interface ITmsItem: IRepositoryItem
    {
        TmsProvider Provider { get; }

        bool Active { get; set; }

        string Serialize();
    }
}
