namespace SpaseFormISPDn
{
    partial class FormKlassIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKlassIS));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKlassIS = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RadioCpecialnaya = new System.Windows.Forms.RadioButton();
            this.RadioTipovaya = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RadioObemIII = new System.Windows.Forms.RadioButton();
            this.RadioObemII = new System.Windows.Forms.RadioButton();
            this.RadioObemI = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RadioKategoryIV = new System.Windows.Forms.RadioButton();
            this.RadioKategoryIII = new System.Windows.Forms.RadioButton();
            this.RadioKategoryII = new System.Windows.Forms.RadioButton();
            this.RadioKategoryI = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.labelSelectKlassIS = new System.Windows.Forms.Label();
            this.iSPDnOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.iSPDnOperatorTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter();
            this.comboBoxISPDnKl = new System.Windows.Forms.ComboBox();
            this.dataGridViewChlenKomiss = new System.Windows.Forms.DataGridView();
            this.NameChlenKomiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChlenKomiss)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonKlassIS
            // 
            this.buttonKlassIS.Location = new System.Drawing.Point(747, 561);
            this.buttonKlassIS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKlassIS.Name = "buttonKlassIS";
            this.buttonKlassIS.Size = new System.Drawing.Size(240, 47);
            this.buttonKlassIS.TabIndex = 3;
            this.buttonKlassIS.Text = "Классифицировать ИСПДн";
            this.buttonKlassIS.UseVisualStyleBackColor = true;
            this.buttonKlassIS.Click += new System.EventHandler(this.buttonKlassIS_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RadioCpecialnaya);
            this.tabPage3.Controls.Add(this.RadioTipovaya);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(972, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ИС по характеристикам";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RadioCpecialnaya
            // 
            this.RadioCpecialnaya.AutoSize = true;
            this.RadioCpecialnaya.Location = new System.Drawing.Point(8, 64);
            this.RadioCpecialnaya.Margin = new System.Windows.Forms.Padding(4);
            this.RadioCpecialnaya.Name = "RadioCpecialnaya";
            this.RadioCpecialnaya.Size = new System.Drawing.Size(871, 174);
            this.RadioCpecialnaya.TabIndex = 1;
            this.RadioCpecialnaya.Text = resources.GetString("RadioCpecialnaya.Text");
            this.RadioCpecialnaya.UseVisualStyleBackColor = true;
            // 
            // RadioTipovaya
            // 
            this.RadioTipovaya.AutoSize = true;
            this.RadioTipovaya.Location = new System.Drawing.Point(8, 20);
            this.RadioTipovaya.Margin = new System.Windows.Forms.Padding(4);
            this.RadioTipovaya.Name = "RadioTipovaya";
            this.RadioTipovaya.Size = new System.Drawing.Size(770, 38);
            this.RadioTipovaya.TabIndex = 0;
            this.RadioTipovaya.Text = "1 - Типовые информационные системы - информационные системы, в которых требуется " +
                "обеспечение только \r\nконфиденциальности персональных данных\r\n";
            this.RadioTipovaya.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RadioObemIII);
            this.tabPage2.Controls.Add(this.RadioObemII);
            this.tabPage2.Controls.Add(this.RadioObemI);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(972, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выбор объема данных";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RadioObemIII
            // 
            this.RadioObemIII.AutoSize = true;
            this.RadioObemIII.Location = new System.Drawing.Point(11, 151);
            this.RadioObemIII.Margin = new System.Windows.Forms.Padding(4);
            this.RadioObemIII.Name = "RadioObemIII";
            this.RadioObemIII.Size = new System.Drawing.Size(789, 38);
            this.RadioObemIII.TabIndex = 2;
            this.RadioObemIII.TabStop = true;
            this.RadioObemIII.Text = "3 - в информационной системе одновременно обрабатываются данные менее чем 1000 су" +
                "бъектов персональных \r\nданных или персональные данные субъектов персональных дан" +
                "ных в пределах конкретной организации.";
            this.RadioObemIII.UseVisualStyleBackColor = true;
            // 
            // RadioObemII
            // 
            this.RadioObemII.AutoSize = true;
            this.RadioObemII.Location = new System.Drawing.Point(8, 80);
            this.RadioObemII.Margin = new System.Windows.Forms.Padding(4);
            this.RadioObemII.Name = "RadioObemII";
            this.RadioObemII.Size = new System.Drawing.Size(816, 55);
            this.RadioObemII.TabIndex = 1;
            this.RadioObemII.TabStop = true;
            this.RadioObemII.Text = resources.GetString("RadioObemII.Text");
            this.RadioObemII.UseVisualStyleBackColor = true;
            // 
            // RadioObemI
            // 
            this.RadioObemI.AutoSize = true;
            this.RadioObemI.Location = new System.Drawing.Point(8, 20);
            this.RadioObemI.Margin = new System.Windows.Forms.Padding(4);
            this.RadioObemI.Name = "RadioObemI";
            this.RadioObemI.Size = new System.Drawing.Size(810, 55);
            this.RadioObemI.TabIndex = 0;
            this.RadioObemI.TabStop = true;
            this.RadioObemI.Text = resources.GetString("RadioObemI.Text");
            this.RadioObemI.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RadioKategoryIV);
            this.tabPage1.Controls.Add(this.RadioKategoryIII);
            this.tabPage1.Controls.Add(this.RadioKategoryII);
            this.tabPage1.Controls.Add(this.RadioKategoryI);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(972, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выбор категории";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RadioKategoryIV
            // 
            this.RadioKategoryIV.AutoSize = true;
            this.RadioKategoryIV.Location = new System.Drawing.Point(8, 149);
            this.RadioKategoryIV.Margin = new System.Windows.Forms.Padding(4);
            this.RadioKategoryIV.Name = "RadioKategoryIV";
            this.RadioKategoryIV.Size = new System.Drawing.Size(536, 21);
            this.RadioKategoryIV.TabIndex = 3;
            this.RadioKategoryIV.Text = "категория 4 - обезличенные и (или) общедоступные персональные данные.";
            this.RadioKategoryIV.UseVisualStyleBackColor = true;
            // 
            // RadioKategoryIII
            // 
            this.RadioKategoryIII.AutoSize = true;
            this.RadioKategoryIII.Location = new System.Drawing.Point(8, 108);
            this.RadioKategoryIII.Margin = new System.Windows.Forms.Padding(4);
            this.RadioKategoryIII.Name = "RadioKategoryIII";
            this.RadioKategoryIII.Size = new System.Drawing.Size(720, 21);
            this.RadioKategoryIII.TabIndex = 2;
            this.RadioKategoryIII.Text = "категория 3 - персональные данные, позволяющие идентифицировать субъекта персонал" +
                "ьных данных;";
            this.RadioKategoryIII.UseVisualStyleBackColor = true;
            // 
            // RadioKategoryII
            // 
            this.RadioKategoryII.AutoSize = true;
            this.RadioKategoryII.Location = new System.Drawing.Point(8, 64);
            this.RadioKategoryII.Margin = new System.Windows.Forms.Padding(4);
            this.RadioKategoryII.Name = "RadioKategoryII";
            this.RadioKategoryII.Size = new System.Drawing.Size(797, 38);
            this.RadioKategoryII.TabIndex = 1;
            this.RadioKategoryII.Text = resources.GetString("RadioKategoryII.Text");
            this.RadioKategoryII.UseVisualStyleBackColor = true;
            // 
            // RadioKategoryI
            // 
            this.RadioKategoryI.AutoSize = true;
            this.RadioKategoryI.Location = new System.Drawing.Point(8, 20);
            this.RadioKategoryI.Margin = new System.Windows.Forms.Padding(4);
            this.RadioKategoryI.Name = "RadioKategoryI";
            this.RadioKategoryI.Size = new System.Drawing.Size(806, 38);
            this.RadioKategoryI.TabIndex = 0;
            this.RadioKategoryI.Text = "категория 1 - персональные данные, касающиеся расовой, национальной принадлежност" +
                "и, политических взглядов, \r\nрелигиозных и философских убеждений, состояния здоро" +
                "вья, интимной жизни;\r\n";
            this.RadioKategoryI.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 106);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 273);
            this.tabControl1.TabIndex = 2;
            // 
            // labelSelectKlassIS
            // 
            this.labelSelectKlassIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectKlassIS.Location = new System.Drawing.Point(8, 73);
            this.labelSelectKlassIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectKlassIS.Name = "labelSelectKlassIS";
            this.labelSelectKlassIS.Size = new System.Drawing.Size(281, 17);
            this.labelSelectKlassIS.TabIndex = 5;
            this.labelSelectKlassIS.Text = "Выберете классифицируемую ИС";
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
            // iSPDnOperatorTableAdapter
            // 
            this.iSPDnOperatorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxISPDnKl
            // 
            this.comboBoxISPDnKl.DataSource = this.iSPDnOperatorBindingSource;
            this.comboBoxISPDnKl.DisplayMember = "ISPDnOperatorName";
            this.comboBoxISPDnKl.FormattingEnabled = true;
            this.comboBoxISPDnKl.Location = new System.Drawing.Point(311, 73);
            this.comboBoxISPDnKl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxISPDnKl.Name = "comboBoxISPDnKl";
            this.comboBoxISPDnKl.Size = new System.Drawing.Size(675, 24);
            this.comboBoxISPDnKl.TabIndex = 37;
            this.comboBoxISPDnKl.ValueMember = "ISPDnOperatorName";
            // 
            // dataGridViewChlenKomiss
            // 
            this.dataGridViewChlenKomiss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChlenKomiss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameChlenKomiss});
            this.dataGridViewChlenKomiss.Location = new System.Drawing.Point(7, 387);
            this.dataGridViewChlenKomiss.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewChlenKomiss.Name = "dataGridViewChlenKomiss";
            this.dataGridViewChlenKomiss.RowTemplate.Height = 24;
            this.dataGridViewChlenKomiss.Size = new System.Drawing.Size(976, 166);
            this.dataGridViewChlenKomiss.TabIndex = 38;
            // 
            // NameChlenKomiss
            // 
            this.NameChlenKomiss.HeaderText = "Фио члена комиссии по классификации";
            this.NameChlenKomiss.Name = "NameChlenKomiss";
            this.NameChlenKomiss.Width = 610;
            // 
            // FormKlassIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(993, 618);
            this.Controls.Add(this.dataGridViewChlenKomiss);
            this.Controls.Add(this.comboBoxISPDnKl);
            this.Controls.Add(this.labelSelectKlassIS);
            this.Controls.Add(this.buttonKlassIS);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKlassIS";
            this.Text = "Аудит ИСПДн и Разработка документации";
            this.Activated += new System.EventHandler(this.FormKlassIS_Activated);
            this.Load += new System.EventHandler(this.FormKlassIS_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChlenKomiss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKlassIS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton RadioCpecialnaya;
        private System.Windows.Forms.RadioButton RadioTipovaya;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton RadioObemIII;
        private System.Windows.Forms.RadioButton RadioObemII;
        private System.Windows.Forms.RadioButton RadioObemI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton RadioKategoryIV;
        private System.Windows.Forms.RadioButton RadioKategoryIII;
        private System.Windows.Forms.RadioButton RadioKategoryII;
        private System.Windows.Forms.RadioButton RadioKategoryI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label labelSelectKlassIS;
        private System.Windows.Forms.BindingSource iSPDnOperatorBindingSource;
        private ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter iSPDnOperatorTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxISPDnKl;
        public ISPDnBDDataSet iSPDnBDDataSet;
        private System.Windows.Forms.DataGridView dataGridViewChlenKomiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameChlenKomiss;
    }
}

