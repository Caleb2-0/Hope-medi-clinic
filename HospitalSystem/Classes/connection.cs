using MySql.Data.MySqlClient;
namespace HospitalSystem.Classes
{
    internal class connection
    {
        MySqlConnection connect = new MySqlConnection("datasource = 127.0.0.1; port= 3306; username=root; password=; database= hope_medi_clinic");
        public MySqlConnection GetSqlConnection
        {
            get
            {
                return connect;
            }
        }
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
