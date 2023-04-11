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
            this.textBox_Date2 = new System.Windows.Forms.TextBox();
            this.textBox_Uh2 = new System.Windows.Forms.TextBox();
            this.textBox_SL2 = new System.Windows.Forms.TextBox();
            this.textBox_Kor2 = new System.Windows.Forms.TextBox();
            this.textBox_Bol2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Date2
            // 
            this.textBox_Date2.Location = new System.Drawing.Point(252, 270);
            this.textBox_Date2.Name = "textBox_Date2";
            this.textBox_Date2.Size = new System.Drawing.Size(297, 22);
            this.textBox_Date2.TabIndex = 10;
            // 
            // textBox_Uh2
            // 
            this.textBox_Uh2.Location = new System.Drawing.Point(252, 242);
            this.textBox_Uh2.Name = "textBox_Uh2";
            this.textBox_Uh2.Size = new System.Drawing.Size(297, 22);
            this.textBox_Uh2.TabIndex = 9;
            // 
            // textBox_SL2
            // 
            this.textBox_SL2.Location = new System.Drawing.Point(252, 158);
            this.textBox_SL2.Name = "textBox_SL2";
            this.textBox_SL2.Size = new System.Drawing.Size(297, 22);
            this.textBox_SL2.TabIndex = 8;
            // 
            // textBox_Kor2
            // 
            this.textBox_Kor2.Location = new System.Drawing.Point(252, 214);
            this.textBox_Kor2.Name = "textBox_Kor2";
            this.textBox_Kor2.Size = new System.Drawing.Size(297, 22);
            this.textBox_Kor2.TabIndex = 7;
            // 
            // textBox_Bol2
            // 
            this.textBox_Bol2.Location = new System.Drawing.Point(252, 186);
            this.textBox_Bol2.Name = "textBox_Bol2";
            this.textBox_Bol2.Size = new System.Drawing.Size(297, 22);
            this.textBox_Bol2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(85, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(85, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Уход:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(85, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Коронавирус:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Больничный:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(85, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Служба:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(361, 359);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(141, 48);
            this.Save.TabIndex = 17;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Создание записи";
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Date2);
            this.Controls.Add(this.textBox_Uh2);
            this.Controls.Add(this.textBox_SL2);
            this.Controls.Add(this.textBox_Kor2);
            this.Controls.Add(this.textBox_Bol2);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Date2;
        private System.Windows.Forms.TextBox textBox_Uh2;
        private System.Windows.Forms.TextBox textBox_SL2;
        private System.Windows.Forms.TextBox textBox_Kor2;
        private System.Windows.Forms.TextBox textBox_Bol2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
    }
}