using System;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class AccessQueries
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();


        public Models.AccessModel getLoginData(Models.AccessModel access)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = string.Format("SELECT username, password, employeeid, isadmin FROM accesstable where username='{0}' and password='{1}'", access.Username, access.Password);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return access;
                }

                while (reader.Read())
                {

                    access.Username = reader["username"].ToString();
                    access.Password = reader["password"].ToString();
                    access.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    access.IsAdmin = bool.Parse(reader["isadmin"].ToString());
                    access.LoggedIn = true;
                }
                dbCon.Close();
            }

            return access;

        }

        public Models.AccessModel VerifyTokenData(Models.AccessModel token, string verifyUsername, string verifyToken)
        {
            if (string.IsNullOrEmpty(verifyToken) || string.IsNullOrEmpty(verifyUsername))
            {
                token.LoggedIn = false;
                return token;
            }
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = string.Format("SELECT username, password, employeeid, isadmin, accesstoken FROM accesstable where username='{0}' and accesstoken='{1}'", token.Username, token.LoginToken);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    token.LoggedIn = false;
                    return token;
                }

                while (reader.Read())
                {

                    token.Username = reader["username"].ToString();
                    token.LoginToken = reader["accesstoken"].ToString();
                    token.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    token.IsAdmin = bool.Parse(reader["isadmin"].ToString());
                    token.LoggedIn = true;
                }
                dbCon.Close();
            }


          
            if (verifyUsername != token.Username) { token.LoggedIn = false; return token; }
            if (verifyToken != token.LoginToken) { token.LoggedIn = false; return token; }

            return token;

        }
        public void CreateUser(Models.AccessModel access)
        {
            var dbCon = DBConnection; //get database
            if (dbCon.IsConnect()) //check if connected
            {
                //set the query to add the new user to the accesstable
                string query = string.Format("INSERT INTO accesstable (username, password, employeeid, isadmin) VALUES('{0}', '{1}', {2}, {3});", access.Username, access.Password, access.EmployeeId,access.IsAdmin);
                var cmd = new MySqlCommand(query, dbCon.Connection); //set mysqll command to be executed.
                var reader = cmd.ExecuteNonQuery(); //execute the query

                dbCon.Close(); //close the database
            }
        }

     
        public void UpdateUser(Models.AccessModel access)
        {

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("UPDATE accesstable set username='{0}', password='{1}', employeeid={2}, isadmin={3} where employeeid={2};", access.Username, access.Password, access.EmployeeId, access.IsAdmin);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

        

        }

        public void UpdateToken(Models.AccessModel access)
        {

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("UPDATE accesstable set accesstoken='{0}' where employeeid={1};", access.LoginToken, access.EmployeeId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }



        }



        public AccessQueries()
        {

           

        }

    }
}
