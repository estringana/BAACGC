namespace Gestión_de_clínicas
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbActualizaStock = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lArticuloActualizar = new System.Windows.Forms.Label();
            this.nudStockActual = new System.Windows.Forms.NumericUpDown();
            this.lStockActual = new System.Windows.Forms.Label();
            this.cbArticuloActualizar = new System.Windows.Forms.ComboBox();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lArticuloBuscar = new System.Windows.Forms.Label();
            this.tbArticuloBuscar = new System.Windows.Forms.TextBox();
            this.gbAltaRapidaArticulos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudLimiteStock = new System.Windows.Forms.NumericUpDown();
            this.nudStockInicial = new System.Windows.Forms.NumericUpDown();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lLimiteStock = new System.Windows.Forms.Label();
            this.lStockInicial = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.dgvArticulosStock = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaUActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbActualizaStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbAltaRapidaArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosStock)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbActualizaStock);
            this.splitContainer1.Panel1.Controls.Add(this.gbBusqueda);
            this.splitContainer1.Panel1.Controls.Add(this.gbAltaRapidaArticulos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvArticulosStock);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 482);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbActualizaStock
            // 
            this.gbActualizaStock.Controls.Add(this.pictureBox3);
            this.gbActualizaStock.Controls.Add(this.lArticuloActualizar);
            this.gbActualizaStock.Controls.Add(this.nudStockActual);
            this.gbActualizaStock.Controls.Add(this.lStockActual);
            this.gbActualizaStock.Controls.Add(this.cbArticuloActualizar);
            this.gbActualizaStock.Location = new System.Drawing.Point(221, 3);
            this.gbActualizaStock.Name = "gbActualizaStock";
            this.gbActualizaStock.Size = new System.Drawing.Size(343, 72);
            this.gbActualizaStock.TabIndex = 3;
            this.gbActualizaStock.TabStop = false;
            this.gbActualizaStock.Text = "Actualiza stock";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(301, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lArticuloActualizar
            // 
            this.lArticuloActualizar.AutoSize = true;
            this.lArticuloActualizar.Location = new System.Drawing.Point(12, 16);
            this.lArticuloActualizar.Name = "lArticuloActualizar";
            this.lArticuloActualizar.Size = new System.Drawing.Size(101, 13);
            this.lArticuloActualizar.TabIndex = 8;
            this.lArticuloActualizar.Text = "Artículo a actualizar";
            // 
            // nudStockActual
            // 
            this.nudStockActual.Location = new System.Drawing.Point(222, 37);
            this.nudStockActual.Name = "nudStockActual";
            this.nudStockActual.Size = new System.Drawing.Size(61, 20);
            this.nudStockActual.TabIndex = 9;
            // 
            // lStockActual
            // 
            this.lStockActual.AutoSize = true;
            this.lStockActual.Location = new System.Drawing.Point(219, 15);
            this.lStockActual.Name = "lStockActual";
            this.lStockActual.Size = new System.Drawing.Size(67, 13);
            this.lStockActual.TabIndex = 8;
            this.lStockActual.Text = "Stock actual";
            // 
            // cbArticuloActualizar
            // 
            this.cbArticuloActualizar.FormattingEnabled = true;
            this.cbArticuloActualizar.Location = new System.Drawing.Point(15, 37);
            this.cbArticuloActualizar.Name = "cbArticuloActualizar";
            this.cbArticuloActualizar.Size = new System.Drawing.Size(201, 21);
            this.cbArticuloActualizar.TabIndex = 0;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.pictureBox2);
            this.gbBusqueda.Controls.Add(this.lArticuloBuscar);
            this.gbBusqueda.Controls.Add(this.tbArticuloBuscar);
            this.gbBusqueda.Location = new System.Drawing.Point(3, 3);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(212, 72);
            this.gbBusqueda.TabIndex = 2;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lArticuloBuscar
            // 
            this.lArticuloBuscar.AutoSize = true;
            this.lArticuloBuscar.Location = new System.Drawing.Point(9, 15);
            this.lArticuloBuscar.Name = "lArticuloBuscar";
            this.lArticuloBuscar.Size = new System.Drawing.Size(88, 13);
            this.lArticuloBuscar.TabIndex = 1;
            this.lArticuloBuscar.Text = "Artículo a buscar";
            // 
            // tbArticuloBuscar
            // 
            this.tbArticuloBuscar.Location = new System.Drawing.Point(12, 37);
            this.tbArticuloBuscar.Name = "tbArticuloBuscar";
            this.tbArticuloBuscar.Size = new System.Drawing.Size(161, 20);
            this.tbArticuloBuscar.TabIndex = 0;
            // 
            // gbAltaRapidaArticulos
            // 
            this.gbAltaRapidaArticulos.Controls.Add(this.pictureBox1);
            this.gbAltaRapidaArticulos.Controls.Add(this.nudLimiteStock);
            this.gbAltaRapidaArticulos.Controls.Add(this.nudStockInicial);
            this.gbAltaRapidaArticulos.Controls.Add(this.tbDescripcion);
            this.gbAltaRapidaArticulos.Controls.Add(this.lLimiteStock);
            this.gbAltaRapidaArticulos.Controls.Add(this.lStockInicial);
            this.gbAltaRapidaArticulos.Controls.Add(this.lDescripcion);
            this.gbAltaRapidaArticulos.Location = new System.Drawing.Point(570, 2);
            this.gbAltaRapidaArticulos.Name = "gbAltaRapidaArticulos";
            this.gbAltaRapidaArticulos.Size = new System.Drawing.Size(444, 73);
            this.gbAltaRapidaArticulos.TabIndex = 0;
            this.gbAltaRapidaArticulos.TabStop = false;
            this.gbAltaRapidaArticulos.Text = "Alta rápida de artículos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // nudLimiteStock
            // 
            this.nudLimiteStock.Location = new System.Drawing.Point(326, 38);
            this.nudLimiteStock.Name = "nudLimiteStock";
            this.nudLimiteStock.Size = new System.Drawing.Size(64, 20);
            this.nudLimiteStock.TabIndex = 6;
            // 
            // nudStockInicial
            // 
            this.nudStockInicial.Location = new System.Drawing.Point(240, 38);
            this.nudStockInicial.Name = "nudStockInicial";
            this.nudStockInicial.Size = new System.Drawing.Size(61, 20);
            this.nudStockInicial.TabIndex = 5;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(12, 38);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(202, 20);
            this.tbDescripcion.TabIndex = 4;
            // 
            // lLimiteStock
            // 
            this.lLimiteStock.AutoSize = true;
            this.lLimiteStock.Location = new System.Drawing.Point(323, 16);
            this.lLimiteStock.Name = "lLimiteStock";
            this.lLimiteStock.Size = new System.Drawing.Size(67, 13);
            this.lLimiteStock.TabIndex = 3;
            this.lLimiteStock.Text = "Límite Stock";
            // 
            // lStockInicial
            // 
            this.lStockInicial.AutoSize = true;
            this.lStockInicial.Location = new System.Drawing.Point(237, 16);
            this.lStockInicial.Name = "lStockInicial";
            this.lStockInicial.Size = new System.Drawing.Size(64, 13);
            this.lStockInicial.TabIndex = 1;
            this.lStockInicial.Text = "Stock inicial";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(9, 16);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 0;
            this.lDescripcion.Text = "Descripción";
            // 
            // dgvArticulosStock
            // 
            this.dgvArticulosStock.AllowUserToAddRows = false;
            this.dgvArticulosStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripción,
            this.Unidades,
            this.StockMinimo,
            this.FechaUActualizacion});
            this.dgvArticulosStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosStock.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulosStock.Name = "dgvArticulosStock";
            this.dgvArticulosStock.Size = new System.Drawing.Size(1017, 399);
            this.dgvArticulosStock.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            // 
            // StockMinimo
            // 
            this.StockMinimo.HeaderText = "Stock Mínimo";
            this.StockMinimo.Name = "StockMinimo";
            // 
            // FechaUActualizacion
            // 
            this.FechaUActualizacion.HeaderText = "Fecha Última actualización";
            this.FechaUActualizacion.Name = "FechaUActualizacion";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1017, 482);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbActualizaStock.ResumeLayout(false);
            this.gbActualizaStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbAltaRapidaArticulos.ResumeLayout(false);
            this.gbAltaRapidaArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbActualizaStock;
        private System.Windows.Forms.Label lArticuloActualizar;
        private System.Windows.Forms.NumericUpDown nudStockActual;
        private System.Windows.Forms.Label lStockActual;
        private System.Windows.Forms.ComboBox cbArticuloActualizar;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lArticuloBuscar;
        private System.Windows.Forms.TextBox tbArticuloBuscar;
        private System.Windows.Forms.GroupBox gbAltaRapidaArticulos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudLimiteStock;
        private System.Windows.Forms.NumericUpDown nudStockInicial;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lLimiteStock;
        private System.Windows.Forms.Label lStockInicial;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.DataGridView dgvArticulosStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaUActualizacion;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}