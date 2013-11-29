using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class HopDongBsn 
    {

        DataLayer.HopDongData hopdongdata = new DataLayer.HopDongData();

        public SqlDataAdapter GetDataAdapter()
        {
            return hopdongdata.GetDataAdapter();
        }
    }
}
