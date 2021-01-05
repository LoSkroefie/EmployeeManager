using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class TaskQueries
    {
        private Database.DatabaseConnection DBConnection = new Database.DatabaseConnection();

        public Models.TaskModel CreateTask(Models.TaskModel Task)
        {
            
            var dbCon = DBConnection; //get database
            if (dbCon.IsConnect()) //check if connected
            {
                //set query to execute
                string query = string.Format("INSERT INTO tasks (title, description, status, startdate, datecompleted, datecreated,completed,deleted) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}',0,0);", Task.Title, Task.Description, Task.Status, Task.StartDate, Task.DateCompleted,Task.DateCreated);

                var cmd = new MySqlCommand(query, dbCon.Connection); //set mysql command to execute

                var reader = cmd.ExecuteNonQuery(); //execute command

                dbCon.Close(); //clsoe database
            }

            return Task; //return task model

        }
        public Models.TaskModel UpdateTask(Models.TaskModel Task)
        {
            var dbCon = DBConnection; //get database
            if (dbCon.IsConnect()) //check if connected
            {
                //set query to update the task
                string query = string.Format("UPDATE tasks set title='{0}', description='{1}', status='{2}', startdate='{3}', datecompleted='{4}', datecreated='{5}' WHERE Taskid={6} and deleted=0;", Task.Title, Task.Description, Task.Status, Task.StartDate, Task.DateCompleted, Task.DateCreated, Task.TaskId);

                var cmd = new MySqlCommand(query, dbCon.Connection); //create mysql command


                var reader = cmd.ExecuteNonQuery(); //execute query

                dbCon.Close(); //database close
            }

            return Task; //return view

        }

        public void UpdateTaskComplete(Models.TaskModel Task)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("UPDATE tasks set datecompleted='{0}', completed={1} WHERE Taskid={2};", Task.DateCompleted, Task.Completed, Task.TaskId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

          

        }
        public Models.TaskModel GetTask(Models.TaskModel Task)
        {
            var dbCon = DBConnection; //get database connection
            if (dbCon.IsConnect()) //check if connected
            {
                // set mysql query
                string query = string.Format("SELECT taskid, title, description, status, startdate, datecompleted, datecreated FROM tasks where Taskid={0} and deleted=0", Task.TaskId);
                var cmd = new MySqlCommand(query, dbCon.Connection); //set mysql command 
                var reader = cmd.ExecuteReader(); //execute mysql command

                while (reader.Read()) //loop through reader and set model properties with database values
                {
                    Task.TaskId = int.Parse(reader["taskid"].ToString());
                    Task.Title = reader["title"].ToString();
                    Task.Description = reader["description"].ToString();
                    Task.Status =  reader["status"].ToString();
                    Task.StartDate = DateTime.Parse(reader["startdate"].ToString());
                    Task.DateCompleted = DateTime.Parse(reader["datecompleted"].ToString());
                    Task.DateCreated = DateTime.Parse(reader["datecreated"].ToString());

                }
                dbCon.Close(); //close connection
            }

            return Task; // Return Task

        }
        public Models.TaskModel GetTask(int TaskId)
        {
            Models.TaskModel Task = new Models.TaskModel();

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT taskid, title, description, status, startdate, datecompleted, datecreated FROM tasks where Taskid={0} and deleted=0", TaskId);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Task.TaskId = int.Parse(reader["taskid"].ToString());
                    Task.Title = reader["title"].ToString();
                    Task.Description = reader["description"].ToString();
                    Task.Status = reader["status"].ToString();
                    Task.StartDate = DateTime.Parse(reader["startdate"].ToString());
                    Task.DateCompleted = DateTime.Parse(reader["datecompleted"].ToString());
                    Task.DateCreated = DateTime.Parse(reader["datecreated"].ToString());

                }
                dbCon.Close();
            }

            return Task;

        }
        public List<Models.TaskModel> GetTasks(List<Models.TaskModel> Tasks)
        {
           

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT taskid, title, description, status, startdate, datecompleted, datecreated FROM tasks Where deleted=0");
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Models.TaskModel Task = new Models.TaskModel();

                    Task.TaskId = int.Parse(reader["taskid"].ToString());
                    Task.Title = reader["title"].ToString();
                    Task.Description = reader["description"].ToString();
                    Task.Status = reader["status"].ToString();

              
                        Task.StartDate = DateTime.Parse(reader["startdate"].ToString());
               
                        Task.DateCompleted = DateTime.Parse(reader["datecompleted"].ToString());
                 
                    Task.DateCreated = DateTime.Parse(reader["datecreated"].ToString());
                    

                    Tasks.Add(Task);
                }
                dbCon.Close();
            }

            return Tasks;

        }
        public List<Models.TaskModel> GetTasks()
        {
            List<Models.TaskModel> Tasks = new List<Models.TaskModel>();

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT taskid, title, description, status, startdate, datecompleted, datecreated FROM tasks WHERE deleted=0");
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Models.TaskModel Task = new Models.TaskModel();

                    Task.TaskId = int.Parse(reader["taskid"].ToString());
                    Task.Title = reader["title"].ToString();
                    Task.Description = reader["description"].ToString();
                    Task.Status = reader["status"].ToString();


                    Task.StartDate = DateTime.Parse(reader["startdate"].ToString());

                    Task.DateCompleted = DateTime.Parse(reader["datecompleted"].ToString());

                    Task.DateCreated = DateTime.Parse(reader["datecreated"].ToString());


                    Tasks.Add(Task);
                }
                dbCon.Close();
            }

            return Tasks;

        }

        public void DeleteTask(int id)
        {

            var dbCon = DBConnection; //get database connection
            if (dbCon.IsConnect()) //check if database connected
            {
                //set query to mark record as deleted.
                string query = string.Format("UPDATE tasks set deleted=1 WHERE taskid={0};", id);

                var cmd = new MySqlCommand(query, dbCon.Connection); //set mysql command
                var reader = cmd.ExecuteNonQuery();//execute query

                dbCon.Close(); //close database connection
            }

        }

        public void CompleteTask(int id)
        {

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = string.Format("UPDATE tasks set completed=1 WHERE taskid={0};", id);



                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }



        }
        public TaskQueries()
        {

           

        }

    }
}
