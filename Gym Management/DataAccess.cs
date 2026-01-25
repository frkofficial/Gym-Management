using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management
{
    public class DataAccess
    {
        public static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["GymsDB"]?.ConnectionString;

        public DataAccess()
        {
            if (string.IsNullOrEmpty(CONNECTION_STRING))
            {
                throw new Exception("Connection string not found!");
            }
        }

        public SqlCommand GetCommand(string sql)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            return sqlCmd;
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            int result = 0;
            try
            {
                command.Connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
                throw new Exception($"Database Error: {ex.Message}", ex);
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            return result;
        }

        public object ExecuteScalar(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception($"ExecuteScalar Error: {ex.Message}", ex);
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
        }

        public int GetNextEmpId()
        {
            SqlCommand cmd = GetCommand("SELECT ISNULL(MAX(EmpId), 0) + 1 FROM EmpInfo");
            object result = ExecuteScalar(cmd);
            return Convert.ToInt32(result);
        }

        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                command.Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database Error: {ex.Message}", ex);
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            return dt;
        }

        
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}