using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLIBENHVIEN.DataLayer
{
    class CTPhongData : Data
    {
        public CTPhongData()
        {
            this.tableName = "CTPhong";
            this.fieldList = "MaPhong, MaNV";
        }

    }
}
