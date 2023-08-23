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
using Word = Microsoft.Office.Interop.Word;



namespace Test_boln
{
   

    enum RowState 
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        private readonly checkUser _user;
        DataBase dataBase = new DataBase();

        int selectedRow;
        public Form1(checkUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void IsAdmin() 
        {
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
            buttonNew_entry.Enabled = _user.IsAdmin;
            button_Delete.Enabled = _user.IsAdmin;
            button_Change.Enabled = _user.IsAdmin;
            bthUpdate_Click.Enabled = _user.IsAdmin;

        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Service", "Служба");
            dataGridView1.Columns.Add("Sick", "Больничные");
            dataGridView1.Columns.Add("Coronavirus", "Коронавирус");
            dataGridView1.Columns.Add("Care", "Уход");
            dataGridView1.Columns.Add("Date", "Дата");
            dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd'.'MM'.'yyyy";
            //dataGridView1.Columns.Add("Всего больничных", "Всего больничных");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["IsNew"].Visible = false;
            //this.dataGridView1.Columns["Всего больничных"].Visible = true;
        }

        private void ClearFields() 
        {
            //textBox_ID.Text = "";
            textBox_Service.Text = "";
            textBox_Sick.Text = "";
            textBox_Coronavirus.Text = "";
            textBox_Сare.Text = "";
            textBox_Date.Text = "";
            //textBox_Total.Text = "";

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetDateTime(5), RowState.ModifiedNew);
        }
        
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Boln";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UserStatus.Text = $"{_user.Login}: {_user.Status}";
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                //textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Service.Text = row.Cells[1].Value.ToString();
                textBox_Sick.Text = row.Cells[2].Value.ToString();
                textBox_Coronavirus.Text = row.Cells[3].Value.ToString();
                textBox_Сare.Text = row.Cells[4].Value.ToString();
                textBox_Date.Text = ((DateTime)dataGridView1.CurrentRow.Cells[5].Value).ToShortDateString();
                textBox_Total.Text = row.Cells[5].Value.ToString();
                //textBox_Date.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Boln where concat (id, Service, Sick, Coronavirus, Care, Date) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            //if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            //{
            //    dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
            //    return;
            //}
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update();
        }
        private new void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {

                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Boln where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var Service = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var Sick = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var Coronavirus = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var Care = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var Date = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    

                    var changeQuery = $"update Boln set Service = '{Service}', Sick = '{Sick}', Coronavirus = '{Coronavirus}', Care = '{Care}', Date = '{Date}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.closeConnection();
        }
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            //var ID = textBox_ID.Text;
            var Service = textBox_Service.Text;
            int Sick;
            var Coronavirus = textBox_Coronavirus.Text;
            var Care = textBox_Сare.Text;
            var Date = textBox_Date.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_Sick.Text, out Sick))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(/*ID,*/ Service, Sick, Coronavirus, Care, Date);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Больничные должны иметь числовой формат!");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox_Total_TextChanged(object sender, EventArgs e)
        {

            //dataBase.openConnection();

            //for (int index = 0; index < dataGridView1.Rows.Count; index++)
            //{
            //    var Date = dataGridView1.Rows[index].Cells[5].Value.ToString();

            //var sql = $"Select SUM(Sick) AS Всего From Boln WHERE Date = '{Date}'";

            //    var command = new SqlCommand(sql, dataBase.getConnection());
            //    command.ExecuteNonQuery();

            //    textBox_Total.Text = sql["Всего"].ToString;
            //}

            //dataBase.closeConnection();


            ////устанавливаем соединение с БД
            //dataBase.openConnection();

            //var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            //var Date = dataGridView1.Rows[1].Cells[5].Value.ToString();
            //// запрос
            //string sql = "Select SUM(Sick) AS Всего From Boln WHERE Date = '20.03.2023'";
            //// объект для выполнения SQL-запроса
            //// выполняем запрос и получаем ответ
            //var command = new SqlCommand(sql, dataBase.getConnection());
            //command.ExecuteNonQuery();
            ////string total = command.ExecuteScalar().ToString();
            //// выводим ответ
            //textBox_Total.Text = sql;
            //// закрываем соединение с БД
            //dataBase.closeConnection();

            string searchString = $"Select SUM(Sick) AS Всего From Boln WHERE Date = '2023-03-20'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();
            string res = string.Empty;

            while (read.Read())
            {
                res += read["Всего"];
            }

            read.Close();
            dataBase.closeConnection();
            textBox_Total.Text = res;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            //this.dataGridView1.Columns["id"].Delete();

            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                
                int r = 1;
                for (int c = 1; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop
                //Word.Document.["id"].Delete();
                
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 1; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                //oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Больничные по отделам";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

            }
        }

        private void lab_search_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void сохранитьОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "Отчёт.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Panel Admin_Panel1 = new Admin_Panel();
            Admin_Panel1.Show();
        }

        private void textBox_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Service_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Coronavirus_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

