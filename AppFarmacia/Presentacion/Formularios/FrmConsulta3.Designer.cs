
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEliminarFiltro = new System.Windows.Forms.Button();
			this.dgvConsulta = new System.Windows.Forms.DataGridView();
			this.cAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTipoSumin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCantTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.chkAnioMes = new System.Windows.Forms.CheckBox();
			this.chkProv = new System.Windows.Forms.CheckBox();
			this.lblAgrupamiento = new System.Windows.Forms.Label();
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvConsulta.ColumnHeadersHeight = 30;
			this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAnio,
            this.cMes,
            this.cProveedor,
            this.cTipoSumin,
            this.cCantTotal});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvConsulta.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvConsulta.Location = new System.Drawing.Point(12, 185);
			this.dgvConsulta.Name = "dgvConsulta";
			this.dgvConsulta.RowHeadersVisible = false;
			this.dgvConsulta.RowTemplate.Height = 25;
			this.dgvConsulta.Size = new System.Drawing.Size(785, 250);
			this.dgvConsulta.TabIndex = 31;
			// 
			// cAnio
			// 
			this.cAnio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cAnio.FillWeight = 203.0457F;
			this.cAnio.HeaderText = "Año";
			this.cAnio.Name = "cAnio";
			this.cAnio.Width = 59;
			// 
			// cMes
			// 
			this.cMes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cMes.FillWeight = 68.08337F;
			this.cMes.HeaderText = "Mes";
			this.cMes.Name = "cMes";
			this.cMes.Width = 57;
			// 
			// cProveedor
			// 
			this.cProveedor.HeaderText = "Proveedor";
			this.cProveedor.Name = "cProveedor";
			this.cProveedor.Visible = false;
			// 
			// cTipoSumin
			// 
			this.cTipoSumin.FillWeight = 64.13766F;
			this.cTipoSumin.HeaderText = "Tipo Suministro";
			this.cTipoSumin.Name = "cTipoSumin";
			// 
			// cCantTotal
			// 
			this.cCantTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cCantTotal.FillWeight = 64.73328F;
			this.cCantTotal.HeaderText = "Cantidad Total";
			this.cCantTotal.Name = "cCantTotal";
			this.cCantTotal.Width = 131;
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.DimGray;
			this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnConsultar.ForeColor = System.Drawing.Color.White;
			this.btnConsultar.Location = new System.Drawing.Point(648, 85);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(80, 41);
			this.btnConsultar.TabIndex = 26;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// txtFiltro
			// 
			this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFiltro.Location = new System.Drawing.Point(345, 84);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(282, 22);
			this.txtFiltro.TabIndex = 25;
			// 
			// cboFiltro
			// 
			this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboFiltro.FormattingEnabled = true;
			this.cboFiltro.Location = new System.Drawing.Point(101, 85);
			this.cboFiltro.Name = "cboFiltro";
			this.cboFiltro.Size = new System.Drawing.Size(223, 25);
			this.cboFiltro.TabIndex = 24;
			this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFiltro.Location = new System.Drawing.Point(101, 65);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(110, 17);
			this.lblFiltro.TabIndex = 23;
			this.lblFiltro.Text = "Filtros avanzados";
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(501, 24);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(126, 22);
			this.dtpFechaHasta.TabIndex = 22;
			// 
			// lblFechaHasta
			// 
			this.lblFechaHasta.AutoSize = true;
			this.lblFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFechaHasta.Location = new System.Drawing.Point(501, 6);
			this.lblFechaHasta.Name = "lblFechaHasta";
			this.lblFechaHasta.Size = new System.Drawing.Size(45, 17);
			this.lblFechaHasta.TabIndex = 21;
			this.lblFechaHasta.Text = "Hasta:";
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(345, 24);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(126, 22);
			this.dtpFechaDesde.TabIndex = 20;
			// 
			// lblFechaDesde
			// 
			this.lblFechaDesde.AutoSize = true;
			this.lblFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFechaDesde.Location = new System.Drawing.Point(345, 6);
			this.lblFechaDesde.Name = "lblFechaDesde";
			this.lblFechaDesde.Size = new System.Drawing.Size(49, 17);
			this.lblFechaDesde.TabIndex = 19;
			this.lblFechaDesde.Text = "Desde:";
			// 
			// cboFiltroFecha
			// 
			this.cboFiltroFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboFiltroFecha.FormattingEnabled = true;
			this.cboFiltroFecha.Location = new System.Drawing.Point(101, 24);
			this.cboFiltroFecha.Name = "cboFiltroFecha";
			this.cboFiltroFecha.Size = new System.Drawing.Size(223, 25);
			this.cboFiltroFecha.TabIndex = 18;
			this.cboFiltroFecha.SelectedIndexChanged += new System.EventHandler(this.cboFiltroFecha_SelectedIndexChanged);
			// 
			// lblFiltroFecha
			// 
			this.lblFiltroFecha.AutoSize = true;
			this.lblFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFiltroFecha.Location = new System.Drawing.Point(101, 6);
			this.lblFiltroFecha.Name = "lblFiltroFecha";
			this.lblFiltroFecha.Size = new System.Drawing.Size(98, 17);
			this.lblFiltroFecha.TabIndex = 17;
			this.lblFiltroFecha.Text = "Filtro por fecha";
			// 
			// chkAnio
			// 
			this.chkAnio.AutoSize = true;
			this.chkAnio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chkAnio.Location = new System.Drawing.Point(194, 159);
			this.chkAnio.Name = "chkAnio";
			this.chkAnio.Size = new System.Drawing.Size(51, 21);
			this.chkAnio.TabIndex = 34;
			this.chkAnio.Text = "Año";
			this.chkAnio.UseVisualStyleBackColor = true;
			this.chkAnio.Click += new System.EventHandler(this.chkAnio_Click);
			// 
			// chkAnioMes
			// 
			this.chkAnioMes.AutoSize = true;
			this.chkAnioMes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chkAnioMes.Location = new System.Drawing.Point(101, 159);
			this.chkAnioMes.Name = "chkAnioMes";
			this.chkAnioMes.Size = new System.Drawing.Size(87, 21);
			this.chkAnioMes.TabIndex = 35;
			this.chkAnioMes.Text = "Año y Mes";
			this.chkAnioMes.UseVisualStyleBackColor = true;
			this.chkAnioMes.Click += new System.EventHandler(this.chkAnioMes_Click);
			// 
			// chkProv
			// 
			this.chkProv.AutoSize = true;
			this.chkProv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chkProv.Location = new System.Drawing.Point(253, 159);
			this.chkProv.Name = "chkProv";
			this.chkProv.Size = new System.Drawing.Size(90, 21);
			this.chkProv.TabIndex = 37;
			this.chkProv.Text = "Proveedor";
			this.chkProv.UseVisualStyleBackColor = true;
			this.chkProv.Click += new System.EventHandler(this.chkProv_Click);
			// 
			// lblAgrupamiento
			// 
			this.lblAgrupamiento.AutoSize = true;
			this.lblAgrupamiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAgrupamiento.Location = new System.Drawing.Point(101, 124);
			this.lblAgrupamiento.Name = "lblAgrupamiento";
			this.lblAgrupamiento.Size = new System.Drawing.Size(121, 17);
			this.lblAgrupamiento.TabIndex = 38;
			this.lblAgrupamiento.Text = "Tipo Agrupamiento";
			// 
			// FrmConsulta3
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(809, 447);
			this.Controls.Add(this.lblAgrupamiento);
			this.Controls.Add(this.chkProv);
			this.Controls.Add(this.chkAnioMes);
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
		private System.Windows.Forms.CheckBox chkAnioMes;
		private System.Windows.Forms.CheckBox chkProv;
		private System.Windows.Forms.Label lblAgrupamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoSumin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantTotal;
    }
}