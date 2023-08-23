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

            var AddService = textBox_AddService.Text;
            var AddCoronavirus = textBox_AddCoronavirus.Text;
            var AddCare = textBox_AddСare.Text;
            DateTime AddDate;
            int AddSick;

            if (int.TryParse(textBox_AddSick.Text, out AddSick) && DateTime.TryParse(textBox_AddDate.Text, out AddDate))
            {
                var addQuery = $"insert into Boln (Service, Sick, Coronavirus, Care, Date) values ('{AddService}', '{AddSick}', '{AddCoronavirus}', '{AddCare}', '{AddDate}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!!", "Ок!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Больничные должны иметь числовой формат, дата должна иметь формат вида: 22.22.22 !!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataBase.closeConnection();

        }
    }
}
