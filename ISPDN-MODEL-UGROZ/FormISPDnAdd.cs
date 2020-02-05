using System;
using System.Data;
using System.Windows.Forms;

namespace SpaseFormISPDn
{
    partial class FormISPDnAdd : Form
    {
        // инициализация компонентов формы
        public FormISPDnAdd()
        {
            InitializeComponent();
        }

        /****************************************************************************************/
        //РАЗДЕЛ ЗАГРУЗКИ ФОРМЫ - SECTION DOWNLOAD FORMS
        /****************************************************************************************/

        /* загружаем данные в таблицы при загрузке формы - load the data into a table when the form loads*/

        private void FormIspdnAdd_Load(object sender, EventArgs e)
        {
            ComboISPDnMethod(ClassGlobalVar.OrgID);
            this.MethodISPDnDataSetUpdate();
        }

        public void ComboISPDnMethod(int orgId)
        {
            this.ispDnOperatorTableAdapter.MetodSelectComboISPDn(this.iSPDnBDDataSet.ISPDnOperator, orgId);
        }



        /****************************************************************************************/
        //РАЗДЕЛ ОБРАБОТКИ СОБЫТИЙ ЭЛЕМЕНТОВ УПРАВЛЕНИЯ (ЧЕКБОКСОВ)
        /****************************************************************************************/

