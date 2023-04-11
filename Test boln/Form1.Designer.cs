namespace Test_boln
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bthUpdate_Click = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_Uh = new System.Windows.Forms.TextBox();
            this.textBox_SL = new System.Windows.Forms.TextBox();
            this.textBox_Kor = new System.Windows.Forms.TextBox();
            this.textBox_Bol = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.lab_search = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bthUpdate_Click);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(478, 248);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 136);
            this.panel1.TabIndex = 0;
            // 
            // bthUpdate_Click
            // 
            this.bthUpdate_Click.Location = new System.Drawing.Point(19, 100);
            this.bthUpdate_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bthUpdate_Click.Name = "bthUpdate_Click";
            this.bthUpdate_Click.Size = new System.Drawing.Size(118, 28);
            this.bthUpdate_Click.TabIndex = 3;
            this.bthUpdate_Click.Text = "Сохранить";
            this.bthUpdate_Click.UseVisualStyleBackColor = true;
            this.bthUpdate_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 67);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Новая запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_Date);
            this.panel2.Controls.Add(this.textBox_Uh);
            this.panel2.Controls.Add(this.textBox_SL);
            this.panel2.Controls.Add(this.textBox_Kor);
            this.panel2.Controls.Add(this.textBox_Bol);
            this.panel2.Controls.Add(this.textBox_ID);
            this.panel2.Location = new System.Drawing.Point(9, 228);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 156);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(34, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Уход:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Коронавирус:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Больничный:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Служба:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(151, 126);
            this.textBox_Date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(224, 20);
            this.textBox_Date.TabIndex = 5;
            // 
            // textBox_Uh
            // 
            this.textBox_Uh.Location = new System.Drawing.Point(151, 103);
            this.textBox_Uh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Uh.Name = "textBox_Uh";
            this.textBox_Uh.Size = new System.Drawing.Size(224, 20);
            this.textBox_Uh.TabIndex = 4;
            // 
            // textBox_SL
            // 
            this.textBox_SL.Location = new System.Drawing.Point(151, 35);
            this.textBox_SL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_SL.Name = "textBox_SL";
            this.textBox_SL.Size = new System.Drawing.Size(224, 20);
            this.textBox_SL.TabIndex = 3;
            // 
            // textBox_Kor
            // 
            this.textBox_Kor.Location = new System.Drawing.Point(151, 80);
            this.textBox_Kor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Kor.Name = "textBox_Kor";
            this.textBox_Kor.Size = new System.Drawing.Size(224, 20);
            this.textBox_Kor.TabIndex = 2;
            // 
            // textBox_Bol
            // 
            this.textBox_Bol.Location = new System.Drawing.Point(151, 58);
            this.textBox_Bol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Bol.Name = "textBox_Bol";
            this.textBox_Bol.Size = new System.Drawing.Size(224, 20);
            this.textBox_Bol.TabIndex = 1;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(151, 12);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(224, 20);
            this.textBox_ID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 171);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(480, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Управление записями";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(543, 33);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(71, 32);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(160, 11);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(363, 20);
            this.textBox_search.TabIndex = 13;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_search.Location = new System.Drawing.Point(94, 10);
            this.lab_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(65, 22);
            this.lab_search.TabIndex = 14;
            this.lab_search.Text = "Поиск";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(543, 71);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 32);
            this.button4.TabIndex = 15;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 410);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lab_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bthUpdate_Click;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_Uh;
        private System.Windows.Forms.TextBox textBox_SL;
        private System.Windows.Forms.TextBox textBox_Kor;
        private System.Windows.Forms.TextBox textBox_Bol;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label lab_search;
        private System.Windows.Forms.Button button4;
    }
}

