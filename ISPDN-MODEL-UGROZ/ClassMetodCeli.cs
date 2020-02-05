using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SpaseFormISPDn
{
    class ClassMetodCeli
    {
        /*
         * метод поиска Всех целей организации в текст ***********8
         */
        public static string CeliOrgMetod(int OrgId)
        {
            string CeliAll = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.CeliObrabotkiPDTableAdapter tblAdaptCeliOrg = new ISPDnBDDataSetTableAdapters.CeliObrabotkiPDTableAdapter();
            tblAdaptCeliOrg.Fill(ds.CeliObrabotkiPD);
            DataTable tableCeli = ds.Tables["CeliObrabotkiPD"];
            foreach (DataRow dataRow in tableCeli.Rows)
            {
                string CeliName = dataRow["CeliObrabotkiName"].ToString();
                int Id = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (OrgId == Id) 
                {
                    CeliAll = CeliAll + CeliName + ". ";
                }
            }
            return CeliAll;
        }


      }
}
