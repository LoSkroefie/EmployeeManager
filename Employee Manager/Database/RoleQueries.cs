using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class RoleQueries
    {
        private Database.DatabaseConnection DBConnection = new Database.DatabaseConnection();

        public Models.RoleModel CreateRole(Models.RoleModel Role)
        {
            
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("INSERT INTO roles (description, rate) VALUES('{0}', '{1}');", Role.Description, Role.Rate);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

            return Role;

        }
        public Models.RoleModel UpdateRole(Models.RoleModel Role)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("UPDATE roles set description='{0}', rate='{1}' WHERE roleid={2};", Role.Description, Role.Rate, Role.RoleId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

            return Role;

        }

        public decimal GetRoleRate(int Id)
        {
            decimal returnValue = decimal.Parse("0,00"); //set default value to return value to avoid null

            var dbCon = DBConnection; // get database connection
            if (dbCon.IsConnect()) // check if db is connected
            {
                //set query to return role rates for a specific role.
                string query = string.Format("SELECT rate FROM roles where roleid={0}", Id);
                var cmd = new MySqlCommand(query, dbCon.Connection);//create mydwl command
                var reader = cmd.ExecuteReader(); //execute command

                while (reader.Read()) //read data reader
                {
                    returnValue = decimal.Parse(reader["rate"].ToString()); //set value of return value
                
                }
                dbCon.Close(); //close database
            }

            return returnValue; //return value

        }
        public Models.RoleModel GetRole(Models.RoleModel Role)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT roleid, description, rate FROM roles where roleid={0}", Role.RoleId);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Role.RoleId = int.Parse(reader["roleid"].ToString());
                    Role.Description = reader["description"].ToString();
                    Role.Rate = decimal.Parse(reader["rate"].ToString());
                  
                }
                dbCon.Close();
            }

            return Role;

        }
        public List<Models.RoleModel> GetRoles(List<Models.RoleModel> Roles)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT roleid, description, rate FROM roles");
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Models.RoleModel Role = new Models.RoleModel
                    {
                        RoleId = int.Parse(reader["roleid"].ToString()),
                        Description = reader["description"].ToString(),
                        Rate = decimal.Parse(reader["rate"].ToString())
                    };

                    Roles.Add(Role);

                }
                dbCon.Close();
            }

            return Roles;

        }

        public List<Models.RoleModel> GetRoles()
        {
            List<Models.RoleModel> Roles = new List<Models.RoleModel>(); //create a role Model list to return
            var dbCon = DBConnection; // get database connection
            if (dbCon.IsConnect()) //check if connected.
            {
                //Set the Query
                string query = string.Format("SELECT roleid, description, rate FROM roles"); 
                //Create the Mysql command to be executed.
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader(); //execute the query

                while (reader.Read()) // read the returned reader.
                {
                    //create a new role model to add to the list to be returned
                    Models.RoleModel Role = new Models.RoleModel 
                    {
                        RoleId = int.Parse(reader["roleid"].ToString()), //Set the Role ID from db to Model property
                        Description = reader["description"].ToString(), //Set the Description from db to Model property
                        Rate = decimal.Parse(reader["rate"].ToString()) //Set the rate from db to Model property
                    };

                    Roles.Add(Role); //add role model to the list to return

                }
                dbCon.Close(); //close the database
            }

            return Roles; //return the list of roles.

        }

        public void DeleteRole(int id)
        {

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("DELETE FROM roles WHERE roleid={0};", id);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }



        }

        public RoleQueries()
        {

           

        }

    }
}
