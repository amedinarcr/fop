using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
namespace Voltage
{
    public sealed class OleHelper
    {
        private OleHelper()
        { }

        public static OleDbConnection Conn
        {
            get 
            {
                //return new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\(E-drive)\Voltage Google\Voltage\Voltage\Voltage\bin\Debug\SerialData.mdb");
                return new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+System.Windows.Forms.Application.StartupPath+"\\SerialData.mdb");
            }
        }
        public static DataSet ExecuteDataset(string commandText)
        {
            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, OleHelper.Conn, null, CommandType.Text, commandText);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.Parameters.Clear();
            OleHelper.Conn.Close();
            return ds;
        }

        public static DataSet ExecuteDataset(OleDbConnection connection, CommandType commandType, string commandText)
        {
            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, null, commandType, commandText);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.Parameters.Clear();
            connection.Close();
            return ds;
        }

        public static DataSet ExecuteDataset(OleDbConnection connection, CommandType commandType, string commandText, OleDbParameter[] parameters)
        {

            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, commandType, commandText, parameters);

            DataSet retval = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(retval);

            cmd.Parameters.Clear();
            connection.Close();
            return retval;

        }

        public static int ExecuteNonQuery(OleDbConnection connection, CommandType commandType, string commandText)
        {

            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, null, commandType, commandText);

            int retval = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
            return retval;

        }

        public static int ExecuteNonQuery(OleDbConnection connection, CommandType commandType, string commandText, OleDbParameter[] parameters)
        {

            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, commandType, commandText, parameters);

            int retval = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
            return retval;

        }


        public static object ExecuteScalar(OleDbConnection connection, CommandType commandType, string commandText)
        {

            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, null, commandType, commandText);

            object retval = cmd.ExecuteScalar();

            cmd.Parameters.Clear();
            connection.Close();
            return retval;

        }

        public static object ExecuteScalar(OleDbConnection connection, CommandType commandType, string commandText, OleDbParameter[] parameters)
        {

            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, commandType, commandText, parameters);

            object retval = cmd.ExecuteScalar();

            cmd.Parameters.Clear();
            connection.Close();
            return retval;

        }

        public static OleDbDataReader ExecuteReader(OleDbConnection connection, CommandType commandType, string commandText)
        {

            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, null, commandType, commandText);

            OleDbDataReader retval = cmd.ExecuteReader();

            cmd.Parameters.Clear();
            connection.Close();
            return retval;

        }

        public static OleDbDataReader ExecuteReader(OleDbConnection connection, CommandType commandType, string commandText,OleDbParameter[] parameters)
        {

            OleDbCommand cmd = new OleDbCommand();

            PrepareCommand(cmd, connection, commandType, commandText, parameters);

            OleDbDataReader retval = cmd.ExecuteReader();

            cmd.Parameters.Clear();
            connection.Close();
            return retval;

        }

        private static void PrepareCommand(OleDbCommand command, OleDbConnection connection, OleDbTransaction transaction, CommandType commandType, string commandText)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.Connection = connection;

            command.CommandText = commandText;

            if (transaction != null)
            {
                command.Transaction = transaction;
            }

            command.CommandType = commandType;

            return;
        }

        private static void PrepareCommand(OleDbCommand command, OleDbConnection connection, CommandType commandType, string commandText,OleDbParameter[] parameters)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.Connection = connection;

            command.CommandText = commandText;

            foreach (OleDbParameter p in parameters)
                command.Parameters.Add(p);

            command.CommandType = commandType;

            return;
        }
    }
}
