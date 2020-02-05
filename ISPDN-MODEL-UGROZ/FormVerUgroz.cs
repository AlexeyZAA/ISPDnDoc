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
    partial class FormVerUgroz : Form
    {
        public FormVerUgroz()
        {
            InitializeComponent();
            DataGridViewVerUgroz.CellMouseUp += CheckedCellOnClickVer;
        }

        private void CheckedCellOnClickVer(object objSrc, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)            // Здесь ставишь свой нужный номер колонки
            {
                if ((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[1].EditedFormattedValue) // кнопка помечена
                {
                    DataGridViewVerUgroz.CurrentRow.Cells[2].ReadOnly = true;
                    DataGridViewVerUgroz.CurrentRow.Cells[3].ReadOnly = true;
                    DataGridViewVerUgroz.CurrentRow.Cells[4].ReadOnly = true;
                }

            }

            else if (e.ColumnIndex == 2)            // Здесь ставишь свой нужный номер колонки
            {
                if ((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[2].EditedFormattedValue) // кнопка помечена
                {
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[1].ReadOnly = true;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                }

            }
            else if (e.ColumnIndex == 3)            // Здесь ставишь свой нужный номер колонки
            {
                if ((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[3].EditedFormattedValue) // кнопка помечена
                {
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[1].ReadOnly = true;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                }

            }
            else if (e.ColumnIndex == 4)            // Здесь ставишь свой нужный номер колонки
            {
                if ((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[4].EditedFormattedValue) // кнопка помечена
                {
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[1].ReadOnly = true;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                }
            }

            if ((e.ColumnIndex == 1) || (e.ColumnIndex == 2) || (e.ColumnIndex == 3) || (e.ColumnIndex == 4))
            {

                if (((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[1].EditedFormattedValue == false) &&
                ((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[2].EditedFormattedValue == false) &&
                ((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[3].EditedFormattedValue == false) &&
                ((bool)DataGridViewVerUgroz.Rows[e.RowIndex].Cells[4].EditedFormattedValue == false))
                {
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[1].ReadOnly = false;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[2].ReadOnly = false;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                    DataGridViewVerUgroz.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                }
            }

        }



        private void nazvanieUgrozBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nazvanieUgrozBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);

        }

        private void FormVerUgroz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.ISPDnOperator". При необходимости она может быть перемещена или удалена.
            this.iSPDnOperatorTableAdapter.Fill(this.iSPDnBDDataSet.ISPDnOperator);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.NazvanieUgroz". При необходимости она может быть перемещена или удалена.
            this.nazvanieUgrozTableAdapter.Fill(this.iSPDnBDDataSet.NazvanieUgroz);
        }


        private void buttonExitVerUgroz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nazvanieUgrozBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nazvanieUgrozBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);

        }

        private void buttonVerUgrRes_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < DataGridViewVerUgroz.Rows.Count; i++)
            //{
            //    if (((bool)DataGridViewVerUgroz.Rows[i].Cells[1].EditedFormattedValue == false) &&
            //    ((bool)DataGridViewVerUgroz.Rows[i].Cells[2].EditedFormattedValue == false) &&
            //    ((bool)DataGridViewVerUgroz.Rows[i].Cells[3].EditedFormattedValue == false) &&
            //    ((bool)DataGridViewVerUgroz.Rows[i].Cells[4].EditedFormattedValue == false))
            //    {
            //        goto exit;
            //    }
            //}
            int idIspdn;
            int IshodnZ;
            idIspdn = 0;
            IshodnZ = 0;
            DataTable tableIspdn = iSPDnBDDataSet.Tables["ISPDnOperator"];
            foreach (DataRow dataRow in tableIspdn.Rows)
            {
                string forName;
                forName = dataRow["ISPDnOperatorName"].ToString();
                string forISPDnID;
                forISPDnID = dataRow["ISPDnOperatorID"].ToString();
                string ishod;
                ishod = dataRow["ISPDnIshodZashitaID"].ToString();
                
                int conv = Convert.ToInt32(forISPDnID);
                int ishodZash = Convert.ToInt32(ishod);

                if (comboBoxISUgrozaOpasn.Text == forName) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    idIspdn = conv;
                    IshodnZ = ishodZash; // Y1 ***********************************************
                }

            }

            int ISrealis;
            int IshodZach;
            ISrealis = idIspdn; // переменная Айди ИСПДн
            IshodZach = IshodnZ; // переменная Айди исходной защищенности текущей ИС Y1

            this.mnogieVerUgrozISTableAdapter.DeleteQueryMnogieVerUgrozIS(idIspdn); // удаляем связные данные вероятности
            this.mnogieRealizUgrozTableAdapter.DeleteQueryMnogieRealUgr(ISrealis);

            string cell;
            string val;
            double realiz; // переменная кооф реализации угрозы Y
            int urver; // переменная индекса вероятности в базе для вставки в связную таблицу
            int indexReal; // переменная индекса реализации

              for (int i = 0; i < DataGridViewVerUgroz.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DataGridViewVerUgroz.Rows[i].Cells.Count; j++)
                {
                    
                    cell = DataGridViewVerUgroz.Rows[i].Cells[j].ValueType.ToString();
                    val = DataGridViewVerUgroz.Rows[i].Cells[j].Value.ToString();
                    if ((cell == "System.Boolean") && (val == "True"))
                    {
                        if (DataGridViewVerUgroz.Columns[j].HeaderText == "маловероятно")
                        {
                            int Y1;
                            Y1 = 0; // var исходной защищенности
                            urver = 1;
                            indexReal = 0;
                            realiz = 0;


                            if (IshodZach == 1)
                            {
                                Y1 = 0;
                            }
                            else if (IshodZach == 2)
                            {
                                Y1 = 5;
                            }
                            else if (IshodZach == 3)
                            {
                                Y1 = 10;
                            }
                            realiz = (Y1 + 0.0) / 20; // расчет кооф реализуемости угрозы
                            if ((0 <= realiz) && (realiz <= 0.3))
                            {
                                indexReal = 1;
                            }
                            else if ((0.3 <= realiz) && (realiz <= 0.6))
                            {
                                indexReal = 2;
                            }
                            else if ((0.6 <= realiz) && (realiz <= 0.8))
                            {
                                indexReal = 3;
                            }
                            else if (realiz <= 0.0)
                            {
                                indexReal = 4;
                            }

                            this.mnogieRealizUgrozTableAdapter.Insert(indexReal, ISrealis, i + 1, realiz.ToString()); // добовляем возможность реализации
                            this.mnogieVerUgrozISTableAdapter.Insert(i + 1, ISrealis, urver);
                        }
                        else if (DataGridViewVerUgroz.Columns[j].HeaderText == "низкая вероятность")
                        {
                            int Y1;
                            Y1 = 0;
                            urver = 2;
                            indexReal = 0;
                            // Y2 = 2
                            if (IshodZach == 1)
                            {
                                Y1 = 0;
                            }
                            else if (IshodZach == 2)
                            {
                                Y1 = 5;
                            }
                            else if (IshodZach == 3)
                            {
                                Y1 = 10;
                            }
                            realiz = (Y1 + 2.0) / 20; // расчет показателя возможномти реализации угроз
                            
                            if ((0 <= realiz) && (realiz <= 0.3))
                            {
                                indexReal = 1;
                            }
                            else if ((0.3 <= realiz) && (realiz <= 0.6))
                            {
                                indexReal = 2;
                            }
                            else if ((0.6 <= realiz) && (realiz <= 0.8))
                            {
                                indexReal = 3;
                            }
                            else if (realiz <= 0.0)
                            {
                                indexReal = 4;
                            }

                            this.mnogieRealizUgrozTableAdapter.Insert(indexReal, ISrealis, i + 1, realiz.ToString());
                            this.mnogieVerUgrozISTableAdapter.Insert(i + 1, ISrealis, urver);
                        }
                        else if (DataGridViewVerUgroz.Columns[j].HeaderText == "средняя вероятность")
                        {
                            int Y1;
                            Y1 = 0;
                            urver = 3;
                            indexReal = 0;
                            // Y2 = 5
                            if (IshodZach == 1)
                            {
                                Y1 = 0;
                            }
                            else if (IshodZach == 2)
                            {
                                Y1 = 5;
                            }
                            else if (IshodZach == 3)
                            {
                                Y1 = 10;
                            }
                            realiz = (Y1 + 5.0) / 20; // расчет показателя возможномти реализации угроз
                            
                            if ((0 <= realiz) && (realiz <= 0.3))
                            {
                                indexReal = 1;
                            }
                            else if ((0.3 <= realiz) && (realiz <= 0.6))
                            {
                                indexReal = 2;
                            }
                            else if ((0.6 <= realiz) && (realiz <= 0.8))
                            {
                                indexReal = 3;
                            }
                            else if (realiz <= 0.0)
                            {
                                indexReal = 4;
                            }

                            this.mnogieRealizUgrozTableAdapter.Insert(indexReal, ISrealis, i + 1, realiz.ToString());
                            this.mnogieVerUgrozISTableAdapter.Insert(i + 1, ISrealis, urver);
                        }
                        else if (DataGridViewVerUgroz.Columns[j].HeaderText == "высокая вероятность")
                        {
                            int Y1;
                            Y1 = 0;
                            urver = 4;
                            indexReal = 0;
                            // Y2 = 10
                            if (IshodZach == 1)
                            {
                                Y1 = 0;
                            }
                            else if (IshodZach == 2)
                            {
                                Y1 = 5;
                            }
                            else if (IshodZach == 3)
                            {
                                Y1 = 10;
                            }
                            
                            realiz = (Y1 + 10.0) / 20; // расчет показателя возможномти реализации угроз

                            if ((0 <= realiz) && (realiz <= 0.3))
                            {
                                indexReal = 1;
                            }
                            else if ((0.3 <= realiz) && (realiz <= 0.6))
                            {
                                indexReal = 2;
                            }
                            else if ((0.6 <= realiz) && (realiz <= 0.8))
                            {
                                indexReal = 3;
                            }
                            else if(realiz <= 0.0)
                            {
                                indexReal = 4;
                            }

                            this.mnogieRealizUgrozTableAdapter.Insert(indexReal, ISrealis, i + 1, realiz.ToString());
                            this.mnogieVerUgrozISTableAdapter.Insert(i + 1, ISrealis, urver);
                        }
                    }
                }

            }
        }

   }
}

