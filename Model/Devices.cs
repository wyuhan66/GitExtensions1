using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuhan.Industrial.Model
{
    [SugarTable("devices")]
    public class Devices
    {
        [SugarColumn(ColumnDataType = "d_id", IsNullable = false)]
        public string Id { get; set; }

        [SugarColumn(ColumnDataType = "d_name")]
        public string Name { get; set; }
    }
}