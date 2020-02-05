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
    partial class FormOpasnUgroz : Form
    {
        public FormOpasnUgroz()
        {
            InitializeComponent();
            DataGridViewOpasnUgroz.CellMouseUp += CheckedCellOnClickOpasn;
        }

        private void CheckedCellOnClickOpasn(object objSrc, DataGridViewCellMouseEventArgs e)
        {


            if (e.RowIndex >= 0)
            {// Здесь ставишь свой нужный номер колонки

                if (e.ColumnIndex == 3)            // Здесь ставишь свой нужный номер колонки
                {
                    if ((bool)DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[3].EditedFormattedValue) // кнопка помечена
                    {
                        DataGridViewOpasnUgroz.CurrentRow.Cells[4].ReadOnly = true;
                        DataGridViewOpasnUgroz.CurrentRow.Cells[5].ReadOnly = true;

                    }

                }

                else if (e.ColumnIndex == 4)            // Здесь ставишь свой нужный номер колонки
                {
                    if ((bool)DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[4].EditedFormattedValue) // кнопка помечена
                    {
                        DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                        DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[5].ReadOnly = true;
                    }

                }
                else if (e.ColumnIndex == 5)            // Здесь ставишь свой нужный номер колонки
                {
                    if ((bool)DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[5].EditedFormattedValue) // кнопка помечена
                    {
                        DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                        DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                    }

                }


                if ((e.ColumnIndex == 3) || (e.ColumnIndex == 4) || (e.ColumnIndex == 5))
                {

                    if (((bool)DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[3].EditedFormattedValue == false) &&
                    ((bool)DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[4].EditedFormattedValue == false) &&
                    ((bool)DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[5].EditedFormattedValue == false))
                    {
                        DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                        DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                        DataGridViewOpasnUgroz.Rows[e.RowIndex].Cells[5].ReadOnly = false;

                    }
                }
            }
        }
        
        private void opasnostUgrozBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);

        }

        private void FormOpasnUgroz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.NazvanieUgroz". При необходимости она может быть перемещена или удалена.
            this.nazvanieUgrozTableAdapter.Fill(this.iSPDnBDDataSet.NazvanieUgroz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.ISPDnOperator". При необходимости она может быть перемещена или удалена.
            this.iSPDnOperatorTableAdapter.Fill(this.iSPDnBDDataSet.ISPDnOperator);
        }

        private void nazvanieUgrozBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nazvanieUgrozBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);

        }

        private void buttonExitOpasnost_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /*
         * КНОПКА ДОБАВЛЕНИЯ ОПАСНОСТИ УГРОЗ
         */
        private void buttonOpasnost_Click(object sender, EventArgs e)
        {
        //    for (int i = 0; i < DataGridViewOpasnUgroz.Rows.Count; i++)
        //    {
        //        if (((bool)DataGridViewOpasnUgroz.Rows[i].Cells[3].EditedFormattedValue == false) &&
        //        ((bool)DataGridViewOpasnUgroz.Rows[i].Cells[4].EditedFormattedValue == false) &&
        //        ((bool)DataGridViewOpasnUgroz.Rows[i].Cells[5].EditedFormattedValue == false))
        //        {
        //            stroka = Convert.ToString(i + 1);
        //            MessageBox.Show("Для какойто из угроз не отмечена характеристика" + " - строка " + stroka);
        //            goto exit;
        //        }
        //     }

            DataTable tableIspdn = iSPDnBDDataSet.Tables["ISPDnOperator"];
            foreach (DataRow dataRow in tableIspdn.Rows)
            {

                string forName;
                forName = dataRow["ISPDnOperatorName"].ToString();
                string forISPDnID;
                forISPDnID = dataRow["ISPDnOperatorID"].ToString();
                int conv = Convert.ToInt32(forISPDnID);
                if (comboBoxISUgrozaOpasn.Text == forName) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    ClassGlobalVar.ISPDnID = conv;
                }
            }
            this.mnogieOpasnUgrozISTableAdapter.DeleteQueryMnogieOpasnUgrIS(ClassGlobalVar.ISPDnID);
            string cell;
            string val;
            int ugroza;
            ugroza = 0;
            for (int i = 0; i < DataGridViewOpasnUgroz.Rows.Count-1; i++)
            {
                for (int j = 0; j < DataGridViewOpasnUgroz.Rows[i].Cells.Count; j++)
                {
                    cell = DataGridViewOpasnUgroz.Rows[i].Cells[j].ValueType.ToString();
                    val = DataGridViewOpasnUgroz.Rows[i].Cells[j].Value.ToString();
                    if  ((cell == "System.Boolean") && (val == "True"))
                    {
                        if (DataGridViewOpasnUgroz.Columns[j].HeaderText == "низкая опасность")
                        {
                            ugroza = 1;
                            this.mnogieOpasnUgrozISTableAdapter.Insert(i+1, ClassGlobalVar.ISPDnID, ugroza);
                        }
                        else if (DataGridViewOpasnUgroz.Columns[j].HeaderText == "средняя опасность")
                        {
                            ugroza = 2;
                            this.mnogieOpasnUgrozISTableAdapter.Insert(i+1, ClassGlobalVar.ISPDnID, ugroza);
                        }
                        else if (DataGridViewOpasnUgroz.Columns[j].HeaderText == "высокая опасность")
                        {
                            ugroza = 3;
                            this.mnogieOpasnUgrozISTableAdapter.Insert(i+1, ClassGlobalVar.ISPDnID, ugroza);
                        }
                    }
                 }
            }
            //exit: ;
        }

        private void FormOpasnUgroz_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.NazvanieUgroz". При необходимости она может быть перемещена или удалена.
            this.nazvanieUgrozTableAdapter.Fill(this.iSPDnBDDataSet.NazvanieUgroz);
        }
              
    }
}
