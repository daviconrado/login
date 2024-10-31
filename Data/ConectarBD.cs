using System;
using System.Data;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using SistemaLogin;
using static Mysqlx.Expect.Open.Types.Condition.Types;

public class ConectaDB
{
    public static DataTable ConectarDB(string sql)
    {
        string connectionString = "Server=localhost;Database=login;User ID=root;Password=748596123;";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                DataTable retorno = new DataTable();

                retorno.Load(mySqlCommand.ExecuteReader());

                return retorno;
            }
            catch (MySqlException ex)
            {
                DataTable retornoE = new DataTable();

                retornoE.Columns.Add("error", typeof(string));
                DataRow row = retornoE.NewRow();

                row["error"] = ex.Message.ToString();
                retornoE.Rows.Add(row);

                return retornoE;
            }

            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
