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
    public partial class FormRabotnikiPDAdd : Form
    {
        public FormRabotnikiPDAdd()
        {
            InitializeComponent();
        }

        private void rabotnikiOrgBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rabotnikiOrgBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);
            this.rabotnikiOrgTableAdapter.MetodRabotnikiSelect(iSPDnBDDataSet.RabotnikiOrg, ClassGlobalVar.OrgID);
        }

        private void FormRabotnikiPDAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.RabotnikiOrg". При необходимости она может быть перемещена или удалена.
            this.rabotnikiOrgTableAdapter.Fill(this.iSPDnBDDataSet.RabotnikiOrg);

        }

        private void buttonRabotnikiAddExit_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.RabotnikiOrgTableAdapter.Update(this.iSPDnBDDataSet);
            try
            {
                FormISPDnAdd frmispdn = (FormISPDnAdd)this.Owner;
                frmispdn.MethodRabotnikiSelect();
            }
            catch
            {
                FormOtdelAdd frmotdel = (FormOtdelAdd)this.Owner;
                frmotdel.MethodRabotnikiSelect();
            }
            FormRabotnikiPDAdd.ActiveForm.Close();
        }

        private void rabotnikiOrgDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            rabotnikiOrgDataGridView.CurrentRow.Cells[3].Value = ClassGlobalVar.OrgID;
        }
    }
}
