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
    public partial class FormBioAdd : Form
    {
        public FormBioAdd()
        {
            InitializeComponent();
        }

        private void kategoryPdBioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kategoryPdBioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);

        }

        private void FormBioAdd_Load(object sender, EventArgs e)
        {
            this.kategoryPdBioTableAdapter.MetodBioOrgSelect(iSPDnBDDataSet.KategoryPdBio, ClassGlobalVar.OrgID);

        }

        private void kategoryPdBioDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.kategoryPdBioDataGridView.CurrentRow.Cells[2].Value = ClassGlobalVar.OrgID;
        }

        private void buttonBioAdd_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.KategoryPdBioTableAdapter.Update(this.iSPDnBDDataSet);
            try
            {
                FormISPDnAdd frmispdn = (FormISPDnAdd)this.Owner;
                frmispdn.MethodKategoryBioSelectTrue();
            }
            catch
            {
                FormOtdelAdd frmotdel = (FormOtdelAdd)this.Owner;
                frmotdel.MethodKategoryBioSelectTrue();
            }
            FormBioAdd.ActiveForm.Close();
        }
    }
}
