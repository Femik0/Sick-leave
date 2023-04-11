using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_boln
{
    public partial class Add_Form : Form
    {

        DataBase dataBase = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var SL = textBox_SL2.Text;
            var Kor = textBox_Kor2.Text;
            var Uh = textBox_Uh2.Text;
            var Date = textBox_Date2.Text;
            int Bol;

            if (int.TryParse(textBox_Bol2.Text, out Bol))
            {
                var addQuery = $"insert into Boln (Служба, Больничные, Коронавирус, Уход, Дата) values ('{SL}', '{Bol}', '{Kor}', '{Uh}', '{Date}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!!", "Ок!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Больничные должны иметь числовой формат!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataBase.closeConnection();

        }
    }
}
