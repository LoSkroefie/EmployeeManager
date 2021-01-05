using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class EmployeeQueries
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();

        public Models.EmployeeModel CreateEmployee(Models.EmployeeModel Employee)
        {
            // get database connection
            var dbCon = DBConnection;
            if (dbCon.IsConnect()) //check if connected
            {
                //set insert Query
                string query = string.Format("INSERT INTO employees (name, lastname, idnumber, address, phone, level, rate, photo) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", Employee.Name, Employee.Lastname, Employee.IDNumber, Employee.Address, Employee.Phone, Employee.Level, Employee.Rate, Employee.Photo);
                var cmd = new MySqlCommand(query, dbCon.Connection); //create mysql to be executed
                var reader = cmd.ExecuteNonQuery(); //execute query
                Employee.EmployeeId = (int)cmd.LastInsertedId; //get last inserted id
                dbCon.Close(); //close database connection
            }

            return Employee; //return employee model

        }
        public Models.EmployeeModel UpdateEmployee(Models.EmployeeModel Employee)
        {
            var dbCon = DBConnection; //get database connection
            if (dbCon.IsConnect()) //check if connected
            {
                //Set query to return employee information
                string query = string.Format("UPDATE employees set name='{0}', lastname='{1}', idnumber='{2}', address='{3}', phone='{4}', level='{5}', rate='{6}', photo='{7}' WHERE employeeid={8} and deleted=0;", Employee.Name, Employee.Lastname, Employee.IDNumber, Employee.Address, Employee.Phone, Employee.Level, Employee.Rate, Employee.Photo, Employee.EmployeeId);
                var cmd = new MySqlCommand(query, dbCon.Connection); // set mysql command to execute

                var reader = cmd.ExecuteNonQuery(); //execute query

                dbCon.Close(); //close connection
            }

            return Employee; //return employee

        }

        public Models.EmployeeModel GetEmployee(Models.EmployeeModel Employee)
        {
            var dbCon = DBConnection;// get database connection
            if (dbCon.IsConnect()) //check if database connected
            {
                //set mysql Query join employees and access table
                string query = string.Format("SELECT employees.employeeid, employees.name, employees.lastname, employees.idnumber, employees.address, employees.phone, employees.level, employees.rate, employees.photo, accesstable.username, accesstable.password, accesstable.isadmin FROM employees left JOIN accesstable on accesstable.employeeid=employees.employeeid where employees.employeeid={0} and deleted=0", Employee.EmployeeId);
                var cmd = new MySqlCommand(query, dbCon.Connection); //set mysql command
                var reader = cmd.ExecuteReader(); //execute mysql query

                while (reader.Read())//read returned reader
                { //set property values from database values
                    Employee.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    Employee.Name = reader["name"].ToString();
                    Employee.Photo = reader["photo"].ToString();
                    Employee.Lastname = reader["lastname"].ToString();
                    Employee.Fullname = reader["name"].ToString() + " " + reader["lastname"].ToString();
                    Employee.IDNumber = reader["idnumber"].ToString();
                    Employee.Address = reader["address"].ToString();
                    Employee.Phone = reader["phone"].ToString();
                    Employee.Level = int.Parse(reader["level"].ToString());
                    Employee.Rate = decimal.Parse(reader["rate"].ToString());

                    Employee.Username = reader["username"].ToString();
                    Employee.Password = reader["password"].ToString();
                    if (string.IsNullOrEmpty(reader["isadmin"].ToString())) //if admin was not set on create parsing a null cause error,
                    {
                        Employee.IsAdmin = false;
                    }
                    else
                    {
                        Employee.IsAdmin = bool.Parse(reader["isadmin"].ToString());
                    }
                }
                dbCon.Close();//close database connection
            }

            return Employee; //return employee

        }
        public Models.EmployeeModel GetEmployee(int EmployeeId)
        {
            Models.EmployeeModel Employee = new Models.EmployeeModel();

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT employees.employeeid, employees.name, employees.lastname, employees.idnumber, employees.address, employees.phone, employees.level, employees.rate, accesstable.username, accesstable.password, accesstable.isadmin FROM employees left join accesstable on accesstable.employeeid=employees.employeeid where employees.employeeid={0} and deleted=0", EmployeeId);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    Employee.Name = reader["name"].ToString();
                    Employee.Lastname = reader["lastname"].ToString();
                    Employee.Fullname = reader["name"].ToString() + " " + reader["lastname"].ToString();
                    Employee.IDNumber = reader["idnumber"].ToString();
                    Employee.Address = reader["address"].ToString();
                    Employee.Phone = reader["phone"].ToString();
                    Employee.Level = int.Parse(reader["level"].ToString());
                    Employee.Rate = decimal.Parse(reader["rate"].ToString());

                    Employee.Username = reader["username"].ToString();
                    Employee.Password = reader["password"].ToString();
                    Employee.IsAdmin = bool.Parse(reader["isadmin"].ToString());

                }
                dbCon.Close();
            }

            return Employee;

        }
        public List<Models.EmployeeModel> GetEmployees(List<Models.EmployeeModel> Employees)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT employeeid, name, lastname, idnumber, address, phone, level, rate, photo FROM employees Where deleted=0");
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Models.EmployeeModel Employee = new Models.EmployeeModel
                    {
                        EmployeeId = int.Parse(reader["employeeid"].ToString()),
                        Name = reader["name"].ToString(),
                        Photo = reader["photo"].ToString(),
                        Lastname = reader["lastname"].ToString(),
                        Fullname = reader["name"].ToString() + " " + reader["lastname"].ToString(),
                        IDNumber = reader["idnumber"].ToString(),
                        Address = reader["address"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Level = int.Parse(reader["level"].ToString()),
                        Rate = decimal.Parse(reader["rate"].ToString())
                    };

                    Employees.Add(Employee);

                }
                dbCon.Close();
            }

            return Employees;

        }
        public List<Models.EmployeeModel> GetEmployees()
        {
            List<Models.EmployeeModel> Employees = new List<Models.EmployeeModel>();
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT employeeid, name, lastname, idnumber, address, phone, level, rate, photo FROM employees Where deleted=0");
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Models.EmployeeModel Employee = new Models.EmployeeModel
                    {
                        EmployeeId = int.Parse(reader["employeeid"].ToString()),
                        Name = reader["name"].ToString(),
                        Photo = reader["photo"].ToString(),
                        Lastname = reader["lastname"].ToString(),
                        Fullname = reader["name"].ToString() + " " + reader["lastname"].ToString(),
                        IDNumber = reader["idnumber"].ToString(),
                        Address = reader["address"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Level = int.Parse(reader["level"].ToString()),
                        Rate = decimal.Parse(reader["rate"].ToString())
                    };

                    Employees.Add(Employee);

                }
                dbCon.Close();
            }

            return Employees;

        }

        public void DeleteEmployee(int id)
        {

            var dbCon = DBConnection; //get database
            if (dbCon.IsConnect()) //check if connected
            {
                //set query to mark the record as deleted. 
                string query = string.Format("UPDATE employees set deleted=1 WHERE employeeid={0};", id);
                var cmd = new MySqlCommand(query, dbCon.Connection); //set mysql command to execute
                var reader = cmd.ExecuteNonQuery();//execute command

                dbCon.Close(); //close database
            }

        }
        public EmployeeQueries()
        {

           

        }

    }
}
