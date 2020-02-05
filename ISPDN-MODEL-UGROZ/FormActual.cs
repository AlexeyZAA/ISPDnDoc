using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpaseFormISPDn
{
    partial class FormActualUgroz : Form
    {
        public FormActualUgroz()
        {
            InitializeComponent();
        }

        private void buttonActual_Click(object sender, EventArgs e)
        {
            int IsIS;
            IsIS = 0;
            this.mnogieRealizUgrozTableAdapter.Fill(iSPDnBDDataSet.MnogieRealizUgroz);
            this.mnogieOpasnUgrozISTableAdapter.Fill(iSPDnBDDataSet.MnogieOpasnUgrozIS);

            DataTable tableIspdn = iSPDnBDDataSet.Tables["ISPDnOperator"];
            DataTable tableMnogOpasn = iSPDnBDDataSet.Tables["MnogieOpasnUgrozIS"]; // создаем связную таблицу реализации  
            DataTable tableMnogRealiz = iSPDnBDDataSet.Tables["MnogieRealizUgroz"]; // создаем связную таблицу реализации  

            if (tableIspdn.Rows.Count == 0)
            {
                MessageBox.Show("Нет Информационной системы для определения актуальности угроз");
                goto end;
            }
            else // выявляем параметры и добовляем в базу
            {
                foreach (DataRow dataRow in tableIspdn.Rows)
                {
                    string forName;
                    forName = dataRow["ISPDnOperatorName"].ToString();
                    string forISPDnID;
                    forISPDnID = dataRow["ISPDnOperatorID"].ToString();
                    int conv = Convert.ToInt32(forISPDnID);
                    if (comboBoxActualIS.Text == forName) // Если  Имя Поля названиеИС равно имени в Базе
                    {
                        IsIS = conv * (-1);
                    }
                }

                this.mnogieUgrozaActualTableAdapter.DeleteQueryMnogieActualUgr(IsIS);
                // после того как нашли ИД информационной системы, ищем ИД Угрозы и ее характеристики
                //*********************************************************************************************

                int real = 0;
                int opasn = 0;
                for (int i = 0; i < nazvanieUgrozDataGridView.Rows.Count - 1; i++) // пробегаем по всем угрозам и смотрим для них возможность реализации
                {
                    int Ugroz = Convert.ToInt32(nazvanieUgrozDataGridView.Rows[i].Cells[0].Value);
                    // ловим возможность опасности для текущей угрозы
                  
                    foreach (DataRow dataRow in tableMnogOpasn.Rows)
                    {
                        string IdISo = dataRow["ISPDnOperatorID"].ToString();
                        string IdUgrozo = dataRow["NazvanieUgrozID"].ToString();
                        string IdOpasn = dataRow["OpasnostUgrozID"].ToString();
                        int convIdISo = Convert.ToInt32(IdISo);
                        int convIdUgrozo = Convert.ToInt32(IdUgrozo);
                        int convIdOpasn = Convert.ToInt32(IdOpasn);
                        if ((convIdISo == IsIS) && (convIdUgrozo == Ugroz))// Если  IdIS d ,базе равно Айди в комбобоксе, и Айди угрозы в базе = Айди угрозы в таблице
                        {
                            opasn = convIdOpasn;
                        }
                    }

                   
                    foreach (DataRow dataRow in tableMnogRealiz.Rows)
                    {
                        string IdIS = dataRow["ISPDnOperatorID"].ToString();
                        string IdUgroz = dataRow["NazvanieUgrozID"].ToString();
                        string IdReal = dataRow["RealizationUgrozID"].ToString();
                        int convIdIS = Convert.ToInt32(IdIS);
                        int convIdUgroz = Convert.ToInt32(IdUgroz);
                        int convertIdReal = Convert.ToInt32(IdReal);

                        if ((convIdIS == IsIS) && (convIdUgroz == Ugroz))// Если  IdIS d ,базе равно Айди в комбобоксе, и Айди угрозы в базе = Айди угрозы в таблице
                        {
                            real = convertIdReal;
                        }
                    }
                     //MessageBox.Show(opasn.ToString() + real.ToString());
                    /* нашли параметры возможности реализации и параметр опасности
    теперь определяем актуальность и добовляем в таблицу актуальности */
                    int mnogieActual = 0;
                    string actual = real.ToString() + opasn.ToString();
                    switch (actual)
                    {
                        case "11": mnogieActual = 2; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "12": mnogieActual = 2; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "13": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "21": mnogieActual = 2; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "22": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "23": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "31": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "32": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "33": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "41": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "42": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        case "43": mnogieActual = 1; this.mnogieUgrozaActualTableAdapter.Insert(Ugroz, IsIS, mnogieActual);
                            break;
                        default: MessageBox.Show("Не нашел совпадений");
                            break;
                    }
                }
                this.nazvanieUgrozTableAdapter.FillsysID(iSPDnBDDataSet.NazvanieUgroz, 1, IsIS);
            }
        end: ;
        }


        private void FormActualUgroz_Load(object sender, EventArgs e)
        {
            this.iSPDnOperatorTableAdapter.MetodSelectComboISPDn(iSPDnBDDataSet.ISPDnOperator, ClassGlobalVar.OrgID);
            this.nazvanieUgrozTableAdapter.Fill(iSPDnBDDataSet.NazvanieUgroz);
        }
    }
}
