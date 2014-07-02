using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;

namespace POETrivia
{
    class SQLite
    {
        private string _connection;

        public SQLite()
        {
            _connection = "Data Source=TriviaDB";
        }
        #region Generic SQL Methods

        /// <summary> Allows the programmer to interact with the database for purposes other than a query. </summary>
        /// <param name="sql">The SQL to be run.</param>
        /// <returns>An Integer containing the number of rows updated.</returns>
        public int ExecuteNonQuery(string sql)
        {
            using (var cnn = new SQLiteConnection(_connection))
            {
                cnn.Open();
                using (var cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary> Allows the programmer to retrieve single items from the DB. </summary>
        /// <param name="sql">The query to run.</param>
        /// <returns>A string</returns>
        public string ExecuteScalar(string sql)
        {
            using (var cnn = new SQLiteConnection(_connection))
            { 
                cnn.Open();
                using (var cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = sql;
                    var value = cmd.ExecuteScalar();
                    return value != null ? value.ToString() : "";
                }
            }
        }

        /// <summary> Allows the programmer to easily insert into the DB </summary>
        /// <param name="tableName">The table into which we insert the data.</param>
        /// <param name="data">A dictionary containing the column names and data for the insert.</param>
        /// <returns>Result as boolean</returns>
        public bool Insert(String tableName, Dictionary<String, String> data)
        {
            var columns = "";
            var values = "";
            var returnCode = true;
            foreach (var val in data)
            {
                columns += String.Format(" {0},", val.Key);
                values += String.Format(" '{0}',", val.Value);
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            try
            {
                ExecuteNonQuery(String.Format("INSERT INTO {0}({1}) VALUESs({2});", tableName, columns, values));
            }
            catch (Exception fail)
            {
                //TODO: Error handling method/solution
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary> Allows the programmer to easily update rows in the DB. </summary>
        /// <param name="tableName">The table to update.</param>
        /// <param name="data">A dictionary containing column names and their new values.</param>
        /// <param name="where">The where clause for the update statement.</param>
        /// <returns>Result as boolean</returns>
        public bool Update(String tableName, Dictionary<String, String> data, String where)
        {
            var vals = "";
            var returnCode = true;
            if (data.Count >= 1)
            {
                vals = data.Aggregate(vals, (current, val) => current + String.Format(" {0} = '{1}',", val.Key, val.Value));
                vals = vals.Substring(0, vals.Length - 1);
            }
            try
            {
                ExecuteNonQuery(String.Format("UPDATE {0} SET {1} WHERE {2};", tableName, vals, where));
            }
            catch
            {
                //TODO: Error handling method/solution
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary> Allows the programmer to easily delete rows from the DB. </summary>
        /// <param name="tableName">The table from which to delete.</param>
        /// <param name="where">The where clause for the delete.</param>
        /// <returns>Result as boolean</returns>
        public bool Delete(String tableName, String where)
        {
            var returnCode = true;
            try
            {
                ExecuteNonQuery(String.Format("DELETE FROM {0} WHERE {1};", tableName, where));
            }
            catch (Exception fail)
            {
                //TODO: Error handling method/solution
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary> Allows the user to easily clear all data from a specific table. </summary>
        /// <param name="table">The name of the table to clear.</param>
        /// <returns>Result as Boolean</returns>
        public bool ClearTable(String table)
        {
            try
            {
                ExecuteNonQuery(String.Format("DELETE FROM {0};", table));
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Custom SQL Methods
        public List<string> QueryCategories()
        {
            var categoryList = new List<string>();
            using (var cnn = new SQLiteConnection(_connection))
            {
                const string queryCategories = @"SELECT category_id, category_name FROM Categories;";
                cnn.Open();
                using (var cmd = new SQLiteCommand(queryCategories, cnn))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            categoryList.Add(rdr.GetString(1));
                        }
                    }
                }
            }
            return categoryList;
        }
        #endregion

        public string _ConString(SQLiteConnectionStringBuilder ConString)
        {
            return ConString.ToString();
        }

    }
}