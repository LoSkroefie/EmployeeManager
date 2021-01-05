using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class QueueRollQueries
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();

        public Models.QueueRollModel CreateQueueRoll(Models.QueueRollModel QueueRoll)
        {
            
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                
                string query = string.Format("INSERT INTO queueroll (queueid, employeeid, taskid, startdate, stopdate, minutes, rate) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", QueueRoll.QueueId, QueueRoll.EmployeeId, QueueRoll.TaskId, QueueRoll.StartDate, QueueRoll.StopDate, QueueRoll.Minutes, QueueRoll.Rate);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

            return QueueRoll;

        }
        public Models.QueueRollModel UpdateQueueRoll(Models.QueueRollModel QueueRoll)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                
                string query = string.Format("UPDATE queueroll set queueid='{0}', employeeid='{1}', taskid='{2}', startdate='{3}', stopdate='{4}', minutes='{5}', rate='{6}' WHERE rollid={7};", QueueRoll.QueueId, QueueRoll.EmployeeId, QueueRoll.TaskId, QueueRoll.StartDate, QueueRoll.StopDate, QueueRoll.Minutes, QueueRoll.Rate, QueueRoll.RollId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);


                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

            return QueueRoll;

        }

        public Models.QueueRollModel UpdateQueueRollStop(Models.QueueRollModel QueueRoll)
        {
            var dbCon =  DBConnection;
            dbCon.Close();
            if (dbCon.IsConnect())
            {
                
                string query = string.Format("UPDATE queueroll set stopdate='{0}', minutes='{1}', rate='{2}' WHERE rollid={3};", QueueRoll.StopDate, QueueRoll.Minutes, QueueRoll.Rate, QueueRoll.RollId);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }
                
                var cmd = new MySqlCommand(query, dbCon.Connection);

            
                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }

            return QueueRoll;

        }

        public Models.QueueRollModel GetQueueRoll(Models.QueueRollModel QueueRoll)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                
                string query = string.Format("SELECT rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate FROM queueroll where rollid={0}", QueueRoll.RollId);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                EmployeeQueries EmployeeQuery = new EmployeeQueries();
                TaskQueries TaskQuery = new TaskQueries();
                while (reader.Read())
                {
                    QueueRoll.RollId = int.Parse(reader["rollid"].ToString());
                    QueueRoll.QueueId = int.Parse(reader["queueid"].ToString());
                    QueueRoll.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    QueueRoll.TaskId = int.Parse(reader["taskid"].ToString());
                    QueueRoll.Employee = EmployeeQuery.GetEmployee(QueueRoll.EmployeeId);
                    QueueRoll.Task = TaskQuery.GetTask(QueueRoll.TaskId);

                }
                dbCon.Close();
            }

            return QueueRoll;

        }
        public Models.QueueRollModel GetQueueRoll(int QueueRollId)
        {
            Models.QueueRollModel QueueRoll = new Models.QueueRollModel();

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate FROM queueroll where rollid={0}", QueueRollId);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                EmployeeQueries EmployeeQuery = new EmployeeQueries();
                TaskQueries TaskQuery = new TaskQueries();
                while (reader.Read())
                {
                    QueueRoll.RollId = int.Parse(reader["rollid"].ToString());
                    QueueRoll.QueueId = int.Parse(reader["queueid"].ToString());
                    QueueRoll.EmployeeId = int.Parse(reader["employeeid"].ToString());
                    QueueRoll.TaskId = int.Parse(reader["taskid"].ToString());
                    QueueRoll.Employee = EmployeeQuery.GetEmployee(QueueRoll.EmployeeId);
                    QueueRoll.Task = TaskQuery.GetTask(QueueRoll.TaskId);
                    QueueRoll.StartDate = DateTime.Parse(reader["startdate"].ToString());
                    QueueRoll.StopDate = DateTime.Parse(reader["stopdate"].ToString());
                    QueueRoll.Minutes = double.Parse(reader["minutes"].ToString());
                    QueueRoll.Rate = decimal.Parse(reader["rate"].ToString());
                }
                dbCon.Close();
            }

            return QueueRoll;

        }

        public List<Models.QueueRollModel> GetQueuesRoll(List<Models.QueueRollModel> QueuesRoll, int EmployeeId, bool isAdmin)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = "";
                if (isAdmin ==true )
                {
                    query = string.Format("SELECT rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate FROM queueroll");
                } else
                {
                    query = string.Format("SELECT rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate FROM queueroll where employeeid={0}", EmployeeId);
                }
               
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    Models.QueueRollModel Queue = new Models.QueueRollModel
                    {
                        RollId = int.Parse(reader["rollid"].ToString()),
                        QueueId = int.Parse(reader["queueid"].ToString()),
                        EmployeeId = int.Parse(reader["employeeid"].ToString()),
                        TaskId = int.Parse(reader["taskid"].ToString()),
                        StartDate = DateTime.Parse(reader["startdate"].ToString()),
                        StopDate = DateTime.Parse(reader["stopdate"].ToString()),
                        Minutes = double.Parse(reader["minutes"].ToString()),
                        Rate = decimal.Parse(reader["rate"].ToString()),


                    };

                 
                        QueuesRoll.Add(Queue);
                  
                    

                }
                dbCon.Close();
            }

            return QueuesRoll;

        }

        public List<Models.QueueRollModel> GetQueuesRoll(int EmployeeId, bool isAdmin)
        {
            List<Models.QueueRollModel> QueuesRoll = new List<Models.QueueRollModel>();
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = "";
                if (isAdmin == true)
                {
                    query = string.Format("SELECT rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate FROM queueroll");
                }
                else
                {
                    query = string.Format("SELECT rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate FROM queueroll employeeid={0}", EmployeeId);
                }
              
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                EmployeeQueries EmployeeQuery = new EmployeeQueries();
                TaskQueries TaskQuery = new TaskQueries();
                while (reader.Read())
                {
                    Models.QueueRollModel Queue = new Models.QueueRollModel
                    {
                        QueueId = int.Parse(reader["queueid"].ToString()),
                        EmployeeId = int.Parse(reader["employeeid"].ToString()),
                        TaskId = int.Parse(reader["taskid"].ToString()),
                        Employee = EmployeeQuery.GetEmployee(int.Parse(reader["employeeid"].ToString())),
                        Task = TaskQuery.GetTask(int.Parse(reader["taskid"].ToString()))
                    };

                    QueuesRoll.Add(Queue);

                }
                dbCon.Close();
            }

            return QueuesRoll;

        }

        public void DeleteQueueRoll(int id)
        {

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("DELETE FROM queueroll WHERE rollid={0};", id);

                if (dbCon.Connection.State.ToString() == "Closed")
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteNonQuery();

                dbCon.Close();
            }



        }

        public bool CheckQueuesRoll(int QueueId, int EmployeeId, int TaskId)
        {
            bool QueueExists = false;
            DateTime DateCheck = DateTime.Now;

            List<Models.QueueRollModel> QueuesRoll = new List<Models.QueueRollModel>();
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {

                string query = string.Format("SELECT rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate FROM queueroll where queueid={0} and employeeid={1} and taskid={2} and stopdate=MIN(date)", QueueId,EmployeeId,TaskId);
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
               

                while (reader.Read())
                {
                    DateCheck = DateTime.Parse(reader["stopdate"].ToString());
                         QueueExists = true;

                }
                dbCon.Close();
            }

            return QueueExists;

        }
        public QueueRollQueries()
        {

           

        }

    }
}
