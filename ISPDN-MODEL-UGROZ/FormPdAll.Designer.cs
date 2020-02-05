namespace SpaseFormISPDn
{
    partial class FormSubjAll
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
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.iSPDnBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnogieISPDnKategoryPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnogieISPDnKategoryPDTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieISPDnKategoryPDTableAdapter();
            this.kategorySubjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorySubjTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.KategorySubjTableAdapter();
            this.tableAdapterManager = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager();
            this.kategorySubjDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEx = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnogieISPDnKategoryPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorySubjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorySubjDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iSPDnBDDataSet
            // 
            this.iSPDnBDDataSet.DataSetName = "ISPDnBDDataSet";
            this.iSPDnBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSPDnBDDataSetBindingSource
            // 
            this.iSPDnBDDataSetBindingSource.DataSource = this.iSPDnBDDataSet;
            this.iSPDnBDDataSetBindingSource.Position = 0;
            // 
            // mnogieISPDnKategoryPDBindingSource
            // 
            this.mnogieISPDnKategoryPDBindingSource.DataMember = "MnogieISPDnKategoryPD";
            this.mnogieISPDnKategoryPDBindingSource.DataSource = this.iSPDnBDDataSetBindingSource;
            // 
            // mnogieISPDnKategoryPDTableAdapter
            // 
            this.mnogieISPDnKategoryPDTableAdapter.ClearBeforeFill = true;
            // 
            // kategorySubjBindingSource
            // 
            this.kategorySubjBindingSource.DataMember = "KategorySubj";
            this.kategorySubjBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // kategorySubjTableAdapter
            // 
            this.kategorySubjTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KategorySubjTableAdapter = this.kategorySubjTableAdapter;
            this.tableAdapterManager.MnogieCeliObrabotkiISPDnTableAdapter = null;
            this.tableAdapterManager.MnogieCeliOtdelTableAdapter = null;
            this.tableAdapterManager.MnogieHarakteristikiIshodTableAdapter = null;
            this.tableAdapterManager.MnogieISPDnKategoryPDTableAdapter = this.mnogieISPDnKategoryPDTableAdapter;
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
            this.tableAdapterManager.MnogieSubjPravoTableAdapter = null;
            this.tableAdapterManager.MnogieUgrozaActualTableAdapter = null;
            this.tableAdapterManager.MnogieVerUgrozISTableAdapter = null;
            this.tableAdapterManager.NazvanieUgrozTableAdapter = null;
            this.tableAdapterManager.OpasnostUgrozTableAdapter = null;
            this.tableAdapterManager.OrgOperatorTableAdapter = null;
            this.tableAdapterManager.OtdelOrgTableAdapter = null;
            this.tableAdapterManager.PravoOrgTableAdapter = null;
            this.tableAdapterManager.RabotnikiOrgTableAdapter = null;
            this.tableAdapterManager.RealizationUgrozTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeroyatnostUgrozTableAdapter = null;
            this.tableAdapterManager.VidIshodHarakteristikTableAdapter = null;
            this.tableAdapterManager.VidUgrozTableAdapter = null;
            // 
            // kategorySubjDataGridView
            // 
            this.kategorySubjDataGridView.AllowUserToAddRows = false;
            this.kategorySubjDataGridView.AllowUserToDeleteRows = false;
            this.kategorySubjDataGridView.AllowUserToResizeColumns = false;
            this.kategorySubjDataGridView.AllowUserToResizeRows = false;
            this.kategorySubjDataGridView.AutoGenerateColumns = false;
            this.kategorySubjDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategorySubjDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.kategorySubjDataGridView.DataSource = this.kategorySubjBindingSource;
            this.kategorySubjDataGridView.Location = new System.Drawing.Point(12, 89);
            this.kategorySubjDataGridView.Name = "kategorySubjDataGridView";
            this.kategorySubjDataGridView.RowTemplate.Height = 24;
            this.kategorySubjDataGridView.Size = new System.Drawing.Size(885, 313);
            this.kategorySubjDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список всех субъектов чьи данные обрабатываются в организации";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(756, 408);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(141, 40);
            this.buttonEx.TabIndex = 2;
            this.buttonEx.Text = "Выход";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KategorySubjID";
            this.dataGridViewTextBoxColumn1.HeaderText = "KategorySubjID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KategorySubjName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категории субъектов персональных данных";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 840;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "KategorySubjSelect";
            this.dataGridViewCheckBoxColumn1.HeaderText = "KategorySubjSelect";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrgOperatorID";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrgOperatorID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // FormSubjAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 459);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategorySubjDataGridView);
            this.Name = "FormSubjAll";
            this.Text = "Все субъекты ПД";
            this.Load += new System.EventHandler(this.FormPdAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnogieISPDnKategoryPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorySubjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorySubjDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource iSPDnBDDataSetBindingSource;
        private ISPDnBDDataSet iSPDnBDDataSet;
        private System.Windows.Forms.BindingSource mnogieISPDnKategoryPDBindingSource;
        private ISPDnBDDataSetTableAdapters.MnogieISPDnKategoryPDTableAdapter mnogieISPDnKategoryPDTableAdapter;
        private System.Windows.Forms.BindingSource kategorySubjBindingSource;
        private ISPDnBDDataSetTableAdapters.KategorySubjTableAdapter kategorySubjTableAdapter;
        private ISPDnBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kategorySubjDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}