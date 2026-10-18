using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Yefer_ControlAcceso.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string TELÈFONO { get; set; }
        public string PAÌS { get; set; }
        public string TIPODOC { get; set; }
        public string DOCUMENTO { get; set; }
        public string CORREO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string FECHA { get; set; }
        public string CONTRASEÑA { get; set; }

        public Usuario(DataRow dr)
        {
            ID = int.Parse(dr["ID"].ToString());
            TELÈFONO = dr["TELÈFONO"].ToString();
            PAÌS = dr["PAÌS"].ToString();
            TIPODOC = dr["TIPODOC"].ToString();
            DOCUMENTO = dr["DOCUMENTO"].ToString();
            CORREO = dr["CORREO"].ToString();
            NOMBRES = dr["NOMBRES"].ToString();
            APELLIDOS = dr["APELLIDOS"].ToString();
            CONTRASEÑA = dr["CONTRASEÑA"].ToString();
            FECHA = dr["FECHA"].ToString();
        }
    }
}