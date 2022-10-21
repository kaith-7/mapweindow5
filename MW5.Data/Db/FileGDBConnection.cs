using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Static;
using MW5.Plugins.Enums;
using MW5.Plugins.Services;

namespace MW5.Data.Db
{
    internal class FileGDBConnection : ConnectionBase
    {
        public string Filename { get; set; }

        public override string BuildConnection(bool noPassword = false)
        {
            return Filename;
        }

        public override GeoDatabaseType DatabaseType
        {
            get { return GeoDatabaseType.FileGDB; }
        }

        public override string Name
        {
            get
            {
                return Filename;
            }
        }

        public override bool Validate()
        {
            if (!Directory.Exists(Filename))
            {
                using (MW5.Api.Concrete.VectorDatasource vds = new Api.Concrete.VectorDatasource())
                {
                    bool ok = vds.CreateDatasource(Filename, "FileGDB");
                    if (!ok)
                    {
                        GeoSource.OpenFromDatabase(Filename, Name);
                        MessageService.Current.Info("File GeoDatabase doesn't exist: " + Filename);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
