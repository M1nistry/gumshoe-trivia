using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace POETrivia
{
    class SQLite
    {
        private readonly string _connection;

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
                ExecuteNonQuery(String.Format("INSERT INTO {0}({1}) VALUES({2});", tableName, columns, values));
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
                        cnn.Close();
                    }
                }
            }
            return categoryList;
        }

        /// <summary> Registers a new user in the database with either their provided pin or a random one </summary>
        /// <param name="account">Account name to register</param>
        /// <param name="pin">Pin to login with</param>
        /// <returns>Sucess</returns>
        public bool RegisterAccount(string account, int pin = 0)
        {
            using (var cnn = new SQLiteConnection(_connection))
            {
                var registerCommand = String.Format("INSERT INTO Users (user_account, user_pin) VALUES (@account, @pin);");
                cnn.Open();
                using (var cmd = new SQLiteCommand(registerCommand, cnn))
                {
                    cmd.Parameters.AddWithValue("@account", account);
                    cmd.Parameters.AddWithValue("@pin", pin);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        return true;
                    }
                    catch (SQLiteException ex)
                    {
                        Console.WriteLine(ex);
                        return false;
                    }
                }
            }
        }

        public int RetrieveId(string account)
        {
            using (var cnn = new SQLiteConnection(_connection))
            {
                cnn.Open();
                using (var cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = String.Format("SELECT `user_id` FROM Users WHERE user_account='{0}';", account);
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) return reader.GetInt32(0);
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        return -1;
                    }
                }
            }
            return -1;
        }

        public int RetrievePin(int userId)
        {
            using (var cnn = new SQLiteConnection(_connection))
            {
                cnn.Open();
                using (var cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = String.Format("SELECT `user_pin` FROM Users WHERE user_id='{0}';", userId);
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) return reader.GetInt32(0);
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        return -1;
                    }
                }
            }
            return -1;
        }

        public bool CharacterExists(int userId, string character)
        {
            var characterList = new List<string>();
            using (var cnn = new SQLiteConnection(_connection))
            {
                cnn.Open();
                using (var cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = String.Format("SELECT `character_name` FROM Characters WHERE character_user_id='{0}';", userId);
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) characterList.Add(reader.GetString(0));
                        }
                        if (characterList.Contains(character)) return false;
                        Insert("Characters", new Dictionary<string, string>
                        {
                            { "character_name", character },
                            { "character_user_id", userId.ToString()}
                        });
                        return true;
                    }
                    catch (SQLiteException ex)
                    {
                        return false;
                    }
                }
            }
        }
        
        #endregion

        public string _ConString(SQLiteConnectionStringBuilder ConString)
        {
            return ConString.ToString();
        }

    }
}