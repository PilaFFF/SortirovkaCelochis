
namespace SortingApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.txtSortedArray = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(560, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArray
            // 
            this.txtArray.BackColor = System.Drawing.SystemColors.Info;
            this.txtArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtArray.Location = new System.Drawing.Point(5, 115);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(301, 52);
            this.txtArray.TabIndex = 1;
            this.txtArray.TextChanged += new System.EventHandler(this.txtArray_TextChanged);
            // 
            // txtSortedArray
            // 
            this.txtSortedArray.BackColor = System.Drawing.SystemColors.Info;
            this.txtSortedArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSortedArray.Location = new System.Drawing.Point(6, 263);
            this.txtSortedArray.Multiline = true;
            this.txtSortedArray.Name = "txtSortedArray";
            this.txtSortedArray.Size = new System.Drawing.Size(301, 51);
            this.txtSortedArray.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTime.Location = new System.Drawing.Point(317, 288);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 26);
            this.lblTime.TabIndex = 8;
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "\"Пузырьком\"",
            "\"Вставками\"",
            "\"Метод Шейкера\"",
            "\"Метод Шелла\""});
            this.cmbSort.Location = new System.Drawing.Point(312, 115);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(199, 32);
            this.cmbSort.TabIndex = 9;
            this.cmbSort.Text = "Метод сортировки:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(560, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ввод:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(3, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Вывод:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(313, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Таймер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.label4.Location = new System.Drawing.Point(219, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сортировка массива";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtSortedArray);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Сортировка целочисленного массива";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.TextBox txtSortedArray;
        private System.Windows.Forms.TextBox lblTime;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