        /* 
         * устанавливаем флажкам судимости, специальным и биометрическим свойства 
         */
        private void checkBoxSpecPD_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxSpecPD.Checked == true)
            {
                this.checkBoxSudimost.Enabled = true;
                this.checkedListBoxSpecKatPD.Enabled = true;
            }
            else
            {
                this.checkBoxSudimost.Enabled = false;
                this.checkedListBoxSpecKatPD.Enabled = false;
            }
        }

        /* 
         * обработка события смены свойства флажка биометрических персональных данных
         */
        private void checkBoxBioKatPD_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxBioKatPD.Checked == true)
            {
                this.kategoryPdBioDataGridView.Enabled = true;
                this.buttonFormBioAdd.Enabled = true;
            }
            else
            {
                this.kategoryPdBioDataGridView.Enabled = false;
                this.buttonFormBioAdd.Enabled = false;
            }
        }

        /****************************************************************************************/
        //РАЗДЕЛ обработки нажатия кнопок
        /****************************************************************************************/

        // НАжатие кнопки выхода
        private void buttonExitISPDn_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void buttonAktivRedIspdn_Click(object sender, EventArgs e)
        {
            FormISPDnAll frmISall = new FormISPDnAll();
            frmISall.Owner = this; //Передаём вновь созданной форме её владельца.
            frmISall.Show();
        }
        /* КНОПКА открываем форму добовления субъектов персональных данных, оставляем связь с предыдущей формой 
        * для передачи в нее параметров
        */
        private void buttonKategorySubAdd_Click(object sender, EventArgs e)
        {
            FormSubjectPDAdd frmSubjAdd = new FormSubjectPDAdd();
            frmSubjAdd.Owner = this; //Передаём вновь созданной форме её владельца.
            frmSubjAdd.Show();
        }

        /* КНОПКА открываем форму добовления Био категорий, оставляем связь с предыдущей формой 
       * для передачи в нее параметров
       */

        private void buttonFormBioAdd_Click(object sender, EventArgs e)
        {
            FormBioAdd frmBioAdd = new FormBioAdd();
            frmBioAdd.Owner = this; //Передаём вновь созданной форме её владельца.
            frmBioAdd.Show();
        }


        /* КНОПКА открываем форму добовления дополнительных категорий персональных данных, оставляем связь с предыдущей формой 
        * для передачи в нее параметров
        */
        private void buttonKategoryPDDopAdd_Click(object sender, EventArgs e)
        {
            FormKategoryDopPDAdd frmKategoryDopPDAdd = new FormKategoryDopPDAdd();
            frmKategoryDopPDAdd.Owner = this; //Передаём вновь созданной форме её владельца.
            frmKategoryDopPDAdd.Show();
        }


        /* КНОПКА открываем форму добовления работников персональных данных, оставляем связь с предыдущей формой 
        * для передачи в нее параметров
        */
        private void buttonRabotnikAdd_Click(object sender, EventArgs e)
        {
            FormRabotnikiPDAdd frmRabAdd = new FormRabotnikiPDAdd();
            frmRabAdd.Owner = this; //Передаём вновь созданной форме её владельца.
            frmRabAdd.Show();
        }

        /* КНОПКА открываем форму добовления целей персональных данных, оставляем связь с предыдущей формой 
        * для передачи в нее параметров
        */
        private void buttonFormCeliAdd_Click(object sender, EventArgs e)
        {
            FormCeliAdd frmCeliAdd = new FormCeliAdd();
            frmCeliAdd.Owner = this; //Передаём вновь созданной форме её владельца.
            frmCeliAdd.Show();
        }
        
        /*
        *  КНОПКА ДОБАВЛЕНИЯ ПАРАМЕТРОВ ФОРМЫ
         */
        
        FormConfirmIspdnAdd frmConfirmISPDn = new FormConfirmIspdnAdd(); //создаем диалоговую форму

        private void btnSPDnAdd_Click(object sender, EventArgs e)
        {


            /********************* - ВНАЧАЛЕ проверяем все ли значения определены - ******************/
            // проверяем заполнено ли поле "Название ИСПДН"
            if (this.comboBoxRedISPDn.Text == "")
            {
                MessageBox.Show("Введите название ИСПДн");
                goto exit;
            }

            // проверяем заполнены ли Таблицы - Субъектов
            if (KategorySubjDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Не выбран ни один субъект персональных данных");
                goto exit;
            }

            // проверяем выбраны ли основные категории ПД и дополнительные
            if ((checkedListBoxPd.CheckedIndices.Count == 0) && (kategoryPdDopDataGridView.Rows.Count == 0))
            {
                MessageBox.Show("Не выбрана ни одна из обрабатываемых категорий ПД");
                goto exit;
            }


            // проверяем если отмечены биометрические категории ПД, есть ли записи в Гриде
            if (checkBoxBioKatPD.Checked == true)
            {
                // проверяем заполнены ли Таблицы - расшифровки биометрических ПД
                if (kategoryPdBioDataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Не расшифрованы биометрические категории персональных данных");
                    goto exit;
                }
            }


            // проверяем заполнены ли Таблицы - Работников допущенных к работе с персональными данными
            if (RabotnikiOrgDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Не выбран ни один Работник допущенный к работе с системой");
                goto exit;
            }

            // проверяем заполнены ли Таблицы - Цели обработки персональных данных
            if (CeliObrabotkiDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Не выбрана ни одна цель обработки ПД");
                goto exit;
            }


            // проверяем выбраны ли специальные категории ПД
            if ((checkBoxSpecPD.Checked == true) && (checkBoxSudimost.Checked == false)
                                                 && (checkedListBoxSpecKatPD.CheckedIndices.Count == 0))
            {
                MessageBox.Show("Ведется обработка специальных категорий ПД, а категории не выбраны");
                goto exit;
            }

            // проверяем отмечен ли тип модели для текущей ИСПДн
            if ((this.radioButtonTipModeliISPDn1.Checked == false) && (this.radioButtonTipModeliISPDn2.Checked == false) &&
                (this.radioButtonTipModeliISPDn3.Checked == false) && (this.radioButtonTipModeliISPDn4.Checked == false) &&
                (this.radioButtonTipModeliISPDn5.Checked == false) && (this.radioButtonTipModeliISPDn6.Checked == false))
            {
                MessageBox.Show("Не отмечен тип для текущей ИСПДн");
                goto exit;
            }
            //******************* Когда проверены условия на заполнения всех полей добавляем записи ИС в базе******/

            //Создаем таблицу ИСПДН, заполняем ее и проверяем есть ли информационная системя в базе
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter tblAdaptISPDNId = new ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter();
            tblAdaptISPDNId.Fill(ds.ISPDnOperator);
            DataTable tableIsName = ds.Tables["ISPDnOperator"];
            foreach (DataRow dataRow in tableIsName.Rows)
            {
                string forName;
                forName = dataRow["ISPDnOperatorName"].ToString();
                int forISPDnID;
                forISPDnID = Convert.ToInt32(dataRow["ISPDnOperatorID"]);
                if (this.comboBoxRedISPDn.Text == forName) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    ClassGlobalVar.ISPDnID = forISPDnID;
                    if (frmConfirmISPDn.ShowDialog() == DialogResult.OK)
                    {
                        // вначале удаляем данные связных таблиц данной ИСПДн потом поновой добовляем
                        this.mnogieISPDnSubjTableAdapter.DeleteQueryMnogieSubjIspdn(ClassGlobalVar.ISPDnID); // удаляем связи субъектов
                        this.mnogieISPDnKategoryPDTableAdapter.DeleteQueryMnogieKategoryPdIS(ClassGlobalVar.ISPDnID); // удаляем связи категорий ПД
                        this.mnogieKategoryPdSpecISPDnTableAdapter.DeleteQueryMnogieSpecPdIspdn(ClassGlobalVar.ISPDnID); // удаляем связи специальных категорий
                        this.mnogieKategoryPdBioISPDnTableAdapter.DeleteQueryMnogieBioPdIspdn(ClassGlobalVar.ISPDnID); // удаляем связи Био категорий
                        this.mnogieKategoryPdDopISPDnTableAdapter.DeleteQueryMnogiePdDopIspdn(ClassGlobalVar.ISPDnID); // удаляем связи дополнительных категорий
                        this.mnogieISPDnRabotnikiTableAdapter.DeleteQueryMnogieRabotnikiIspdn(ClassGlobalVar.ISPDnID); // удаляем связи работников
                        this.mnogieCeliObrabotkiISPDnTableAdapter.DeleteQueryMnogieCeliIspdn(ClassGlobalVar.ISPDnID); // удаляем связи целей

                        
                        /************ вставляем данные по новой **********/

                        MethodInsertSubject(); // вставляем в многие ИС+субъекты

                        // Если отмечен БИО то вставляем
                        if (this.checkBoxBioKatPD.Checked == true)
                        {
                            MethodInsertMnogieBioISPDn();
                        }

                        MethodKategoryPDDopAdd(); // добовляем дополнительные категории ПД
                        MethodKategorySpecAdd(); // вставляем специальные категории ПД
                        MethodKategoryPDAdd(); // добавляем в связную таблицу категории основных ПД из лист бокса
                        MethodInsertRabotniki(); // вставляем в многие ИС+Работники
                        MethodInsertCeli(); // вставляем в многие ИС+цели
                        int tipModeli = 0;
                        if (this.radioButtonTipModeliISPDn1.Checked == true)
                        {
                            tipModeli = 1;
                        }
                        else if (this.radioButtonTipModeliISPDn2.Checked == true)
                        {
                            tipModeli = 2;
                        }
                        else if (this.radioButtonTipModeliISPDn3.Checked == true)
                        {
                            tipModeli = 3;
                        }
                        else if (this.radioButtonTipModeliISPDn4.Checked == true)
                        {
                            tipModeli = 4;
                        }
                        else if (this.radioButtonTipModeliISPDn5.Checked == true)
                        {
                            tipModeli = 5;
                        }
                        else if (this.radioButtonTipModeliISPDn6.Checked == true)
                        {
                            tipModeli = 6;
                        }
                        // добовляем тип модели для текущей ИСПДн
                        this.ispDnOperatorTableAdapter.UpdateTipModeliISPDn(tipModeli, ClassGlobalVar.ISPDnID, ClassGlobalVar.OrgID);
                        MessageBox.Show("Информационная система Обновлена");
                        goto exit;
                    }
                    else
                    {
                        goto exit;
                    }
                }
            }

                // Добавляем данные (Насвание ИСПДн и номер организации к которой она относится)
                this.ispDnOperatorTableAdapter.InsertISPDnData(comboBoxRedISPDn.Text, ClassGlobalVar.OrgID, null, null, null, null, null);

                // Если отмечен БИО то вставляем
                if (this.checkBoxBioKatPD.Checked == true)
                {
                    MethodInsertMnogieBioISPDn();
                }

                MethodKategoryPDDopAdd(); // добовляем дополнительные категории ПД

                MethodKategorySpecAdd(); // вставляем специальные категории ПД

                MethodInsertSubject(); // вставляем в многие ИС+субъекты

                MethodKategoryPDAdd(); // добавляем в связную таблицу категории основных ПД из лист бокса

                MethodInsertRabotniki(); // вставляем в многие ИС+Работники

                MethodInsertCeli(); // вставляем в многие ИС+цели

                MessageBox.Show("Информационная система добавлена");
                /*
                * Очищаем все поля и  таблицы для добавления новой Информационной системы 
                */
                this.kategorySubjTableAdapter.MetodSubjNoLoad(iSPDnBDDataSet.KategorySubj, "No");

                foreach (int index in checkedListBoxPd.CheckedIndices)
                {
                    checkedListBoxPd.SetItemCheckState(index, CheckState.Unchecked);
                }

                this.checkBoxSpecPD.Checked = false;
                this.checkBoxSudimost.Checked = false;

                foreach (int index in checkedListBoxSpecKatPD.CheckedIndices)
                {
                    checkedListBoxSpecKatPD.SetItemCheckState(index, CheckState.Unchecked);
                }

                this.checkBoxBioKatPD.Checked = false;

                this.kategoryPdBioTableAdapter.MetodBioNoLoad(iSPDnBDDataSet.KategoryPdBio, "No");

                this.kategoryPdDopTableAdapter.MetodPdDopNoLoad(iSPDnBDDataSet.KategoryPdDop, "No");

                this.RabotnikiOrgTableAdapter.MetodRabotnikiNoLoad(iSPDnBDDataSet.RabotnikiOrg, "No");

                this.CeliObrabotkiPDTableAdapter.MetodCeliNoLoad(iSPDnBDDataSet.CeliObrabotkiPD, "No");

        exit: ; // принудительный выход из выполнения кода ----------------------------------------
        }



        /**************************************************************************************************/
        //РАЗДЕЛ ГДЕ ОПИСЫВАЮТСЯ МЕТОДЫ КЛАССА ФОРМЫ ИНФОРМАЦИОННОЙ СИСТЕМЫ
        /***************************************************************************************************/
        // метод заполнения Дата сета ИСПДн
        public void MethodISPDnDataSetUpdate()
        {
            this.ispDnOperatorTableAdapter.Fill(iSPDnBDDataSet.ISPDnOperator);
        }

        // функция добавления СУбъектов для ИСПДн, для использования в дополнительной форме
        public void MethodSubjectSelect()
        {
            this.kategorySubjTableAdapter.MetodKategorySubjSelectTrue(iSPDnBDDataSet.KategorySubj, true, ClassGlobalVar.OrgID);
        }

        // функция добовления биометрических  категорий в таблицу многие + ИСПДн
        private void MethodInsertMnogieBioISPDn()
        {
            for (int i = 0; i < kategoryPdBioDataGridView.Rows.Count; i++)
            {
                int RabID = Convert.ToInt32(kategoryPdBioDataGridView.Rows[i].Cells[0].Value);
                this.mnogieKategoryPdBioISPDnTableAdapter.Insert(ClassGlobalVar.ISPDnID, RabID);
            }
        }

        // функция добавления РАботников для ИСПДн, для использования в дополнительной форме
        public void MethodRabotnikiSelect()
        {
            this.RabotnikiOrgTableAdapter.MetodRabotnikiSelectTrue(iSPDnBDDataSet.RabotnikiOrg, ClassGlobalVar.OrgID, true);
        }

        // функция добавления ЦЕлей для ИСПДн, для использования в дополнительной форме
        public void MethodCeliSelect()
        {
            this.CeliObrabotkiPDTableAdapter.MetodCeliSelectTrue(iSPDnBDDataSet.CeliObrabotkiPD, ClassGlobalVar.OrgID, true);

        }

        // функция добавления дополнительных категорий в грид на форме ИСПДн
        public void MethodKategoryDopSelect()
        {
            this.kategoryPdDopTableAdapter.MetodKategoryDopPDOrgSelectTrue(iSPDnBDDataSet.KategoryPdDop, ClassGlobalVar.OrgID, true);
        }

        // функция добавления Био категорий в грид на форме ИСПДн
        public void MethodKategoryBioSelectTrue()
        {
            kategoryPdBioTableAdapter.MetodBioSelectTrue(iSPDnBDDataSet.KategoryPdBio, ClassGlobalVar.OrgID, true);
        }


        // функция вставки целей из Грида в связные таблицы с ИС
        private void MethodInsertCeli()
        {
            for (int i = 0; i < CeliObrabotkiDataGridView.Rows.Count; i++)
            {
                int CeliID = Convert.ToInt32(CeliObrabotkiDataGridView.Rows[i].Cells[0].Value);
                this.mnogieCeliObrabotkiISPDnTableAdapter.Insert(CeliID, ClassGlobalVar.ISPDnID);
            }
        }

        // функция вставки работников из Грида в связные таблицы
        private void MethodInsertRabotniki()
        {
            for (int i = 0; i < RabotnikiOrgDataGridView.Rows.Count; i++)
            {
                int RabID = Convert.ToInt32(RabotnikiOrgDataGridView.Rows[i].Cells[0].Value);
                this.mnogieISPDnRabotnikiTableAdapter.Insert(ClassGlobalVar.ISPDnID, RabID);
            }
        }

        // функция вставки субъектов из Грида в связные таблицы
        private void MethodInsertSubject()
        {
            for (int i = 0; i < KategorySubjDataGridView.Rows.Count; i++)
            {
                int SubjID = Convert.ToInt32(KategorySubjDataGridView.Rows[i].Cells[0].Value);
                this.mnogieISPDnSubjTableAdapter.Insert(SubjID, ClassGlobalVar.ISPDnID);
            }
        }

        private void MethodKategoryPDAdd()
        {
            foreach (int index in checkedListBoxPd.CheckedIndices)
            {
                this.mnogieISPDnKategoryPDTableAdapter.InsertMnogieISPDnKategoryPD(ClassGlobalVar.ISPDnID, index + 1);
                string LisboxPD = checkedListBoxPd.Items[index].ToString();
            }
        }

        // функция просмотра листбокса специальных категорий ПД и добовление их в связную таблицу БД
        private void MethodKategorySpecAdd()
        {   // судимость
            if ((checkBoxSudimost.Checked == true) && (checkBoxSudimost.Enabled == true))
            {
                this.mnogieKategoryPdSpecISPDnTableAdapter.Insert(ClassGlobalVar.ISPDnID, 7);
            }

            if (checkedListBoxSpecKatPD.Enabled == true)
            {
                // все остальные
                foreach (int index in checkedListBoxSpecKatPD.CheckedIndices)
                {
                    this.mnogieKategoryPdSpecISPDnTableAdapter.Insert(ClassGlobalVar.ISPDnID, index + 1);
                }
            }
        }

        // функция пробежав по таблице добавляет отмеченные категории для текушей ИС в БД 
        private void MethodKategoryPDDopAdd()
        {
            for (int i = 0; i < this.kategoryPdDopDataGridView.Rows.Count; i++)
            {
                int DopPDID = Convert.ToInt32(this.kategoryPdDopDataGridView.Rows[i].Cells[0].Value);
                this.mnogieKategoryPdDopISPDnTableAdapter.Insert(ClassGlobalVar.ISPDnID, DopPDID);
            }
        }


        // функция поиска ИС в базе и извлечение ее индекса в переменную
        private void MethodPoiskaISPDninBD()
        {
            
            
        }

        private void buttonNewISPDn_Click(object sender, EventArgs e)
        {
            this.comboBoxRedISPDn.Enabled = false;
            
            /*
             * Очищаем все поля и  таблицы для добавления новой Информационной системы 
             */

            this.kategorySubjTableAdapter.MetodSubjNoLoad(iSPDnBDDataSet.KategorySubj, "No");

            foreach (int index in checkedListBoxPd.CheckedIndices)
            {
                checkedListBoxPd.SetItemCheckState(index, CheckState.Unchecked);
            }

            this.checkBoxSpecPD.Checked = false;
            this.checkBoxSudimost.Checked = false;

            foreach (int index in checkedListBoxSpecKatPD.CheckedIndices)
            {
                checkedListBoxSpecKatPD.SetItemCheckState(index, CheckState.Unchecked);
            }

            this.checkBoxBioKatPD.Checked = false;

            this.kategoryPdBioTableAdapter.MetodBioNoLoad(iSPDnBDDataSet.KategoryPdBio, "No");

            this.kategoryPdDopTableAdapter.MetodPdDopNoLoad(iSPDnBDDataSet.KategoryPdDop, "No");

            this.RabotnikiOrgTableAdapter.MetodRabotnikiNoLoad(iSPDnBDDataSet.RabotnikiOrg, "No");

            this.CeliObrabotkiPDTableAdapter.MetodCeliNoLoad(iSPDnBDDataSet.CeliObrabotkiPD, "No");

        }

        private void buttonISRed_Click(object sender, EventArgs e)
        {
            if (this.comboBoxRedISPDn.Enabled == true)
            {
                
                //обновляем таблицы на форме по запросу ИСПДн
                this.kategorySubjTableAdapter.MetodComboISPDnRed(iSPDnBDDataSet.KategorySubj, this.comboBoxRedISPDn.Text);
                this.kategoryPdBioTableAdapter.MetodBioISRed(iSPDnBDDataSet.KategoryPdBio, this.comboBoxRedISPDn.Text);
                this.kategoryPdDopTableAdapter.MetodPdDopIsRed(iSPDnBDDataSet.KategoryPdDop, this.comboBoxRedISPDn.Text);
                this.RabotnikiOrgTableAdapter.MetodRabotnikiISRed(iSPDnBDDataSet.RabotnikiOrg, this.comboBoxRedISPDn.Text);
                this.CeliObrabotkiPDTableAdapter.MetodCeliISRed(iSPDnBDDataSet.CeliObrabotkiPD, this.comboBoxRedISPDn.Text);

                DataTable tableOsn = iSPDnBDDataSet.Tables["MnogieISPDnKategoryPD"];
                DataTable tableSpec = iSPDnBDDataSet.Tables["MnogieKategoryPdSpecISPDn"];
                DataTable tableBio = iSPDnBDDataSet.Tables["KategoryPdBio"];
                DataTable tableIspdn = iSPDnBDDataSet.Tables["ISPDnOperator"];
                this.mnogieISPDnKategoryPDTableAdapter.Fill(iSPDnBDDataSet.MnogieISPDnKategoryPD);
                this.mnogieKategoryPdSpecISPDnTableAdapter.Fill(iSPDnBDDataSet.MnogieKategoryPdSpecISPDn);
                
                if (tableIspdn.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in tableIspdn.Rows)
                    {
                        int IspdnId;
                        IspdnId = Convert.ToInt32(dataRow["ISPDnOperatorID"].ToString());
                        string IspdnName;
                        IspdnName = dataRow["ISPDnOperatorName"].ToString();
                        if (this.comboBoxRedISPDn.Text == IspdnName) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            ClassGlobalVar.ISPDnID = IspdnId;
                        }
                    }
                }
                
                // очищаем чекбоксы основных категорий
                foreach (int index in checkedListBoxPd.CheckedIndices)
                {
                    checkedListBoxPd.SetItemCheckState(index, CheckState.Unchecked);
                }
                
                // проверяем основные категории и устанавливаем флажки
                if (tableOsn.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in tableOsn.Rows)
                    {
                        string IdKategoryPD;
                        IdKategoryPD = dataRow["KategoryPdID"].ToString();
                        string Id;
                        Id = dataRow["ISPDnOperatorID"].ToString();
                        int IdPd = Convert.ToInt32(IdKategoryPD);
                        if (Convert.ToInt32(Id) == ClassGlobalVar.ISPDnID) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            checkedListBoxPd.SetItemCheckState(IdPd-1, CheckState.Checked);
                        }
                    }

                }


                // очищаем чекбоксы специальных категорий категорий
                foreach (int index in checkedListBoxSpecKatPD.CheckedIndices)
                {
                    checkedListBoxSpecKatPD.SetItemCheckState(index, CheckState.Unchecked);
                }
                this.checkBoxSudimost.Checked = false;
                this.checkBoxSpecPD.Checked = false;

                // проверяем специальные категории и устанавливаем флажки
                if (tableSpec.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in tableSpec.Rows)
                    {
                        string IdSpecPD;
                        IdSpecPD = dataRow["KategoryPdSpecID"].ToString();
                        int IdPdSpec = Convert.ToInt32(IdSpecPD);
                        string IdIspdn;
                        IdIspdn = dataRow["ISPDnOperatorID"].ToString();
                        if ((Convert.ToInt32(IdIspdn) == ClassGlobalVar.ISPDnID) && (IdPdSpec != 7)) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            checkedListBoxSpecKatPD.SetItemCheckState(IdPdSpec - 1, CheckState.Checked);
                        }
                        if ((Convert.ToInt32(IdIspdn) == ClassGlobalVar.ISPDnID) && (IdPdSpec == 7))
                        {
                            this.checkBoxSudimost.Checked = true;
                        }
                    }

                    // проверяем выбраны ли специальные категории ПД и если да то ставим галочку на спец категории
                    if (checkedListBoxSpecKatPD.CheckedIndices.Count > 0)
                    {
                        this.checkBoxSpecPD.Checked = true;
                    }

                }

                // проверяем есть ли биометрические данные, если есть то ставим галочку на чекбоксе
                if (this.kategoryPdBioDataGridView.Rows.Count > 0)
                {
                    this.checkBoxBioKatPD.Checked = true;
                }
                else
                {
                    this.checkBoxBioKatPD.Checked = false;
                }

            }

        }

        private void FormISPDnAdd_Activated(object sender, EventArgs e)
        {
            ComboISPDnMethod(ClassGlobalVar.OrgID);
        }

        private void buttonViewDateISPDn_Click(object sender, EventArgs e)
        {
                //обновляем таблицы на форме по запросу ИСПДн
                this.comboBoxRedISPDn.Text = this.comboBoxRedISPDn.Text;
                this.kategorySubjTableAdapter.MetodComboISPDnRed(iSPDnBDDataSet.KategorySubj, this.comboBoxRedISPDn.Text);
                this.kategoryPdBioTableAdapter.MetodBioISRed(iSPDnBDDataSet.KategoryPdBio, this.comboBoxRedISPDn.Text);
                this.kategoryPdDopTableAdapter.MetodPdDopIsRed(iSPDnBDDataSet.KategoryPdDop, this.comboBoxRedISPDn.Text);
                this.RabotnikiOrgTableAdapter.MetodRabotnikiISRed(iSPDnBDDataSet.RabotnikiOrg, this.comboBoxRedISPDn.Text);
                this.CeliObrabotkiPDTableAdapter.MetodCeliISRed(iSPDnBDDataSet.CeliObrabotkiPD, this.comboBoxRedISPDn.Text);

                DataTable tableOsn = iSPDnBDDataSet.Tables["MnogieISPDnKategoryPD"];
                DataTable tableSpec = iSPDnBDDataSet.Tables["MnogieKategoryPdSpecISPDn"];
                DataTable tableBio = iSPDnBDDataSet.Tables["KategoryPdBio"];
                DataTable tableIspdn = iSPDnBDDataSet.Tables["ISPDnOperator"];
                this.mnogieISPDnKategoryPDTableAdapter.Fill(iSPDnBDDataSet.MnogieISPDnKategoryPD);
                this.mnogieKategoryPdSpecISPDnTableAdapter.Fill(iSPDnBDDataSet.MnogieKategoryPdSpecISPDn);

                if (tableIspdn.Rows.Count > 0)
                {
                    ClassGlobalVar.ISPDnID = ClassMetodISPDn.ISPDnIDGetMetod(this.comboBoxRedISPDn.Text);
                }
                // очищаем чекбоксы основных категорий
                foreach (int index in checkedListBoxPd.CheckedIndices)
                {
                    checkedListBoxPd.SetItemCheckState(index, CheckState.Unchecked);
                }

                // проверяем основные категории и устанавливаем флажки
                if (tableOsn.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in tableOsn.Rows)
                    {
                        string IdKategoryPD;
                        IdKategoryPD = dataRow["KategoryPdID"].ToString();
                        string Id;
                        Id = dataRow["ISPDnOperatorID"].ToString();
                        int IdPd = Convert.ToInt32(IdKategoryPD);
                        if (Convert.ToInt32(Id) == ClassGlobalVar.ISPDnID) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            checkedListBoxPd.SetItemCheckState(IdPd - 1, CheckState.Checked);
                        }
                    }

                }

                // очищаем чекбоксы специальных категорий категорий
                foreach (int index in checkedListBoxSpecKatPD.CheckedIndices)
                {
                    checkedListBoxSpecKatPD.SetItemCheckState(index, CheckState.Unchecked);
                }
                this.checkBoxSudimost.Checked = false;
                this.checkBoxSpecPD.Checked = false;

                // проверяем специальные категории и устанавливаем флажки
                if (tableSpec.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in tableSpec.Rows)
                    {
                        string IdSpecPD;
                        IdSpecPD = dataRow["KategoryPdSpecID"].ToString();
                        int IdPdSpec = Convert.ToInt32(IdSpecPD);
                        string IdIspdn;
                        IdIspdn = dataRow["ISPDnOperatorID"].ToString();
                        if ((Convert.ToInt32(IdIspdn) == ClassGlobalVar.ISPDnID) && (IdPdSpec != 7)) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            checkedListBoxSpecKatPD.SetItemCheckState(IdPdSpec - 1, CheckState.Checked);
                        }
                        if ((Convert.ToInt32(IdIspdn) == ClassGlobalVar.ISPDnID) && (IdPdSpec == 7))
                        {
                            this.checkBoxSudimost.Checked = true;
                        }
                    }

                    // проверяем выбраны ли специальные категории ПД и если да то ставим галочку на спец категории
                    if (checkedListBoxSpecKatPD.CheckedIndices.Count > 0)
                    {
                        this.checkBoxSpecPD.Checked = true;
                    }

                }

                // проверяем есть ли биометрические данные, если есть то ставим галочку на чекбоксе
                if (this.kategoryPdBioDataGridView.Rows.Count > 0)
                {
                    this.checkBoxBioKatPD.Checked = true;
                }
                else
                {
                    this.checkBoxBioKatPD.Checked = false;
                }
        }

        // метод извлечения выбранных законов
        public void MethodPravoSelectTrue(bool yesno)
        {
            this.pravoOrgTableAdapter.MetodPravoSelectTrue(iSPDnBDDataSet.PravoOrg, yesno);
        }

        private void buttonPravoIs_Click(object sender, EventArgs e)
        {
            FormPravoIsAdd frmPravoAdd = new FormPravoIsAdd();
            frmPravoAdd.Owner = this; //Передаём вновь созданной форме её владельца.
            frmPravoAdd.Show();
        }

     }
}
