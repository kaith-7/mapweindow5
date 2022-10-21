// -------------------------------------------------------------------------------------------
// <copyright file="ILoggingService.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace MW5.Shared.CheckResult
{
    public interface ICheckAttrService
    {
        event EventHandler<AttributeCheckResultEntryAddArgs> EntryAdded;

        void Init(object context, object layer, object rule);

        void Run();
    }
}