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
    public partial class Form : UserControl
    {

        public Form()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommandBuilder command;
        SqlDataAdapter dataAdapter;
        DatasetFunctions functions;
     
        public string server()
        {
            return serverNameTxt.Text;
        }
        public string table()
        {
            return tableNameTxt.Text;
        }

        public string database()
        {
            return databaseTxt.Text;
        }
       
        Model model = new Model();
        string scriptText;
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
        void selectFrom()
        {
            try
            {
                scriptText = "Select * from " + tableNameTxt.Text;
                model.Sort(server(),database(),table(),scriptText);
                dataGridView1.DataSource = model.dataSet.Tables[0];
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Veritabanı gösterilemiyor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enterButon_Click(object sender, EventArgs e)
        {
            selectFrom();
            string[] row = { server(), database(), table() };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }

        public DialogResult messageAmaHatali(string mesaj,string baslik)
        {
            return MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
             //   dataGridView1.SelectAll();
                model.Update(server(),database(),table());
            }
            catch (Exception sqlError)
            {
                MessageBox.Show(sqlError.Message, "SQL Güncellenirken Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
        
        public DialogResult giveInformation(String mes, String title)
        {
           return MessageBox.Show(mes, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newDatabaseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                model.NewDatabase(serverNameTxt.Text, databaseTxt.Text);
            }
            catch (NullReferenceException nullReferance)
            {
                messageAmaHatali(nullReferance.Message, "Null Referance");
            }
            catch(Exception error)
            {
                messageAmaHatali(error.Message, "Exception");
            }
        }

        private void newColumnLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string typelist = typeListComboBox.SelectedItem.ToString();
                string connectionString = "Data Source=" + serverNameTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=True";
                string createNewColumnString = "ALTER TABLE " + tableNameTxt.Text + " ADD " + columnNameTxt.Text + " " + typelist + ";";
                model.NewColumnCreate(connectionString,createNewColumnString);
            }
            catch(NullReferenceException nullEx)
            {
                messageAmaHatali(nullEx.Message, "Null");
            }
            catch (Exception hata)
            {
                messageAmaHatali(hata.Message, "Hata");
            }
        }

        private void newTableLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            model.InsertInto(server(), database(), table());
        }

        private void Form_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Server Name", 150);
            listView1.Columns.Add("Database Name", 150);
            listView1.Columns.Add("Tables Name", 150);
        }
    }
}
