using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SpaseFormISPDn
{
    class ClassMetodOtdel
    {
        /*
        * метод возвращает ИД ИСПДн по Имени ***********8
        */
        public static int OtdelIDGetMetod(string OtdelnName)
        {
            int IdOtdel = 0;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OtdelOrgTableAdapter tblAdaptOtdelId = new ISPDnBDDataSetTableAdapters.OtdelOrgTableAdapter();
            tblAdaptOtdelId.Fill(ds.OtdelOrg);
            DataTable tableOtdeId = ds.Tables["OtdelOrg"];
            foreach (DataRow dataRow in tableOtdeId.Rows)
            {
                string OtdelName = dataRow["OtdelOrgName"].ToString();
                int Id = Convert.ToInt32(dataRow["OtdelOrgID"].ToString());
                if (OtdelnName == OtdelName)
                {
                    IdOtdel = Id;
                }
            }
            return IdOtdel;
        }
    }
}
