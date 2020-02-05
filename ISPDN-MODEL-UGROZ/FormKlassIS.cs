using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SpaseFormISPDn;
//using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
//using Microsoft.Office.Interop.Word;

namespace SpaseFormISPDn
{
    partial class FormKlassIS : Form
    {
        public FormKlassIS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonKlassIS_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewChlenKomiss.Rows.Count == 0)
            {
                MessageBox.Show("Нет членов комиссии для добавления в документ");
                goto Theend;
            }

            DataTable tableIspdn = iSPDnBDDataSet.Tables["ISPDnOperator"];
            if (tableIspdn.Rows.Count == 0)
            {
                MessageBox.Show("Нет ИСПДн для классификации");
                goto Theend;
            }
            else
            {
                foreach (DataRow dataRow in tableIspdn.Rows)
                {
                    string forName;
                    forName = dataRow["ISPDnOperatorName"].ToString();
                    string forISPDnID;
                    forISPDnID = dataRow["ISPDnOperatorID"].ToString();
                    if (this.comboBoxISPDnKl.Text == forName) // Если  Имя Поля названиеИС равно имени в Базе
                    {
                        ClassGlobalVar.ISPDnID = Convert.ToInt32(forISPDnID);
                    }
                }
            }

            // метод параметров классификации... смотреть ниже
            string Klas = KlassifikationMethod(); //вставляем класс
            if (Klas != "")
            {
                MessageBox.Show("класс ИСПДн определен как" + " " + Klas);
            }

            string Komiss = "";
            for (int i = 0; i < this.dataGridViewChlenKomiss.Rows.Count; i++)
            {
                Komiss = Komiss + this.dataGridViewChlenKomiss.Rows[i].Cells[0].Value + "\n";
                ClassGlobalVar.KomisKlassIS = Komiss;
            }
            ClassMetodDocumentCreate DocCreateClass = new ClassMetodDocumentCreate();
            // Считывает шаблон приказа Классификации и сохраняет измененный в новом 1
            MyDelegateWord delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazKlass);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\KlassISPDn\\sPrikazKlassISPDn.dot",
                "\\GotovDoc\\KlassISPDn\\PrikazKlassISPDn.doc", delegateTempl);

            // Считывает шаблон Акта Классификации и сохраняет измененный в новом 2
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateAktKlass);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\KlassISPDn\\sAktKlassISPDn.dot",
                "\\GotovDoc\\KlassISPDn\\AktKlassISPDn.doc", delegateTempl);
            DocCreateClass.oWord.Quit();
        /*private void buttonPrint_Click(object sender, EventArgs e)
        {
            // Создание документа для печати
            _Document oDoc = GetDoc(Environment.CurrentDirectory + "\\Doc_propusk.dotx");
            oDoc.PrintOut();
            oDoc.Close(WdSaveOptions.wdDoNotSaveChanges);
        }*/
        Theend: ;
        }

          /*/ метод параметров классификации.
        ------------------------------------------*/
        /*Проверяем установлены ли чекбоксы в разделе категории обрабатываемых ПД*/
       
        private string KlassifikationMethod()
        {  string Klass;
           Klass = "";
            if ((RadioKategoryI.Checked == false) && (RadioKategoryII.Checked == false) &&
                (RadioKategoryIII.Checked == false) && (RadioKategoryIV.Checked == false))
            {
                MessageBox.Show("Введите параметры категории ИСПДн");
                goto Theend;
            }
            else if (RadioKategoryI.Checked == true) 
            {
                iSPDnOperatorTableAdapter.UpdateKategoryISPDn(1, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
            }
            else if (RadioKategoryII.Checked == true)
            {
                iSPDnOperatorTableAdapter.UpdateKategoryISPDn(2, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID); 
            }
            else if (RadioKategoryIII.Checked == true)
            {
                iSPDnOperatorTableAdapter.UpdateKategoryISPDn(3, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID); 
            }
            else if (RadioKategoryIV.Checked == true)
            {
                iSPDnOperatorTableAdapter.UpdateKategoryISPDn(4, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);   
            }

           /*проверяем установлены ли чекбоксы объема обрабатываемых данных*/ 
           
            if ((RadioObemI.Checked == false) && (RadioObemII.Checked == false) &&
                (RadioObemIII.Checked == false))
            {
                MessageBox.Show("Введите параметры Обема ПД ИСПДН");
                goto Theend;
            }
            else if (RadioObemI.Checked == true)
            {
                iSPDnOperatorTableAdapter.UpdateObiemPD(1, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);   
            }
            else if (RadioObemII.Checked == true)
            {
                iSPDnOperatorTableAdapter.UpdateObiemPD(2, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
            }
            else if (RadioObemIII.Checked == true)
            {
                iSPDnOperatorTableAdapter.UpdateObiemPD(3, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
            }
          
          /*проверяем установлены ли чекбоксы типа ИСПДн*/

           if ((RadioCpecialnaya.Checked == false) && (RadioTipovaya.Checked == false))
            {
                MessageBox.Show("Выберите какой у Вас тип ИСПДн");
                goto Theend;
            }
           else if (RadioCpecialnaya.Checked == true)
           {
               iSPDnOperatorTableAdapter.UpdateTipISPDn(2, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
           }
           else if (RadioTipovaya.Checked == true)
           {
               iSPDnOperatorTableAdapter.UpdateTipISPDn(1, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
           }

           /*выбираем параметры и определяем на их основе класс ИС*/

            if (RadioKategoryI.Checked == true && RadioObemI.Checked == true)
            {
                Klass = "K1";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(1, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }

            if (RadioKategoryI.Checked == true && RadioObemII.Checked == true)
            {
                Klass = "K1";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(1, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }
            if (RadioKategoryI.Checked == true && RadioObemIII.Checked == true)
            {
                Klass = "K1";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(1, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }

            if (RadioKategoryII.Checked == true && RadioObemI.Checked == true)
            {
                Klass = "K1";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(1, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }

            if (RadioKategoryII.Checked == true && RadioObemII.Checked == true)
            {
                Klass = "K2";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(2, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }

            if (RadioKategoryII.Checked == true && RadioObemIII.Checked == true)
            {
                Klass = "K3";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(3, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;

            }
            if (RadioKategoryIII.Checked == true && RadioObemI.Checked == true)
            {
                Klass = "K2";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(2, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;

            }
            if (RadioKategoryIII.Checked == true && RadioObemII.Checked == true)
            {
                Klass = "K3";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(3, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }

            if (RadioKategoryIII.Checked == true && RadioObemIII.Checked == true)
            {
                Klass = "K3";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(3, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }

            if (RadioKategoryIV.Checked == true && RadioObemI.Checked == true)
            {
                Klass = "K4";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(4, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;

            }
            if (RadioKategoryIV.Checked == true && RadioObemII.Checked == true)
            {
                Klass = "K4";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(4, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }

            if (RadioKategoryIV.Checked == true && RadioObemIII.Checked == true)
            {
                Klass = "K4";
                iSPDnOperatorTableAdapter.UpdateKlassISPDn(4, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                goto Theend;
            }
            
            Theend: ;
        return Klass;
        }

        private void FormKlassIS_Load(object sender, EventArgs e)
        {
            this.iSPDnOperatorTableAdapter.MetodSelectComboISPDn(this.iSPDnBDDataSet.ISPDnOperator, ClassGlobalVar.OrgID);
        }

        private void FormKlassIS_Activated(object sender, EventArgs e)
        {
            this.iSPDnOperatorTableAdapter.Fill(iSPDnBDDataSet.ISPDnOperator);
        }

    }
}
