namespace SpaseFormISPDn
{
    partial class FormOtdelAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtdelAll));
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.otdelOrgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelOrgTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.OtdelOrgTableAdapter();
            this.tableAdapterManager = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager();
            this.otdelOrgDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOtdelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelOrgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelOrgDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iSPDnBDDataSet
            // 
            this.iSPDnBDDataSet.DataSetName = "ISPDnBDDataSet";
            this.iSPDnBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otdelOrgBindingSource
            // 
            this.otdelOrgBindingSource.DataMember = "OtdelOrg";
            this.otdelOrgBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // otdelOrgTableAdapter
            // 
            this.otdelOrgTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NazvanieUgrozTableAdapter = null;
            this.tableAdapterManager.OpasnostUgrozTableAdapter = null;
            this.tableAdapterManager.OrgOperatorTableAdapter = null;
            this.tableAdapterManager.OtdelOrgTableAdapter = this.otdelOrgTableAdapter;
            this.tableAdapterManager.RabotnikiOrgTableAdapter = null;
            this.tableAdapterManager.RealizationUgrozTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeroyatnostUgrozTableAdapter = null;
            this.tableAdapterManager.VidIshodHarakteristikTableAdapter = null;
            this.tableAdapterManager.VidUgrozTableAdapter = null;
            // 
            // otdelOrgDataGridView
            // 
            this.otdelOrgDataGridView.AutoGenerateColumns = false;
            this.otdelOrgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otdelOrgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.otdelOrgDataGridView.DataSource = this.otdelOrgBindingSource;
            this.otdelOrgDataGridView.Location = new System.Drawing.Point(12, 12);
            this.otdelOrgDataGridView.Name = "otdelOrgDataGridView";
            this.otdelOrgDataGridView.Size = new System.Drawing.Size(641, 246);
            this.otdelOrgDataGridView.TabIndex = 1;
            this.otdelOrgDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.otdelOrgDataGridView_CellBeginEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OtdelOrgID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OtdelOrgID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OtdelOrgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование отдела";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrgOperatorID";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrgOperatorID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // buttonOtdelAll
            // 
            this.buttonOtdelAll.Location = new System.Drawing.Point(545, 264);
            this.buttonOtdelAll.Name = "buttonOtdelAll";
            this.buttonOtdelAll.Size = new System.Drawing.Size(108, 34);
            this.buttonOtdelAll.TabIndex = 2;
            this.buttonOtdelAll.Text = "Добавить";
            this.buttonOtdelAll.UseVisualStyleBackColor = true;
            this.buttonOtdelAll.Click += new System.EventHandler(this.buttonOtdelAll_Click);
            // 
            // FormOtdelAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 304);
            this.Controls.Add(this.buttonOtdelAll);
            this.Controls.Add(this.otdelOrgDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOtdelAll";
            this.Text = "FormOtdelAll";
            this.Load += new System.EventHandler(this.FormOtdelAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelOrgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelOrgDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ISPDnBDDataSet iSPDnBDDataSet;
        private System.Windows.Forms.BindingSource otdelOrgBindingSource;
        private ISPDnBDDataSetTableAdapters.OtdelOrgTableAdapter otdelOrgTableAdapter;
        private ISPDnBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView otdelOrgDataGridView;
        private System.Windows.Forms.Button buttonOtdelAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}