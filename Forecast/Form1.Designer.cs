namespace Forecast
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbChekDate = new System.Windows.Forms.ComboBox();
            this.CmbChekCity = new System.Windows.Forms.ComboBox();
            this.BtnPogoda = new System.Windows.Forms.Button();
            this.TbxPogoda = new System.Windows.Forms.TextBox();
            this.LbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать дату";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбрать город";
            // 
            // CmbChekDate
            // 
            this.CmbChekDate.FormattingEnabled = true;
            this.CmbChekDate.Location = new System.Drawing.Point(667, 193);
            this.CmbChekDate.Name = "CmbChekDate";
            this.CmbChekDate.Size = new System.Drawing.Size(121, 21);
            this.CmbChekDate.TabIndex = 2;
            // 
            // CmbChekCity
            // 
            this.CmbChekCity.FormattingEnabled = true;
            this.CmbChekCity.Location = new System.Drawing.Point(364, 193);
            this.CmbChekCity.Name = "CmbChekCity";
            this.CmbChekCity.Size = new System.Drawing.Size(121, 21);
            this.CmbChekCity.TabIndex = 3;
            // 
            // BtnPogoda
            // 
            this.BtnPogoda.Location = new System.Drawing.Point(12, 175);
            this.BtnPogoda.Name = "BtnPogoda";
            this.BtnPogoda.Size = new System.Drawing.Size(124, 54);
            this.BtnPogoda.TabIndex = 4;
            this.BtnPogoda.Text = "Получить данные о погоде";
            this.BtnPogoda.UseVisualStyleBackColor = true;
            // 
            // TbxPogoda
            // 
            this.TbxPogoda.Location = new System.Drawing.Point(13, 236);
            this.TbxPogoda.Multiline = true;
            this.TbxPogoda.Name = "TbxPogoda";
            this.TbxPogoda.Size = new System.Drawing.Size(216, 123);
            this.TbxPogoda.TabIndex = 5;
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.Location = new System.Drawing.Point(235, 236);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(16, 22);
            this.LbStatus.TabIndex = 6;
            this.LbStatus.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.TbxPogoda);
            this.Controls.Add(this.BtnPogoda);
            this.Controls.Add(this.CmbChekCity);
            this.Controls.Add(this.CmbChekDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbChekDate;
        private System.Windows.Forms.ComboBox CmbChekCity;
        private System.Windows.Forms.Button BtnPogoda;
        private System.Windows.Forms.TextBox TbxPogoda;
        private System.Windows.Forms.Label LbStatus;
    }
}

