using Yefer_ControlAcceso.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yefer_ControlAcceso.Controllers
{
    public class UsuarioDAO 
    {
        Db db = new Db("Platanitos");
        
        public Usuario Login(string CORREO, string CONTRASEÑA)
        {
            db.Sentencia(@"SELECT ID, TELÈFONO, PAÌS, TIPODOC,
                                 DOCUMENTO, CORREO, NOMBRES, APELLIDOS,
                                 CONTRASEÑA, FECHA
                          FROM Usuarios
                          WHERE CORREO = @CORREO AND CONTRASEÑA = @CONTRASEÑA");
            db.Parametro("@CORREO", CORREO.Trim());
            db.Parametro("@CONTRASEÑA", CONTRASEÑA);

            DataTable filas = db.getDataTable();
            if (filas == null)
            {
                return null;
            }
            return new Usuario(filas.Rows[0]);

        }
        
    }
}