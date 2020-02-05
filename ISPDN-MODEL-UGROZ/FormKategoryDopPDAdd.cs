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
    public partial class FormKategoryDopPDAdd : Form
    {
        public FormKategoryDopPDAdd()
        {
            InitializeComponent();
        }

        private void kategoryPdDopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kategoryPdDopBindingSource.EndEdit();
            this.tableAdapterManager.KategoryPdDopTableAdapter.Update(this.iSPDnBDDataSet);
            this.tableAdapterManager.KategoryPdDopTableAdapter.Fill(iSPDnBDDataSet.KategoryPdDop);
         }

        private void FormKategoryDopPDAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.KategoryPdDop". При необходимости она может быть перемещена или удалена.
            this.kategoryPdDopTableAdapter.MetodKategoruDopPDSelect(iSPDnBDDataSet.KategoryPdDop, ClassGlobalVar.OrgID);
        }

        private void buttonKategoryDopPDAddP_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.KategoryPdDopTableAdapter.Update(this.iSPDnBDDataSet);
            try
            {
                FormISPDnAdd frmKategoryPDDop = (FormISPDnAdd)this.Owner;
                frmKategoryPDDop.MethodKategoryDopSelect();
            }
            catch
            {
                FormOtdelAdd frmKategoryDop = (FormOtdelAdd)this.Owner;
                frmKategoryDop.MethodKategoryDopSelect();
                
            }
            FormKategoryDopPDAdd.ActiveForm.Close();
        }

        private void kategoryPdDopDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            kategoryPdDopDataGridView.CurrentRow.Cells[3].Value = ClassGlobalVar.OrgID;
        }

        private void kategoryPdDopDataGridView_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            kategoryPdDopDataGridView.CurrentRow.Cells[3].Value = ClassGlobalVar.OrgID;
        }
    }
}
