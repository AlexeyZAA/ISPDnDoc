using System;
using System.Data;
using System.Windows.Forms;

namespace SpaseFormISPDn
{
    partial class FormOtdelAdd : Form
    {
        public FormOtdelAdd()
        {
            InitializeComponent();
        }

        /****************************************************************************************/
        //РАЗДЕЛ ЗАГРУЗКИ ФОРМЫ - SECTION DOWNLOAD FORMS
        /****************************************************************************************/

        /* загружаем данные в таблицы при загрузке формы - load the data into a table when the form loads*/

        private void FormOtdelAdd_Load(object sender, EventArgs e)
        {
            ComboFillMethod(ClassGlobalVar.OrgID);
        }

        public void ComboFillMethod(int OrgId)
        {
            this.otdelOrgTableAdapter.MetodSelectOtdelCombo(this.iSPDnBDDataSet.OtdelOrg, OrgId);
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
        private void buttonExitOtdel_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
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

        FormConfirmIspdnAdd frmConfirmOtdel = new FormConfirmIspdnAdd(); //создаем диалоговую форму

        private void btnOtdelAdd_Click(object sender, EventArgs e)
        {

            /********************* - ВНАЧАЛЕ проверяем все ли значения определены - ******************/

            // проверяем заполнено ли поле "Название ИСПДН"
            if (this.comboBoxRedOtdel.Text == "")
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


            //******************* Когда проверены условия на заполнения всех полей добавляем записи ИС в базе******/

            //Создаем таблицу ИСПДН, заполняем ее и проверяем есть ли информационная системя в базе
            ISPDnBDDataSet ds = new ISPDnBDDataSet();
            ISPDnBDDataSetTableAdapters.OtdelOrgTableAdapter tblAdaptISPDNId = new ISPDnBDDataSetTableAdapters.OtdelOrgTableAdapter();
            tblAdaptISPDNId.Fill(ds.OtdelOrg);
            DataTable tableOtdelName = ds.Tables["OtdelOrg"];

            foreach (DataRow dataRow in tableOtdelName.Rows)
            {
                string forName;
                forName = dataRow["OtdelOrgName"].ToString();
                int forOtdelID;
                forOtdelID = Convert.ToInt32(dataRow["OtdelOrgID"]);
                if (this.comboBoxRedOtdel.Text == forName) // Если  Имя Поля названиеИС равно имени в Базе
                {
                    ClassGlobalVar.OtdelID = Convert.ToInt32(forOtdelID);

                    if (frmConfirmOtdel.ShowDialog() == DialogResult.OK)
                    {
                        // вначале удаляем данные связных таблиц данной ИСПДн потом поновой добовляем
                        this.mnogieOtdelSubjTableAdapter.DeleteQueryMnogieSubjOtdel(ClassGlobalVar.OtdelID); // удаляем связи субъектов
                        this.mnogieKategoryPdOtdelTableAdapter.DeleteQueryMnogieKategoryPdOtdel(ClassGlobalVar.OtdelID); // удаляем связи категорий ПД
                        this.mnogieKategoriSpecOtdelTableAdapter.DeleteQueryMnogiePdSpecOtdel(ClassGlobalVar.OtdelID); // удаляем связи специальных категорий
                        this.mnogieKategoryBioOtdelTableAdapter.DeleteQueryMnogieBioOtdel(ClassGlobalVar.OtdelID); // удаляем связи Био категорий
                        this.mnogieKategoryDopOtdelTableAdapter.DeleteQueryMnogiePdDopOtdel(ClassGlobalVar.OtdelID); // удаляем связи дополнительных категорий
                        this.mnogieRabotnikiOtdelTableAdapter.DeleteQueryMnogieRabotnikiOtdel(ClassGlobalVar.OtdelID); // удаляем связи работников
                        this.mnogieCeliOtdelTableAdapter.DeleteQueryMnogieCeliOtdel(ClassGlobalVar.OtdelID); // удаляем связи целей

                        /************ вставляем данные по новой **********/

                        MethodInsertSubject(); // вставляем в многие ИС+субъекты

                        // Если отмечен БИО то вставляем
                        if (this.checkBoxBioKatPD.Checked == true)
                        {
                            MethodInsertMnogieBioOtdel();
                        }

                        MethodKategoryPDDopAdd(); // добовляем дополнительные категории ПД
                        MethodKategorySpecAdd(); // вставляем специальные категории ПД
                        MethodKategoryPDAdd(); // добавляем в связную таблицу категории основных ПД из лист бокса
                        MethodInsertRabotniki(); // вставляем в многие ИС+Работники
                        MethodInsertCeli(); // вставляем в многие ИС+цели
                        MessageBox.Show("Отдел Обнолен");
                        goto exit;
                    }
                    else
                    {
                        goto exit;
                    }
                }
            }

            // Добавляем данные (Название ИСПДн и номер организации к которой она относится)
            this.otdelOrgTableAdapter.Insert(this.comboBoxRedOtdel.Text, ClassGlobalVar.OrgID);

            // Если отмечен БИО то вставляем
            if (this.checkBoxBioKatPD.Checked == true)
            {
                MethodInsertMnogieBioOtdel();
            }

            MethodKategoryPDDopAdd(); // добовляем дополнительные категории ПД

            MethodKategorySpecAdd(); // вставляем специальные категории ПД

            MethodInsertSubject(); // вставляем в многие ИС+субъекты

            MethodKategoryPDAdd(); // добавляем в связную таблицу категории основных ПД из лист бокса

            MethodInsertRabotniki(); // вставляем в многие ИС+Работники

            MethodInsertCeli(); // вставляем в многие ИС+цели

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
        //РАЗДЕЛ ГДЕ ОПИСЫВАЮТСЯ ФУНКЦИИ КЛАССА ФОРМЫ ИНФОРМАЦИОННОЙ СИСТЕМЫ
        /***************************************************************************************************/
       
        // метод обновления Дата сет по Отделам
        public void MethodOtdelDataSetUpdate()
        {
            this.otdelOrgTableAdapter.Fill(iSPDnBDDataSet.OtdelOrg);
        }


        // функция добавления СУбъектов для ИСПДн, для использования в дополнительной форме
        public void MethodSubjectSelect()
        {
            this.kategorySubjTableAdapter.MetodKategorySubjSelectTrue(iSPDnBDDataSet.KategorySubj, true, ClassGlobalVar.OrgID);
        }

        // функция добовления биометрических  категорий в таблицу многие + ИСПДн
        private void MethodInsertMnogieBioOtdel()
        {
            for (int i = 0; i < kategoryPdBioDataGridView.Rows.Count; i++)
            {
                int RabID = Convert.ToInt32(kategoryPdBioDataGridView.Rows[i].Cells[0].Value);
                
                this.mnogieKategoryBioOtdelTableAdapter.Insert(ClassGlobalVar.OtdelID, RabID);
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
                this.mnogieCeliOtdelTableAdapter.Insert(ClassGlobalVar.OtdelID, CeliID);
            }
        }

        // функция вставки работников из Грида в связные таблицы
        private void MethodInsertRabotniki()
        {
            for (int i = 0; i < RabotnikiOrgDataGridView.Rows.Count; i++)
            {
                int RabID = Convert.ToInt32(RabotnikiOrgDataGridView.Rows[i].Cells[0].Value);
                this.mnogieRabotnikiOtdelTableAdapter.Insert(ClassGlobalVar.OtdelID, RabID);
            }
        }

        // функция вставки субъектов из Грида в связные таблицы
        private void MethodInsertSubject()
        {
            for (int i = 0; i < KategorySubjDataGridView.Rows.Count; i++)
            {
                int SubjID = Convert.ToInt32(KategorySubjDataGridView.Rows[i].Cells[0].Value);
                this.mnogieOtdelSubjTableAdapter.Insert(SubjID, ClassGlobalVar.OtdelID);
            }
        }

        private void MethodKategoryPDAdd()
        {
            foreach (int index in checkedListBoxPd.CheckedIndices)
            {
                this.mnogieKategoryPdOtdelTableAdapter.Insert(ClassGlobalVar.OtdelID, index + 1);
                string LisboxPD = checkedListBoxPd.Items[index].ToString();
            }
        }

        // функция просмотра листбокса специальных категорий ПД и добовление их в связную таблицу БД
        private void MethodKategorySpecAdd()
        {   // судимость
            if ((checkBoxSudimost.Checked == true) && (checkBoxSudimost.Enabled == true))
            {
                this.mnogieKategoriSpecOtdelTableAdapter.Insert(ClassGlobalVar.OtdelID, 7);
            }

            if (checkedListBoxSpecKatPD.Enabled == true)
            {
                // все остальные
                foreach (int index in checkedListBoxSpecKatPD.CheckedIndices)
                {
                    this.mnogieKategoriSpecOtdelTableAdapter.Insert(ClassGlobalVar.OtdelID, index + 1);
                }
            }
        }

        // функция пробежав по таблице добавляет отмеченные категории для текушей ИС в БД 
        private void MethodKategoryPDDopAdd()
        {
            for (int i = 0; i < this.kategoryPdDopDataGridView.Rows.Count; i++)
            {
                int DopPDID = Convert.ToInt32(this.kategoryPdDopDataGridView.Rows[i].Cells[0].Value);
                this.mnogieKategoryDopOtdelTableAdapter.Insert(ClassGlobalVar.OtdelID, DopPDID);
            }
        }


        // функция поиска ИС в базе и извлечение ее индекса в переменную
        private void MethodPoiskaOtdelinBD(DataTable tableOtdel)
        {
            foreach (DataRow dataRow in tableOtdel.Rows)
            {
                string indexRow = dataRow["OtdelOrgID"].ToString();
                string forNameOtdel = dataRow["OtdelOrgName"].ToString();
                if (comboBoxRedOtdel.Text == forNameOtdel) // Если текстовое поле равно записи в базе
                {
                    int ISid;
                    bool result = Int32.TryParse(indexRow, out ISid);
                    if (result)
                    {
                        ClassGlobalVar.OtdelID = ISid; // присваиваем глобальному ID ИСПДн текуший айдишник из базы
                    }
                    else
                    {
                        if (indexRow == null) indexRow = "";
                        MessageBox.Show(indexRow + "Нет значения для добавления в таблицу");
                    }
                }
            }
        }

        private void buttonNewISPDn_Click(object sender, EventArgs e)
        {
            this.comboBoxRedOtdel.Enabled = false;
            
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
            if (this.comboBoxRedOtdel.Enabled == true)
            {
                
                //обновляем таблицы на форме по запросу ИСПДн
                this.kategorySubjTableAdapter.MetodComboOtdelRed(iSPDnBDDataSet.KategorySubj, this.comboBoxRedOtdel.Text);
                this.kategoryPdBioTableAdapter.MetodBioOtdelRed(iSPDnBDDataSet.KategoryPdBio, this.comboBoxRedOtdel.Text);
                this.kategoryPdDopTableAdapter.MetodPdDopOtdelRed(iSPDnBDDataSet.KategoryPdDop, this.comboBoxRedOtdel.Text);
                this.RabotnikiOrgTableAdapter.MetodRabotnikiOtdelRed(iSPDnBDDataSet.RabotnikiOrg, this.comboBoxRedOtdel.Text);
                this.CeliObrabotkiPDTableAdapter.MetodCeliOtdelRed(iSPDnBDDataSet.CeliObrabotkiPD, this.comboBoxRedOtdel.Text);

                DataTable tableOsn = iSPDnBDDataSet.Tables["MnogieKategoryPdOtdel"];
                DataTable tableSpec = iSPDnBDDataSet.Tables["MnogieKategoriSpecOtdel"];
                DataTable tableBio = iSPDnBDDataSet.Tables["KategoryPdBio"];
                DataTable tableOtdel = iSPDnBDDataSet.Tables["OtdelOrg"];
                this.mnogieKategoryPdOtdelTableAdapter.Fill(iSPDnBDDataSet.MnogieKategoryPdOtdel);
                this.mnogieKategoriSpecOtdelTableAdapter.Fill(iSPDnBDDataSet.MnogieKategoriSpecOtdel);
                                
                if (tableOtdel.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in tableOtdel.Rows)
                    {
                        int OtdelId;
                        OtdelId = Convert.ToInt32(dataRow["OtdelOrgID"].ToString());
                        string OtdelName;
                        OtdelName = dataRow["OtdelOrgName"].ToString();
                        if (this.comboBoxRedOtdel.Text == OtdelName) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            ClassGlobalVar.OtdelID = OtdelId;
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
                        Id = dataRow["OtdelOrgID"].ToString();
                        int IdPd = Convert.ToInt32(IdKategoryPD);
                        if (Convert.ToInt32(Id) == ClassGlobalVar.OtdelID) // Если  Имя Поля названиеИС равно имени в Базе
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
                        string IdOtdel;
                        IdOtdel = dataRow["OtdelOrgID"].ToString();
                        if ((Convert.ToInt32(IdOtdel) == ClassGlobalVar.ISPDnID) && (IdPdSpec != 7)) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            checkedListBoxSpecKatPD.SetItemCheckState(IdPdSpec - 1, CheckState.Checked);
                        }
                        if ((Convert.ToInt32(IdOtdel) == ClassGlobalVar.ISPDnID) && (IdPdSpec == 7))
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
            this.comboBoxRedOtdel.Enabled = false;
        }

        private void buttonAktivRedIspdn_Click(object sender, EventArgs e)
        {
            FormOtdelAll frmOtdelall = new FormOtdelAll();
            frmOtdelall.Owner = this; //Передаём вновь созданной форме её владельца.
            frmOtdelall.Show();
        }

        private void buttonViewDateOtdel_Click(object sender, EventArgs e)
        {
                //обновляем таблицы на форме по запросу ИСПДн
                this.comboBoxRedOtdel.Text = this.comboBoxRedOtdel.Text;
                this.kategorySubjTableAdapter.MetodComboOtdelRed(iSPDnBDDataSet.KategorySubj, this.comboBoxRedOtdel.Text);
                this.kategoryPdBioTableAdapter.MetodBioOtdelRed(iSPDnBDDataSet.KategoryPdBio, this.comboBoxRedOtdel.Text);
                this.kategoryPdDopTableAdapter.MetodPdDopOtdelRed(iSPDnBDDataSet.KategoryPdDop, this.comboBoxRedOtdel.Text);
                this.RabotnikiOrgTableAdapter.MetodRabotnikiOtdelRed(iSPDnBDDataSet.RabotnikiOrg, this.comboBoxRedOtdel.Text);
                this.CeliObrabotkiPDTableAdapter.MetodCeliOtdelRed(iSPDnBDDataSet.CeliObrabotkiPD, this.comboBoxRedOtdel.Text);

                DataTable tableOsn = iSPDnBDDataSet.Tables["MnogieKategoryPdOtdel"];
                DataTable tableSpec = iSPDnBDDataSet.Tables["MnogieKategoriSpecOtdel"];
                DataTable tableBio = iSPDnBDDataSet.Tables["KategoryPdBio"];
                DataTable tableOtdel = iSPDnBDDataSet.Tables["OtdelOrg"];
                this.mnogieKategoryPdOtdelTableAdapter.Fill(iSPDnBDDataSet.MnogieKategoryPdOtdel);
                this.mnogieKategoriSpecOtdelTableAdapter.Fill(iSPDnBDDataSet.MnogieKategoriSpecOtdel);

                if (tableOtdel.Rows.Count > 0)
                {
                    ClassGlobalVar.OtdelID = ClassMetodOtdel.OtdelIDGetMetod(this.comboBoxRedOtdel.Text);
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
                        Id = dataRow["OtdelOrgID"].ToString();
                        int IdPd = Convert.ToInt32(IdKategoryPD);
                        if (Convert.ToInt32(Id) == ClassGlobalVar.OtdelID) // Если  Имя Поля названиеИС равно имени в Базе
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
                        string IdOtdel;
                        IdOtdel = dataRow["OtdelOrgID"].ToString();
                        if ((Convert.ToInt32(IdOtdel) == ClassGlobalVar.ISPDnID) && (IdPdSpec != 7)) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            checkedListBoxSpecKatPD.SetItemCheckState(IdPdSpec - 1, CheckState.Checked);
                        }
                        if ((Convert.ToInt32(IdOtdel) == ClassGlobalVar.ISPDnID) && (IdPdSpec == 7))
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

    }
}
