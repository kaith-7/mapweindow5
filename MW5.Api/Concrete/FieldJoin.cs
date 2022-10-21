using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using MapWinGIS;

namespace MW5.Api.Concrete
{
    public class FieldJoin
    {
        private readonly Table _table;
        private readonly int _joinIndex;

        public FieldJoin(Table table, int joinIndex)
        {
            _table = table;
            _joinIndex = joinIndex;
        }

        [DisplayName("文件名")]
        public string DisplayName
        {
            get
            {
                string path = _table.JoinFilename[_joinIndex];
                return Path.GetFileName(path);
            }
        }

        [Browsable(false)]
        public string Filename
        {
            get { return _table.JoinFilename[_joinIndex]; }
        }

        [DisplayName("外部图层关联字段")]
        public string FromField
        {
            get { return _table.JoinFromField[_joinIndex]; }
        }

        [DisplayName("此图层关联字段")]
        public string ToField
        {
            get { return _table.JoinToField[_joinIndex]; }
        }

        [Browsable(false)]
        public int JoinIndex
        {
            get { return _joinIndex; }
        }

        [Browsable(false)]
        public IEnumerable<string> Fields
        {
            get
            {
                var s =_table.JoinFields[_joinIndex];
                return s.Split(',');
            }
        }

        [DisplayName("字段")]
        public string FieldsCsv
        {
            get
            {
                var s = _table.JoinFields[_joinIndex];
                return string.IsNullOrWhiteSpace(s) ? "<全部>" : s;
            }
        }

        [Browsable(false)]
        public string Options
        {
            get
            {
                return _table.JoinOptions[_joinIndex];
            }
        }
    }
}
