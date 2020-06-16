using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    class DatasetFunctions 
    {
        public SqlConnection connection;
        public SqlCommand command;
        protected SqlCommandBuilder commandBuilder { get; set; }
        public SqlDataAdapter dataAdapter;
        public DataSet dataSet { get; set; }
        protected DataTable dataTable { get; set; }

        public SqlConnection getConnection(string serverName, string databaseNames)
        {
            connection=new SqlConnection("Data Source=" + serverName + ";Initial Catalog=" + databaseNames+ ";Integrated Security=True");
            return connection;
        }
        protected SqlDataAdapter getDataAdapter(string sorgu,SqlConnection sqlConnection)
        {
            dataAdapter = new SqlDataAdapter(sorgu, sqlConnection);
            return dataAdapter;
        }
    }
}
