﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Tools.Model.Parameters
{
    interface IOutputParameter
    {
        void ResolveTemplateName(string inputFilename);
    }
}
