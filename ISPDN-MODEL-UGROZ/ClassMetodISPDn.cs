using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SpaseFormISPDn
{
    class ClassMetodISPDn
    {
        /*
        * метод возвращает ИД ИСПДн по Имени ***********
        */
        public static int ISPDnIDGetMetod(string ISPDnName)
        {
            int IdIs = 0;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter tblAdaptISPDNId = new ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter();
            tblAdaptISPDNId.Fill(ds.ISPDnOperator);
            DataTable tableIsName = ds.Tables["ISPDnOperator"];
            foreach (DataRow dataRow in tableIsName.Rows)
            {
                string IsName = dataRow["ISPDnOperatorName"].ToString();
                int Id = Convert.ToInt32(dataRow["ISPDnOperatorID"].ToString());
                if (ISPDnName == IsName)
                {
                    IdIs = Id;
                }
            }
            return IdIs;
        }
    }
}
