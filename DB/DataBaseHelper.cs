using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuhan.Industrial.DB
{
    public class DataBaseHelper
    {
        public static SqlSugarScope Db = new SqlSugarScope(new ConnectionConfig()
        {
            ConnectionString = "Data Source=localhost;Initial Catalog=zx_scada_data;Persist Security Info=True;User ID=sa;Password=123;Connection Timeout=3",//连接符字串
            DbType = DbType.SqlServer,//数据库类型
            IsAutoCloseConnection = true //不设成true要手动close
        });
    }
}