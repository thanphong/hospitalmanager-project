using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class PhongBsn
    {

        public SqlDataAdapter GetDataAdapter()
        {
            DataLayer.PhongData phongdata = new DataLayer.PhongData();
            return phongdata.GetDataAdapter();
        }
    }
}
