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
    public partial class FormDocumentSoglasie : Form
    {
        public FormDocumentSoglasie()
        {
            InitializeComponent();
        }

        private void FormDocumentSoglasie_Load(object sender, EventArgs e)
        {
           // проверяем флажок биометр перс данных
            int countbio = ClassMetodSpecBioPD.BioPdCountMetod();
            if (countbio > 0)
            {
                this.checkBoxBioPD.Enabled = true;
            }
            else
            {
                this.checkBoxBioPD.Enabled = false;
            }
            
            // проверяем флажок специальных данных
            int countspecOtd = ClassMetodSpecBioPD.SpecOtdelPdCountMetod();
            int countspecIs = ClassMetodSpecBioPD.SpecIsPdCountMetod();
            if ((countspecOtd > 0) || (countspecIs > 0))
            {
                this.checkBoxSpecPD1.Enabled = true;
                this.checkBoxSpecPD2.Enabled = true;
                this.checkBoxSpecPD3.Enabled = true;
                this.checkBoxSpecPD4.Enabled = true;
                this.checkBoxSpecPD5.Enabled = true;
                this.checkBoxSpecPD6.Enabled = true;
                this.checkBoxSpecPD7.Enabled = true;
                this.checkBoxSpecPD8.Enabled = true;
                this.checkBoxSpecPD9.Enabled = true;
                this.checkBoxSpecPD10.Enabled = true;
                this.checkBoxSpecPD11.Enabled = true;
            }
            else
            {
                this.checkBoxSpecPD1.Enabled = false;
                this.checkBoxSpecPD2.Enabled = false;
                this.checkBoxSpecPD3.Enabled = false;
                this.checkBoxSpecPD4.Enabled = false;
                this.checkBoxSpecPD5.Enabled = false;
                this.checkBoxSpecPD6.Enabled = false;
                this.checkBoxSpecPD7.Enabled = false;
                this.checkBoxSpecPD8.Enabled = false;
                this.checkBoxSpecPD9.Enabled = false;
                this.checkBoxSpecPD10.Enabled = false;
                this.checkBoxSpecPD11.Enabled = false;
            }
        }

        // проверяем условия и формируем согласие
        private void buttonSoglasieCreate_Click(object sender, EventArgs e)
        {
            int countBio = ClassMetodSpecBioPD.BioPdCountMetod();
            int countSpecIs = ClassMetodSpecBioPD.SpecIsPdCountMetod();
            int countSpecOtdel =ClassMetodSpecBioPD.SpecOtdelPdCountMetod();
            int countDopIs = ClassMetodOsnDopPd.DopolnitPdCountISMetod();
            int countDopOtdel = ClassMetodOsnDopPd.DopolnitPdCountOtdelMetod();
            int countOsnIs = ClassMetodOsnDopPd.IsPdCountMetod();
            int countOsnOtdel = ClassMetodOsnDopPd.OtdelPdCountMetod();

            if ((countBio > 0 && this.checkBoxBioPD.Checked == false)
                || ((countSpecIs > 0 || countSpecOtdel > 0) && (this.checkBoxSpecPD1.Checked == false && this.checkBoxSpecPD2.Checked == false &&
                this.checkBoxSpecPD3.Checked == false && this.checkBoxSpecPD4.Checked == false && this.checkBoxSpecPD5.Checked == false &&
                this.checkBoxSpecPD6.Checked == false && this.checkBoxSpecPD7.Checked == false && this.checkBoxSpecPD8.Checked == false &&
                this.checkBoxSpecPD9.Checked == false && this.checkBoxSpecPD10.Checked == false && this.checkBoxSpecPD11.Checked == false))
                || ((countOsnIs > 0 || countOsnOtdel > 0 || countDopIs > 0 || countDopOtdel > 0)
                && (checkBoxP1S6.Checked == false && checkBoxP2S6.Checked == false && checkBoxP3S6.Checked == false && checkBoxP4S6.Checked == false &&
                checkBoxP5S6.Checked == false && checkBoxP6S6.Checked == false && checkBoxP7S6.Checked == false && checkBoxP8S6.Checked == false &&
                checkBoxP9S6.Checked == false && checkBoxP10S6.Checked == false))
                || (this.checkBoxSoglasie.Checked == true))
            {
                
                MessageBox.Show("Исходя из отмеченных параметров Будет сформировано согласие");
                ClassMetodDocumentCreate DocCreateClass = new ClassMetodDocumentCreate();
                // сохраняем Уведомление об обработке
                MyDelegateWord delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateSoglasie);
                DocCreateClass.OpenSaveDocMethod("\\Sabl\\Soglasie\\sSoglasieNaObrabotkuOtziv.dot",
                    "\\GotovDoc\\Soglasie\\SoglasieNaObrabotkuOtziv.doc", delegateTempl);
                DocCreateClass.oWord.Quit();
            }
            else
            {
                MessageBox.Show("Исходя из отмеченных параметров согласие не требуется");
            }
        }
        


        private void buttonSubj_Click(object sender, EventArgs e)
        {
            FormSubjAll frmSubjAll = new FormSubjAll();
            frmSubjAll.Show();
        }

        
    }
}
