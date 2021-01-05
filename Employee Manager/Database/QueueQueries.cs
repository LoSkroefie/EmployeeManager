using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class QueueQueries
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();

        public Models.QueueModel CreateQueue(Models.QueueModel Queue)
        {
            
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("INSERT INTO queue (employeeid, taskid) VALUES('{0}', '{1}');", Queue.EmployeeId, Queue.TaskId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

            return Queue;

        }
        public Models.QueueModel UpdateQueue(Models.QueueModel Queue)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("UPDATE queue set employeeid='{0}', taskid='{1}' WHERE queueid={2};", Queue.EmployeeId, Queue.TaskId, Queue.QueueId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

            return Queue;

        }
        public void UpdateQueueComplete(int QueueId)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("UPDATE queue set completed=1 WHERE queueid={0};", QueueId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

      

        }

        public decimal GetQueueRate(int Id)
        {
            decimal returnValue = decimal.Parse("0,00");

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT rate FROM queue where Queueid={0}", Id);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    returnValue = decimal.Parse(reader["rate"].ToString());
                
                }
                dbCon.Close();
            }

            return returnValue;

        }
        public Models.QueueModel GetQueue(Models.QueueModel Queue)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                
                string query = string.Format("SELECT queueid, employeeid, taskid FROM queue where queueid={0}", Queue.QueueId);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                EmployeeQueries EmployeeQuery = new EmployeeQueries();
                TaskQueries TaskQuery = new TaskQueries();
                while (reader.Read())
                {
                    Queue.QueueId = int.Parse(reader["Queueid"].ToString());
                    Queue.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    Queue.TaskId = int.Parse(reader["taskid"].ToString());
                    Queue.Employee = EmployeeQuery.GetEmployee(Queue.EmployeeId);
                    Queue.Task = TaskQuery.GetTask(Queue.TaskId);

                }
                dbCon.Close();
            }

            return Queue;

        }
        public Models.QueueModel GetQueue(int id)
        {
            Models.QueueModel Queue = new Models.QueueModel();
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT queueid, employeeid, taskid FROM queue where queueid={0}", id);
                
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

             
                while (reader.Read())
                {
                    Queue.QueueId = int.Parse(reader["Queueid"].ToString());
                    Queue.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    Queue.TaskId = int.Parse(reader["taskid"].ToString());
             

                }
                dbCon.Close();
            }

            return Queue;

        }

        public List<Models.QueueModel> GetQueues(List<Models.QueueModel> Queues, int EmployeeId, bool isAdmin)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = "";
                if (isAdmin == true)
                {
                     query = string.Format("SELECT queueid, employeeid, taskid FROM queue");
                }
                else
                {
                     query = string.Format("SELECT queueid, employeeid, taskid FROM queue where employeeid=" + EmployeeId);
                }
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Models.QueueModel Queue = new Models.QueueModel
                    {
                        QueueId = int.Parse(reader["queueid"].ToString()),
                        EmployeeId = int.Parse(reader["employeeid"].ToString()),
                        TaskId = int.Parse(reader["taskid"].ToString())
                };

                    Queues.Add(Queue);

                }
                dbCon.Close();
            }

            return Queues;

        }

        public List<Models.QueueModel> GetQueuesJoinedRoll(List<Models.QueueModel> Queues, int EmployeeId,bool isAdmin)
        {
        
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = "";

                if (isAdmin == true)
                {
                     query = string.Format("SELECT queue.queueid, queue.employeeid, queue.taskid, queueroll.startdate, queueroll.stopdate FROM queue LEFT JOIN queueroll on queue.queueid=queueroll.queueid and queue.employeeid=queueroll.employeeid and queue.taskid=queueroll.taskid where completed=0 group by queue.queueid");

                } else
                {
                     query = string.Format("SELECT queue.queueid, queue.employeeid, queue.taskid, queueroll.startdate, queueroll.stopdate FROM queue LEFT JOIN queueroll on queue.queueid=queueroll.queueid and queue.employeeid=queueroll.employeeid and queue.taskid=queueroll.taskid where completed=0 and queue.employeeid={0} group by queueroll.queueid", EmployeeId);
                }
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Models.QueueModel Queue = new Models.QueueModel
                    {
                        QueueId = int.Parse(reader["queueid"].ToString()),
                        EmployeeId = int.Parse(reader["employeeid"].ToString()),
                        TaskId = int.Parse(reader["taskid"].ToString())
                    };
                    bool Add_item_tolist = true;

                    DateTime checkdate = DateTime.Now;
                    if (reader["stopdate"].ToString() != "")
                    {
                        checkdate = DateTime.Parse(reader["stopdate"].ToString());
                    }


                    if (checkdate == DateTime.MinValue)
                    {
                        Add_item_tolist = false;

                    }

                    if (Add_item_tolist == true)
                    {
                        Queues.Add(Queue);
                    }
                   

                }
                dbCon.Close();
            }

            return Queues;

        }

        public List<Models.QueueModel> GetQueues(int EmployeeId, bool isAdmin)
        {
            List<Models.QueueModel> Queues = new List<Models.QueueModel>();
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = "";
                if (isAdmin == true)
                {
                     query = string.Format("SELECT queueid, employeeid, taskid FROM queue");
                }
                else
                {
                     query = string.Format("SELECT queueid, employeeid, taskid FROM queue where employeeid=" + EmployeeId);
                }
                
               
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                EmployeeQueries EmployeeQuery = new EmployeeQueries();
                TaskQueries TaskQuery = new TaskQueries();
                while (reader.Read())
                {
                    Models.QueueModel Queue = new Models.QueueModel
                    {
                        QueueId = int.Parse(reader["Queueid"].ToString()),
                        EmployeeId = int.Parse(reader["description"].ToString()),
                        TaskId = int.Parse(reader["rate"].ToString()),
                        Employee = EmployeeQuery.GetEmployee(int.Parse(reader["employeeid"].ToString())),
                        Task = TaskQuery.GetTask(int.Parse(reader["taskid"].ToString()))
                    };

                    Queues.Add(Queue);

                }
                dbCon.Close();
            }

            return Queues;

        }

        public void DeleteQueue(int id)
        {

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("DELETE FROM queue WHERE queueid={0};", id);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }



        }

        public QueueQueries()
        {

           

        }

    }
}
