namespace SpaseFormISPDn
{
    partial class FormOpasnUgroz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpasnUgroz));
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.tableAdapterManager = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager();
            this.buttonOpasnost = new System.Windows.Forms.Button();
            this.comboBoxISUgrozaOpasn = new System.Windows.Forms.ComboBox();
            this.iSPDnOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSPDnOperatorTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter();
            this.nazvanieUgrozBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazvanieUgrozTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.NazvanieUgrozTableAdapter();
            this.DataGridViewOpasnUgroz = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mnogieOpasnUgrozISTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieOpasnUgrozISTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOpasnUgroz)).BeginInit();
            this.SuspendLayout();
            // 
            // iSPDnBDDataSet
            // 
            this.iSPDnBDDataSet.DataSetName = "ISPDnBDDataSet";
            this.iSPDnBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActualnostTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CeliObrabotkiPDTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ISPDnHarakteristikIshodTableAdapter = null;
            this.tableAdapterManager.ISPDnIshodZashitaTableAdapter = null;
            this.tableAdapterManager.ISPDnKategoryTableAdapter = null;
            this.tableAdapterManager.ISPDnKlassTableAdapter = null;
            this.tableAdapterManager.ISPDnObemTableAdapter = null;
            this.tableAdapterManager.ISPDnOperatorTableAdapter = null;
            this.tableAdapterManager.ISPDnTipSpecialTableAdapter = null;
            this.tableAdapterManager.KategoryPdBioTableAdapter = null;
            this.tableAdapterManager.KategoryPdDopTableAdapter = null;
            this.tableAdapterManager.KategoryPdSpecTableAdapter = null;
            this.tableAdapterManager.KategoryPdTableAdapter = null;
            this.tableAdapterManager.KategorySubjTableAdapter = null;
            this.tableAdapterManager.MnogieCeliObrabotkiISPDnTableAdapter = null;
            this.tableAdapterManager.MnogieCeliOtdelTableAdapter = null;
            this.tableAdapterManager.MnogieHarakteristikiIshodTableAdapter = null;
            this.tableAdapterManager.MnogieISPDnKategoryPDTableAdapter = null;
            this.tableAdapterManager.MnogieISPDnRabotnikiTableAdapter = null;
            this.tableAdapterManager.MnogieISPDnSubjTableAdapter = null;
            this.tableAdapterManager.MnogieKategoriSpecOtdelTableAdapter = null;
            this.tableAdapterManager.MnogieKategoryBioOtdelTableAdapter = null;
            this.tableAdapterManager.MnogieKategoryDopOtdelTableAdapter = null;
            this.tableAdapterManager.MnogieKategoryPdBioISPDnTableAdapter = null;
            this.tableAdapterManager.MnogieKategoryPdDopISPDnTableAdapter = null;
            this.tableAdapterManager.MnogieKategoryPdOtdelTableAdapter = null;
            this.tableAdapterManager.MnogieKategoryPdSpecISPDnTableAdapter = null;
            this.tableAdapterManager.MnogieOpasnUgrozISTableAdapter = null;
            this.tableAdapterManager.MnogieOtdelSubjTableAdapter = null;
            this.tableAdapterManager.MnogieRabotnikiOtdelTableAdapter = null;
            this.tableAdapterManager.MnogieRealizUgrozTableAdapter = null;
            this.tableAdapterManager.MnogieUgrozaActualTableAdapter = null;
            this.tableAdapterManager.MnogieVerUgrozISTableAdapter = null;
            this.tableAdapterManager.NazvanieUgrozTableAdapter = null;
            this.tableAdapterManager.OpasnostUgrozTableAdapter = null;
            this.tableAdapterManager.OrgOperatorTableAdapter = null;
            this.tableAdapterManager.OtdelOrgTableAdapter = null;
            this.tableAdapterManager.RabotnikiOrgTableAdapter = null;
            this.tableAdapterManager.RealizationUgrozTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeroyatnostUgrozTableAdapter = null;
            this.tableAdapterManager.VidIshodHarakteristikTableAdapter = null;
            this.tableAdapterManager.VidUgrozTableAdapter = null;
            // 
            // buttonOpasnost
            // 
            this.buttonOpasnost.Location = new System.Drawing.Point(742, 381);
            this.buttonOpasnost.Name = "buttonOpasnost";
            this.buttonOpasnost.Size = new System.Drawing.Size(118, 35);
            this.buttonOpasnost.TabIndex = 3;
            this.buttonOpasnost.Text = "Определение опасности";
            this.buttonOpasnost.UseVisualStyleBackColor = true;
            this.buttonOpasnost.Click += new System.EventHandler(this.buttonOpasnost_Click);
            // 
            // comboBoxISUgrozaOpasn
            // 
            this.comboBoxISUgrozaOpasn.DataSource = this.iSPDnOperatorBindingSource;
            this.comboBoxISUgrozaOpasn.DisplayMember = "ISPDnOperatorName";
            this.comboBoxISUgrozaOpasn.FormattingEnabled = true;
            this.comboBoxISUgrozaOpasn.Location = new System.Drawing.Point(135, 59);
            this.comboBoxISUgrozaOpasn.Name = "comboBoxISUgrozaOpasn";
            this.comboBoxISUgrozaOpasn.Size = new System.Drawing.Size(725, 21);
            this.comboBoxISUgrozaOpasn.TabIndex = 38;
            this.comboBoxISUgrozaOpasn.ValueMember = "ISPDnOperatorName";
            // 
            // iSPDnOperatorBindingSource
            // 
            this.iSPDnOperatorBindingSource.DataMember = "ISPDnOperator";
            this.iSPDnOperatorBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // iSPDnOperatorTableAdapter
            // 
            this.iSPDnOperatorTableAdapter.ClearBeforeFill = true;
            // 
            // nazvanieUgrozBindingSource
            // 
            this.nazvanieUgrozBindingSource.DataMember = "NazvanieUgroz";
            this.nazvanieUgrozBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // nazvanieUgrozTableAdapter
            // 
            this.nazvanieUgrozTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridViewOpasnUgroz
            // 
            this.DataGridViewOpasnUgroz.AllowUserToResizeColumns = false;
            this.DataGridViewOpasnUgroz.AllowUserToResizeRows = false;
            this.DataGridViewOpasnUgroz.AutoGenerateColumns = false;
            this.DataGridViewOpasnUgroz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOpasnUgroz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.DataGridViewOpasnUgroz.DataSource = this.nazvanieUgrozBindingSource;
            this.DataGridViewOpasnUgroz.Location = new System.Drawing.Point(9, 86);
            this.DataGridViewOpasnUgroz.Name = "DataGridViewOpasnUgroz";
            this.DataGridViewOpasnUgroz.Size = new System.Drawing.Size(851, 289);
            this.DataGridViewOpasnUgroz.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NazvanieUgrozID";
            this.dataGridViewTextBoxColumn1.HeaderText = "УгрозаID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazvanieUgrozName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название угроз";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 463;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VidUgrozID";
            this.dataGridViewTextBoxColumn3.HeaderText = "VidUgrozID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "1";
            this.dataGridViewCheckBoxColumn1.HeaderText = "низкая опасность";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 115;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "2";
            this.dataGridViewCheckBoxColumn2.HeaderText = "средняя опасность";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 115;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "3";
            this.dataGridViewCheckBoxColumn3.HeaderText = "высокая опасность";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 115;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "4";
            this.dataGridViewCheckBoxColumn4.HeaderText = "4";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // mnogieOpasnUgrozISTableAdapter
            // 
            this.mnogieOpasnUgrozISTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Выбрать ИСПДн:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(158, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Требуется выбрать уровень опасности для каждой из угроз для выбранной ИСПДн";
            // 
            // FormOpasnUgroz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewOpasnUgroz);
            this.Controls.Add(this.comboBoxISUgrozaOpasn);
            this.Controls.Add(this.buttonOpasnost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOpasnUgroz";
            this.Text = "Форма определения опасности Угроз";
            this.Load += new System.EventHandler(this.FormOpasnUgroz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOpasnUgroz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ISPDnBDDataSet iSPDnBDDataSet;
        private ISPDnBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonOpasnost;
        private System.Windows.Forms.ComboBox comboBoxISUgrozaOpasn;
        private System.Windows.Forms.BindingSource iSPDnOperatorBindingSource;
        private ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter iSPDnOperatorTableAdapter;
        private System.Windows.Forms.BindingSource nazvanieUgrozBindingSource;
        private ISPDnBDDataSetTableAdapters.NazvanieUgrozTableAdapter nazvanieUgrozTableAdapter;
        private System.Windows.Forms.DataGridView DataGridViewOpasnUgroz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private ISPDnBDDataSetTableAdapters.MnogieOpasnUgrozISTableAdapter mnogieOpasnUgrozISTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}