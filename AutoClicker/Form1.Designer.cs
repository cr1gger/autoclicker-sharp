namespace AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.coordsXtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coordsYtextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelDelayError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coordsXtextBox
            // 
            this.coordsXtextBox.Location = new System.Drawing.Point(258, 19);
            this.coordsXtextBox.Name = "coordsXtextBox";
            this.coordsXtextBox.ReadOnly = true;
            this.coordsXtextBox.Size = new System.Drawing.Size(100, 20);
            this.coordsXtextBox.TabIndex = 2;
            this.coordsXtextBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDelayError);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.delayTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.coordsYtextBox);
            this.groupBox1.Controls.Add(this.coordsXtextBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Задержка между кликами в миллисекундах: ";
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(258, 72);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(100, 20);
            this.delayTextBox.TabIndex = 6;
            this.delayTextBox.Text = "1000";
            this.delayTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Координата Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Координата X:";
            // 
            // coordsYtextBox
            // 
            this.coordsYtextBox.Location = new System.Drawing.Point(258, 45);
            this.coordsYtextBox.Name = "coordsYtextBox";
            this.coordsYtextBox.ReadOnly = true;
            this.coordsYtextBox.Size = new System.Drawing.Size(100, 20);
            this.coordsYtextBox.TabIndex = 3;
            this.coordsYtextBox.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(23, 166);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(358, 137);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // labelDelayError
            // 
            this.labelDelayError.AutoSize = true;
            this.labelDelayError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelDelayError.Location = new System.Drawing.Point(258, 99);
            this.labelDelayError.Name = "labelDelayError";
            this.labelDelayError.Size = new System.Drawing.Size(0, 13);
            this.labelDelayError.TabIndex = 8;
            this.labelDelayError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 369);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Автокликер по координатам";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox coordsXtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coordsYtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delayTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelDelayError;
    }
}

