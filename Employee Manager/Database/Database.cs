using System;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class DatabaseConnection
    {
        public DatabaseConnection()
        {
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DatabaseConnection _instance = null;
        public static DatabaseConnection Instance()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            try
            {
                if (Connection == null)
                {
                    string connstring = "Server=154.0.168.249; database=jvrsovfj_area51; UID=jvrsovfj_root; password=J@nn137812225034082; Connection Timeout=120";
                    connection = new MySqlConnection(connstring);

                    connection.Open();


                }

                return true;
            } catch 
            {
                return false;

            }



            
        }

        public void Close()
        {
            connection.Close();
        }


    }
}
