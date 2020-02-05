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
    public partial class FormCeliAdd : Form
    {
        public FormCeliAdd()
        {
            InitializeComponent();
        }

        private void celiObrabotkiPDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.celiObrabotkiPDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);

        }


        private void buttonCeliAdd_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.CeliObrabotkiPDTableAdapter.Update(this.iSPDnBDDataSet);
            try
            {
                FormISPDnAdd frmispdn = (FormISPDnAdd)this.Owner;
                frmispdn.MethodCeliSelect();
            }
            catch
            {
                FormOtdelAdd frmotdel = (FormOtdelAdd)this.Owner;
                frmotdel.MethodCeliSelect();
            }
                FormCeliAdd.ActiveForm.Close();
         }

        private void celiObrabotkiPDBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.celiObrabotkiPDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);
            this.celiObrabotkiPDTableAdapter.MetodCeliOrgSelect(iSPDnBDDataSet.CeliObrabotkiPD, ClassGlobalVar.OrgID);
        }

        private void FormCeliAdd_Load(object sender, EventArgs e)
        {
            this.celiObrabotkiPDTableAdapter.MetodCeliOrgSelect(iSPDnBDDataSet.CeliObrabotkiPD, ClassGlobalVar.OrgID);
        }

        private void celiObrabotkiPDDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            celiObrabotkiPDDataGridView.CurrentRow.Cells[3].Value = ClassGlobalVar.OrgID;
        }

    }
}
