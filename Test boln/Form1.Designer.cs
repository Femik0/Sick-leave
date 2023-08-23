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
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.buttonNew_entry = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Сare = new System.Windows.Forms.Label();
            this.label_Coronavirus = new System.Windows.Forms.Label();
            this.label_Sick = new System.Windows.Forms.Label();
            this.label_Service = new System.Windows.Forms.Label();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_Сare = new System.Windows.Forms.TextBox();
            this.textBox_Service = new System.Windows.Forms.TextBox();
            this.textBox_Coronavirus = new System.Windows.Forms.TextBox();
            this.textBox_Sick = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Upr_zapis = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.lab_search = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserStatus = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bthUpdate_Click);
            this.panel1.Controls.Add(this.button_Change);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.buttonNew_entry);
            this.panel1.Location = new System.Drawing.Point(637, 348);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 173);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bthUpdate_Click
            // 
            this.bthUpdate_Click.Location = new System.Drawing.Point(25, 123);
            this.bthUpdate_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bthUpdate_Click.Name = "bthUpdate_Click";
            this.bthUpdate_Click.Size = new System.Drawing.Size(157, 34);
            this.bthUpdate_Click.TabIndex = 3;
            this.bthUpdate_Click.Text = "Сохранить";
            this.bthUpdate_Click.UseVisualStyleBackColor = true;
            this.bthUpdate_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(25, 82);
            this.button_Change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(157, 34);
            this.button_Change.TabIndex = 2;
            this.button_Change.Text = "Изменить";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(25, 43);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(157, 34);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonNew_entry
            // 
            this.buttonNew_entry.Location = new System.Drawing.Point(25, 2);
            this.buttonNew_entry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNew_entry.Name = "buttonNew_entry";
            this.buttonNew_entry.Size = new System.Drawing.Size(157, 34);
            this.buttonNew_entry.TabIndex = 0;
            this.buttonNew_entry.Text = "Новая запись";
            this.buttonNew_entry.UseVisualStyleBackColor = true;
            this.buttonNew_entry.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label_Total);
            this.panel2.Controls.Add(this.textBox_Total);
            this.panel2.Controls.Add(this.label_Date);
            this.panel2.Controls.Add(this.label_Сare);
            this.panel2.Controls.Add(this.label_Coronavirus);
            this.panel2.Controls.Add(this.label_Sick);
            this.panel2.Controls.Add(this.label_Service);
            this.panel2.Controls.Add(this.textBox_Date);
            this.panel2.Controls.Add(this.textBox_Сare);
            this.panel2.Controls.Add(this.textBox_Service);
            this.panel2.Controls.Add(this.textBox_Coronavirus);
            this.panel2.Controls.Add(this.textBox_Sick);
            this.panel2.Location = new System.Drawing.Point(12, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 217);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Total.Location = new System.Drawing.Point(45, 181);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(65, 22);
            this.label_Total.TabIndex = 13;
            this.label_Total.Text = "Всего:";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(201, 181);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(297, 22);
            this.textBox_Total.TabIndex = 12;
            this.textBox_Total.TextChanged += new System.EventHandler(this.textBox_Total_TextChanged);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Date.Location = new System.Drawing.Point(45, 155);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(56, 22);
            this.label_Date.TabIndex = 11;
            this.label_Date.Text = "Дата:";
            // 
            // label_Сare
            // 
            this.label_Сare.AutoSize = true;
            this.label_Сare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Сare.Location = new System.Drawing.Point(45, 127);
            this.label_Сare.Name = "label_Сare";
            this.label_Сare.Size = new System.Drawing.Size(55, 22);
            this.label_Сare.TabIndex = 10;
            this.label_Сare.Text = "Уход:";
            // 
            // label_Coronavirus
            // 
            this.label_Coronavirus.AutoSize = true;
            this.label_Coronavirus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Coronavirus.Location = new System.Drawing.Point(45, 98);
            this.label_Coronavirus.Name = "label_Coronavirus";
            this.label_Coronavirus.Size = new System.Drawing.Size(126, 22);
            this.label_Coronavirus.TabIndex = 9;
            this.label_Coronavirus.Text = "Коронавирус:";
            // 
            // label_Sick
            // 
            this.label_Sick.AutoSize = true;
            this.label_Sick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sick.Location = new System.Drawing.Point(45, 71);
            this.label_Sick.Name = "label_Sick";
            this.label_Sick.Size = new System.Drawing.Size(123, 22);
            this.label_Sick.TabIndex = 8;
            this.label_Sick.Text = "Больничный:";
            // 
            // label_Service
            // 
            this.label_Service.AutoSize = true;
            this.label_Service.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Service.Location = new System.Drawing.Point(45, 43);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(81, 22);
            this.label_Service.TabIndex = 7;
            this.label_Service.Text = "Служба:";
            this.label_Service.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(201, 155);
            this.textBox_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(297, 22);
            this.textBox_Date.TabIndex = 5;
            this.textBox_Date.TextChanged += new System.EventHandler(this.textBox_Date_TextChanged);
            // 
            // textBox_Сare
            // 
            this.textBox_Сare.Location = new System.Drawing.Point(201, 127);
            this.textBox_Сare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Сare.Name = "textBox_Сare";
            this.textBox_Сare.Size = new System.Drawing.Size(297, 22);
            this.textBox_Сare.TabIndex = 4;
            // 
            // textBox_Service
            // 
            this.textBox_Service.Location = new System.Drawing.Point(201, 43);
            this.textBox_Service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Service.Name = "textBox_Service";
            this.textBox_Service.Size = new System.Drawing.Size(297, 22);
            this.textBox_Service.TabIndex = 3;
            this.textBox_Service.TextChanged += new System.EventHandler(this.textBox_Service_TextChanged);
            // 
            // textBox_Coronavirus
            // 
            this.textBox_Coronavirus.Location = new System.Drawing.Point(201, 98);
            this.textBox_Coronavirus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Coronavirus.Name = "textBox_Coronavirus";
            this.textBox_Coronavirus.Size = new System.Drawing.Size(297, 22);
            this.textBox_Coronavirus.TabIndex = 2;
            this.textBox_Coronavirus.TextChanged += new System.EventHandler(this.textBox_Coronavirus_TextChanged);
            // 
            // textBox_Sick
            // 
            this.textBox_Sick.Location = new System.Drawing.Point(201, 71);
            this.textBox_Sick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Sick.Name = "textBox_Sick";
            this.textBox_Sick.Size = new System.Drawing.Size(297, 22);
            this.textBox_Sick.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 224);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Upr_zapis
            // 
            this.Upr_zapis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Upr_zapis.AutoSize = true;
            this.Upr_zapis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upr_zapis.Location = new System.Drawing.Point(640, 305);
            this.Upr_zapis.Name = "Upr_zapis";
            this.Upr_zapis.Size = new System.Drawing.Size(197, 22);
            this.Upr_zapis.TabIndex = 5;
            this.Upr_zapis.Text = "Управление записями";
            this.Upr_zapis.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(661, 47);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(85, 30);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(172, 51);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(483, 22);
            this.textBox_search.TabIndex = 13;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_search.Location = new System.Drawing.Point(84, 47);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(82, 26);
            this.lab_search.TabIndex = 14;
            this.lab_search.Text = "Поиск";
            this.lab_search.Click += new System.EventHandler(this.lab_search_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(756, 47);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 30);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem,
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьОтчётToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьОтчётToolStripMenuItem
            // 
            this.сохранитьОтчётToolStripMenuItem.Name = "сохранитьОтчётToolStripMenuItem";
            this.сохранитьОтчётToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.сохранитьОтчётToolStripMenuItem.Text = "Сохранить отчёт";
            this.сохранитьОтчётToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОтчётToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.управлениеToolStripMenuItem.Text = "Управление";
            this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
            // 
            // UserStatus
            // 
            this.UserStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserStatus.Location = new System.Drawing.Point(622, 6);
            this.UserStatus.Name = "UserStatus";
            this.UserStatus.Size = new System.Drawing.Size(219, 22);
            this.UserStatus.TabIndex = 19;
            this.UserStatus.TextChanged += new System.EventHandler(this.UserStatus_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.UserStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.lab_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.Upr_zapis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bthUpdate_Click;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button buttonNew_entry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Upr_zapis;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Сare;
        private System.Windows.Forms.Label label_Coronavirus;
        private System.Windows.Forms.Label label_Sick;
        private System.Windows.Forms.Label label_Service;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_Сare;
        private System.Windows.Forms.TextBox textBox_Service;
        private System.Windows.Forms.TextBox textBox_Coronavirus;
        private System.Windows.Forms.TextBox textBox_Sick;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label lab_search;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.TextBox UserStatus;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОтчётToolStripMenuItem;
    }
}

