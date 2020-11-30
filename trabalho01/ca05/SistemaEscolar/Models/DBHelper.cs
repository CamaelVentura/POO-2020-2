using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace SistemaEscolar.Models
{
    class DBHelper
    {
        private static SQLiteConnection connection;
        private static string filePath = "db.sqlite";

        private static string tableName;

        public DBHelper() { }

        public static SQLiteConnection DBConnection()
        {
            connection = new SQLiteConnection("Data Source=.\\" + filePath + "/ Version=3;");
            connection.Open();
            return connection;
        }

        public static void initDB()
        {
            try
            {
                SQLiteConnection.CreateFile(@filePath);
            }
            catch
            {
                throw;
            }
        }

        private static DataTable All()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM " + tableName;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static DataTable Find(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM " + tableName + " WHERE id = " + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }
}
