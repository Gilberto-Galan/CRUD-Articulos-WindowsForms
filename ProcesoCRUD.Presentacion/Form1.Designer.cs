namespace ProcesoCRUD.Presentacion
{
    partial class Frm_Articulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Articulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_botonesprincipales = new System.Windows.Forms.Panel();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Pnl_detalle = new System.Windows.Forms.Panel();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_lupa_ca = new System.Windows.Forms.Button();
            this.Btn_lupa_me = new System.Windows.Forms.Button();
            this.Txt_descripcion_ca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_descripcion_me = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_marca_ar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_descripcion_ar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pnl_resumen = new System.Windows.Forms.Panel();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_resumen = new System.Windows.Forms.DataGridView();
            this.Pnl_me = new System.Windows.Forms.Panel();
            this.Dgv_me = new System.Windows.Forms.DataGridView();
            this.Btn_retornar_me = new System.Windows.Forms.Button();
            this.Pnl_ca = new System.Windows.Forms.Panel();
            this.Btn_retornar_ca = new System.Windows.Forms.Button();
            this.Dgv_ca = new System.Windows.Forms.DataGridView();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_botonesprincipales.SuspendLayout();
            this.Pnl_detalle.SuspendLayout();
            this.Pnl_resumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resumen)).BeginInit();
            this.Pnl_me.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_me)).BeginInit();
            this.Pnl_ca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ca)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_titulo.Controls.Add(this.Label1);
            this.Pnl_titulo.Controls.Add(this.pictureBox1);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(959, 64);
            this.Pnl_titulo.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(69, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 26);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Articulos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pnl_botonesprincipales
            // 
            this.Pnl_botonesprincipales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_botonesprincipales.Controls.Add(this.Btn_salir);
            this.Pnl_botonesprincipales.Controls.Add(this.Btn_reporte);
            this.Pnl_botonesprincipales.Controls.Add(this.Btn_eliminar);
            this.Pnl_botonesprincipales.Controls.Add(this.Btn_actualizar);
            this.Pnl_botonesprincipales.Controls.Add(this.Btn_nuevo);
            this.Pnl_botonesprincipales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_botonesprincipales.Location = new System.Drawing.Point(0, 396);
            this.Pnl_botonesprincipales.Name = "Pnl_botonesprincipales";
            this.Pnl_botonesprincipales.Size = new System.Drawing.Size(959, 107);
            this.Pnl_botonesprincipales.TabIndex = 1;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_salir.ImageKey = "logout.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(849, 15);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(97, 79);
            this.Btn_salir.TabIndex = 4;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "archivo.png");
            this.imageList1.Images.SetKeyName(1, "editar-documento.png");
            this.imageList1.Images.SetKeyName(2, "expediente.png");
            this.imageList1.Images.SetKeyName(3, "logout.png");
            this.imageList1.Images.SetKeyName(4, "nuevo-documento.png");
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.Transparent;
            this.Btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_reporte.ImageKey = "archivo.png";
            this.Btn_reporte.ImageList = this.imageList1;
            this.Btn_reporte.Location = new System.Drawing.Point(746, 15);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(97, 79);
            this.Btn_reporte.TabIndex = 3;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_eliminar.ImageKey = "expediente.png";
            this.Btn_eliminar.ImageList = this.imageList1;
            this.Btn_eliminar.Location = new System.Drawing.Point(643, 15);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(97, 79);
            this.Btn_eliminar.TabIndex = 2;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_actualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_actualizar.ImageKey = "editar-documento.png";
            this.Btn_actualizar.ImageList = this.imageList1;
            this.Btn_actualizar.Location = new System.Drawing.Point(540, 15);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(97, 79);
            this.Btn_actualizar.TabIndex = 1;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nuevo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_nuevo.ImageKey = "nuevo-documento.png";
            this.Btn_nuevo.ImageList = this.imageList1;
            this.Btn_nuevo.Location = new System.Drawing.Point(437, 15);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(97, 79);
            this.Btn_nuevo.TabIndex = 0;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Pnl_detalle
            // 
            this.Pnl_detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_detalle.Controls.Add(this.Pnl_me);
            this.Pnl_detalle.Controls.Add(this.Btn_guardar);
            this.Pnl_detalle.Controls.Add(this.Btn_cancelar);
            this.Pnl_detalle.Controls.Add(this.Btn_lupa_ca);
            this.Pnl_detalle.Controls.Add(this.Btn_lupa_me);
            this.Pnl_detalle.Controls.Add(this.Txt_descripcion_ca);
            this.Pnl_detalle.Controls.Add(this.label6);
            this.Pnl_detalle.Controls.Add(this.Txt_descripcion_me);
            this.Pnl_detalle.Controls.Add(this.label5);
            this.Pnl_detalle.Controls.Add(this.Txt_marca_ar);
            this.Pnl_detalle.Controls.Add(this.label4);
            this.Pnl_detalle.Controls.Add(this.Txt_descripcion_ar);
            this.Pnl_detalle.Controls.Add(this.label3);
            this.Pnl_detalle.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_detalle.Location = new System.Drawing.Point(653, 64);
            this.Pnl_detalle.Name = "Pnl_detalle";
            this.Pnl_detalle.Size = new System.Drawing.Size(306, 332);
            this.Pnl_detalle.TabIndex = 2;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_guardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(167, 271);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(100, 39);
            this.Btn_guardar.TabIndex = 13;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.Location = new System.Drawing.Point(61, 271);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(100, 39);
            this.Btn_cancelar.TabIndex = 4;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_lupa_ca
            // 
            this.Btn_lupa_ca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_lupa_ca.Location = new System.Drawing.Point(218, 226);
            this.Btn_lupa_ca.Name = "Btn_lupa_ca";
            this.Btn_lupa_ca.Size = new System.Drawing.Size(75, 27);
            this.Btn_lupa_ca.TabIndex = 12;
            this.Btn_lupa_ca.Text = ":::";
            this.Btn_lupa_ca.UseVisualStyleBackColor = true;
            this.Btn_lupa_ca.Visible = false;
            this.Btn_lupa_ca.Click += new System.EventHandler(this.Btn_lupa_ca_Click);
            // 
            // Btn_lupa_me
            // 
            this.Btn_lupa_me.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_lupa_me.Location = new System.Drawing.Point(218, 161);
            this.Btn_lupa_me.Name = "Btn_lupa_me";
            this.Btn_lupa_me.Size = new System.Drawing.Size(75, 27);
            this.Btn_lupa_me.TabIndex = 4;
            this.Btn_lupa_me.Text = ":::";
            this.Btn_lupa_me.UseVisualStyleBackColor = true;
            this.Btn_lupa_me.Visible = false;
            this.Btn_lupa_me.Click += new System.EventHandler(this.Btn_lupa_me_Click);
            // 
            // Txt_descripcion_ca
            // 
            this.Txt_descripcion_ca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion_ca.Location = new System.Drawing.Point(9, 226);
            this.Txt_descripcion_ca.Name = "Txt_descripcion_ca";
            this.Txt_descripcion_ca.ReadOnly = true;
            this.Txt_descripcion_ca.Size = new System.Drawing.Size(203, 27);
            this.Txt_descripcion_ca.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categoria:";
            // 
            // Txt_descripcion_me
            // 
            this.Txt_descripcion_me.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion_me.Location = new System.Drawing.Point(9, 161);
            this.Txt_descripcion_me.Name = "Txt_descripcion_me";
            this.Txt_descripcion_me.ReadOnly = true;
            this.Txt_descripcion_me.Size = new System.Drawing.Size(203, 27);
            this.Txt_descripcion_me.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Medida:";
            // 
            // Txt_marca_ar
            // 
            this.Txt_marca_ar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_marca_ar.Location = new System.Drawing.Point(9, 99);
            this.Txt_marca_ar.Name = "Txt_marca_ar";
            this.Txt_marca_ar.ReadOnly = true;
            this.Txt_marca_ar.Size = new System.Drawing.Size(284, 27);
            this.Txt_marca_ar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca:";
            // 
            // Txt_descripcion_ar
            // 
            this.Txt_descripcion_ar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion_ar.Location = new System.Drawing.Point(9, 33);
            this.Txt_descripcion_ar.Name = "Txt_descripcion_ar";
            this.Txt_descripcion_ar.ReadOnly = true;
            this.Txt_descripcion_ar.Size = new System.Drawing.Size(284, 27);
            this.Txt_descripcion_ar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Articulo:";
            // 
            // Pnl_resumen
            // 
            this.Pnl_resumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_resumen.Controls.Add(this.Pnl_ca);
            this.Pnl_resumen.Controls.Add(this.Btn_buscar);
            this.Pnl_resumen.Controls.Add(this.Txt_buscar);
            this.Pnl_resumen.Controls.Add(this.label2);
            this.Pnl_resumen.Controls.Add(this.Dgv_resumen);
            this.Pnl_resumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_resumen.Location = new System.Drawing.Point(0, 64);
            this.Pnl_resumen.Name = "Pnl_resumen";
            this.Pnl_resumen.Size = new System.Drawing.Size(653, 332);
            this.Pnl_resumen.TabIndex = 3;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_buscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar.Location = new System.Drawing.Point(339, 44);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 27);
            this.Btn_buscar.TabIndex = 3;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(74, 44);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(247, 27);
            this.Txt_buscar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // Dgv_resumen
            // 
            this.Dgv_resumen.AllowUserToAddRows = false;
            this.Dgv_resumen.AllowUserToDeleteRows = false;
            this.Dgv_resumen.AllowUserToOrderColumns = true;
            this.Dgv_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_resumen.Location = new System.Drawing.Point(12, 77);
            this.Dgv_resumen.Name = "Dgv_resumen";
            this.Dgv_resumen.ReadOnly = true;
            this.Dgv_resumen.Size = new System.Drawing.Size(625, 233);
            this.Dgv_resumen.TabIndex = 0;
            this.Dgv_resumen.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_resumen_CellEnter);
            // 
            // Pnl_me
            // 
            this.Pnl_me.BackColor = System.Drawing.Color.AliceBlue;
            this.Pnl_me.Controls.Add(this.Btn_retornar_me);
            this.Pnl_me.Controls.Add(this.Dgv_me);
            this.Pnl_me.Location = new System.Drawing.Point(5, 47);
            this.Pnl_me.Name = "Pnl_me";
            this.Pnl_me.Size = new System.Drawing.Size(203, 187);
            this.Pnl_me.TabIndex = 14;
            this.Pnl_me.Visible = false;
            // 
            // Dgv_me
            // 
            this.Dgv_me.AllowUserToAddRows = false;
            this.Dgv_me.AllowUserToDeleteRows = false;
            this.Dgv_me.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_me.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_me.ColumnHeadersHeight = 30;
            this.Dgv_me.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_me.Location = new System.Drawing.Point(0, 0);
            this.Dgv_me.Name = "Dgv_me";
            this.Dgv_me.ReadOnly = true;
            this.Dgv_me.Size = new System.Drawing.Size(203, 153);
            this.Dgv_me.TabIndex = 4;
            this.Dgv_me.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_me_CellDoubleClick);
            // 
            // Btn_retornar_me
            // 
            this.Btn_retornar_me.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_retornar_me.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retornar_me.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_retornar_me.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_retornar_me.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar_me.Location = new System.Drawing.Point(3, 157);
            this.Btn_retornar_me.Name = "Btn_retornar_me";
            this.Btn_retornar_me.Size = new System.Drawing.Size(197, 27);
            this.Btn_retornar_me.TabIndex = 4;
            this.Btn_retornar_me.Text = "Retornar";
            this.Btn_retornar_me.UseVisualStyleBackColor = false;
            this.Btn_retornar_me.Click += new System.EventHandler(this.Btn_retornar_me_Click);
            // 
            // Pnl_ca
            // 
            this.Pnl_ca.BackColor = System.Drawing.Color.AliceBlue;
            this.Pnl_ca.Controls.Add(this.Btn_retornar_ca);
            this.Pnl_ca.Controls.Add(this.Dgv_ca);
            this.Pnl_ca.Location = new System.Drawing.Point(437, 47);
            this.Pnl_ca.Name = "Pnl_ca";
            this.Pnl_ca.Size = new System.Drawing.Size(203, 187);
            this.Pnl_ca.TabIndex = 15;
            this.Pnl_ca.Visible = false;
            // 
            // Btn_retornar_ca
            // 
            this.Btn_retornar_ca.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_retornar_ca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retornar_ca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_retornar_ca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_retornar_ca.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar_ca.Location = new System.Drawing.Point(3, 157);
            this.Btn_retornar_ca.Name = "Btn_retornar_ca";
            this.Btn_retornar_ca.Size = new System.Drawing.Size(197, 27);
            this.Btn_retornar_ca.TabIndex = 4;
            this.Btn_retornar_ca.Text = "Retornar";
            this.Btn_retornar_ca.UseVisualStyleBackColor = false;
            this.Btn_retornar_ca.Click += new System.EventHandler(this.Btn_retornar_ca_Click);
            // 
            // Dgv_ca
            // 
            this.Dgv_ca.AllowUserToAddRows = false;
            this.Dgv_ca.AllowUserToDeleteRows = false;
            this.Dgv_ca.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_ca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_ca.ColumnHeadersHeight = 30;
            this.Dgv_ca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_ca.Location = new System.Drawing.Point(0, 0);
            this.Dgv_ca.Name = "Dgv_ca";
            this.Dgv_ca.ReadOnly = true;
            this.Dgv_ca.Size = new System.Drawing.Size(203, 153);
            this.Dgv_ca.TabIndex = 4;
            this.Dgv_ca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ca_CellDoubleClick);
            // 
            // Frm_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 503);
            this.Controls.Add(this.Pnl_resumen);
            this.Controls.Add(this.Pnl_detalle);
            this.Controls.Add(this.Pnl_botonesprincipales);
            this.Controls.Add(this.Pnl_titulo);
            this.Name = "Frm_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Articulos";
            this.Load += new System.EventHandler(this.Frm_Articulos_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_botonesprincipales.ResumeLayout(false);
            this.Pnl_detalle.ResumeLayout(false);
            this.Pnl_detalle.PerformLayout();
            this.Pnl_resumen.ResumeLayout(false);
            this.Pnl_resumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resumen)).EndInit();
            this.Pnl_me.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_me)).EndInit();
            this.Pnl_ca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Panel Pnl_botonesprincipales;
        private System.Windows.Forms.Panel Pnl_detalle;
        private System.Windows.Forms.Panel Pnl_resumen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_resumen;
        private System.Windows.Forms.TextBox Txt_descripcion_ca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_descripcion_me;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_marca_ar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_descripcion_ar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_lupa_ca;
        private System.Windows.Forms.Button Btn_lupa_me;
        private System.Windows.Forms.Panel Pnl_me;
        private System.Windows.Forms.Button Btn_retornar_me;
        private System.Windows.Forms.DataGridView Dgv_me;
        private System.Windows.Forms.Panel Pnl_ca;
        private System.Windows.Forms.Button Btn_retornar_ca;
        private System.Windows.Forms.DataGridView Dgv_ca;
    }
}

