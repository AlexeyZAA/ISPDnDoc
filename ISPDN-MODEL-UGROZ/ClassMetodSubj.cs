using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SpaseFormISPDn
{
    class ClassMetodSubj
    {
        /*
        * Так как программа пишеться для одной организации то Пока не реализована выборка всех перс данных для текущей организации 
        *  метод поиска Всех категорий Перс данных для организации ***********
        */

        public static string SubjAllMetod()
        {
            string SubjAll = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.KategorySubjTableAdapter tblAdaptSubjAll = new ISPDnBDDataSetTableAdapters.KategorySubjTableAdapter();
            tblAdaptSubjAll.Fill(ds.KategorySubj);
            DataTable tableSubjAll = ds.Tables["KategorySubj"];
            foreach (DataRow dataRow in tableSubjAll.Rows)
            {
                string subjName = dataRow["KategorySubjName"].ToString();
                SubjAll = SubjAll + subjName + ". ";
            }
            return SubjAll;
        }
    }
}
