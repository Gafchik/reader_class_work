namespace fuck_reader
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
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(70, 12);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 43);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Открыть это дерьмо";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(271, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 43);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Сохранить это дерьмо";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(166, 382);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(75, 56);
            this.btn_color.TabIndex = 2;
            this.btn_color.Text = "Выбрать цвет этому дерьму";
            this.btn_color.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 262);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.Text = "Читать эти дерьмовые файлы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.TextBox textBox1;
    }
}

