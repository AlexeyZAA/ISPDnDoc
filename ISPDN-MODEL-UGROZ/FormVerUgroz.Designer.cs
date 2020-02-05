namespace SpaseFormISPDn
{
    partial class FormVerUgroz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerUgroz));
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewVerUgroz = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nazvanieUgrozBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.buttonVerUgrRes = new System.Windows.Forms.Button();
            this.comboBoxISUgrozaOpasn = new System.Windows.Forms.ComboBox();
            this.iSPDnOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazvanieUgrozTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.NazvanieUgrozTableAdapter();
            this.tableAdapterManager = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager();
            this.iSPDnOperatorTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter();
            this.mnogieVerUgrozISTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieVerUgrozISTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnogieRealizUgrozTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieRealizUgrozTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVerUgroz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazvanieUgrozName";
            this.dataGridViewTextBoxColumn2.HeaderText = "NazvanieUgrozName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // DataGridViewVerUgroz
            // 
            this.DataGridViewVerUgroz.AllowUserToAddRows = false;
            this.DataGridViewVerUgroz.AllowUserToDeleteRows = false;
            this.DataGridViewVerUgroz.AllowUserToResizeColumns = false;
            this.DataGridViewVerUgroz.AllowUserToResizeRows = false;
            this.DataGridViewVerUgroz.AutoGenerateColumns = false;
            this.DataGridViewVerUgroz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVerUgroz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.DataGridViewVerUgroz.DataSource = this.nazvanieUgrozBindingSource;
            this.DataGridViewVerUgroz.Location = new System.Drawing.Point(12, 75);
            this.DataGridViewVerUgroz.MultiSelect = false;
            this.DataGridViewVerUgroz.Name = "DataGridViewVerUgroz";
            this.DataGridViewVerUgroz.RowHeadersWidth = 25;
            this.DataGridViewVerUgroz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewVerUgroz.Size = new System.Drawing.Size(867, 311);
            this.DataGridViewVerUgroz.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NazvanieUgrozName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название угроз";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 517;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "1";
            this.dataGridViewCheckBoxColumn1.HeaderText = "маловероятно";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.Width = 85;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "2";
            this.dataGridViewCheckBoxColumn2.HeaderText = "низкая вероятность";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn2.Width = 80;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "3";
            this.dataGridViewCheckBoxColumn3.HeaderText = "средняя вероятность";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn3.Width = 80;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "4";
            this.dataGridViewCheckBoxColumn4.HeaderText = "высокая вероятность";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn4.Width = 80;
            // 
            // nazvanieUgrozBindingSource
            // 
            this.nazvanieUgrozBindingSource.DataMember = "NazvanieUgroz";
            this.nazvanieUgrozBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // iSPDnBDDataSet
            // 
            this.iSPDnBDDataSet.DataSetName = "ISPDnBDDataSet";
            this.iSPDnBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonVerUgrRes
            // 
            this.buttonVerUgrRes.Location = new System.Drawing.Point(746, 392);
            this.buttonVerUgrRes.Name = "buttonVerUgrRes";
            this.buttonVerUgrRes.Size = new System.Drawing.Size(133, 36);
            this.buttonVerUgrRes.TabIndex = 4;
            this.buttonVerUgrRes.Text = "Готово";
            this.buttonVerUgrRes.UseVisualStyleBackColor = true;
            this.buttonVerUgrRes.Click += new System.EventHandler(this.buttonVerUgrRes_Click);
            // 
            // comboBoxISUgrozaOpasn
            // 
            this.comboBoxISUgrozaOpasn.DataSource = this.iSPDnOperatorBindingSource;
            this.comboBoxISUgrozaOpasn.DisplayMember = "ISPDnOperatorName";
            this.comboBoxISUgrozaOpasn.FormattingEnabled = true;
            this.comboBoxISUgrozaOpasn.Location = new System.Drawing.Point(127, 48);
            this.comboBoxISUgrozaOpasn.Name = "comboBoxISUgrozaOpasn";
            this.comboBoxISUgrozaOpasn.Size = new System.Drawing.Size(752, 21);
            this.comboBoxISUgrozaOpasn.TabIndex = 39;
            this.comboBoxISUgrozaOpasn.ValueMember = "ISPDnOperatorName";
            // 
            // iSPDnOperatorBindingSource
            // 
            this.iSPDnOperatorBindingSource.DataMember = "ISPDnOperator";
            this.iSPDnOperatorBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // nazvanieUgrozTableAdapter
            // 
            this.nazvanieUgrozTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActualnostTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CeliObrabotkiPDTableAdapter = null;
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
            this.tableAdapterManager.NazvanieUgrozTableAdapter = this.nazvanieUgrozTableAdapter;
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
            // iSPDnOperatorTableAdapter
            // 
            this.iSPDnOperatorTableAdapter.ClearBeforeFill = true;
            // 
            // mnogieVerUgrozISTableAdapter
            // 
            this.mnogieVerUgrozISTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Выбрать ИСПДн:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Требуется выбрать уровень вероятности для каждой из угроз для выбранной ИСПДн";
            // 
            // mnogieRealizUgrozTableAdapter
            // 
            this.mnogieRealizUgrozTableAdapter.ClearBeforeFill = true;
            // 
            // FormVerUgroz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxISUgrozaOpasn);
            this.Controls.Add(this.DataGridViewVerUgroz);
            this.Controls.Add(this.buttonVerUgrRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVerUgroz";
            this.Text = "Форма определения вероятности Угроз ИСПДн";
            this.Load += new System.EventHandler(this.FormVerUgroz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVerUgroz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ISPDnBDDataSet iSPDnBDDataSet;
        private System.Windows.Forms.BindingSource nazvanieUgrozBindingSource;
        private ISPDnBDDataSetTableAdapters.NazvanieUgrozTableAdapter nazvanieUgrozTableAdapter;
        private ISPDnBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DataGridViewVerUgroz;
        private System.Windows.Forms.Button buttonVerUgrRes;
        private System.Windows.Forms.ComboBox comboBoxISUgrozaOpasn;
        private System.Windows.Forms.BindingSource iSPDnOperatorBindingSource;
        private ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter iSPDnOperatorTableAdapter;
        private ISPDnBDDataSetTableAdapters.MnogieVerUgrozISTableAdapter mnogieVerUgrozISTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ISPDnBDDataSetTableAdapters.MnogieRealizUgrozTableAdapter mnogieRealizUgrozTableAdapter;
    }
}