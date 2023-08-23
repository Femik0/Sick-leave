namespace Test_boln
{
    partial class Add_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_AddDate = new System.Windows.Forms.TextBox();
            this.textBox_AddСare = new System.Windows.Forms.TextBox();
            this.textBox_AddService = new System.Windows.Forms.TextBox();
            this.textBox_AddCoronavirus = new System.Windows.Forms.TextBox();
            this.textBox_AddSick = new System.Windows.Forms.TextBox();
            this.label_AddDate = new System.Windows.Forms.Label();
            this.label_AddCare = new System.Windows.Forms.Label();
            this.label_AddCoronavirus = new System.Windows.Forms.Label();
            this.label_AddSick = new System.Windows.Forms.Label();
            this.label_AddService = new System.Windows.Forms.Label();
            this.Add_Save = new System.Windows.Forms.Button();
            this.labelCreate_entry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_AddDate
            // 
            this.textBox_AddDate.Location = new System.Drawing.Point(252, 270);
            this.textBox_AddDate.Name = "textBox_AddDate";
            this.textBox_AddDate.Size = new System.Drawing.Size(297, 22);
            this.textBox_AddDate.TabIndex = 10;
            // 
            // textBox_AddСare
            // 
            this.textBox_AddСare.Location = new System.Drawing.Point(252, 242);
            this.textBox_AddСare.Name = "textBox_AddСare";
            this.textBox_AddСare.Size = new System.Drawing.Size(297, 22);
            this.textBox_AddСare.TabIndex = 9;
            // 
            // textBox_AddService
            // 
            this.textBox_AddService.Location = new System.Drawing.Point(252, 158);
            this.textBox_AddService.Name = "textBox_AddService";
            this.textBox_AddService.Size = new System.Drawing.Size(297, 22);
            this.textBox_AddService.TabIndex = 8;
            // 
            // textBox_AddCoronavirus
            // 
            this.textBox_AddCoronavirus.Location = new System.Drawing.Point(252, 214);
            this.textBox_AddCoronavirus.Name = "textBox_AddCoronavirus";
            this.textBox_AddCoronavirus.Size = new System.Drawing.Size(297, 22);
            this.textBox_AddCoronavirus.TabIndex = 7;
            // 
            // textBox_AddSick
            // 
            this.textBox_AddSick.Location = new System.Drawing.Point(252, 186);
            this.textBox_AddSick.Name = "textBox_AddSick";
            this.textBox_AddSick.Size = new System.Drawing.Size(297, 22);
            this.textBox_AddSick.TabIndex = 6;
            // 
            // label_AddDate
            // 
            this.label_AddDate.AutoSize = true;
            this.label_AddDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AddDate.Location = new System.Drawing.Point(85, 270);
            this.label_AddDate.Name = "label_AddDate";
            this.label_AddDate.Size = new System.Drawing.Size(56, 22);
            this.label_AddDate.TabIndex = 16;
            this.label_AddDate.Text = "Дата:";
            // 
            // label_AddCare
            // 
            this.label_AddCare.AutoSize = true;
            this.label_AddCare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AddCare.Location = new System.Drawing.Point(85, 242);
            this.label_AddCare.Name = "label_AddCare";
            this.label_AddCare.Size = new System.Drawing.Size(55, 22);
            this.label_AddCare.TabIndex = 15;
            this.label_AddCare.Text = "Уход:";
            // 
            // label_AddCoronavirus
            // 
            this.label_AddCoronavirus.AutoSize = true;
            this.label_AddCoronavirus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AddCoronavirus.Location = new System.Drawing.Point(85, 214);
            this.label_AddCoronavirus.Name = "label_AddCoronavirus";
            this.label_AddCoronavirus.Size = new System.Drawing.Size(126, 22);
            this.label_AddCoronavirus.TabIndex = 14;
            this.label_AddCoronavirus.Text = "Коронавирус:";
            // 
            // label_AddSick
            // 
            this.label_AddSick.AutoSize = true;
            this.label_AddSick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AddSick.Location = new System.Drawing.Point(85, 186);
            this.label_AddSick.Name = "label_AddSick";
            this.label_AddSick.Size = new System.Drawing.Size(123, 22);
            this.label_AddSick.TabIndex = 13;
            this.label_AddSick.Text = "Больничный:";
            // 
            // label_AddService
            // 
            this.label_AddService.AutoSize = true;
            this.label_AddService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AddService.Location = new System.Drawing.Point(85, 158);
            this.label_AddService.Name = "label_AddService";
            this.label_AddService.Size = new System.Drawing.Size(81, 22);
            this.label_AddService.TabIndex = 12;
            this.label_AddService.Text = "Служба:";
            // 
            // Add_Save
            // 
            this.Add_Save.Location = new System.Drawing.Point(361, 359);
            this.Add_Save.Name = "Add_Save";
            this.Add_Save.Size = new System.Drawing.Size(141, 48);
            this.Add_Save.TabIndex = 17;
            this.Add_Save.Text = "Сохранить";
            this.Add_Save.UseVisualStyleBackColor = true;
            this.Add_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // labelCreate_entry
            // 
            this.labelCreate_entry.AutoSize = true;
            this.labelCreate_entry.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreate_entry.Location = new System.Drawing.Point(83, 73);
            this.labelCreate_entry.Name = "labelCreate_entry";
            this.labelCreate_entry.Size = new System.Drawing.Size(223, 32);
            this.labelCreate_entry.TabIndex = 18;
            this.labelCreate_entry.Text = "Создание записи";
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 497);
            this.Controls.Add(this.labelCreate_entry);
            this.Controls.Add(this.Add_Save);
            this.Controls.Add(this.label_AddDate);
            this.Controls.Add(this.label_AddCare);
            this.Controls.Add(this.label_AddCoronavirus);
            this.Controls.Add(this.label_AddSick);
            this.Controls.Add(this.label_AddService);
            this.Controls.Add(this.textBox_AddDate);
            this.Controls.Add(this.textBox_AddСare);
            this.Controls.Add(this.textBox_AddService);
            this.Controls.Add(this.textBox_AddCoronavirus);
            this.Controls.Add(this.textBox_AddSick);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AddDate;
        private System.Windows.Forms.TextBox textBox_AddСare;
        private System.Windows.Forms.TextBox textBox_AddService;
        private System.Windows.Forms.TextBox textBox_AddCoronavirus;
        private System.Windows.Forms.TextBox textBox_AddSick;
        private System.Windows.Forms.Label label_AddDate;
        private System.Windows.Forms.Label label_AddCare;
        private System.Windows.Forms.Label label_AddCoronavirus;
        private System.Windows.Forms.Label label_AddSick;
        private System.Windows.Forms.Label label_AddService;
        private System.Windows.Forms.Button Add_Save;
        private System.Windows.Forms.Label labelCreate_entry;
    }
}