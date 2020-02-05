namespace SpaseFormISPDn
{
    partial class FormConfirmIspdnAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOKconfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сейчас будет добавлена сводная информация по Обработке ПД, если информация уже су" +
                "ществует то она будет обновлена в базе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOKconfirm
            // 
            this.buttonOKconfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOKconfirm.Location = new System.Drawing.Point(143, 71);
            this.buttonOKconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOKconfirm.Name = "buttonOKconfirm";
            this.buttonOKconfirm.Size = new System.Drawing.Size(149, 36);
            this.buttonOKconfirm.TabIndex = 1;
            this.buttonOKconfirm.Text = "ОК";
            this.buttonOKconfirm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(300, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormConfirmIspdnAdd
            // 
            this.AcceptButton = this.buttonOKconfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 117);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOKconfirm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfirmIspdnAdd";
            this.Text = "Подтвердите обновление записей";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOKconfirm;
        private System.Windows.Forms.Button button1;
    }
}