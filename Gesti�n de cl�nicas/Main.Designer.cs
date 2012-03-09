namespace Gestión_de_clínicas
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.barraMensajes = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu = new System.Windows.Forms.TabControl();
            this.tab_medicos = new System.Windows.Forms.TabPage();
            this.Med_mod = new System.Windows.Forms.Button();
            this.Med_del = new System.Windows.Forms.Button();
            this.Med_add = new System.Windows.Forms.Button();
            this.tab_auxiliares = new System.Windows.Forms.TabPage();
            this.Aux_mod = new System.Windows.Forms.Button();
            this.Aux_del = new System.Windows.Forms.Button();
            this.Aux_add = new System.Windows.Forms.Button();
            this.tab_pacientes = new System.Windows.Forms.TabPage();
            this.tab_administracion = new System.Windows.Forms.TabPage();
            this.adm_mod = new System.Windows.Forms.Button();
            this.adm_del = new System.Windows.Forms.Button();
            this.adm_add = new System.Windows.Forms.Button();
            this.tab_stock = new System.Windows.Forms.TabPage();
            this.tab_agendaCitas = new System.Windows.Forms.TabPage();
            this.tab_informes = new System.Windows.Forms.TabPage();
            this.tab_facturas = new System.Windows.Forms.TabPage();
            this.tab_mensajes = new System.Windows.Forms.TabPage();
            this.tab_servicios = new System.Windows.Forms.TabPage();
            this.tab_citas = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbMedicos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAuxiliares = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdministracion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStock = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInformes = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiArticulosEnZonaCritica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListadosDePrecios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFacturas = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiNuevaFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMensajes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbServicios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraMensajes.SuspendLayout();
            this.Menu.SuspendLayout();
            this.tab_medicos.SuspendLayout();
            this.tab_auxiliares.SuspendLayout();
            this.tab_administracion.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraMensajes
            // 
            this.barraMensajes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ts_Version});
            this.barraMensajes.Location = new System.Drawing.Point(0, 559);
            this.barraMensajes.Name = "barraMensajes";
            this.barraMensajes.Size = new System.Drawing.Size(1022, 22);
            this.barraMensajes.TabIndex = 1;
            this.barraMensajes.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "Gestión de Clínicas";
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tab_medicos);
            this.Menu.Controls.Add(this.tab_auxiliares);
            this.Menu.Controls.Add(this.tab_pacientes);
            this.Menu.Controls.Add(this.tab_administracion);
            this.Menu.Controls.Add(this.tab_stock);
            this.Menu.Controls.Add(this.tab_agendaCitas);
            this.Menu.Controls.Add(this.tab_informes);
            this.Menu.Controls.Add(this.tab_facturas);
            this.Menu.Controls.Add(this.tab_mensajes);
            this.Menu.Controls.Add(this.tab_servicios);
            this.Menu.Controls.Add(this.tab_citas);
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1024, 63);
            this.Menu.TabIndex = 2;
            this.Menu.SelectedIndexChanged += new System.EventHandler(this.Menu_SelectedIndexChanged);
            this.Menu.TabIndexChanged += new System.EventHandler(this.Menu_TabIndexChanged);
            // 
            // tab_medicos
            // 
            this.tab_medicos.Controls.Add(this.Med_mod);
            this.tab_medicos.Controls.Add(this.Med_del);
            this.tab_medicos.Controls.Add(this.Med_add);
            this.tab_medicos.Location = new System.Drawing.Point(4, 22);
            this.tab_medicos.Name = "tab_medicos";
            this.tab_medicos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_medicos.Size = new System.Drawing.Size(1016, 37);
            this.tab_medicos.TabIndex = 0;
            this.tab_medicos.Text = "Médicos";
            this.tab_medicos.UseVisualStyleBackColor = true;
            this.tab_medicos.Click += new System.EventHandler(this.tab_medicos_Click);
            // 
            // Med_mod
            // 
            this.Med_mod.Location = new System.Drawing.Point(162, 8);
            this.Med_mod.Name = "Med_mod";
            this.Med_mod.Size = new System.Drawing.Size(75, 23);
            this.Med_mod.TabIndex = 2;
            this.Med_mod.Text = "Modificar";
            this.Med_mod.UseVisualStyleBackColor = true;
            // 
            // Med_del
            // 
            this.Med_del.Location = new System.Drawing.Point(81, 8);
            this.Med_del.Name = "Med_del";
            this.Med_del.Size = new System.Drawing.Size(75, 23);
            this.Med_del.TabIndex = 1;
            this.Med_del.Text = "Eliminar";
            this.Med_del.UseVisualStyleBackColor = true;
            // 
            // Med_add
            // 
            this.Med_add.Location = new System.Drawing.Point(0, 8);
            this.Med_add.Name = "Med_add";
            this.Med_add.Size = new System.Drawing.Size(75, 23);
            this.Med_add.TabIndex = 0;
            this.Med_add.Text = "Añadir";
            this.Med_add.UseVisualStyleBackColor = true;
            // 
            // tab_auxiliares
            // 
            this.tab_auxiliares.Controls.Add(this.Aux_mod);
            this.tab_auxiliares.Controls.Add(this.Aux_del);
            this.tab_auxiliares.Controls.Add(this.Aux_add);
            this.tab_auxiliares.Location = new System.Drawing.Point(4, 22);
            this.tab_auxiliares.Name = "tab_auxiliares";
            this.tab_auxiliares.Padding = new System.Windows.Forms.Padding(3);
            this.tab_auxiliares.Size = new System.Drawing.Size(1016, 37);
            this.tab_auxiliares.TabIndex = 1;
            this.tab_auxiliares.Text = "Auxiliares";
            this.tab_auxiliares.UseVisualStyleBackColor = true;
            // 
            // Aux_mod
            // 
            this.Aux_mod.Location = new System.Drawing.Point(162, 8);
            this.Aux_mod.Name = "Aux_mod";
            this.Aux_mod.Size = new System.Drawing.Size(75, 23);
            this.Aux_mod.TabIndex = 5;
            this.Aux_mod.Text = "Modificar";
            this.Aux_mod.UseVisualStyleBackColor = true;
            // 
            // Aux_del
            // 
            this.Aux_del.Location = new System.Drawing.Point(81, 8);
            this.Aux_del.Name = "Aux_del";
            this.Aux_del.Size = new System.Drawing.Size(75, 23);
            this.Aux_del.TabIndex = 4;
            this.Aux_del.Text = "Eliminar";
            this.Aux_del.UseVisualStyleBackColor = true;
            // 
            // Aux_add
            // 
            this.Aux_add.Location = new System.Drawing.Point(0, 8);
            this.Aux_add.Name = "Aux_add";
            this.Aux_add.Size = new System.Drawing.Size(75, 23);
            this.Aux_add.TabIndex = 3;
            this.Aux_add.Text = "Añadir";
            this.Aux_add.UseVisualStyleBackColor = true;
            // 
            // tab_pacientes
            // 
            this.tab_pacientes.Location = new System.Drawing.Point(4, 22);
            this.tab_pacientes.Name = "tab_pacientes";
            this.tab_pacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pacientes.Size = new System.Drawing.Size(1016, 37);
            this.tab_pacientes.TabIndex = 2;
            this.tab_pacientes.Text = "Pacientes";
            this.tab_pacientes.UseVisualStyleBackColor = true;
            // 
            // tab_administracion
            // 
            this.tab_administracion.Controls.Add(this.adm_mod);
            this.tab_administracion.Controls.Add(this.adm_del);
            this.tab_administracion.Controls.Add(this.adm_add);
            this.tab_administracion.Location = new System.Drawing.Point(4, 22);
            this.tab_administracion.Name = "tab_administracion";
            this.tab_administracion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_administracion.Size = new System.Drawing.Size(1016, 37);
            this.tab_administracion.TabIndex = 10;
            this.tab_administracion.Text = "Administración";
            this.tab_administracion.UseVisualStyleBackColor = true;
            // 
            // adm_mod
            // 
            this.adm_mod.Location = new System.Drawing.Point(162, 8);
            this.adm_mod.Name = "adm_mod";
            this.adm_mod.Size = new System.Drawing.Size(75, 23);
            this.adm_mod.TabIndex = 5;
            this.adm_mod.Text = "Modificar";
            this.adm_mod.UseVisualStyleBackColor = true;
            // 
            // adm_del
            // 
            this.adm_del.Location = new System.Drawing.Point(81, 8);
            this.adm_del.Name = "adm_del";
            this.adm_del.Size = new System.Drawing.Size(75, 23);
            this.adm_del.TabIndex = 4;
            this.adm_del.Text = "Eliminar";
            this.adm_del.UseVisualStyleBackColor = true;
            // 
            // adm_add
            // 
            this.adm_add.Location = new System.Drawing.Point(0, 8);
            this.adm_add.Name = "adm_add";
            this.adm_add.Size = new System.Drawing.Size(75, 23);
            this.adm_add.TabIndex = 3;
            this.adm_add.Text = "Añadir";
            this.adm_add.UseVisualStyleBackColor = true;
            // 
            // tab_stock
            // 
            this.tab_stock.Location = new System.Drawing.Point(4, 22);
            this.tab_stock.Name = "tab_stock";
            this.tab_stock.Padding = new System.Windows.Forms.Padding(3);
            this.tab_stock.Size = new System.Drawing.Size(1016, 37);
            this.tab_stock.TabIndex = 3;
            this.tab_stock.Text = "Stock";
            this.tab_stock.UseVisualStyleBackColor = true;
            // 
            // tab_agendaCitas
            // 
            this.tab_agendaCitas.Location = new System.Drawing.Point(4, 22);
            this.tab_agendaCitas.Name = "tab_agendaCitas";
            this.tab_agendaCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_agendaCitas.Size = new System.Drawing.Size(1016, 37);
            this.tab_agendaCitas.TabIndex = 4;
            this.tab_agendaCitas.Text = "Agenda citas";
            this.tab_agendaCitas.UseVisualStyleBackColor = true;
            // 
            // tab_informes
            // 
            this.tab_informes.Location = new System.Drawing.Point(4, 22);
            this.tab_informes.Name = "tab_informes";
            this.tab_informes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_informes.Size = new System.Drawing.Size(1016, 37);
            this.tab_informes.TabIndex = 5;
            this.tab_informes.Text = "Informes";
            this.tab_informes.UseVisualStyleBackColor = true;
            // 
            // tab_facturas
            // 
            this.tab_facturas.Location = new System.Drawing.Point(4, 22);
            this.tab_facturas.Name = "tab_facturas";
            this.tab_facturas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_facturas.Size = new System.Drawing.Size(1016, 37);
            this.tab_facturas.TabIndex = 6;
            this.tab_facturas.Text = "Facturas";
            this.tab_facturas.UseVisualStyleBackColor = true;
            // 
            // tab_mensajes
            // 
            this.tab_mensajes.Location = new System.Drawing.Point(4, 22);
            this.tab_mensajes.Name = "tab_mensajes";
            this.tab_mensajes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mensajes.Size = new System.Drawing.Size(1016, 37);
            this.tab_mensajes.TabIndex = 7;
            this.tab_mensajes.Text = "Mensajes";
            this.tab_mensajes.UseVisualStyleBackColor = true;
            // 
            // tab_servicios
            // 
            this.tab_servicios.Location = new System.Drawing.Point(4, 22);
            this.tab_servicios.Name = "tab_servicios";
            this.tab_servicios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_servicios.Size = new System.Drawing.Size(1016, 37);
            this.tab_servicios.TabIndex = 8;
            this.tab_servicios.Text = "Servicios";
            this.tab_servicios.UseVisualStyleBackColor = true;
            // 
            // tab_citas
            // 
            this.tab_citas.Location = new System.Drawing.Point(4, 22);
            this.tab_citas.Name = "tab_citas";
            this.tab_citas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_citas.Size = new System.Drawing.Size(1016, 37);
            this.tab_citas.TabIndex = 9;
            this.tab_citas.Text = "Citas";
            this.tab_citas.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMedicos,
            this.toolStripSeparator11,
            this.tsbAuxiliares,
            this.toolStripSeparator10,
            this.tsbPacientes,
            this.toolStripSeparator9,
            this.tsbAdministracion,
            this.toolStripSeparator8,
            this.tsbStock,
            this.toolStripSeparator7,
            this.tsbAgenda,
            this.toolStripSeparator6,
            this.tsbInformes,
            this.toolStripSeparator5,
            this.tsbFacturas,
            this.toolStripSeparator1,
            this.tsbMensajes,
            this.toolStripSeparator2,
            this.tsbServicios,
            this.toolStripSeparator3,
            this.tsbSalir,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 72);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbMedicos
            // 
            this.tsbMedicos.Image = ((System.Drawing.Image)(resources.GetObject("tsbMedicos.Image")));
            this.tsbMedicos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbMedicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMedicos.Name = "tsbMedicos";
            this.tsbMedicos.Size = new System.Drawing.Size(56, 69);
            this.tsbMedicos.Text = "Medicos";
            this.tsbMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbMedicos.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbAuxiliares
            // 
            this.tsbAuxiliares.Image = ((System.Drawing.Image)(resources.GetObject("tsbAuxiliares.Image")));
            this.tsbAuxiliares.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbAuxiliares.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAuxiliares.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAuxiliares.Name = "tsbAuxiliares";
            this.tsbAuxiliares.Size = new System.Drawing.Size(61, 69);
            this.tsbAuxiliares.Text = "Auxiliares";
            this.tsbAuxiliares.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbAuxiliares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAuxiliares.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbPacientes
            // 
            this.tsbPacientes.Image = ((System.Drawing.Image)(resources.GetObject("tsbPacientes.Image")));
            this.tsbPacientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPacientes.Name = "tsbPacientes";
            this.tsbPacientes.Size = new System.Drawing.Size(61, 69);
            this.tsbPacientes.Text = "Pacientes";
            this.tsbPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPacientes.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbAdministracion
            // 
            this.tsbAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdministracion.Image")));
            this.tsbAdministracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbAdministracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdministracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdministracion.Name = "tsbAdministracion";
            this.tsbAdministracion.Size = new System.Drawing.Size(92, 69);
            this.tsbAdministracion.Text = "Administracion";
            this.tsbAdministracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAdministracion.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbStock
            // 
            this.tsbStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbStock.Image = ((System.Drawing.Image)(resources.GetObject("tsbStock.Image")));
            this.tsbStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStock.Name = "tsbStock";
            this.tsbStock.Size = new System.Drawing.Size(52, 69);
            this.tsbStock.Text = "Stock";
            this.tsbStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbStock.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbAgenda
            // 
            this.tsbAgenda.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgenda.Image")));
            this.tsbAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgenda.Name = "tsbAgenda";
            this.tsbAgenda.Size = new System.Drawing.Size(52, 69);
            this.tsbAgenda.Text = "Agenda";
            this.tsbAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAgenda.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbInformes
            // 
            this.tsbInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArticulosEnZonaCritica,
            this.tsmiListadosDePrecios,
            this.tsmiEstadisticas});
            this.tsbInformes.Image = ((System.Drawing.Image)(resources.GetObject("tsbInformes.Image")));
            this.tsbInformes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInformes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInformes.Name = "tsbInformes";
            this.tsbInformes.Size = new System.Drawing.Size(70, 69);
            this.tsbInformes.Text = "Informes";
            this.tsbInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInformes.ButtonClick += new System.EventHandler(this.toolStripButton5_ButtonClick);
            // 
            // tsmiArticulosEnZonaCritica
            // 
            this.tsmiArticulosEnZonaCritica.Name = "tsmiArticulosEnZonaCritica";
            this.tsmiArticulosEnZonaCritica.Size = new System.Drawing.Size(200, 22);
            this.tsmiArticulosEnZonaCritica.Text = "Artículos en zona crítica";
            // 
            // tsmiListadosDePrecios
            // 
            this.tsmiListadosDePrecios.Name = "tsmiListadosDePrecios";
            this.tsmiListadosDePrecios.Size = new System.Drawing.Size(200, 22);
            this.tsmiListadosDePrecios.Text = "Listados de precios";
            // 
            // tsmiEstadisticas
            // 
            this.tsmiEstadisticas.Name = "tsmiEstadisticas";
            this.tsmiEstadisticas.Size = new System.Drawing.Size(200, 22);
            this.tsmiEstadisticas.Text = "Estadísticas";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbFacturas
            // 
            this.tsbFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbFacturas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevaFactura,
            this.tsmiVerFacturas});
            this.tsbFacturas.Image = ((System.Drawing.Image)(resources.GetObject("tsbFacturas.Image")));
            this.tsbFacturas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbFacturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFacturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFacturas.Name = "tsbFacturas";
            this.tsbFacturas.Size = new System.Drawing.Size(67, 69);
            this.tsbFacturas.Text = "Facturas";
            this.tsbFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbFacturas.ButtonClick += new System.EventHandler(this.toolStripButton1_ButtonClick);
            this.tsbFacturas.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsmiNuevaFactura
            // 
            this.tsmiNuevaFactura.Name = "tsmiNuevaFactura";
            this.tsmiNuevaFactura.Size = new System.Drawing.Size(148, 22);
            this.tsmiNuevaFactura.Text = "Nueva factura";
            // 
            // tsmiVerFacturas
            // 
            this.tsmiVerFacturas.Name = "tsmiVerFacturas";
            this.tsmiVerFacturas.Size = new System.Drawing.Size(148, 22);
            this.tsmiVerFacturas.Text = "Ver facturas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbMensajes
            // 
            this.tsbMensajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbMensajes.Image = ((System.Drawing.Image)(resources.GetObject("tsbMensajes.Image")));
            this.tsbMensajes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbMensajes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMensajes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMensajes.Name = "tsbMensajes";
            this.tsbMensajes.Size = new System.Drawing.Size(60, 69);
            this.tsbMensajes.Text = "Mensajes";
            this.tsbMensajes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbMensajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbMensajes.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbServicios
            // 
            this.tsbServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbServicios.Image = ((System.Drawing.Image)(resources.GetObject("tsbServicios.Image")));
            this.tsbServicios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbServicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbServicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServicios.Name = "tsbServicios";
            this.tsbServicios.Size = new System.Drawing.Size(57, 69);
            this.tsbServicios.Text = "Servicios";
            this.tsbServicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbServicios.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 72);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(52, 69);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 72);
            // 
            // ts_Version
            // 
            this.ts_Version.Name = "ts_Version";
            this.ts_Version.Size = new System.Drawing.Size(31, 17);
            this.ts_Version.Text = "v 1.0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 581);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.barraMensajes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Gestión Clínica";
            this.Load += new System.EventHandler(this.Main_Load);
            this.barraMensajes.ResumeLayout(false);
            this.barraMensajes.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.tab_medicos.ResumeLayout(false);
            this.tab_auxiliares.ResumeLayout(false);
            this.tab_administracion.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraMensajes;
        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tab_medicos;
        private System.Windows.Forms.TabPage tab_auxiliares;
        private System.Windows.Forms.TabPage tab_pacientes;
        private System.Windows.Forms.TabPage tab_stock;
        private System.Windows.Forms.TabPage tab_agendaCitas;
        private System.Windows.Forms.TabPage tab_informes;
        private System.Windows.Forms.TabPage tab_facturas;
        private System.Windows.Forms.TabPage tab_mensajes;
        private System.Windows.Forms.TabPage tab_servicios;
        private System.Windows.Forms.TabPage tab_citas;
        private System.Windows.Forms.Button Med_mod;
        private System.Windows.Forms.Button Med_del;
        private System.Windows.Forms.Button Med_add;
        private System.Windows.Forms.Button Aux_mod;
        private System.Windows.Forms.Button Aux_del;
        private System.Windows.Forms.Button Aux_add;
        private System.Windows.Forms.TabPage tab_administracion;
        private System.Windows.Forms.Button adm_mod;
        private System.Windows.Forms.Button adm_del;
        private System.Windows.Forms.Button adm_add;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbMedicos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsbAuxiliares;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbAdministracion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbAgenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbMensajes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbServicios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton tsbInformes;
        private System.Windows.Forms.ToolStripMenuItem tsmiArticulosEnZonaCritica;
        private System.Windows.Forms.ToolStripMenuItem tsmiListadosDePrecios;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstadisticas;
        private System.Windows.Forms.ToolStripSplitButton tsbFacturas;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevaFactura;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerFacturas;
        private System.Windows.Forms.ToolStripStatusLabel ts_Version;
    }
}

