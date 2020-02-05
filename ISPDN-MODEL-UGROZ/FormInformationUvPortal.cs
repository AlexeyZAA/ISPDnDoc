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
    public partial class FormInformationUvPortal : Form
    {
        public FormInformationUvPortal()
        {
            InitializeComponent();
        }

        private void buttonUvDoc_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        // присваиваем полям информационной формы текст
        private void FormInformationUvPortal_Load(object sender, EventArgs e)
        {
            this.textBoxNameOrgFull.Text = ClassMetodOrg.NameOrgPolnMetod(); // получение полного названия оператора
            this.textBoxNameOrgKratk.Text = ClassMetodOrg.NameOrgKratkMetod(); // получение краткого названия оператора
            this.textBoxAdressOper.Text = ClassMetodOrg.AdressOrgMetod();
            this.textBoxRekvisitOper.Text = ClassMetodOrg.INNOrgMetod(); // получение реквизитов оператора
            this.textBoxCelOper.Text = ClassMetodCeli.CeliOrgMetod(ClassGlobalVar.OrgID); // получение целей оператора
            this.textBoxKategoryPD.Text = ClassMetodKategoryPD.KategoryPdAllMetod(); // получение категорий ПД оператора
            this.textBoxSubjOper.Text = ClassMetodSubj.SubjAllMetod(); // получение Субъектов ПД оператора
        }

    }
}
