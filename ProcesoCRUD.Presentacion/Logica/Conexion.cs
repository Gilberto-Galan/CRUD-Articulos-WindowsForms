using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ProcesoCRUD.Presentacion.Logica
{
    public class Conexion
    {
        private string Provider;
        private string BasedeDatos;
        private static Conexion Con = null;
        
        private Conexion()
        {
            this.Provider = "Microsoft.ACE.OLEDB.12.0";     
            this.BasedeDatos = "./bd_aprendizaje.accdb";
        }


        public OleDbConnection CrearConexion()
        {
            OleDbConnection Cadena = new OleDbConnection();
            try
            {
                Cadena.ConnectionString = "Provider=" + this.Provider + 
                                            ";Data Source=" + this.BasedeDatos +
                                            ";Persist Security Info=False;";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }

}
