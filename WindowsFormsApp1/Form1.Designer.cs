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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.F = new System.Windows.Forms.CheckBox();
            this.K = new System.Windows.Forms.CheckBox();
            this.C1 = new System.Windows.Forms.CheckBox();
            this.K1 = new System.Windows.Forms.CheckBox();
            this.F1 = new System.Windows.Forms.CheckBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(430, 33);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(33, 17);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.CheckedChanged += new System.EventHandler(this.C_CheckedChanged);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(430, 77);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(32, 17);
            this.F.TabIndex = 4;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.CheckedChanged += new System.EventHandler(this.F_CheckedChanged);
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Location = new System.Drawing.Point(430, 56);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(33, 17);
            this.K.TabIndex = 5;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            this.K.CheckedChanged += new System.EventHandler(this.K_CheckedChanged);
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Location = new System.Drawing.Point(430, 192);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(33, 17);
            this.C1.TabIndex = 6;
            this.C1.Text = "C";
            this.C1.UseVisualStyleBackColor = true;
            this.C1.CheckedChanged += new System.EventHandler(this.C1_CheckedChanged);
            // 
            // K1
            // 
            this.K1.AutoSize = true;
            this.K1.Location = new System.Drawing.Point(430, 215);
            this.K1.Name = "K1";
            this.K1.Size = new System.Drawing.Size(33, 17);
            this.K1.TabIndex = 7;
            this.K1.Text = "K";
            this.K1.UseVisualStyleBackColor = true;
            this.K1.CheckedChanged += new System.EventHandler(this.K1_CheckedChanged);
            // 
            // F1
            // 
            this.F1.AutoSize = true;
            this.F1.Location = new System.Drawing.Point(430, 238);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(32, 17);
            this.F1.TabIndex = 8;
            this.F1.Text = "F";
            this.F1.UseVisualStyleBackColor = true;
            this.F1.CheckedChanged += new System.EventHandler(this.F1_CheckedChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(58, 235);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 9;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 425);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.K1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.K);
            this.Controls.Add(this.F);
            this.Controls.Add(this.C);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.CheckBox F;
        private System.Windows.Forms.CheckBox K;
        private System.Windows.Forms.CheckBox C1;
        private System.Windows.Forms.CheckBox K1;
        private System.Windows.Forms.CheckBox F1;
        private System.Windows.Forms.TextBox Result;
    }
}

