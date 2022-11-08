using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Yuhan.Industrial.Model
{
    public class StorageArea
    {
        [SugarColumn(ColumnDataType = "id")]
        public string Id { get; set; }

        [SugarColumn(ColumnDataType = "slave_add", IsNullable = false)]
        public int SlaveAdd { get; set; }

        [SugarColumn(ColumnDataType = "func_code", IsNullable = false)]
        public string FuncCode { get; set; }

        [SugarColumn(ColumnDataType = "s_area_name")]
        public string SAreaName { get; set; }

        [SugarColumn(ColumnDataType = "start_reg")]
        public string StartReg { get; set; }

        [SugarColumn(ColumnDataType = "length")]
        public string Length { get; set; }
    }
}