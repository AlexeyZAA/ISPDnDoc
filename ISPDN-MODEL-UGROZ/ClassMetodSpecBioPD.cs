using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SpaseFormISPDn
{
    class ClassMetodSpecBioPD
    {
        // поиск количества записей специальных категорий многие-спец отдел
        public static int SpecOtdelPdCountMetod()
        {
            int SpecOtdelPdCount;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.MnogieKategoriSpecOtdelTableAdapter tblAdaptMnogSpecOtdelPD = new ISPDnBDDataSetTableAdapters.MnogieKategoriSpecOtdelTableAdapter();
            tblAdaptMnogSpecOtdelPD.Fill(ds.MnogieKategoriSpecOtdel);
            DataTable tblSpecotdel = ds.Tables["MnogieKategoriSpecOtdel"];
            SpecOtdelPdCount = tblSpecotdel.Rows.Count;
            return SpecOtdelPdCount;
        }

        // поиск количества записей специальных категорий многие-спец ИСПДн
        public static int SpecIsPdCountMetod()
        {
            int SpecIsPdCount;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.MnogieKategoryPdSpecISPDnTableAdapter tblAdaptMnogSpecIslPD = new ISPDnBDDataSetTableAdapters.MnogieKategoryPdSpecISPDnTableAdapter();
            tblAdaptMnogSpecIslPD.Fill(ds.MnogieKategoryPdSpecISPDn);
            DataTable tblSpecotdel = ds.Tables["MnogieKategoryPdSpecISPDn"];
            SpecIsPdCount = tblSpecotdel.Rows.Count;
            return SpecIsPdCount;
        }

        // поиск количества записей БИО категорий
        public static int BioPdCountMetod()
        {
            int BioPdCount;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.KategoryPdBioTableAdapter tblAdaptBioPD = new ISPDnBDDataSetTableAdapters.KategoryPdBioTableAdapter();
            tblAdaptBioPD.Fill(ds.KategoryPdBio);
            DataTable tblBio = ds.Tables["KategoryPdBio"];
            BioPdCount = tblBio.Rows.Count;
            return BioPdCount;
        }
    }
}
