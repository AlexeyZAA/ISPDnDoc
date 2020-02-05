namespace SpaseFormISPDn
{
    partial class FormOrganizationAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrganizationAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.textOrgKratkNameOrgAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textOrgNameOrgAdd = new System.Windows.Forms.TextBox();
            this.buttonOrgAdd = new System.Windows.Forms.Button();
            this.textInnOrgAdd = new System.Windows.Forms.TextBox();
            this.labelInnOrg = new System.Windows.Forms.Label();
            this.labelFIORukovoditOrg = new System.Windows.Forms.Label();
            this.textRukOrgAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDolgnRukOrgAdd = new System.Windows.Forms.TextBox();
            this.orgOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSPDnBDDataSet = new SpaseFormISPDn.ISPDnBDDataSet();
            this.selectOrgToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.orgOperatorTableAdapter = new SpaseFormISPDn.ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter();
            this.HelpHarakteristik = new System.Windows.Forms.Label();
            this.textBoxAdressOrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Краткое наименование организации:";
            // 
            // textOrgKratkNameOrgAdd
            // 
            this.textOrgKratkNameOrgAdd.Location = new System.Drawing.Point(276, 49);
            this.textOrgKratkNameOrgAdd.Multiline = true;
            this.textOrgKratkNameOrgAdd.Name = "textOrgKratkNameOrgAdd";
            this.textOrgKratkNameOrgAdd.Size = new System.Drawing.Size(416, 44);
            this.textOrgKratkNameOrgAdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Полное наименование организации:";
            // 
            // textOrgNameOrgAdd
            // 
            this.textOrgNameOrgAdd.Location = new System.Drawing.Point(276, 99);
            this.textOrgNameOrgAdd.Multiline = true;
            this.textOrgNameOrgAdd.Name = "textOrgNameOrgAdd";
            this.textOrgNameOrgAdd.Size = new System.Drawing.Size(416, 44);
            this.textOrgNameOrgAdd.TabIndex = 3;
            // 
            // buttonOrgAdd
            // 
            this.buttonOrgAdd.Location = new System.Drawing.Point(568, 358);
            this.buttonOrgAdd.Name = "buttonOrgAdd";
            this.buttonOrgAdd.Size = new System.Drawing.Size(124, 33);
            this.buttonOrgAdd.TabIndex = 5;
            this.buttonOrgAdd.Text = "Зафиксировать";
            this.buttonOrgAdd.UseVisualStyleBackColor = true;
            this.buttonOrgAdd.Click += new System.EventHandler(this.buttonOrgAdd_Click);
            // 
            // textInnOrgAdd
            // 
            this.textInnOrgAdd.Location = new System.Drawing.Point(276, 198);
            this.textInnOrgAdd.MaxLength = 13;
            this.textInnOrgAdd.Name = "textInnOrgAdd";
            this.textInnOrgAdd.Size = new System.Drawing.Size(181, 20);
            this.textInnOrgAdd.TabIndex = 6;
            this.textInnOrgAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInnOrgAdd_KeyPress);
            // 
            // labelInnOrg
            // 
            this.labelInnOrg.AutoSize = true;
            this.labelInnOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInnOrg.Location = new System.Drawing.Point(12, 202);
            this.labelInnOrg.Name = "labelInnOrg";
            this.labelInnOrg.Size = new System.Drawing.Size(118, 13);
            this.labelInnOrg.TabIndex = 7;
            this.labelInnOrg.Text = "ИНН организации:";
            // 
            // labelFIORukovoditOrg
            // 
            this.labelFIORukovoditOrg.AutoSize = true;
            this.labelFIORukovoditOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIORukovoditOrg.Location = new System.Drawing.Point(12, 295);
            this.labelFIORukovoditOrg.Name = "labelFIORukovoditOrg";
            this.labelFIORukovoditOrg.Size = new System.Drawing.Size(207, 13);
            this.labelFIORukovoditOrg.TabIndex = 8;
            this.labelFIORukovoditOrg.Text = "ФИО руководиетля организации:";
            // 
            // textRukOrgAdd
            // 
            this.textRukOrgAdd.Location = new System.Drawing.Point(276, 291);
            this.textRukOrgAdd.Name = "textRukOrgAdd";
            this.textRukOrgAdd.Size = new System.Drawing.Size(416, 20);
            this.textRukOrgAdd.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Должность руководителя организации:";
            // 
            // textDolgnRukOrgAdd
            // 
            this.textDolgnRukOrgAdd.Location = new System.Drawing.Point(276, 326);
            this.textDolgnRukOrgAdd.Name = "textDolgnRukOrgAdd";
            this.textDolgnRukOrgAdd.Size = new System.Drawing.Size(416, 20);
            this.textDolgnRukOrgAdd.TabIndex = 11;
            // 
            // orgOperatorBindingSource
            // 
            this.orgOperatorBindingSource.DataMember = "OrgOperator";
            this.orgOperatorBindingSource.DataSource = this.iSPDnBDDataSet;
            // 
            // iSPDnBDDataSet
            // 
            this.iSPDnBDDataSet.DataSetName = "ISPDnBDDataSet";
            this.iSPDnBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectOrgToolStripButton
            // 
            this.selectOrgToolStripButton.Name = "selectOrgToolStripButton";
            this.selectOrgToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // orgOperatorTableAdapter
            // 
            this.orgOperatorTableAdapter.ClearBeforeFill = true;
            // 
            // HelpHarakteristik
            // 
            this.HelpHarakteristik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelpHarakteristik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpHarakteristik.Location = new System.Drawing.Point(5, 9);
            this.HelpHarakteristik.Name = "HelpHarakteristik";
            this.HelpHarakteristik.Size = new System.Drawing.Size(687, 37);
            this.HelpHarakteristik.TabIndex = 16;
            this.HelpHarakteristik.Text = "Этап 1:  на этом этаме вносятся данные по организации для дальнейшего использован" +
                "ия в разрабатываемых документах";
            // 
            // textBoxAdressOrg
            // 
            this.textBoxAdressOrg.Location = new System.Drawing.Point(276, 148);
            this.textBoxAdressOrg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdressOrg.Multiline = true;
            this.textBoxAdressOrg.Name = "textBoxAdressOrg";
            this.textBoxAdressOrg.Size = new System.Drawing.Size(416, 45);
            this.textBoxAdressOrg.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Адрес организации:";
            // 
            // FormOrganizationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAdressOrg);
            this.Controls.Add(this.HelpHarakteristik);
            this.Controls.Add(this.textDolgnRukOrgAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRukOrgAdd);
            this.Controls.Add(this.labelFIORukovoditOrg);
            this.Controls.Add(this.labelInnOrg);
            this.Controls.Add(this.textInnOrgAdd);
            this.Controls.Add(this.buttonOrgAdd);
            this.Controls.Add(this.textOrgNameOrgAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOrgKratkNameOrgAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrganizationAdd";
            this.Text = "Ввод параметров организации";
            this.Load += new System.EventHandler(this.FormOrganizationAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSPDnBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOrgAdd;
        private System.Windows.Forms.Label labelInnOrg;
        private System.Windows.Forms.Label labelFIORukovoditOrg;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textInnOrgAdd;
        private System.Windows.Forms.ToolStripButton selectOrgToolStripButton;
        private System.Windows.Forms.Label HelpHarakteristik;
        public System.Windows.Forms.TextBox textOrgKratkNameOrgAdd;
        public System.Windows.Forms.TextBox textOrgNameOrgAdd;
        public System.Windows.Forms.TextBox textRukOrgAdd;
        public System.Windows.Forms.TextBox textDolgnRukOrgAdd;
        public ISPDnBDDataSet iSPDnBDDataSet;
        public System.Windows.Forms.BindingSource orgOperatorBindingSource;
        public ISPDnBDDataSetTableAdapters.OrgOperatorTableAdapter orgOperatorTableAdapter;
        private System.Windows.Forms.TextBox textBoxAdressOrg;
        private System.Windows.Forms.Label label4;
       
    }
}