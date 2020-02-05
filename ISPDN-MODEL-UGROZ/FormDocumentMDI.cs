using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;

namespace SpaseFormISPDn
{
    public partial class FormDocumentMDI : Form
    {
        
        public FormDocumentMDI()
        {
            InitializeComponent();

        }

         public void toolStripButtonDocKlass_Click(object sender, EventArgs e)
        {
            FormKlassIS frmKlassIS = new FormKlassIS();
            frmKlassIS.MdiParent = this;
            frmKlassIS.Show();
        }

        private void toolStripButtonUvedoml_Click(object sender, EventArgs e)
        {
            FormDocumentUved frmUved = new FormDocumentUved();
            frmUved.MdiParent = this;
            frmUved.Show();
        }

        private void toolStripButtonSoglasie_Click(object sender, EventArgs e)
        {
            FormDocumentSoglasie frmSoglas = new FormDocumentSoglasie();
            frmSoglas.MdiParent = this;
            frmSoglas.Show();
        }

        private void toolStripButtonKomplexDoc_Click(object sender, EventArgs e)
        {
            FormDocumentAll frmKompleksDoc = new FormDocumentAll();
            frmKompleksDoc.MdiParent = this;
            frmKompleksDoc.Show();
        }

        private void FormDocumentMDI_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonModelUgroz_Click(object sender, EventArgs e)
        {
            FormModelUgrozMDI frmModelugroz = new FormModelUgrozMDI();
            frmModelugroz.Show();
        }

    }
}
