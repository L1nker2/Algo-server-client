using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace Server
{
    public class SqlWork
    {
        public string StringSqlConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\AlgoritmikaDB.mdf;Integrated Security=True;Connect Timeout=30";
        public static void CreateTable(string StringSqlConn, string GruopName)
        {
            SqlConnection Con = new SqlConnection(StringSqlConn); // создание подключения
            string sqlCommand = "Create table " + GruopName +
                                "(" +
                                "st_id int identity(0,1) primary key," +
                                "st_Name nvarchar(max) not null," +
                                "st_SecName nvarchar(max) not null," +
                                "st_Login nvarchar(max) not null," +
                                "st_Pass nvarchar(max) not null" +
                                ")";
            //команда для создания таблицы
            SqlCommand Command = new SqlCommand(sqlCommand, Con); //создание команды
            Con.Open(); //открытие подключения
            Command.ExecuteNonQuery(); //выполнение запроса
            MessageBox.Show("Группа создана!"); //успешное создание таблицы
            Con.Close(); //закрытие подключения
        }
        public static void InsertDataToTable(string StringSqlConn, string GropuName, string st_Name, string st_SecName, string st_Login, string st_Pass)
        {
            SqlConnection Con = new SqlConnection(StringSqlConn);
            string sqlCommand = $"INSERT INTO {GropuName} (st_Name, st_SecName, st_Login, st_Pass) values (N'{st_Name}', N'{st_SecName}', N'{st_Login}', N'{st_Pass}')";
            SqlCommand Command = new SqlCommand(sqlCommand, Con);
            Con.Open();
            Command.ExecuteNonQuery();
            MessageBox.Show("Данные внесены!");
            Con.Close();
        }
        public static void DeleteTable(string StringSqlConn, string GroupName)
        {
            SqlConnection Con = new SqlConnection(StringSqlConn);
            string sqlCommand = "DROP TABLE " + GroupName;
            SqlCommand Command = new SqlCommand(sqlCommand, Con);
            Con.Open();
            Command.ExecuteNonQuery();
            MessageBox.Show("Группа удалена!");
            Con.Close();
        }
        public static string GetTableDataAsJson(string connectionString, string tableName)
        {
            string query = string.Format("select * from {0}", tableName);
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            string json = JsonConvert.SerializeObject(dataTable, Formatting.None);
            return json;
        }
        public static string Data(string StringSqlConn)
        {
            string str = null;
            SqlConnection connection = new SqlConnection(StringSqlConn);
            connection.Open();
            string[] restrictions = new string[4];
            restrictions[3] = "BASE TABLE";
            var tables = connection.GetSchema("Tables", restrictions);
            foreach (System.Data.DataRow row in tables.Rows)
            {
                str +=row["TABLE_NAME"].ToString() + ';';
            }
            connection.Close();
            return str;
        }
        public static void DeleteRow(string StringSqlConn, string GroupName, string st_id)
        {
            SqlConnection Con = new SqlConnection(StringSqlConn);
            string SQLcommand = "DELETE FROM " + GroupName + " WHERE st_id = " + st_id;
            SqlCommand sqlCommand = new SqlCommand(SQLcommand, Con);
            Con.Open();
            sqlCommand.ExecuteNonQuery();
            Con.Close();
        }
    }
}