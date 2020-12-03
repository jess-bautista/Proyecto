namespace Proyecto
{
    partial class Inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.rdBuscar = new System.Windows.Forms.RadioButton();
            this.rdnAgregar = new System.Windows.Forms.RadioButton();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.rdDescripcion = new System.Windows.Forms.RadioButton();
            this.rdClave = new System.Windows.Forms.RadioButton();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rdDesactivar = new System.Windows.Forms.RadioButton();
            this.panelDesactivar = new System.Windows.Forms.Panel();
            this.table2 = new System.Windows.Forms.DataGridView();
            this.table1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.activar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminarD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.panelAgregar.SuspendLayout();
            this.panelDesactivar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdBuscar
            // 
            this.rdBuscar.AutoSize = true;
            this.rdBuscar.BackColor = System.Drawing.Color.Transparent;
            this.rdBuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdBuscar.ImageKey = "(ninguno)";
            this.rdBuscar.Location = new System.Drawing.Point(94, 85);
            this.rdBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.rdBuscar.Name = "rdBuscar";
            this.rdBuscar.Size = new System.Drawing.Size(153, 36);
            this.rdBuscar.TabIndex = 1;
            this.rdBuscar.TabStop = true;
            this.rdBuscar.Text = "Buscar";
            this.rdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdBuscar.UseVisualStyleBackColor = false;
            this.rdBuscar.Click += new System.EventHandler(this.rdBuscar_Click);
            // 
            // rdnAgregar
            // 
            this.rdnAgregar.AutoSize = true;
            this.rdnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.rdnAgregar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnAgregar.Image = global::Proyecto.Properties.Resources.agregar;
            this.rdnAgregar.Location = new System.Drawing.Point(432, 85);
            this.rdnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.rdnAgregar.Name = "rdnAgregar";
            this.rdnAgregar.Size = new System.Drawing.Size(210, 36);
            this.rdnAgregar.TabIndex = 2;
            this.rdnAgregar.TabStop = true;
            this.rdnAgregar.Text = "Agregar";
            this.rdnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdnAgregar.UseVisualStyleBackColor = false;
            this.rdnAgregar.Click += new System.EventHandler(this.rdnAgregar_Click);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.panelBusqueda.Controls.Add(this.dataTable);
            this.panelBusqueda.Controls.Add(this.rdDescripcion);
            this.panelBusqueda.Controls.Add(this.rdClave);
            this.panelBusqueda.Controls.Add(this.btnBusqueda);
            this.panelBusqueda.Controls.Add(this.txtBusqueda);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Location = new System.Drawing.Point(16, 140);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1169, 457);
            this.panelBusqueda.TabIndex = 5;
            this.panelBusqueda.Visible = false;
            
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(439, 92);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(692, 278);
            this.dataTable.TabIndex = 8;
            // 
            // rdDescripcion
            // 
            this.rdDescripcion.AutoSize = true;
            this.rdDescripcion.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDescripcion.Location = new System.Drawing.Point(168, 113);
            this.rdDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rdDescripcion.Name = "rdDescripcion";
            this.rdDescripcion.Size = new System.Drawing.Size(199, 44);
            this.rdDescripcion.TabIndex = 7;
            this.rdDescripcion.TabStop = true;
            this.rdDescripcion.Text = "Descripcion";
            this.rdDescripcion.UseVisualStyleBackColor = true;
            // 
            // rdClave
            // 
            this.rdClave.AutoSize = true;
            this.rdClave.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdClave.Location = new System.Drawing.Point(27, 113);
            this.rdClave.Margin = new System.Windows.Forms.Padding(4);
            this.rdClave.Name = "rdClave";
            this.rdClave.Size = new System.Drawing.Size(112, 44);
            this.rdClave.TabIndex = 6;
            this.rdClave.TabStop = true;
            this.rdClave.Text = "Clave";
            this.rdClave.UseVisualStyleBackColor = true;
            
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBusqueda.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBusqueda.Image = global::Proyecto.Properties.Resources.busqueda;
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(95, 219);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(193, 60);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(49, 174);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(296, 34);
            this.txtBusqueda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busqueda";
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.Transparent;
            this.panelAgregar.Controls.Add(this.dgvA);
            this.panelAgregar.Controls.Add(this.btnAgregar);
            this.panelAgregar.Controls.Add(this.txtPrecio);
            this.panelAgregar.Controls.Add(this.txtCantidad);
            this.panelAgregar.Controls.Add(this.txtMarca);
            this.panelAgregar.Controls.Add(this.txtDescripcion);
            this.panelAgregar.Controls.Add(this.txtClave);
            this.panelAgregar.Controls.Add(this.label8);
            this.panelAgregar.Controls.Add(this.label7);
            this.panelAgregar.Controls.Add(this.label6);
            this.panelAgregar.Controls.Add(this.label5);
            this.panelAgregar.Controls.Add(this.label4);
            this.panelAgregar.Controls.Add(this.lblTitulo);
            this.panelAgregar.Controls.Add(this.btnActualizar);
            this.panelAgregar.Location = new System.Drawing.Point(12, 137);
            this.panelAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(1169, 457);
            this.panelAgregar.TabIndex = 8;
            this.panelAgregar.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(163, 363);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 41);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(180, 305);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(256, 32);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(180, 250);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(256, 32);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(180, 196);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(256, 32);
            this.txtMarca.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(180, 140);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(256, 32);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(180, 89);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(256, 32);
            this.txtClave.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Clave";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(544, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(163, 363);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 41);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalir.Image = global::Proyecto.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(1035, 588);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 70);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rdDesactivar
            // 
            this.rdDesactivar.AutoSize = true;
            this.rdDesactivar.BackColor = System.Drawing.Color.Transparent;
            this.rdDesactivar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDesactivar.Location = new System.Drawing.Point(764, 85);
            this.rdDesactivar.Margin = new System.Windows.Forms.Padding(4);
            this.rdDesactivar.Name = "rdDesactivar";
            this.rdDesactivar.Size = new System.Drawing.Size(397, 36);
            this.rdDesactivar.TabIndex = 4;
            this.rdDesactivar.TabStop = true;
            this.rdDesactivar.Text = "Eliminar - ACTUALIZAR";
            this.rdDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdDesactivar.UseVisualStyleBackColor = false;
            this.rdDesactivar.Click += new System.EventHandler(this.rdDesactivar_Click);
            // 
            // panelDesactivar
            // 
            this.panelDesactivar.BackColor = System.Drawing.Color.Transparent;
            this.panelDesactivar.Controls.Add(this.table2);
            this.panelDesactivar.Controls.Add(this.table1);
            this.panelDesactivar.Controls.Add(this.label10);
            this.panelDesactivar.Controls.Add(this.label3);
            this.panelDesactivar.Location = new System.Drawing.Point(12, 137);
            this.panelDesactivar.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesactivar.Name = "panelDesactivar";
            this.panelDesactivar.Size = new System.Drawing.Size(1173, 460);
            this.panelDesactivar.TabIndex = 14;
            // 
            // table2
            // 
            this.table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activar,
            this.eliminarD});
            this.table2.Location = new System.Drawing.Point(326, 256);
            this.table2.Name = "table2";
            this.table2.RowHeadersWidth = 51;
            this.table2.RowTemplate.Height = 24;
            this.table2.Size = new System.Drawing.Size(815, 164);
            this.table2.TabIndex = 6;
            this.table2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick_1);
            // 
            // table1
            // 
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.update,
            this.delete});
            this.table1.Location = new System.Drawing.Point(21, 88);
            this.table1.Name = "table1";
            this.table1.RowHeadersWidth = 51;
            this.table1.RowTemplate.Height = 24;
            this.table1.Size = new System.Drawing.Size(1128, 150);
            this.table1.TabIndex = 5;
            this.table1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 35);
            this.label10.TabIndex = 3;
            this.label10.Text = "Articulos inactivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eliminar";
            // 
            // update
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update.DefaultCellStyle = dataGridViewCellStyle3;
            this.update.HeaderText = "Modificar";
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            this.update.Text = "Modificar";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 125;
            // 
            // delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.HeaderText = "Desactivar";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Text = "Desactivar";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // activar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.activar.DefaultCellStyle = dataGridViewCellStyle1;
            this.activar.HeaderText = "Activar";
            this.activar.MinimumWidth = 6;
            this.activar.Name = "activar";
            this.activar.Text = "Activar";
            this.activar.UseColumnTextForButtonValue = true;
            this.activar.Width = 125;
            // 
            // eliminarD
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
            this.eliminarD.DefaultCellStyle = dataGridViewCellStyle2;
            this.eliminarD.HeaderText = "Eliminar";
            this.eliminarD.MinimumWidth = 6;
            this.eliminarD.Name = "eliminarD";
            this.eliminarD.Text = "Eliminar";
            this.eliminarD.UseColumnTextForButtonValue = true;
            this.eliminarD.Width = 125;
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(477, 89);
            this.dgvA.Name = "dgvA";
            this.dgvA.RowHeadersWidth = 51;
            this.dgvA.RowTemplate.Height = 24;
            this.dgvA.Size = new System.Drawing.Size(672, 270);
            this.dgvA.TabIndex = 14;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 673);
            this.Controls.Add(this.rdDesactivar);
            this.Controls.Add(this.rdnAgregar);
            this.Controls.Add(this.rdBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelDesactivar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de tienda";
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            this.panelDesactivar.ResumeLayout(false);
            this.panelDesactivar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBuscar;
        private System.Windows.Forms.RadioButton rdnAgregar;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rdDescripcion;
        private System.Windows.Forms.RadioButton rdClave;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdDesactivar;
        private System.Windows.Forms.Panel panelDesactivar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.DataGridView table2;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn activar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarD;
        private System.Windows.Forms.DataGridView dgvA;
    }
}

