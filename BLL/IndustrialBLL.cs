using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Windows.Documents;
using Yuhan.Communication;
using Yuhan.Industrial.Model;

namespace Yuhan.Industrial.BLL
{
    public class IndustrialBll
    {
        public DataResult<SerialInfo> InitSerialInfo()
        {
            DataResult<SerialInfo> result = new DataResult<SerialInfo>();
            try
            {
                SerialInfo si = new SerialInfo();
                si.PortName = ConfigurationManager.AppSettings["port"].ToString();
                si.BaudRate = int.Parse(ConfigurationManager.AppSettings["baud"].ToString());
                si.DataBit = int.Parse(ConfigurationManager.AppSettings["data_bit"].ToString());
                si.Parity = (Parity)Enum.Parse(typeof(Parity), ConfigurationManager.AppSettings["data_bit"].ToString(), true);
                si.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ConfigurationManager.AppSettings["data_bit"].ToString(), true);

                result.State = true;
                result.Data = si;
            }
            catch (Exception e)
            {
                result.Message = e.Message;
            }

            return result;
        }
    }

    public DataResult<List<StorageArea>> InitDataRedult
}