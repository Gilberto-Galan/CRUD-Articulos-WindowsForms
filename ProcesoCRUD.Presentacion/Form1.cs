using ProcesoCRUD.Presentacion.Logica;
using ProcesoCRUD.Presentacion.Modelo;
using ProcesoCRUD.Presentacion.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesoCRUD.Presentacion
{
    public partial class Frm_Articulos : Form
    {
        public Frm_Articulos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nEstado_guarda = 0;
        int nCodigo_ar = 0;
        int nCodigo_me = 0;
        int nCodigo_ca = 0;
        #endregion

        #region "Mis Metodos"
        private void Formato_ar()
        {
            Dgv_resumen.Columns[0].Width = 90;
            Dgv_resumen.Columns[0].HeaderText = "CODIGO_AR";
            Dgv_resumen.Columns[1].Width = 130;
            Dgv_resumen.Columns[1].HeaderText = "ARTICULO";
            Dgv_resumen.Columns[2].Width = 120;
            Dgv_resumen.Columns[2].HeaderText = "MARCA";
            Dgv_resumen.Columns[3].Width = 120;
            Dgv_resumen.Columns[3].HeaderText = "MEDIDA";
            Dgv_resumen.Columns[4].Width = 120;
            Dgv_resumen.Columns[4].HeaderText = "CATEGORIA";
            Dgv_resumen.Columns[5].Visible = false;
            Dgv_resumen.Columns[6].Visible = false;
        }

        private void Listado_ar(string cTexto)
        {
            L_Articulos Datos = new L_Articulos();
            Dgv_resumen.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();
        }

        private void Estado_texto(bool lEstado)
        {
            Txt_descripcion_ar.ReadOnly = !lEstado;
            Txt_marca_ar.ReadOnly = !lEstado;
        }

        private void Limpiar_texto()
        {
            Txt_descripcion_ar.Clear();
            Txt_marca_ar.Clear();
            Txt_descripcion_me.Clear();
            Txt_descripcion_ca.Clear();
        }

        private void Estado_botonesprincipales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
        }

        private void Estado_botonesprocesos(bool lEstado)
        {
            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;
            Btn_lupa_me.Visible = lEstado;
            Btn_lupa_ca.Visible = lEstado;

            Btn_buscar.Enabled = !lEstado;
            Txt_buscar.Enabled = !lEstado;
            Dgv_resumen.Enabled = !lEstado;
        }

        private void Selecciona_item_ar()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_resumen.CurrentRow.Cells["codigo_ar"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_ar = Convert.ToInt32(Dgv_resumen.CurrentRow.Cells["codigo_ar"].Value);
                Txt_descripcion_ar.Text = Convert.ToString(Dgv_resumen.CurrentRow.Cells["descripcion_ar"].Value);
                Txt_marca_ar.Text = Convert.ToString(Dgv_resumen.CurrentRow.Cells["marca_ar"].Value);
                Txt_descripcion_me.Text = Convert.ToString(Dgv_resumen.CurrentRow.Cells["descripcion_me"].Value);
                Txt_descripcion_ca.Text = Convert.ToString(Dgv_resumen.CurrentRow.Cells["descripcion_ca"].Value);
                nCodigo_me = Convert.ToInt32(Dgv_resumen.CurrentRow.Cells["codigo_me"].Value);
                nCodigo_ca = Convert.ToInt32(Dgv_resumen.CurrentRow.Cells["codigo_ca"].Value); 
            }
        }

        private void Formato_me()
        {
            Dgv_me.Columns[0].Width = 180;
            Dgv_me.Columns[0].HeaderText = "MEDIDA";  
            Dgv_me.Columns[1].Visible = false;
        }

        private void Listado_me()
        {
            L_Articulos Datos = new L_Articulos();
            Dgv_me.DataSource = Datos.Listado_me();
            this.Formato_me();
        }

        private void Selecciona_item_me()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_me.CurrentRow.Cells["codigo_me"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_me = Convert.ToInt32(Dgv_me.CurrentRow.Cells["codigo_me"].Value);
                Txt_descripcion_me.Text = Convert.ToString(Dgv_me.CurrentRow.Cells["descripcion_me"].Value);
            }
        }

        private void Formato_ca()
        {
            Dgv_ca.Columns[0].Width = 180;
            Dgv_ca.Columns[0].HeaderText = "CATEGORIA";
            Dgv_ca.Columns[1].Visible = false;
        }

        private void Listado_ca()
        {
            L_Articulos Datos = new L_Articulos();
            Dgv_ca.DataSource = Datos.Listado_ca();
            this.Formato_ca();
        }

        private void Selecciona_item_ca()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_ca.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_ca = Convert.ToInt32(Dgv_ca.CurrentRow.Cells["codigo_ca"].Value);
                Txt_descripcion_ca.Text = Convert.ToString(Dgv_ca.CurrentRow.Cells["descripcion_ca"].Value);
            }
        }

        #endregion

        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            this.Estado_texto(true);
            this.Listado_me();
            this.Listado_ca();
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstado_guarda = 1; //Nuevo Registro
            this.Estado_texto(true);
            this.Limpiar_texto();
            this.Estado_botonesprocesos(true);
            this.Estado_botonesprincipales(false);
            Txt_descripcion_ar.Focus();
        }
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            nEstado_guarda = 0;
            nCodigo_ar = 0;
            nCodigo_me = 0;
            nCodigo_ca = 0;
            this.Estado_texto(false);
            this.Limpiar_texto();
            this.Estado_botonesprocesos(false);
            this.Estado_botonesprincipales(true);
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if(Txt_descripcion_ar.Text == string.Empty || Txt_marca_ar.Text == string.Empty)
            {
                MessageBox.Show("Ingrese datos requeridos (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //Guardar Registro
            {
                M_Articulos oPro = new M_Articulos();
                oPro.Codigo_ar = nCodigo_ar;
                oPro.Descripcion_ar = Txt_descripcion_ar.Text.Trim();
                oPro.Marca_ar = Txt_marca_ar.Text.Trim();
                oPro.Codigo_me = nCodigo_me;
                oPro.Codigo_ca = nCodigo_ca;

                string Rpta = "";
                L_Articulos Datos = new L_Articulos();
                Rpta = Datos.Guardar_ar(nEstado_guarda, oPro);
                if (Rpta.Equals("OK"))
                {
                    this.Estado_texto(false);
                    this.Estado_botonesprocesos(false);
                    this.Estado_botonesprincipales(true);
                    this.Listado_ar("%");
                    nEstado_guarda = 0;
                    nCodigo_ar = 0;
                    nCodigo_me = 0;
                    nCodigo_ca = 0;
                    MessageBox.Show("Los datos han sido guardados correctamente",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(Rpta);
                }
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            nEstado_guarda = 2; //Actualizar Registro
            this.Estado_texto(true);
            this.Estado_botonesprocesos(true);
            this.Estado_botonesprincipales(false);
            Txt_descripcion_ar.Focus();
        }

        private void Dgv_resumen_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_ar();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_resumen.Rows.Count>0)
            {
                string Rpta = "";
                L_Articulos Datos = new L_Articulos();
                Rpta = Datos.Eliminar_ar(nCodigo_ar);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ar("%");
                    nCodigo_ar = 0;
                    nCodigo_me = 0;
                    nCodigo_ca = 0;
                    this.Limpiar_texto();
                    MessageBox.Show("El registro ha sido eliminado",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta);
                }
            }
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Articulos oRpt = new Frm_Rpt_Articulos();
            oRpt.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_lupa_me_Click(object sender, EventArgs e)
        {
            Pnl_me.Location = Txt_descripcion_ar.Location;
            Pnl_me.Visible = true;
        }

        private void Btn_retornar_me_Click(object sender, EventArgs e)
        {
            Pnl_me.Visible = false;
        }

        private void Dgv_me_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_me();
            Pnl_me.Visible = false;
        }

        private void Btn_retornar_ca_Click(object sender, EventArgs e)
        {
            Pnl_ca.Visible = false;

        }

        private void Btn_lupa_ca_Click(object sender, EventArgs e)
        {
            this.Pnl_ca.Location = Txt_descripcion_ar.Location;
            this.Pnl_ca.Visible = true;
        }

        private void Dgv_ca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_ca();
            Pnl_ca.Visible = false;
        }
    }
}