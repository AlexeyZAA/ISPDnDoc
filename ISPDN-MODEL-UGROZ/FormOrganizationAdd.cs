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
    partial class FormOrganizationAdd : Form
    {
        public FormOrganizationAdd()
        {
            InitializeComponent(); // инициализируем компоненты формы
        }


        private void buttonOrgAdd_Click(object sender, EventArgs e)
        {
            if ((this.textInnOrgAdd.Text.Length != 10) && (this.textInnOrgAdd.Text.Length < 13))
            {
                MessageBox.Show(" Проверьте количество символов в ИНН");
                goto close;
            }

            MethodOrgAdd();
            close: ;
        }



        private void buttonSuhOrg_Click(object sender, EventArgs e)
        {
            textOrgKratkNameOrgAdd.Text = "";
            textOrgNameOrgAdd.Text = "";
            textInnOrgAdd.Text = "";
            textRukOrgAdd.Text = "";
            textDolgnRukOrgAdd.Text = "";

            textOrgKratkNameOrgAdd.Enabled = false;
            textOrgNameOrgAdd.Enabled = false;
            textInnOrgAdd.Enabled = false;
            textRukOrgAdd.Enabled = false;
            textDolgnRukOrgAdd.Enabled = false;
        }


        private void textInnOrgAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

            }
        }

        
        /** метод для кнопки добавления организации 
        ------------------------------------------------------------------------------------------------
        */

        private void MethodOrgAdd()
        {

            DataTable tableOrg = iSPDnBDDataSet.Tables["OrgOperator"]; // создаем экземпляр таблицы Организации
            this.orgOperatorTableAdapter.Fill(iSPDnBDDataSet.OrgOperator); // обновляем ДатаСет
            try
            {
                if (tableOrg.Rows.Count == 0)
                {
                    /// вставляем данные по организации из формы "FormOrganizationAdd" в базу
                    this.orgOperatorTableAdapter.Insert(this.textOrgKratkNameOrgAdd.Text, // -- далее
                    this.textOrgNameOrgAdd.Text, textInnOrgAdd.Text, this.textRukOrgAdd.Text,  // -- далее
                    this.textDolgnRukOrgAdd.Text, this.textBoxAdressOrg.Text); // -- пришли

                    this.orgOperatorTableAdapter.Fill(iSPDnBDDataSet.OrgOperator); // обновляем ДатаСет
                    foreach (DataRow dataRow in tableOrg.Rows)
                    {
                        string forOrgINN = dataRow["OrgOperatorINN"].ToString();
                        string forOrgID = dataRow["OrgOperatorID"].ToString(); ;
                        if (this.textInnOrgAdd.Text == forOrgINN) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            ClassGlobalVar.OrgID = Convert.ToInt32(forOrgID);
                            MessageBox.Show("Организация добавлена");
                        }
                    }
                }
                else if (tableOrg.Rows.Count > 0)
                {
                    this.orgOperatorTableAdapter.UpdateQueryOrgMetod(textOrgKratkNameOrgAdd.Text, textOrgNameOrgAdd.Text,
                    textInnOrgAdd.Text, textRukOrgAdd.Text, textDolgnRukOrgAdd.Text, 1);
                    this.orgOperatorTableAdapter.Fill(iSPDnBDDataSet.OrgOperator); // обновляем ДатаСет
                    foreach (DataRow dataRow in tableOrg.Rows)
                    {
                        string forOrgINN = dataRow["OrgOperatorINN"].ToString();
                        string forOrgID = dataRow["OrgOperatorID"].ToString(); ;
                        if (this.textInnOrgAdd.Text == forOrgINN) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            ClassGlobalVar.OrgID = Convert.ToInt32(forOrgID);
                            MessageBox.Show("Организация обновлена");
                        }
                    }
                }
           }
            catch
            {
                MessageBox.Show("какаято ошибка");
            }
           } 

        private void FormOrganizationAdd_Load(object sender, EventArgs e)
        {
            ClassGlobalVar.INN = this.textInnOrgAdd.Text;
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            this.orgOperatorTableAdapter.Fill(ds.OrgOperator); // обновляем ДатаСет
            DataTable tableOrg = ds.Tables["OrgOperator"]; // создаем экземпляр таблицы Организации
            if (tableOrg.Rows.Count > 0)
            {
                foreach (DataRow dataRow in tableOrg.Rows)
                {
                    int indexRow = Convert.ToInt32(dataRow["OrgOperatorID"].ToString());
                    string orgKratk = dataRow["OrgOperatorKratkName"].ToString();
                    string orgFull = dataRow["OrgOperatorFullName"].ToString();
                    string orgINN = dataRow["OrgOperatorINN"].ToString();
                    string orgRukDoln = dataRow["OrgOperatorRukovoditelDolgn"].ToString();
                    string orgRukName = dataRow["OrgOperatorRukovoditelName"].ToString();
                    string orgAdress = dataRow["OrgOperatorAdress"].ToString();
                    
                    if (indexRow == 1) // Если текстовое поле равно записи в базе
                    {
                        ClassGlobalVar.OrgID = indexRow;
                        this.textOrgKratkNameOrgAdd.Text = orgKratk;
                        this.textOrgNameOrgAdd.Text = orgFull;
                        this.textInnOrgAdd.Text = orgINN;
                        this.textRukOrgAdd.Text = orgRukDoln;
                        this.textDolgnRukOrgAdd.Text = orgRukName;
                        this.textBoxAdressOrg.Text = orgAdress;
                    }
                }
            }
        }
    }
}
