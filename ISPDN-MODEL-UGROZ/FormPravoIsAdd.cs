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
    public partial class FormPravoIsAdd : Form
    {
        public FormPravoIsAdd()
        {
            InitializeComponent();
        }

        private void pravoOrgBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pravoOrgBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSPDnBDDataSet);

        }

        private void FormPravoIsAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.PravoOrg". При необходимости она может быть перемещена или удалена.
            this.pravoOrgTableAdapter.Fill(this.iSPDnBDDataSet.PravoOrg);

        }

        private void buttonPravoAdd_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.PravoOrgTableAdapter.Update(this.iSPDnBDDataSet);
            try
            {
                FormISPDnAdd frmispdn = (FormISPDnAdd)this.Owner;
                frmispdn.MethodPravoSelectTrue(true);
            }
            catch
            {
                FormOtdelAdd frmotdel = (FormOtdelAdd)this.Owner;
                frmotdel.MethodPravoSelectTrue(true);
            }
            FormCeliAdd.ActiveForm.Close();
        }

    }
}
