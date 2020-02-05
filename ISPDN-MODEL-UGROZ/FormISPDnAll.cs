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
    public partial class FormISPDnAll : Form
    {
        public FormISPDnAll()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.ISPDnOperatorTableAdapter.Update(this.iSPDnBDDataSet);
            FormISPDnAdd frmispdn = (FormISPDnAdd)this.Owner;
            frmispdn.ComboISPDnMethod(ClassGlobalVar.OrgID);
            frmispdn.MethodISPDnDataSetUpdate();
            FormISPDnAll.ActiveForm.Close();
        }

        private void FormISPDnAll_Load(object sender, EventArgs e)
        {
            this.iSPDnOperatorTableAdapter.Fill(iSPDnBDDataSet.ISPDnOperator);
        }

        private void iSPDnOperatorDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.iSPDnOperatorAllDataGridView.CurrentRow.Cells[2].Value = ClassGlobalVar.OrgID;
        }
    }
}
