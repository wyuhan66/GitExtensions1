using SqlSugar;

namespace Yuhan.Industrial.Model
{
    [SugarTable("monitor_values")]
    public class MonitorValues
    {
        [SugarColumn(ColumnDataType = "d_id", IsNullable = false)]
        public string Did { get; set; }

        [SugarColumn(ColumnDataType = "value_id")]
        public string ValueId { get; set; }

        [SugarColumn(ColumnDataType = "value_name")]
        public string ValueName { get; set; }

        [SugarColumn(ColumnDataType = "s_area_id")]
        public string AreaId { get; set; }

        [SugarColumn(ColumnDataType = "address")]
        public int? Address { get; set; }

        [SugarColumn(ColumnDataType = "absolute_add")]
        public string AbsouluteAdd { get; set; }

        [SugarColumn(ColumnDataType = "data_type")]
        public string DataType { get; set; }

        [SugarColumn(ColumnDataType = "is_alarm")]
        public int? IsAlarm { get; set; }

        [SugarColumn(ColumnDataType = "description")]
        public string Description { get; set; }

        [SugarColumn(ColumnDataType = "unit")]
        public string Unit { get; set; }

        [SugarColumn(ColumnDataType = "alarm_lolo")]
        public string AlarmLoLo { get; set; }

        [SugarColumn(ColumnDataType = "alarm_low")]
        public string AlarmLow { get; set; }

        [SugarColumn(ColumnDataType = "alarm_high")]
        public string AlarmHigh { get; set; }

        [SugarColumn(ColumnDataType = "alarm_hihi")]
        public string AlarmHiHi { get; set; }
    }
}