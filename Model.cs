using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    class Model:DatasetFunctions
    {
        Form form;
        public void NewDatabase(string serverName,string databaseName)
        {
            form = new Form();
            string connectionString = "Server = " + serverName + "; Integrated security = SSPI; database = master";
            String str = "CREATE DATABASE " + databaseName+ ";";
            try
            {   connection = new SqlConnection(connectionString);
                command = new SqlCommand(str, connection);
                connection.Open();
                command.ExecuteNonQuery();
                form.giveInformation("Created " + databaseName + " database!", "Database Created");
                connection.Close();
            }
            catch (SqlException sqlHata)
            {
                form.messageAmaHatali(sqlHata.Message, "Sql Hatası");
            }
        }

        public void Sort(string serverName,string database, string table,string script)
        {
            form = new Form();
            try
            {   connection = getConnection(serverName,database);
                connection.Open();
                Console.WriteLine("bağlantı kuruldu");
                dataAdapter = getDataAdapter(script, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, table);
                form.dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch(SqlException sql)
            {
                form.messageAmaHatali(sql.Message, "Sql Hatası");
                Console.WriteLine(sql);
            }
            catch(NullReferenceException nullEx)
            {
                form.messageAmaHatali(nullEx.Message, "Sen bana değer vermiyorsun!!");
            }
            catch(Exception eeHataYani)
            {
                form.messageAmaHatali(eeHataYani.Message, "Hata!");
            }
        }
        public void NewColumnCreate(string connectionString,string alertString)
        {
            form = new Form();
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand(alertString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception hata)
            {
                form.messageAmaHatali(hata.Message, "Error");
            }
        }

        public void Update(string server,string database,string table)
        {
            string script = "Select * from " + table;
            form = new Form();
            connection = getConnection(server, database);
            connection.Open();
            dataAdapter.Update(dataSet,table);
            command = new SqlCommand(script, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertInto(String serverName, string databaseName, string table)
        {
            form = new Form();
            try
            {
                // string createTable = "CREATE TABLE " + table + "(id int);";
                string createTable = "CREATE TABLE " + table+ "(id   TINYINT  IDENTITY(1,1) NOT NULL,PRIMARY KEY(id));" ;
                connection = getConnection(serverName,databaseName);
                connection.Open();
                SqlCommand sqlCmd = new SqlCommand(createTable, connection);
                sqlCmd.ExecuteNonQuery();
                connection.Close();
                form.giveInformation("Table and column name's id created!","");
            }
            catch (SqlException sqlHata)
            {
                form.messageAmaHatali(sqlHata.Message, "SQL Hatası");
            }
            catch (NullReferenceException)
            {
                form.messageAmaHatali("Tablo değeri girilmemiş kuzum!", "Değerim Yok Benim");
            }
            catch (Exception hata)
            {
                form.messageAmaHatali(hata.Message, "Run www.stackoverflow.com");
            }
        }
    }
}
