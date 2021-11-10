
namespace Presentacion.Formularios
{
	partial class FrmConsulta3
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEliminarFiltro = new System.Windows.Forms.Button();
			this.dgvConsulta = new System.Windows.Forms.DataGridView();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.cboFiltro = new System.Windows.Forms.ComboBox();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.lblFechaHasta = new System.Windows.Forms.Label();
			this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.lblFechaDesde = new System.Windows.Forms.Label();
			this.cboFiltroFecha = new System.Windows.Forms.ComboBox();
			this.lblFiltroFecha = new System.Windows.Forms.Label();
			this.chkAnio = new System.Windows.Forms.CheckBox();
			this.chkMes = new System.Windows.Forms.CheckBox();
			this.chkTipoSum = new System.Windows.Forms.CheckBox();
			this.chkProv = new System.Windows.Forms.CheckBox();
			this.lblAgrupamiento = new System.Windows.Forms.Label();
			this.cAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTipoSumin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCantTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(589, 579);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 33;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnEliminarFiltro
			// 
			this.btnEliminarFiltro.Location = new System.Drawing.Point(24, 579);
			this.btnEliminarFiltro.Name = "btnEliminarFiltro";
			this.btnEliminarFiltro.Size = new System.Drawing.Size(94, 23);
			this.btnEliminarFiltro.TabIndex = 32;
			this.btnEliminarFiltro.Text = "Eliminar Filtro";
			this.btnEliminarFiltro.UseVisualStyleBackColor = true;
			// 
			// dgvConsulta
			// 
			this.dgvConsulta.AllowUserToAddRows = false;
			this.dgvConsulta.AllowUserToDeleteRows = false;
			this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvConsulta.ColumnHeadersHeight = 30;
			this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAnio,
            this.cMes,
            this.cProveedor,
            this.cTipoSumin,
            this.cCantTotal});
			this.dgvConsulta.Location = new System.Drawing.Point(12, 185);
			this.dgvConsulta.Name = "dgvConsulta";
			this.dgvConsulta.ReadOnly = true;
			this.dgvConsulta.RowHeadersVisible = false;
			this.dgvConsulta.RowTemplate.Height = 25;
			this.dgvConsulta.Size = new System.Drawing.Size(785, 250);
			this.dgvConsulta.TabIndex = 31;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(644, 85);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 26;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(352, 85);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(282, 23);
			this.txtFiltro.TabIndex = 25;
			// 
			// cboFiltro
			// 
			this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltro.FormattingEnabled = true;
			this.cboFiltro.Location = new System.Drawing.Point(108, 86);
			this.cboFiltro.Name = "cboFiltro";
			this.cboFiltro.Size = new System.Drawing.Size(223, 23);
			this.cboFiltro.TabIndex = 24;
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Location = new System.Drawing.Point(108, 66);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(97, 15);
			this.lblFiltro.TabIndex = 23;
			this.lblFiltro.Text = "Filtros avanzados";
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(508, 25);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(126, 23);
			this.dtpFechaHasta.TabIndex = 22;
			// 
			// lblFechaHasta
			// 
			this.lblFechaHasta.AutoSize = true;
			this.lblFechaHasta.Location = new System.Drawing.Point(508, 7);
			this.lblFechaHasta.Name = "lblFechaHasta";
			this.lblFechaHasta.Size = new System.Drawing.Size(40, 15);
			this.lblFechaHasta.TabIndex = 21;
			this.lblFechaHasta.Text = "Hasta:";
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(352, 25);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(126, 23);
			this.dtpFechaDesde.TabIndex = 20;
			// 
			// lblFechaDesde
			// 
			this.lblFechaDesde.AutoSize = true;
			this.lblFechaDesde.Location = new System.Drawing.Point(352, 7);
			this.lblFechaDesde.Name = "lblFechaDesde";
			this.lblFechaDesde.Size = new System.Drawing.Size(42, 15);
			this.lblFechaDesde.TabIndex = 19;
			this.lblFechaDesde.Text = "Desde:";
			// 
			// cboFiltroFecha
			// 
			this.cboFiltroFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroFecha.FormattingEnabled = true;
			this.cboFiltroFecha.Location = new System.Drawing.Point(108, 25);
			this.cboFiltroFecha.Name = "cboFiltroFecha";
			this.cboFiltroFecha.Size = new System.Drawing.Size(223, 23);
			this.cboFiltroFecha.TabIndex = 18;
			// 
			// lblFiltroFecha
			// 
			this.lblFiltroFecha.AutoSize = true;
			this.lblFiltroFecha.Location = new System.Drawing.Point(108, 7);
			this.lblFiltroFecha.Name = "lblFiltroFecha";
			this.lblFiltroFecha.Size = new System.Drawing.Size(87, 15);
			this.lblFiltroFecha.TabIndex = 17;
			this.lblFiltroFecha.Text = "Filtro por fecha";
			// 
			// chkAnio
			// 
			this.chkAnio.AutoSize = true;
			this.chkAnio.Location = new System.Drawing.Point(110, 161);
			this.chkAnio.Name = "chkAnio";
			this.chkAnio.Size = new System.Drawing.Size(48, 19);
			this.chkAnio.TabIndex = 34;
			this.chkAnio.Text = "Año";
			this.chkAnio.UseVisualStyleBackColor = true;
			// 
			// chkMes
			// 
			this.chkMes.AutoSize = true;
			this.chkMes.Location = new System.Drawing.Point(175, 161);
			this.chkMes.Name = "chkMes";
			this.chkMes.Size = new System.Drawing.Size(48, 19);
			this.chkMes.TabIndex = 35;
			this.chkMes.Text = "Mes";
			this.chkMes.UseVisualStyleBackColor = true;
			// 
			// chkTipoSum
			// 
			this.chkTipoSum.AutoSize = true;
			this.chkTipoSum.Location = new System.Drawing.Point(240, 161);
			this.chkTipoSum.Name = "chkTipoSum";
			this.chkTipoSum.Size = new System.Drawing.Size(109, 19);
			this.chkTipoSum.TabIndex = 36;
			this.chkTipoSum.Text = "Tipo Suministro";
			this.chkTipoSum.UseVisualStyleBackColor = true;
			// 
			// chkProv
			// 
			this.chkProv.AutoSize = true;
			this.chkProv.Location = new System.Drawing.Point(366, 161);
			this.chkProv.Name = "chkProv";
			this.chkProv.Size = new System.Drawing.Size(80, 19);
			this.chkProv.TabIndex = 37;
			this.chkProv.Text = "Proveedor";
			this.chkProv.UseVisualStyleBackColor = true;
			// 
			// lblAgrupamiento
			// 
			this.lblAgrupamiento.AutoSize = true;
			this.lblAgrupamiento.Location = new System.Drawing.Point(108, 125);
			this.lblAgrupamiento.Name = "lblAgrupamiento";
			this.lblAgrupamiento.Size = new System.Drawing.Size(110, 15);
			this.lblAgrupamiento.TabIndex = 38;
			this.lblAgrupamiento.Text = "Tipo Agrupamiento";
			// 
			// cAnio
			// 
			this.cAnio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cAnio.FillWeight = 203.0457F;
			this.cAnio.HeaderText = "Año";
			this.cAnio.Name = "cAnio";
			this.cAnio.ReadOnly = true;
			this.cAnio.Width = 54;
			// 
			// cMes
			// 
			this.cMes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cMes.FillWeight = 68.08337F;
			this.cMes.HeaderText = "Mes";
			this.cMes.Name = "cMes";
			this.cMes.ReadOnly = true;
			this.cMes.Width = 54;
			// 
			// cProveedor
			// 
			this.cProveedor.HeaderText = "Proveedor";
			this.cProveedor.Name = "cProveedor";
			this.cProveedor.ReadOnly = true;
			this.cProveedor.Visible = false;
			// 
			// cTipoSumin
			// 
			this.cTipoSumin.FillWeight = 64.13766F;
			this.cTipoSumin.HeaderText = "Tipo Suministro";
			this.cTipoSumin.Name = "cTipoSumin";
			this.cTipoSumin.ReadOnly = true;
			// 
			// cCantTotal
			// 
			this.cCantTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cCantTotal.FillWeight = 64.73328F;
			this.cCantTotal.HeaderText = "Cantidad Total";
			this.cCantTotal.Name = "cCantTotal";
			this.cCantTotal.ReadOnly = true;
			this.cCantTotal.Width = 108;
			// 
			// FrmConsulta3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 447);
			this.Controls.Add(this.lblAgrupamiento);
			this.Controls.Add(this.chkProv);
			this.Controls.Add(this.chkTipoSum);
			this.Controls.Add(this.chkMes);
			this.Controls.Add(this.chkAnio);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEliminarFiltro);
			this.Controls.Add(this.dgvConsulta);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.cboFiltro);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.dtpFechaHasta);
			this.Controls.Add(this.lblFechaHasta);
			this.Controls.Add(this.dtpFechaDesde);
			this.Controls.Add(this.lblFechaDesde);
			this.Controls.Add(this.cboFiltroFecha);
			this.Controls.Add(this.lblFiltroFecha);
			this.Name = "FrmConsulta3";
			this.Text = "FrmConsulta3";
			this.Load += new System.EventHandler(this.FrmConsulta3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEliminarFiltro;
		private System.Windows.Forms.DataGridView dgvConsulta;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.ComboBox cboFiltro;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.DateTimePicker dtpFechaHasta;
		private System.Windows.Forms.Label lblFechaHasta;
		private System.Windows.Forms.DateTimePicker dtpFechaDesde;
		private System.Windows.Forms.Label lblFechaDesde;
		private System.Windows.Forms.ComboBox cboFiltroFecha;
		private System.Windows.Forms.Label lblFiltroFecha;
		private System.Windows.Forms.CheckBox chkAnio;
		private System.Windows.Forms.CheckBox chkMes;
		private System.Windows.Forms.CheckBox chkTipoSum;
		private System.Windows.Forms.CheckBox chkProv;
		private System.Windows.Forms.Label lblAgrupamiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAnio;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMes;
		private System.Windows.Forms.DataGridViewTextBoxColumn cProveedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn cTipoSumin;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCantTotal;
	}
}