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
            this.CmbChekCity = new System.Windows.Forms.ComboBox();
            this.BtnPogoda = new System.Windows.Forms.Button();
            this.LbStatus = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RtbxPogoda = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // CmbChekCity
            // 
            this.CmbChekCity.FormattingEnabled = true;
            this.CmbChekCity.Items.AddRange(new object[] {
            "Москва",
            "Париж",
            "Осло",
            "Берлин"});
            this.CmbChekCity.Location = new System.Drawing.Point(364, 193);
            this.CmbChekCity.Name = "CmbChekCity";
            this.CmbChekCity.Size = new System.Drawing.Size(121, 21);
            this.CmbChekCity.TabIndex = 3;
            this.CmbChekCity.SelectedIndexChanged += new System.EventHandler(this.CmbChekCity_SelectedIndexChanged);
            // 
            // BtnPogoda
            // 
            this.BtnPogoda.Location = new System.Drawing.Point(12, 175);
            this.BtnPogoda.Name = "BtnPogoda";
            this.BtnPogoda.Size = new System.Drawing.Size(124, 54);
            this.BtnPogoda.TabIndex = 4;
            this.BtnPogoda.Text = "Получить данные о погоде";
            this.BtnPogoda.UseVisualStyleBackColor = true;
            this.BtnPogoda.Click += new System.EventHandler(this.BtnPogoda_Click);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // RtbxPogoda
            // 
            this.RtbxPogoda.Location = new System.Drawing.Point(12, 240);
            this.RtbxPogoda.Name = "RtbxPogoda";
            this.RtbxPogoda.Size = new System.Drawing.Size(318, 143);
            this.RtbxPogoda.TabIndex = 9;
            this.RtbxPogoda.Text = "";
            this.RtbxPogoda.TextChanged += new System.EventHandler(this.RtbxPogoda_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 118);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.RtbxPogoda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.BtnPogoda);
            this.Controls.Add(this.CmbChekCity);
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
        private System.Windows.Forms.ComboBox CmbChekCity;
        private System.Windows.Forms.Button BtnPogoda;
        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox RtbxPogoda;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

