using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRptDatasourceFields
    {
        public int DatasourceFieldId { get; set; }
        public string Name { get; set; }
        public string GroupingFuntion { get; set; }
        public string DataType { get; set; }
        public string Width { get; set; }
        public string FontSize { get; set; }
        public bool? FontStyleIsBold { get; set; }
        public bool? FontStyleIsItalic { get; set; }
        public string FontColor { get; set; }
        public string BackgroundColor { get; set; }
        public int DatasourceId { get; set; }
        public int Sequence { get; set; }
        public string ResourceKey { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRptDatasources Datasource { get; set; }
    }
}
