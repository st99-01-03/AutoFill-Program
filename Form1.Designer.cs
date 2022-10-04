namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btFile = new System.Windows.Forms.Button();
            this.btTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFile = new System.Windows.Forms.Label();
            this.lbTemplate = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFile
            // 
            this.btFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btFile.Location = new System.Drawing.Point(18, 214);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(162, 23);
            this.btFile.TabIndex = 0;
            this.btFile.Text = "Выбрать файл";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // btTemplate
            // 
            this.btTemplate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btTemplate.Location = new System.Drawing.Point(18, 185);
            this.btTemplate.Name = "btTemplate";
            this.btTemplate.Size = new System.Drawing.Size(162, 23);
            this.btTemplate.TabIndex = 1;
            this.btTemplate.Text = "Выбрать шаблон";
            this.btTemplate.UseVisualStyleBackColor = true;
            this.btTemplate.Click += new System.EventHandler(this.btTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Состояние:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Location = new System.Drawing.Point(83, 27);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(92, 13);
            this.lbFile.TabIndex = 3;
            this.lbFile.Text = "Файл не выбран";
            // 
            // lbTemplate
            // 
            this.lbTemplate.AutoSize = true;
            this.lbTemplate.Location = new System.Drawing.Point(82, 9);
            this.lbTemplate.Name = "lbTemplate";
            this.lbTemplate.Size = new System.Drawing.Size(102, 13);
            this.lbTemplate.TabIndex = 3;
            this.lbTemplate.Text = "Шаблон не выбран";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(18, 156);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(162, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Готово";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(198, 246);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTemplate);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTemplate);
            this.Controls.Add(this.btFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "AutoFill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.Label lbTemplate;
        private System.Windows.Forms.Button btStart;
    }
}

