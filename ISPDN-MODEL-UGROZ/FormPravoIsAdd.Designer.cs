namespace SpaseFormISPDn
{
    partial class FormPravoIsAdd
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
            this.pravoOrgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pravoOrgTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.PravoOrgTableAdapter();
            this.tableAdapterManager = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager();
            this.pravoOrgDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPravoAdd = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravoOrgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravoOrgDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iSPDnBDDataSet
            // 
            this.iSPDnBDDataSet.DataSetName = "ISPDnBDDataSet";
            this.iSPDnBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pravoOrgBindingSource
            // 
            this.pravoOrgBindingSource.DataMember = "PravoOrg";
            this.pravoOrgBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // pravoOrgTableAdapter
            // 
            this.pravoOrgTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MnogieSubjPravoTableAdapter = null;
            this.tableAdapterManager.MnogieUgrozaActualTableAdapter = null;
            this.tableAdapterManager.MnogieVerUgrozISTableAdapter = null;
            this.tableAdapterManager.NazvanieUgrozTableAdapter = null;
            this.tableAdapterManager.OpasnostUgrozTableAdapter = null;
            this.tableAdapterManager.OrgOperatorTableAdapter = null;
            this.tableAdapterManager.OtdelOrgTableAdapter = null;
            this.tableAdapterManager.PravoOrgTableAdapter = this.pravoOrgTableAdapter;
            this.tableAdapterManager.RabotnikiOrgTableAdapter = null;
            this.tableAdapterManager.RealizationUgrozTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeroyatnostUgrozTableAdapter = null;
            this.tableAdapterManager.VidIshodHarakteristikTableAdapter = null;
            this.tableAdapterManager.VidUgrozTableAdapter = null;
            // 
            // pravoOrgDataGridView
            // 
            this.pravoOrgDataGridView.AutoGenerateColumns = false;
            this.pravoOrgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pravoOrgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.pravoOrgDataGridView.DataSource = this.pravoOrgBindingSource;
            this.pravoOrgDataGridView.Location = new System.Drawing.Point(0, 12);
            this.pravoOrgDataGridView.Name = "pravoOrgDataGridView";
            this.pravoOrgDataGridView.RowTemplate.Height = 24;
            this.pravoOrgDataGridView.Size = new System.Drawing.Size(843, 299);
            this.pravoOrgDataGridView.TabIndex = 1;
            // 
            // buttonPravoAdd
            // 
            this.buttonPravoAdd.Location = new System.Drawing.Point(702, 317);
            this.buttonPravoAdd.Name = "buttonPravoAdd";
            this.buttonPravoAdd.Size = new System.Drawing.Size(148, 44);
            this.buttonPravoAdd.TabIndex = 2;
            this.buttonPravoAdd.Text = "Добавить";
            this.buttonPravoAdd.UseVisualStyleBackColor = true;
            this.buttonPravoAdd.Click += new System.EventHandler(this.buttonPravoAdd_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PravoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PravoID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PravoName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Законы, нормативно-правовые акты";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 700;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "PravoSelect";
            this.dataGridViewCheckBoxColumn1.HeaderText = "выбрать";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // FormPravoIsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 367);
            this.Controls.Add(this.buttonPravoAdd);
            this.Controls.Add(this.pravoOrgDataGridView);
            this.Name = "FormPravoIsAdd";
            this.Text = "Список всех законов в организации";
            this.Load += new System.EventHandler(this.FormPravoIsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravoOrgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravoOrgDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ISPDnBDDataSet iSPDnBDDataSet;
        private System.Windows.Forms.BindingSource pravoOrgBindingSource;
        private ISPDnBDDataSetTableAdapters.PravoOrgTableAdapter pravoOrgTableAdapter;
        private ISPDnBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pravoOrgDataGridView;
        private System.Windows.Forms.Button buttonPravoAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;


    }
}