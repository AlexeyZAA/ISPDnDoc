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
    public partial class FormSubjectPDAdd : Form
    {
        public FormSubjectPDAdd()
        {
            InitializeComponent();
        }

        private void FormSubjectPDAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.KategorySubj". При необходимости она может быть перемещена или удалена.
            this.kategorySubjTableAdapter.MetodKategorySubSelect(iSPDnBDDataSet.KategorySubj, ClassGlobalVar.OrgID);
        }


        private void kategorySubjBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kategorySubjBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);
        }


        private void kategorySubjBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.kategorySubjBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);
            this.kategorySubjTableAdapter.MetodKategorySubSelect(iSPDnBDDataSet.KategorySubj, ClassGlobalVar.OrgID);
        }


        private void kategorySubjDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            kategorySubjDataGridView.CurrentRow.Cells[3].Value = ClassGlobalVar.OrgID;
        }

        private void buttonSubjectPDAddExit_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.KategorySubjTableAdapter.Update(this.iSPDnBDDataSet);
            try
            {
                FormISPDnAdd frmispdn = (FormISPDnAdd)this.Owner;
                frmispdn.MethodSubjectSelect();
            }
            catch 
            {
                FormOtdelAdd frmotdel = (FormOtdelAdd)this.Owner;
                frmotdel.MethodSubjectSelect();
            }
                FormSubjectPDAdd.ActiveForm.Close();
        }


    }
}
