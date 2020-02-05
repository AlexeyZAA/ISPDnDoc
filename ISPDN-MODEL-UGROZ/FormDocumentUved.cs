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
    public partial class FormDocumentUved : Form
    {
        public FormDocumentUved()
        {
            InitializeComponent();
        }

        private void buttoConfirParUvedoml_Click(object sender, EventArgs e)
        {
            if (checkBoxNoUved10.Checked == true || checkBoxNoUved11.Checked == true || checkBoxNoUved12.Checked == true)
            {
                MessageBox.Show("Сейчас будет сформирована информация требуемая для внесения на портале персональных данных," +
                "для формирования уведомления, для этого необходимо добавить некоторые параметры ");
                ClassMetodDocumentCreate DocCreateClass = new ClassMetodDocumentCreate();
                // сохраняем Уведомление об обработке
                MyDelegateWord delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateUv);
                DocCreateClass.OpenSaveDocMethod("\\Sabl\\UvedomleniePD\\sUvedomleniePortal.dot",
                    "\\GotovDoc\\UvedomleniePD\\UvedomleniePortal.doc", delegateTempl);
                DocCreateClass.oWord.Quit();
                FormInformationUvPortal frmInfoUv = new FormInformationUvPortal();
                frmInfoUv.Show();
             }
            else
            {
                string punkt = "";
                if (this.checkBoxNoUved1.Checked)
                {
                    punkt = punkt + "1, ";
                }
                if (this.checkBoxNoUved2.Checked)
                {
                    punkt = punkt + "2, ";
                }
                if (this.checkBoxNoUved3.Checked)
                {
                    punkt = punkt + " 3, ";
                }
                if (this.checkBoxNoUved4.Checked)
                {
                    punkt = punkt + "4, ";
                }
                if (this.checkBoxNoUved5.Checked)
                {
                    punkt = punkt + "5, ";
                }
                if (this.checkBoxNoUved6.Checked)
                {
                    punkt = punkt + "6, ";
                }
                if (this.checkBoxNoUved7.Checked)
                {
                    punkt = punkt + "7, ";
                }
                if (this.checkBoxNoUved8.Checked)
                {
                    punkt = punkt + "8, ";
                }
                if (this.checkBoxNoUved9.Checked)
                {
                    punkt = punkt + "9, ";
                }
                string punktAll;
                punktAll = punkt.Remove(punkt.Length - 2, 2);
                ClassGlobalVar.Punkt222 = punktAll;
                MessageBox.Show("В соответствии с отмеченными Вами функциями, уведомления не требуется, будет сформировано письмо со ссылкой на ч. 2 статью 22");
                ClassMetodDocumentCreate DocCreateClass = new ClassMetodDocumentCreate();
                // сохраняем письмо ч 2 ст 22
                MyDelegateWord delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplate222);
                DocCreateClass.OpenSaveDocMethod("\\Sabl\\UvedomleniePD\\sUvedomlenie2-22.dot",
                    "\\GotovDoc\\UvedomleniePD\\Uvedomlenie2-22.doc", delegateTempl);
                DocCreateClass.oWord.Quit();
            }
        }


        private void buttonExitUv_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

  }
}
