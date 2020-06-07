using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database
{
    public partial class Form: UserControl
    {

        public Form()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommandBuilder command;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        private void ThereAreTable_Load(object sender, EventArgs e)
        {
          
        }

        void temelSql(string sqlScripts)
        {
            
            string connectionString = "Data Source=" + serverNameTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("bağlantı kuruldu");
                SqlCommand command = new SqlCommand(sqlScripts, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
            catch (SqlException sqlHatasi)
            {
                MessageBox.Show("SQL Server kaynaklı : " + sqlHatasi.Message + "oluştu", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enterButon_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=" + serverNameTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=True");
            connection.Open();
            MessageBox.Show("bağlantı ok");
            try
            {
                dataAdapter = new SqlDataAdapter("Select * from " + tableNameTxt.Text, connection);
                command = new SqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, tableNameTxt.Text);
                dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Veritabanı gösterilemiyor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(dataSet, tableNameTxt.Text);
                MessageBox.Show("update ok");
            }
            catch (Exception sqlError)
            {
                MessageBox.Show(sqlError.Message, "SQL Güncellenirken Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string createTable = "CREATE TABLE " + tableNameTxt.Text + "(id int);";
                connection = new SqlConnection("Data Source=" + serverNameTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=True");
                connection.Open();
                MessageBox.Show("bağlantı ok");
                SqlCommand sqlCmd = new SqlCommand(createTable, connection);
                sqlCmd.ExecuteNonQuery();
                connection.Close();
            }
            catch(SqlException sqlHata)
            {
                MessageBox.Show(sqlHata.Message, "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Tablo değeri girilmemiş kuzum!", "Değerim Yok Benim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Run www.stackoverflow.com", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Seçim yapmadın Neo!","Sorun bende değil sende!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Kaldıramayacağım yük loaded");
            }
        }
        

        private void databaseInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Server = " + serverNameTxt.Text + "; Integrated security = SSPI; database = master");
                String str = "CREATE DATABASE " + databaseTxt.Text + ";";

                SqlCommand sqlCmd = new SqlCommand(str, connection);
                connection.Open();
                MessageBox.Show("bağlantı ok");
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Database created!");
                connection.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Beceremedim Ağbi!", MessageBoxButtons.OK); ;
            }
        }

        private void newColumn_Click(object sender, EventArgs e)
        {
            try
            {
                string createNewColumn = "ALTER TABLE " + tableNameTxt.Text + " ADD " + columnNameTxt.Text + " " + typeTxt.Text + ";";
                connection = new SqlConnection("Data Source=" + serverNameTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=True");
                connection.Open();
                MessageBox.Show("bağlantı ok");
                SqlCommand sqlCmd = new SqlCommand(createNewColumn, connection);
                sqlCmd.ExecuteNonQuery();
                connection.Close();
            }
            catch(SqlException sql)
            {
                MessageBox.Show(sql.Message + "Yapamadım Yeni Değer Ekleyecek gücüm kalmadı","SQL GG");
            }
        }
    }
}
