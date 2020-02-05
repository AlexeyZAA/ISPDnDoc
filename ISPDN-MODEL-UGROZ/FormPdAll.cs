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
    public partial class FormSubjAll : Form
    {
        public FormSubjAll()
        {
            InitializeComponent();
        }

        private void FormPdAll_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.KategorySubj". При необходимости она может быть перемещена или удалена.
            this.kategorySubjTableAdapter.Fill(this.iSPDnBDDataSet.KategorySubj);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSPDnBDDataSet.MnogieISPDnKategoryPD". При необходимости она может быть перемещена или удалена.
            this.mnogieISPDnKategoryPDTableAdapter.Fill(this.iSPDnBDDataSet.MnogieISPDnKategoryPD);
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
