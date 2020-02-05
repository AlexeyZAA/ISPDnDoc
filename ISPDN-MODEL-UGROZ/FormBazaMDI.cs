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
    public partial class MDIFormBaza : Form
    {
        private int childFormNumber = 0;

        // мои дочерние окна 
        FormOrganizationAdd frmOrgAdd = new FormOrganizationAdd();
        FormISPDnAdd frmISPDnAdd = new FormISPDnAdd();
        FormOtdelAdd frmOtdelAdd = new FormOtdelAdd();
        FormKlassIS frmKlassIS = new FormKlassIS();


        public MDIFormBaza()
        {
            InitializeComponent();
            frmOrgAdd.MdiParent = this;
            frmISPDnAdd.MdiParent = this;
            frmOtdelAdd.MdiParent = this;
            frmKlassIS.MdiParent = this;
        }

       

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Окно " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

    
        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmOrgAdd.Show();
        }

        // открытие инфы при загрузке
        private void MDIFormBaza_Load(object sender, EventArgs e)
        {
            frmOrgAdd.Show();
        }

        // открытие формы редактирования организации 

        private void toolStripButtonOrgAdd_Click(object sender, EventArgs e)
        {
            // проверяем если запись организации есть то кнопки ИСПДн и Подразделения делаем активными
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            this.orgOperatorTableAdapterOrgAdd.Fill(ds.OrgOperator); // обновляем ДатаСет
            DataTable tableOrg = ds.Tables["OrgOperator"]; // создаем экземпляр таблицы Организации

            frmOrgAdd.Show();
            frmISPDnAdd.Hide();
            frmOtdelAdd.Hide();
            frmKlassIS.Hide();
        }

    
       private void toolStripISPDn_Click(object sender, EventArgs e)
        {
            frmISPDnAdd.Show();
            frmOrgAdd.Hide();
            frmOtdelAdd.Hide();
            frmKlassIS.Hide();
        }

        private void toolStripButtonOtdel_Click(object sender, EventArgs e)
        {
            frmOtdelAdd.Show();
            frmOrgAdd.Hide();
            frmISPDnAdd.Hide();
            frmKlassIS.Hide();
        }

        private void toolStripButtonKlassIS_Click(object sender, EventArgs e)
        {
            frmKlassIS.Show();
            frmOtdelAdd.Hide();
            frmOrgAdd.Hide();
            frmISPDnAdd.Hide();
        }


        private void toolStripButtonModelUgroz_Click(object sender, EventArgs e)
        {
            FormModelUgrozMDI frmModelugroz = new FormModelUgrozMDI();
            frmModelugroz.Show();
        }
        
        private void toolStripButtonDocum_Click(object sender, EventArgs e)
        {
            FormDocumentMDI frmDoc = new FormDocumentMDI();
            frmDoc.Show();
        }



    }
}
