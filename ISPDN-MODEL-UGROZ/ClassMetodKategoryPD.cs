using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SpaseFormISPDn
{
    class ClassMetodKategoryPD
    {
        /*
         * Так как программа пишеться для одной организации то Пока не реализована выборка всех перс данных для текущей организации 
         *  метод поиска Всех категорий Перс данных для организации ***********
         */
        
        public static string KategoryPdAllMetod()
        {
            string KategoryPDAll = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.KategoryPdTableAdapter tblAdaptKategoryPdAll = new ISPDnBDDataSetTableAdapters.KategoryPdTableAdapter();
            tblAdaptKategoryPdAll.Fill(ds.KategoryPd);
            DataTable tablePdAll = ds.Tables["KategoryPd"];
            foreach (DataRow dataRow in tablePdAll.Rows)
            {
                string PDAll = dataRow["KategoryPdName"].ToString();
                KategoryPDAll = KategoryPDAll + PDAll + ". ";
            }
            return KategoryPDAll;
        }
    }
}
