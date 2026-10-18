using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yefer_ControlAcceso.Controllers
{
    public class Db
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;

        public Db(string cnn)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[cnn].ConnectionString);
            cmd = new SqlCommand("", cn);
            adapter = new SqlDataAdapter(cmd);
        }

        internal void Sentencia(string sql)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
        }

        internal void Parametro(string sql, string valor)
        {
            cmd.Parameters.AddWithValue(sql, valor);
        }

        internal DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows.Count == 0 ? null : dt;
        }

    }
}