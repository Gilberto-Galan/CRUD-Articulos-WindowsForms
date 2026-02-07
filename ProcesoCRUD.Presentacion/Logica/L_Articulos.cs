using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using ProcesoCRUD.Presentacion.Modelo;

namespace ProcesoCRUD.Presentacion.Logica
{
    public class L_Articulos
    {
        public DataTable Listado_ar(string cTexto)
        {
            OleDbDataReader Resultado;
            DataTable Tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                cTexto = "%" + cTexto.Trim().ToUpper() + "%";

                string Sql_tarea = "SELECT  tb_articulos.codigo_ar, tb_articulos.descripcion_ar, tb_articulos.marca_ar, tb_medidas.descripcion_me, tb_categorias.descripcion_ca, tb_articulos.codigo_me, tb_articulos.codigo_ca " +
                                    "FROM ((tb_articulos INNER JOIN " +
                                    "tb_categorias ON tb_articulos.codigo_ca = tb_categorias.codigo_ca) INNER JOIN " +
                                    "tb_medidas ON tb_articulos.codigo_me = tb_medidas.codigo_me) "+
                                    "where ucase(trim(tb_articulos.descripcion_ar)) like '" + cTexto + "'";

                OleDbCommand Comando = new OleDbCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    
        public string Guardar_ar(int nOpcion, M_Articulos oPro)
        {
            string Rpta = "";
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string Sql_tarea = "";
                if (nOpcion == 1) //Nuevo Registro
                {
                    Sql_tarea = "insert into tb_articulos(descripcion_ar, marca_ar, codigo_me, codigo_ca) " +
                                " values('" + oPro.Descripcion_ar + "','" + oPro.Marca_ar + "','" + oPro.Codigo_me + "','" + oPro.Codigo_ca + "')"; ;
                }
                else //Actualizar Registro
                {
                    Sql_tarea = "update tb_articulos set descripcion_ar='" + oPro.Descripcion_ar + "' ,"+
                                " marca_ar= '" + oPro.Marca_ar + "',"+
                                " codigo_me= val('" + oPro.Codigo_me + "') ,"+
                                " codigo_ca= val('" + oPro.Codigo_ca + "') "+
                                " where codigo_ar= val('" + oPro.Codigo_ar + "')";
                }
                OleDbCommand Comando = new OleDbCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar_ar(int nCodigo_ar)
        {
            string Rpta = "";
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string Sql_tarea = "";
                Sql_tarea = "delete from tb_articulos where codigo_ar= val('" + nCodigo_ar + "')";
                OleDbCommand Comando = new OleDbCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public DataTable Listado_me()
        {
            OleDbDataReader Resultado;
            DataTable Tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                
                string Sql_tarea = "select descripcion_me, codigo_me from tb_medidas";

                OleDbCommand Comando = new OleDbCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listado_ca()
        {
            OleDbDataReader Resultado;
            DataTable Tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                string Sql_tarea = "select descripcion_ca, codigo_ca from tb_categorias";

                OleDbCommand Comando = new OleDbCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

    }
}
