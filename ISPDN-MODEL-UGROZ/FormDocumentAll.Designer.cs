namespace SpaseFormISPDn
{
    partial class FormDocumentAll
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
            this.checkBoxGuchetProverok = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxGrazovPropusk = new System.Windows.Forms.CheckBox();
            this.checkBoxGUchetaT = new System.Windows.Forms.CheckBox();
            this.buttonCreateAllDoc = new System.Windows.Forms.Button();
            this.buttonOtmena = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxGuchetProverok
            // 
            this.checkBoxGuchetProverok.Location = new System.Drawing.Point(20, 15);
            this.checkBoxGuchetProverok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxGuchetProverok.Name = "checkBoxGuchetProverok";
            this.checkBoxGuchetProverok.Size = new System.Drawing.Size(201, 20);
            this.checkBoxGuchetProverok.TabIndex = 0;
            this.checkBoxGuchetProverok.Text = "Журнал учета проверок(книжный)";
            this.checkBoxGuchetProverok.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBoxGrazovPropusk);
            this.panel1.Controls.Add(this.checkBoxGUchetaT);
            this.panel1.Controls.Add(this.checkBoxGuchetProverok);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 279);
            this.panel1.TabIndex = 1;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(225, 247);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(296, 20);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Журнал учета проверок";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(225, 223);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(296, 20);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Журнал учета проверок";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(225, 199);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(296, 20);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Журнал учета проверок";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrazovPropusk
            // 
            this.checkBoxGrazovPropusk.Location = new System.Drawing.Point(20, 40);
            this.checkBoxGrazovPropusk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxGrazovPropusk.Name = "checkBoxGrazovPropusk";
            this.checkBoxGrazovPropusk.Size = new System.Drawing.Size(296, 20);
            this.checkBoxGrazovPropusk.TabIndex = 2;
            this.checkBoxGrazovPropusk.Text = "Журнал разового пропуска на территорию";
            this.checkBoxGrazovPropusk.UseVisualStyleBackColor = true;
            // 
            // checkBoxGUchetaT
            // 
            this.checkBoxGUchetaT.Location = new System.Drawing.Point(225, 15);
            this.checkBoxGUchetaT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxGUchetaT.Name = "checkBoxGUchetaT";
            this.checkBoxGUchetaT.Size = new System.Drawing.Size(296, 20);
            this.checkBoxGUchetaT.TabIndex = 1;
            this.checkBoxGUchetaT.Text = "Журнал учета проверок(табличный)";
            this.checkBoxGUchetaT.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAllDoc
            // 
            this.buttonCreateAllDoc.Location = new System.Drawing.Point(591, 305);
            this.buttonCreateAllDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateAllDoc.Name = "buttonCreateAllDoc";
            this.buttonCreateAllDoc.Size = new System.Drawing.Size(117, 28);
            this.buttonCreateAllDoc.TabIndex = 2;
            this.buttonCreateAllDoc.Text = "Создать документы";
            this.buttonCreateAllDoc.UseVisualStyleBackColor = true;
            this.buttonCreateAllDoc.Click += new System.EventHandler(this.buttonCreateAllDoc_Click);
            // 
            // buttonOtmena
            // 
            this.buttonOtmena.Location = new System.Drawing.Point(443, 305);
            this.buttonOtmena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtmena.Name = "buttonOtmena";
            this.buttonOtmena.Size = new System.Drawing.Size(117, 28);
            this.buttonOtmena.TabIndex = 3;
            this.buttonOtmena.Text = "Отмена";
            this.buttonOtmena.UseVisualStyleBackColor = true;
            this.buttonOtmena.Click += new System.EventHandler(this.buttonOtmena_Click);
            // 
            // FormDocumentAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(728, 339);
            this.Controls.Add(this.buttonOtmena);
            this.Controls.Add(this.buttonCreateAllDoc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDocumentAll";
            this.Text = "Документы формирующиеся на основе сводной информации";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxGuchetProverok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxGrazovPropusk;
        private System.Windows.Forms.CheckBox checkBoxGUchetaT;
        private System.Windows.Forms.Button buttonCreateAllDoc;
        private System.Windows.Forms.Button buttonOtmena;
    }
}