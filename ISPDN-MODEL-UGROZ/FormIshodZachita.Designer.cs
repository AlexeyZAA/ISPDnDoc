namespace SpaseFormISPDn
{
    partial class FormIshodZachita
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIshodZachita));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ZagTerr = new System.Windows.Forms.Label();
            this.RadioButtonTerRadioButtonTerLocalZdanie = new System.Windows.Forms.RadioButton();
            this.RadioButtonTerLocal = new System.Windows.Forms.RadioButton();
            this.RadioButtonTerKorparation = new System.Windows.Forms.RadioButton();
            this.RadioButtonTerGorod = new System.Windows.Forms.RadioButton();
            this.RadioButtonTerGosudarstvo = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButtonSInetOtdelno = new System.Windows.Forms.RadioButton();
            this.RadioButtonSInetOdnotochie = new System.Windows.Forms.RadioButton();
            this.RadioButtonSInetMnogotochie = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioButtonLegalPeredacha = new System.Windows.Forms.RadioButton();
            this.RadioButtonLegalZapis = new System.Windows.Forms.RadioButton();
            this.RadioButtonLegalChtenie = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioButtonDostupOtkrit = new System.Windows.Forms.RadioButton();
            this.RadioButtonDostupVseSotrud = new System.Windows.Forms.RadioButton();
            this.RadioButtonDostupPerechen = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioButtonDrugieOdnaBD = new System.Windows.Forms.RadioButton();
            this.RadioButtonDrugieBDInteger = new System.Windows.Forms.RadioButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioButtonBezlicNo = new System.Windows.Forms.RadioButton();
            this.RadioButtonBezlicOrganization = new System.Windows.Forms.RadioButton();
            this.RadioButtonBezlicRegion = new System.Windows.Forms.RadioButton();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioButtonObyemNo = new System.Windows.Forms.RadioButton();
            this.RadioButtonObyemChastPD = new System.Windows.Forms.RadioButton();
            this.RadioButtonObyemAll = new System.Windows.Forms.RadioButton();
            this.buttonIshodZashita = new System.Windows.Forms.Button();
            this.ispDnOperatorTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter();
            this.mnogieHarakteristikiIshodTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieHarakteristikiIshodTableAdapter();
            this.comboBoxISPDnIshod = new System.Windows.Forms.ComboBox();
            this.iSPDnOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(3, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ZagTerr);
            this.tabPage1.Controls.Add(this.RadioButtonTerRadioButtonTerLocalZdanie);
            this.tabPage1.Controls.Add(this.RadioButtonTerLocal);
            this.tabPage1.Controls.Add(this.RadioButtonTerKorparation);
            this.tabPage1.Controls.Add(this.RadioButtonTerGorod);
            this.tabPage1.Controls.Add(this.RadioButtonTerGosudarstvo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметр - 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ZagTerr
            // 
            this.ZagTerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZagTerr.Location = new System.Drawing.Point(253, 14);
            this.ZagTerr.Name = "ZagTerr";
            this.ZagTerr.Size = new System.Drawing.Size(224, 23);
            this.ZagTerr.TabIndex = 5;
            this.ZagTerr.Text = "По территориальному размещению";
            // 
            // RadioButtonTerRadioButtonTerLocalZdanie
            // 
            this.RadioButtonTerRadioButtonTerLocalZdanie.Location = new System.Drawing.Point(6, 132);
            this.RadioButtonTerRadioButtonTerLocalZdanie.Name = "RadioButtonTerRadioButtonTerLocalZdanie";
            this.RadioButtonTerRadioButtonTerLocalZdanie.Size = new System.Drawing.Size(602, 17);
            this.RadioButtonTerRadioButtonTerLocalZdanie.TabIndex = 4;
            this.RadioButtonTerRadioButtonTerLocalZdanie.Text = "локальная ИСПДн, развернутая в пределах одного здания.";
            this.RadioButtonTerRadioButtonTerLocalZdanie.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTerLocal
            // 
            this.RadioButtonTerLocal.Location = new System.Drawing.Point(6, 109);
            this.RadioButtonTerLocal.Name = "RadioButtonTerLocal";
            this.RadioButtonTerLocal.Size = new System.Drawing.Size(602, 17);
            this.RadioButtonTerLocal.TabIndex = 3;
            this.RadioButtonTerLocal.Text = "локальная (кампусная) ИСПДн, развернутая в пределах нескольких близко расположенн" +
                "ых зданий;\r\n";
            this.RadioButtonTerLocal.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTerKorparation
            // 
            this.RadioButtonTerKorparation.AutoSize = true;
            this.RadioButtonTerKorparation.Location = new System.Drawing.Point(6, 86);
            this.RadioButtonTerKorparation.Name = "RadioButtonTerKorparation";
            this.RadioButtonTerKorparation.Size = new System.Drawing.Size(538, 17);
            this.RadioButtonTerKorparation.TabIndex = 2;
            this.RadioButtonTerKorparation.Text = "корпоративная распределенная ИСПДн, охватывающая многие подразделения одной орган" +
                "изации;\r\n";
            this.RadioButtonTerKorparation.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTerGorod
            // 
            this.RadioButtonTerGorod.AutoSize = true;
            this.RadioButtonTerGorod.Location = new System.Drawing.Point(6, 63);
            this.RadioButtonTerGorod.Name = "RadioButtonTerGorod";
            this.RadioButtonTerGorod.Size = new System.Drawing.Size(488, 17);
            this.RadioButtonTerGorod.TabIndex = 1;
            this.RadioButtonTerGorod.Text = "городская ИСПДн, охватывающая не более одного населенного пункта (города, поселка" +
                ");\r\n";
            this.RadioButtonTerGorod.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTerGosudarstvo
            // 
            this.RadioButtonTerGosudarstvo.AutoSize = true;
            this.RadioButtonTerGosudarstvo.Location = new System.Drawing.Point(6, 40);
            this.RadioButtonTerGosudarstvo.Name = "RadioButtonTerGosudarstvo";
            this.RadioButtonTerGosudarstvo.Size = new System.Drawing.Size(582, 17);
            this.RadioButtonTerGosudarstvo.TabIndex = 0;
            this.RadioButtonTerGosudarstvo.Text = "распределенная ИСПДн, которая охватывает несколько областей, краев, округов или г" +
                "осударство в целом;\r\n";
            this.RadioButtonTerGosudarstvo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.RadioButtonSInetOtdelno);
            this.tabPage2.Controls.Add(this.RadioButtonSInetOdnotochie);
            this.tabPage2.Controls.Add(this.RadioButtonSInetMnogotochie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Параметр - 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "По наличию соединения с сетями общего пользования";
            // 
            // RadioButtonSInetOtdelno
            // 
            this.RadioButtonSInetOtdelno.AutoSize = true;
            this.RadioButtonSInetOtdelno.Location = new System.Drawing.Point(6, 88);
            this.RadioButtonSInetOtdelno.Name = "RadioButtonSInetOtdelno";
            this.RadioButtonSInetOtdelno.Size = new System.Drawing.Size(339, 17);
            this.RadioButtonSInetOtdelno.TabIndex = 2;
            this.RadioButtonSInetOtdelno.TabStop = true;
            this.RadioButtonSInetOtdelno.Text = "ИСПДн, физически отделенная от сети общего пользования.";
            this.RadioButtonSInetOtdelno.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSInetOdnotochie
            // 
            this.RadioButtonSInetOdnotochie.AutoSize = true;
            this.RadioButtonSInetOdnotochie.Location = new System.Drawing.Point(6, 65);
            this.RadioButtonSInetOdnotochie.Name = "RadioButtonSInetOdnotochie";
            this.RadioButtonSInetOdnotochie.Size = new System.Drawing.Size(374, 17);
            this.RadioButtonSInetOdnotochie.TabIndex = 1;
            this.RadioButtonSInetOdnotochie.TabStop = true;
            this.RadioButtonSInetOdnotochie.Text = "ИСПДн, имеющая одноточечный выход в сеть общего пользования;";
            this.RadioButtonSInetOdnotochie.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSInetMnogotochie
            // 
            this.RadioButtonSInetMnogotochie.AutoSize = true;
            this.RadioButtonSInetMnogotochie.Location = new System.Drawing.Point(6, 42);
            this.RadioButtonSInetMnogotochie.Name = "RadioButtonSInetMnogotochie";
            this.RadioButtonSInetMnogotochie.Size = new System.Drawing.Size(381, 17);
            this.RadioButtonSInetMnogotochie.TabIndex = 0;
            this.RadioButtonSInetMnogotochie.TabStop = true;
            this.RadioButtonSInetMnogotochie.Text = "ИСПДн, имеющая многоточечный выход в сеть общего пользования;";
            this.RadioButtonSInetMnogotochie.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.RadioButtonLegalPeredacha);
            this.tabPage3.Controls.Add(this.RadioButtonLegalZapis);
            this.tabPage3.Controls.Add(this.RadioButtonLegalChtenie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(736, 161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Параметр - 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "По встроенным (легальным) операциям с записями баз персональных данных";
            // 
            // RadioButtonLegalPeredacha
            // 
            this.RadioButtonLegalPeredacha.AutoSize = true;
            this.RadioButtonLegalPeredacha.Location = new System.Drawing.Point(6, 78);
            this.RadioButtonLegalPeredacha.Name = "RadioButtonLegalPeredacha";
            this.RadioButtonLegalPeredacha.Size = new System.Drawing.Size(151, 17);
            this.RadioButtonLegalPeredacha.TabIndex = 2;
            this.RadioButtonLegalPeredacha.TabStop = true;
            this.RadioButtonLegalPeredacha.Text = "модификация, передача.";
            this.RadioButtonLegalPeredacha.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLegalZapis
            // 
            this.RadioButtonLegalZapis.AutoSize = true;
            this.RadioButtonLegalZapis.Location = new System.Drawing.Point(6, 55);
            this.RadioButtonLegalZapis.Name = "RadioButtonLegalZapis";
            this.RadioButtonLegalZapis.Size = new System.Drawing.Size(182, 17);
            this.RadioButtonLegalZapis.TabIndex = 1;
            this.RadioButtonLegalZapis.TabStop = true;
            this.RadioButtonLegalZapis.Text = "запись, удаление, сортировка;";
            this.RadioButtonLegalZapis.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLegalChtenie
            // 
            this.RadioButtonLegalChtenie.AutoSize = true;
            this.RadioButtonLegalChtenie.Location = new System.Drawing.Point(6, 32);
            this.RadioButtonLegalChtenie.Name = "RadioButtonLegalChtenie";
            this.RadioButtonLegalChtenie.Size = new System.Drawing.Size(98, 17);
            this.RadioButtonLegalChtenie.TabIndex = 0;
            this.RadioButtonLegalChtenie.TabStop = true;
            this.RadioButtonLegalChtenie.Text = "чтение, поиск;";
            this.RadioButtonLegalChtenie.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.RadioButtonDostupOtkrit);
            this.tabPage4.Controls.Add(this.RadioButtonDostupVseSotrud);
            this.tabPage4.Controls.Add(this.RadioButtonDostupPerechen);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(736, 161);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Параметр - 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(214, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "По разграничению доступа к персональным данным";
            // 
            // RadioButtonDostupOtkrit
            // 
            this.RadioButtonDostupOtkrit.AutoSize = true;
            this.RadioButtonDostupOtkrit.Location = new System.Drawing.Point(15, 82);
            this.RadioButtonDostupOtkrit.Name = "RadioButtonDostupOtkrit";
            this.RadioButtonDostupOtkrit.Size = new System.Drawing.Size(181, 17);
            this.RadioButtonDostupOtkrit.TabIndex = 2;
            this.RadioButtonDostupOtkrit.TabStop = true;
            this.RadioButtonDostupOtkrit.Text = "ИСПДн с открытым доступом.";
            this.RadioButtonDostupOtkrit.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDostupVseSotrud
            // 
            this.RadioButtonDostupVseSotrud.AutoSize = true;
            this.RadioButtonDostupVseSotrud.Location = new System.Drawing.Point(15, 59);
            this.RadioButtonDostupVseSotrud.Name = "RadioButtonDostupVseSotrud";
            this.RadioButtonDostupVseSotrud.Size = new System.Drawing.Size(522, 17);
            this.RadioButtonDostupVseSotrud.TabIndex = 1;
            this.RadioButtonDostupVseSotrud.TabStop = true;
            this.RadioButtonDostupVseSotrud.Text = "ИСПДн, к которой имеют доступ все сотрудники организации, являющейся владельцем И" +
                "СПДн;";
            this.RadioButtonDostupVseSotrud.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDostupPerechen
            // 
            this.RadioButtonDostupPerechen.AutoSize = true;
            this.RadioButtonDostupPerechen.Location = new System.Drawing.Point(15, 36);
            this.RadioButtonDostupPerechen.Name = "RadioButtonDostupPerechen";
            this.RadioButtonDostupPerechen.Size = new System.Drawing.Size(639, 17);
            this.RadioButtonDostupPerechen.TabIndex = 0;
            this.RadioButtonDostupPerechen.TabStop = true;
            this.RadioButtonDostupPerechen.Text = "ИСПДн, к которой имеют доступ определенные переченем сотрудники организации, явля" +
                "ющейся владельцем ИСПДн, ";
            this.RadioButtonDostupPerechen.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.RadioButtonDrugieOdnaBD);
            this.tabPage5.Controls.Add(this.RadioButtonDrugieBDInteger);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(736, 161);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Параметр - 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(197, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "По наличию соединений с другими базами ПДн иных ИСПДн";
            // 
            // RadioButtonDrugieOdnaBD
            // 
            this.RadioButtonDrugieOdnaBD.AutoSize = true;
            this.RadioButtonDrugieOdnaBD.Location = new System.Drawing.Point(6, 72);
            this.RadioButtonDrugieOdnaBD.Name = "RadioButtonDrugieOdnaBD";
            this.RadioButtonDrugieOdnaBD.Size = new System.Drawing.Size(574, 17);
            this.RadioButtonDrugieOdnaBD.TabIndex = 1;
            this.RadioButtonDrugieOdnaBD.Text = "ИСПДн, в которой используется одна база ПДн, принадлежащая организации - владельц" +
                "у данной ИСПДн.";
            this.RadioButtonDrugieOdnaBD.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDrugieBDInteger
            // 
            this.RadioButtonDrugieBDInteger.AutoSize = true;
            this.RadioButtonDrugieBDInteger.Location = new System.Drawing.Point(6, 36);
            this.RadioButtonDrugieBDInteger.Name = "RadioButtonDrugieBDInteger";
            this.RadioButtonDrugieBDInteger.Size = new System.Drawing.Size(619, 30);
            this.RadioButtonDrugieBDInteger.TabIndex = 0;
            this.RadioButtonDrugieBDInteger.Text = "интегрированная ИСПДн (организация использует несколько баз ПДн ИСПДн, при этом о" +
                "рганизация не является \r\nвладельцем всех используемых баз ПДн);";
            this.RadioButtonDrugieBDInteger.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.RadioButtonBezlicNo);
            this.tabPage6.Controls.Add(this.RadioButtonBezlicOrganization);
            this.tabPage6.Controls.Add(this.RadioButtonBezlicRegion);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(736, 161);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Параметр - 6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(224, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "По уровню обобщения (обезличивания) ПДн";
            // 
            // RadioButtonBezlicNo
            // 
            this.RadioButtonBezlicNo.AutoSize = true;
            this.RadioButtonBezlicNo.Location = new System.Drawing.Point(6, 110);
            this.RadioButtonBezlicNo.Name = "RadioButtonBezlicNo";
            this.RadioButtonBezlicNo.Size = new System.Drawing.Size(579, 30);
            this.RadioButtonBezlicNo.TabIndex = 2;
            this.RadioButtonBezlicNo.TabStop = true;
            this.RadioButtonBezlicNo.Text = "ИСПДн, в которой предоставляемые пользователю данные не являются обезличенными (т" +
                ".е. присутствует \r\nинформация, позволяющая идентифицировать субъекта ПДн).";
            this.RadioButtonBezlicNo.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBezlicOrganization
            // 
            this.RadioButtonBezlicOrganization.AutoSize = true;
            this.RadioButtonBezlicOrganization.Location = new System.Drawing.Point(6, 74);
            this.RadioButtonBezlicOrganization.Name = "RadioButtonBezlicOrganization";
            this.RadioButtonBezlicOrganization.Size = new System.Drawing.Size(582, 30);
            this.RadioButtonBezlicOrganization.TabIndex = 1;
            this.RadioButtonBezlicOrganization.TabStop = true;
            this.RadioButtonBezlicOrganization.Text = "ИСПДн, в которой данные обезличиваются только при передаче в другие организации и" +
                " не обезличены при \r\nпредоставлении пользователю в организации;";
            this.RadioButtonBezlicOrganization.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBezlicRegion
            // 
            this.RadioButtonBezlicRegion.AutoSize = true;
            this.RadioButtonBezlicRegion.Location = new System.Drawing.Point(6, 38);
            this.RadioButtonBezlicRegion.Name = "RadioButtonBezlicRegion";
            this.RadioButtonBezlicRegion.Size = new System.Drawing.Size(642, 30);
            this.RadioButtonBezlicRegion.TabIndex = 0;
            this.RadioButtonBezlicRegion.TabStop = true;
            this.RadioButtonBezlicRegion.Text = "ИСПДн, в которой предоставляемые пользователю данные являются обезличенными (на у" +
                "ровне организации, отрасли,\r\n области, региона и т.д.);\r\n";
            this.RadioButtonBezlicRegion.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.RadioButtonObyemNo);
            this.tabPage7.Controls.Add(this.RadioButtonObyemChastPD);
            this.tabPage7.Controls.Add(this.RadioButtonObyemAll);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(736, 161);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Параметр - 7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(697, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "По объему  ПДн, которые предоставляются  сторонним пользователям ИСПДн без предва" +
                "рительной обработки";
            // 
            // RadioButtonObyemNo
            // 
            this.RadioButtonObyemNo.AutoSize = true;
            this.RadioButtonObyemNo.Location = new System.Drawing.Point(6, 82);
            this.RadioButtonObyemNo.Name = "RadioButtonObyemNo";
            this.RadioButtonObyemNo.Size = new System.Drawing.Size(293, 17);
            this.RadioButtonObyemNo.TabIndex = 2;
            this.RadioButtonObyemNo.TabStop = true;
            this.RadioButtonObyemNo.Text = "ИСПДн, не предоставляющая никакой информации.";
            this.RadioButtonObyemNo.UseVisualStyleBackColor = true;
            // 
            // RadioButtonObyemChastPD
            // 
            this.RadioButtonObyemChastPD.AutoSize = true;
            this.RadioButtonObyemChastPD.Location = new System.Drawing.Point(6, 59);
            this.RadioButtonObyemChastPD.Name = "RadioButtonObyemChastPD";
            this.RadioButtonObyemChastPD.Size = new System.Drawing.Size(223, 17);
            this.RadioButtonObyemChastPD.TabIndex = 1;
            this.RadioButtonObyemChastPD.TabStop = true;
            this.RadioButtonObyemChastPD.Text = "ИСПДн, предоставляющая часть ПДн;";
            this.RadioButtonObyemChastPD.UseVisualStyleBackColor = true;
            // 
            // RadioButtonObyemAll
            // 
            this.RadioButtonObyemAll.AutoSize = true;
            this.RadioButtonObyemAll.Location = new System.Drawing.Point(6, 36);
            this.RadioButtonObyemAll.Name = "RadioButtonObyemAll";
            this.RadioButtonObyemAll.Size = new System.Drawing.Size(290, 17);
            this.RadioButtonObyemAll.TabIndex = 0;
            this.RadioButtonObyemAll.TabStop = true;
            this.RadioButtonObyemAll.Text = "ИСПДн, предоставляющая всю базу данных с ПДн;";
            this.RadioButtonObyemAll.UseVisualStyleBackColor = true;
            // 
            // buttonIshodZashita
            // 
            this.buttonIshodZashita.Location = new System.Drawing.Point(602, 278);
            this.buttonIshodZashita.Name = "buttonIshodZashita";
            this.buttonIshodZashita.Size = new System.Drawing.Size(145, 38);
            this.buttonIshodZashita.TabIndex = 1;
            this.buttonIshodZashita.Text = "Исходная защищенность";
            this.buttonIshodZashita.UseVisualStyleBackColor = true;
            this.buttonIshodZashita.Click += new System.EventHandler(this.buttonIshodZashita_Click);
            // 
            // ispDnOperatorTableAdapter
            // 
            this.ispDnOperatorTableAdapter.ClearBeforeFill = true;
            // 
            // mnogieHarakteristikiIshodTableAdapter
            // 
            this.mnogieHarakteristikiIshodTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxISPDnIshod
            // 
            this.comboBoxISPDnIshod.DataSource = this.iSPDnOperatorBindingSource;
            this.comboBoxISPDnIshod.DisplayMember = "ISPDnOperatorName";
            this.comboBoxISPDnIshod.FormattingEnabled = true;
            this.comboBoxISPDnIshod.Location = new System.Drawing.Point(245, 48);
            this.comboBoxISPDnIshod.Name = "comboBoxISPDnIshod";
            this.comboBoxISPDnIshod.Size = new System.Drawing.Size(502, 21);
            this.comboBoxISPDnIshod.TabIndex = 38;
            this.comboBoxISPDnIshod.ValueMember = "ISPDnOperatorName";
            // 
            // iSPDnOperatorBindingSource
            // 
            this.iSPDnOperatorBindingSource.DataMember = "ISPDnOperator";
            this.iSPDnOperatorBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // iSPDnBDDataSet
            // 
            this.iSPDnBDDataSet.DataSetName = "ISPDnBDDataSet";
            this.iSPDnBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(157, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 27);
            this.label7.TabIndex = 39;
            this.label7.Text = "Технические и эксплуатационные характеристики ИСПДн";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Выбрать характеристики для ИСПДн:";
            // 
            // FormIshodZachita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 326);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxISPDnIshod);
            this.Controls.Add(this.buttonIshodZashita);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIshodZachita";
            this.Text = "Определение исходной защищенности ИСПДн";
            this.Activated += new System.EventHandler(this.FormIshodZachita_Activated);
            this.Load += new System.EventHandler(this.FormIshodZachita_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton RadioButtonTerRadioButtonTerLocalZdanie;
        private System.Windows.Forms.RadioButton RadioButtonTerLocal;
        private System.Windows.Forms.RadioButton RadioButtonTerKorparation;
        private System.Windows.Forms.RadioButton RadioButtonTerGorod;
        private System.Windows.Forms.RadioButton RadioButtonTerGosudarstvo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton RadioButtonSInetOtdelno;
        private System.Windows.Forms.RadioButton RadioButtonSInetOdnotochie;
        private System.Windows.Forms.RadioButton RadioButtonSInetMnogotochie;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button buttonIshodZashita;
        private System.Windows.Forms.RadioButton RadioButtonLegalPeredacha;
        private System.Windows.Forms.RadioButton RadioButtonLegalZapis;
        private System.Windows.Forms.RadioButton RadioButtonLegalChtenie;
        private System.Windows.Forms.RadioButton RadioButtonDostupOtkrit;
        private System.Windows.Forms.RadioButton RadioButtonDostupVseSotrud;
        private System.Windows.Forms.RadioButton RadioButtonDostupPerechen;
        private System.Windows.Forms.RadioButton RadioButtonDrugieOdnaBD;
        private System.Windows.Forms.RadioButton RadioButtonDrugieBDInteger;
        private System.Windows.Forms.RadioButton RadioButtonBezlicNo;
        private System.Windows.Forms.RadioButton RadioButtonBezlicOrganization;
        private System.Windows.Forms.RadioButton RadioButtonBezlicRegion;
        private System.Windows.Forms.RadioButton RadioButtonObyemNo;
        private System.Windows.Forms.RadioButton RadioButtonObyemChastPD;
        private System.Windows.Forms.RadioButton RadioButtonObyemAll;
        private ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter ispDnOperatorTableAdapter;
        private ISPDnBDDataSetTableAdapters.MnogieHarakteristikiIshodTableAdapter mnogieHarakteristikiIshodTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxISPDnIshod;
        private System.Windows.Forms.BindingSource iSPDnOperatorBindingSource;
        private ISPDnBDDataSet iSPDnBDDataSet;
        private System.Windows.Forms.Label ZagTerr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}