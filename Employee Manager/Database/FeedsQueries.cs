using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Database
{
    public class FeedsQueries
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();


        public List<Models.FeedsModel> getFeeds(List<Models.FeedsModel> feeds)
        {
            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                string query = string.Format("SELECT link_id, link_name FROM jobs_links");
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    return feeds;
                }

                while (reader.Read())
                {
                    Models.FeedsModel feed = new Models.FeedsModel();

                    feed.Link_Id = int.Parse(reader["link_id"].ToString());
                    feed.Link_Name = reader["link_name"].ToString();

                    feeds.Add(feed);

                }
                dbCon.Close();
            }

            return feeds;

        }

        public List<Models.FeedsModel> UpdateFeeds(List<Models.FeedsModel> feeds)
        {

            var dbCon = DBConnection;
            if (dbCon.IsConnect())
            {
                foreach (Models.FeedsModel feed in feeds)
                {

                    string query = string.Format("Update jobs_links set link_name='{0}' where link_id={1}", feed.Link_Name, feed.Link_Id);
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    if (dbCon.Connection.State.ToString() == "Closed")
                    {
                        dbCon.Connection.Open();
                    }

                    var reader = cmd.ExecuteNonQuery();

                }

                dbCon.Close();
            }

            return feeds;

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
        
        public FeedsQueries()
        {

           

        }

    }
}
