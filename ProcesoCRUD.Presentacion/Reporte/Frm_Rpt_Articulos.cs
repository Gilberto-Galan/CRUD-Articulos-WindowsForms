using Microsoft.Reporting.WinForms;
using ProcesoCRUD.Presentacion.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesoCRUD.Presentacion.Reporte
{
    public partial class Frm_Rpt_Articulos : Form
    {
        public Frm_Rpt_Articulos()
        {
            InitializeComponent();
        }

        #region "Mis Metodos"
        public void Listado_ar()
        {
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                
                string Sql_tarea = "SELECT  tb_articulos.codigo_ar, tb_articulos.descripcion_ar, tb_articulos.marca_ar, tb_medidas.descripcion_me, tb_categorias.descripcion_ca " +
                                    "FROM ((tb_articulos INNER JOIN " +
                                    "tb_categorias ON tb_articulos.codigo_ca = tb_categorias.codigo_ca) INNER JOIN " +
                                    "tb_medidas ON tb_articulos.codigo_me = tb_medidas.codigo_me) ";

                OleDbDataAdapter da = new OleDbDataAdapter(Sql_tarea, SqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ReportDataSource fuente = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(fuente);
                reportViewer1.LocalReport.ReportEmbeddedResource = "ProcesoCRUD.Presentacion.Reporte.Rpt_Reporte_ar.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
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
        #endregion

        private void Frm_Rpt_Articulos_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            this.Listado_ar();
        }
    }
}
