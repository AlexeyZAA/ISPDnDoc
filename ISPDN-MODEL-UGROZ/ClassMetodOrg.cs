using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SpaseFormISPDn
{
    class ClassMetodOrg
    {
        // метод поиска ФИО руководителя ***********************
        public static string RukFIOMetod()
        {
            string RukName = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter tblAdaptOrg = new ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            tblAdaptOrg.Fill(ds.OrgOperator);
            DataTable tableRuk = ds.Tables["OrgOperator"];
            foreach (DataRow dataRow in tableRuk.Rows)
            {
                string NameRuk = dataRow["OrgOperatorRukovoditelName"].ToString();
                int orgId = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (ClassGlobalVar.OrgID == orgId) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    RukName = NameRuk;
                }
            }
            return RukName;
        }
        
        // метод поиска должности руководителя ************************
        public static string RukDolgnMetod(int organId)
        {
            string RukDolgn = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter tblAdaptOrg = new ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            tblAdaptOrg.Fill(ds.OrgOperator);
            DataTable tableRuk = ds.Tables["OrgOperator"];
            foreach (DataRow dataRow in tableRuk.Rows)
            {
                string NameRuk = dataRow["OrgOperatorRukovoditelDolgn"].ToString();
                int orgId = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (organId == orgId) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    RukDolgn = NameRuk;
                }
            }
            return RukDolgn;
        }

        // метод поиска краткого названия организации *********************
        public static string NameOrgKratkMetod()
        {
            string nameOrg = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter tblAdaptOrg = new ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            tblAdaptOrg.Fill(ds.OrgOperator);
            DataTable tableNameOrgKratk = ds.Tables["OrgOperator"];
            foreach (DataRow dataRow in tableNameOrgKratk.Rows)
            {
                string NameOrgKratk = dataRow["OrgOperatorKratkName"].ToString();
                int orgId = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (ClassGlobalVar.OrgID == orgId) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    nameOrg = NameOrgKratk;
                }
            }
            return nameOrg;
        }

        // метод поиска Полного названия организации ****************
        public static string NameOrgPolnMetod()
        {
            string nameOrg = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter tblAdaptOrg = new ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            tblAdaptOrg.Fill(ds.OrgOperator);
            DataTable tableNameOrgPoln = ds.Tables["OrgOperator"];
            foreach (DataRow dataRow in tableNameOrgPoln.Rows)
            {
                string NameOrgPoln = dataRow["OrgOperatorFullName"].ToString();
                int orgId = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (ClassGlobalVar.OrgID == orgId) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    nameOrg = NameOrgPoln;
                }
            }
            return nameOrg;
        }

        // метод поиска ИНН организации *******************
        public static string INNOrgMetod()
        {
            string innOrg = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter tblAdaptOrg = new ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            tblAdaptOrg.Fill(ds.OrgOperator);
            DataTable tableINNOrg = ds.Tables["OrgOperator"];
            foreach (DataRow dataRow in tableINNOrg.Rows)
            {
                string INN = dataRow["OrgOperatorINN"].ToString();
                int orgId = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (ClassGlobalVar.OrgID == orgId) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    innOrg = INN;
                }
            }
            return innOrg;
        } 

        // метод возвращает ID организации ********************************
        public static int IdOrgMetod(string INN)
        {
            int idOrg = 0;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter tblAdaptOrg = new ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            tblAdaptOrg.Fill(ds.OrgOperator);
            DataTable tableIdOrg = ds.Tables["OrgOperator"];
            foreach (DataRow dataRow in tableIdOrg.Rows)
            {
                string innBase = dataRow["OrgOperatorINN"].ToString();
                int orgId = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (INN == innBase) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    idOrg = orgId;
                }
            }
            return idOrg;
        }

        // метод возвращает Adress организации ********************************
        public static string AdressOrgMetod()
        {
            string AdressOrg = "";
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter tblAdaptOrg = new ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            tblAdaptOrg.Fill(ds.OrgOperator);
            DataTable tableAdressOrg = ds.Tables["OrgOperator"];
            foreach (DataRow dataRow in tableAdressOrg.Rows)
            {
                string adress= dataRow["OrgOperatorAdress"].ToString();
                int orgId = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                if (ClassGlobalVar.OrgID == orgId) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    AdressOrg = adress;
                }
            }
            return AdressOrg;
        } 
    }
}
