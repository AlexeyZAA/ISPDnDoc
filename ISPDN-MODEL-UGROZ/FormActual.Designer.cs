namespace SpaseFormISPDn
{
    partial class FormActualUgroz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualUgroz));
            this.comboBoxActualIS = new System.Windows.Forms.ComboBox();
            this.iSPDnOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.iSPDnOperatorTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter();
            this.nazvanieUgrozBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazvanieUgrozTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.NazvanieUgrozTableAdapter();
            this.tableAdapterManager = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.TableAdapterManager();
            this.nazvanieUgrozDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonActual = new System.Windows.Forms.Button();
            this.mnogieUgrozaActualTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieUgrozaActualTableAdapter();
            this.mnogieRealizUgrozTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieRealizUgrozTableAdapter();
            this.mnogieOpasnUgrozISTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.MnogieOpasnUgrozISTableAdapter();
            this.ZagActualUgrozList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxActualIS
            // 
            this.comboBoxActualIS.DataSource = this.iSPDnOperatorBindingSource;
            this.comboBoxActualIS.DisplayMember = "ISPDnOperatorName";
            this.comboBoxActualIS.FormattingEnabled = true;
            this.comboBoxActualIS.Location = new System.Drawing.Point(3, 61);
            this.comboBoxActualIS.Name = "comboBoxActualIS";
            this.comboBoxActualIS.Size = new System.Drawing.Size(731, 21);
            this.comboBoxActualIS.TabIndex = 0;
            this.comboBoxActualIS.ValueMember = "ISPDnOperatorName";
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
            // nazvanieUgrozBindingSource
            // 
            this.nazvanieUgrozBindingSource.DataMember = "NazvanieUgroz";
            this.nazvanieUgrozBindingSource.DataSource = this.iSPDnBDDataSet;
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
            this.tableAdapterManager.ISPDnOperatorTableAdapter = this.iSPDnOperatorTableAdapter;
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
            // nazvanieUgrozDataGridView
            // 
            this.nazvanieUgrozDataGridView.AutoGenerateColumns = false;
            this.nazvanieUgrozDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nazvanieUgrozDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.nazvanieUgrozDataGridView.DataSource = this.nazvanieUgrozBindingSource;
            this.nazvanieUgrozDataGridView.Location = new System.Drawing.Point(3, 88);
            this.nazvanieUgrozDataGridView.Name = "nazvanieUgrozDataGridView";
            this.nazvanieUgrozDataGridView.Size = new System.Drawing.Size(731, 256);
            this.nazvanieUgrozDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NazvanieUgrozID";
            this.dataGridViewTextBoxColumn1.HeaderText = "NazvanieUgrozID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazvanieUgrozName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название актуальных угроз";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 688;
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
            this.dataGridViewCheckBoxColumn1.HeaderText = "1";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "2";
            this.dataGridViewCheckBoxColumn2.HeaderText = "2";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "3";
            this.dataGridViewCheckBoxColumn3.HeaderText = "3";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "4";
            this.dataGridViewCheckBoxColumn4.HeaderText = "4";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // buttonActual
            // 
            this.buttonActual.Location = new System.Drawing.Point(601, 350);
            this.buttonActual.Name = "buttonActual";
            this.buttonActual.Size = new System.Drawing.Size(133, 28);
            this.buttonActual.TabIndex = 2;
            this.buttonActual.Text = "Показать актуальные";
            this.buttonActual.UseVisualStyleBackColor = true;
            this.buttonActual.Click += new System.EventHandler(this.buttonActual_Click);
            // 
            // mnogieUgrozaActualTableAdapter
            // 
            this.mnogieUgrozaActualTableAdapter.ClearBeforeFill = true;
            // 
            // mnogieRealizUgrozTableAdapter
            // 
            this.mnogieRealizUgrozTableAdapter.ClearBeforeFill = true;
            // 
            // mnogieOpasnUgrozISTableAdapter
            // 
            this.mnogieOpasnUgrozISTableAdapter.ClearBeforeFill = true;
            // 
            // ZagActualUgrozList
            // 
            this.ZagActualUgrozList.Location = new System.Drawing.Point(3, 27);
            this.ZagActualUgrozList.Name = "ZagActualUgrozList";
            this.ZagActualUgrozList.Size = new System.Drawing.Size(722, 23);
            this.ZagActualUgrozList.TabIndex = 3;
            this.ZagActualUgrozList.Text = "В данном списке отображается перечень актуальных угроз для текущей информационной" +
                " системы";
            this.ZagActualUgrozList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormActualUgroz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 384);
            this.Controls.Add(this.ZagActualUgrozList);
            this.Controls.Add(this.buttonActual);
            this.Controls.Add(this.nazvanieUgrozDataGridView);
            this.Controls.Add(this.comboBoxActualIS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormActualUgroz";
            this.Text = "Форма определения Актуальности";
            this.Load += new System.EventHandler(this.FormActualUgroz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieUgrozDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxActualIS;
        private ISPDnBDDataSet iSPDnBDDataSet;
        private System.Windows.Forms.BindingSource iSPDnOperatorBindingSource;
        private ISPDnBDDataSetTableAdapters.ISPDnOperatorTableAdapter iSPDnOperatorTableAdapter;
        private System.Windows.Forms.BindingSource nazvanieUgrozBindingSource;
        private ISPDnBDDataSetTableAdapters.NazvanieUgrozTableAdapter nazvanieUgrozTableAdapter;
        private ISPDnBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nazvanieUgrozDataGridView;
        private System.Windows.Forms.Button buttonActual;
        private ISPDnBDDataSetTableAdapters.MnogieUgrozaActualTableAdapter mnogieUgrozaActualTableAdapter;
        private ISPDnBDDataSetTableAdapters.MnogieRealizUgrozTableAdapter mnogieRealizUgrozTableAdapter;
        private ISPDnBDDataSetTableAdapters.MnogieOpasnUgrozISTableAdapter mnogieOpasnUgrozISTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.Label ZagActualUgrozList;
    }
}