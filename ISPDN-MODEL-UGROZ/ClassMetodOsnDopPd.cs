using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SpaseFormISPDn
{
    class ClassMetodOsnDopPd
    {
        // поиск количества записей основных категорий явных в Отделах связной таблицы
        public static int OtdelPdCountMetod()
        {
            int OsnovOtdPdCount;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.MnogieKategoryPdOtdelTableAdapter tblAdaptMnogOtdelPD = new ISPDnBDDataSetTableAdapters.MnogieKategoryPdOtdelTableAdapter();
            tblAdaptMnogOtdelPD.Fill(ds.MnogieKategoryPdOtdel);
            DataTable tblOsnPDotdel = ds.Tables["MnogieKategoryPdOtdel"];
            OsnovOtdPdCount = tblOsnPDotdel.Rows.Count;
            return OsnovOtdPdCount;
        }

        // поиск количества записей основных категорий явных в ИС связной таблицы
        public static int IsPdCountMetod()
        {
            int OsnovIsPdCount;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.MnogieISPDnKategoryPDTableAdapter tblAdaptMnogIsPD = new ISPDnBDDataSetTableAdapters.MnogieISPDnKategoryPDTableAdapter();
            tblAdaptMnogIsPD.Fill(ds.MnogieISPDnKategoryPD);
            DataTable tblOsnPDispdn = ds.Tables["MnogieISPDnKategoryPD"];
            OsnovIsPdCount = tblOsnPDispdn.Rows.Count;
            return OsnovIsPdCount;
        }

        // поиск количества записей дополнительных категорий для связной ИС
        public static int DopolnitPdCountISMetod()
        {
            int DopPdCountIs;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.MnogieKategoryPdDopISPDnTableAdapter tblAdaptDopIsPD = new ISPDnBDDataSetTableAdapters.MnogieKategoryPdDopISPDnTableAdapter();
            tblAdaptDopIsPD.Fill(ds.MnogieKategoryPdDopISPDn);
            DataTable tbldoppdIs = ds.Tables["MnogieKategoryPdDopISPDn"];
            DopPdCountIs = tbldoppdIs.Rows.Count;
            return DopPdCountIs;
        }

        // поиск количества записей дополнительных категорий для связной Отделов
        public static int DopolnitPdCountOtdelMetod()
        {
            int DopPdCountOtdel;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.MnogieKategoryDopOtdelTableAdapter tblAdaptDopOtdelPD = new ISPDnBDDataSetTableAdapters.MnogieKategoryDopOtdelTableAdapter();
            tblAdaptDopOtdelPD.Fill(ds.MnogieKategoryDopOtdel);
            DataTable tbldoppdOtdel = ds.Tables["MnogieKategoryDopOtdel"];
            DopPdCountOtdel = tbldoppdOtdel.Rows.Count;
            return DopPdCountOtdel;
        }
   }
}
