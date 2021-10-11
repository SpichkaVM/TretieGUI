
namespace TretieGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.outStr = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дано предложение. Определить, сколько в нем \r\nодинаковых соседних букв. Пробелы н" +
    "е учитывать. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите предложение: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Определить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outStr
            // 
            this.outStr.AutoSize = true;
            this.outStr.Location = new System.Drawing.Point(11, 111);
            this.outStr.Name = "outStr";
            this.outStr.Size = new System.Drawing.Size(58, 17);
            this.outStr.TabIndex = 3;
            this.outStr.Text = "Вывод: ";
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(181, 72);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(165, 22);
            this.txtStr.TabIndex = 4;
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(179, 276);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(165, 49);
            this.txtClear.TabIndex = 5;
            this.txtClear.Text = "Очистить";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 337);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.outStr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lab_Str";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outStr;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Button txtClear;
    }
}

