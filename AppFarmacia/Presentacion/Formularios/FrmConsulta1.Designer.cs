﻿
namespace Presentacion.Formularios
{
    partial class FrmConsulta1
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
			this.Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Obra_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.lblFiltroDescuento = new System.Windows.Forms.Label();
			this.cboFiltroObraSocial = new System.Windows.Forms.ComboBox();
			this.lblFiltroFecha = new System.Windows.Forms.Label();
			this.tkbDescuento = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.lblFechaHasta = new System.Windows.Forms.Label();
			this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tkbDescuento)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// dgvConsulta1
			// 
			this.dgvConsulta1.AllowUserToAddRows = false;
			this.dgvConsulta1.AllowUserToDeleteRows = false;
			this.dgvConsulta1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvConsulta1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvConsulta1.ColumnHeadersHeight = 30;
			this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvConsulta1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Afiliado,
            this.Obra_Social,
            this.descuento,
            this.fecha_factura});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvConsulta1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvConsulta1.Location = new System.Drawing.Point(23, 131);
			this.dgvConsulta1.Name = "dgvConsulta1";
			this.dgvConsulta1.ReadOnly = true;
			this.dgvConsulta1.RowHeadersVisible = false;
			this.dgvConsulta1.RowTemplate.Height = 25;
			this.dgvConsulta1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvConsulta1.Size = new System.Drawing.Size(774, 263);
			this.dgvConsulta1.TabIndex = 31;
			// 
			// Afiliado
			// 
			this.Afiliado.DataPropertyName = "Afiliado";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Afiliado.DefaultCellStyle = dataGridViewCellStyle2;
			this.Afiliado.FillWeight = 200F;
			this.Afiliado.HeaderText = "Afiliado";
			this.Afiliado.Name = "Afiliado";
			this.Afiliado.ReadOnly = true;
			// 
			// Obra_Social
			// 
			this.Obra_Social.DataPropertyName = "Obra_Social";
			this.Obra_Social.HeaderText = "Obra Social";
			this.Obra_Social.Name = "Obra_Social";
			this.Obra_Social.ReadOnly = true;
			// 
			// descuento
			// 
			this.descuento.DataPropertyName = "descuento";
			this.descuento.HeaderText = "Descuento";
			this.descuento.Name = "descuento";
			this.descuento.ReadOnly = true;
			// 
			// fecha_factura
			// 
			this.fecha_factura.DataPropertyName = "fecha_factura";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.fecha_factura.DefaultCellStyle = dataGridViewCellStyle3;
			this.fecha_factura.HeaderText = "Fecha Factura";
			this.fecha_factura.Name = "fecha_factura";
			this.fecha_factura.ReadOnly = true;
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.DimGray;
			this.btnConsultar.FlatAppearance.BorderSize = 0;
			this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnConsultar.ForeColor = System.Drawing.Color.White;
			this.btnConsultar.Location = new System.Drawing.Point(635, 45);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(80, 41);
			this.btnConsultar.TabIndex = 26;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// lblFiltroDescuento
			// 
			this.lblFiltroDescuento.AutoSize = true;
			this.lblFiltroDescuento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFiltroDescuento.Location = new System.Drawing.Point(23, 82);
			this.lblFiltroDescuento.Name = "lblFiltroDescuento";
			this.lblFiltroDescuento.Size = new System.Drawing.Size(107, 16);
			this.lblFiltroDescuento.TabIndex = 23;
			this.lblFiltroDescuento.Text = "Descuento Hasta:";
			// 
			// cboFiltroObraSocial
			// 
			this.cboFiltroObraSocial.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.cboFiltroObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroObraSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboFiltroObraSocial.ForeColor = System.Drawing.Color.Black;
			this.cboFiltroObraSocial.FormattingEnabled = true;
			this.cboFiltroObraSocial.Location = new System.Drawing.Point(142, 29);
			this.cboFiltroObraSocial.Name = "cboFiltroObraSocial";
			this.cboFiltroObraSocial.Size = new System.Drawing.Size(223, 25);
			this.cboFiltroObraSocial.TabIndex = 18;
			// 
			// lblFiltroFecha
			// 
			this.lblFiltroFecha.AutoSize = true;
			this.lblFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFiltroFecha.Location = new System.Drawing.Point(51, 33);
			this.lblFiltroFecha.Name = "lblFiltroFecha";
			this.lblFiltroFecha.Size = new System.Drawing.Size(79, 16);
			this.lblFiltroFecha.TabIndex = 17;
			this.lblFiltroFecha.Text = "Obra Social:";
			// 
			// tkbDescuento
			// 
			this.tkbDescuento.Location = new System.Drawing.Point(142, 80);
			this.tkbDescuento.Name = "tkbDescuento";
			this.tkbDescuento.Size = new System.Drawing.Size(223, 45);
			this.tkbDescuento.TabIndex = 34;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(102, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 15);
			this.label1.TabIndex = 36;
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(465, 76);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(126, 22);
			this.dtpFechaHasta.TabIndex = 40;
			// 
			// lblFechaHasta
			// 
			this.lblFechaHasta.AutoSize = true;
			this.lblFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFechaHasta.Location = new System.Drawing.Point(411, 80);
			this.lblFechaHasta.Name = "lblFechaHasta";
			this.lblFechaHasta.Size = new System.Drawing.Size(42, 16);
			this.lblFechaHasta.TabIndex = 39;
			this.lblFechaHasta.Text = "Hasta:";
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(465, 30);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(126, 22);
			this.dtpFechaDesde.TabIndex = 38;
			this.dtpFechaDesde.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(408, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 37;
			this.label2.Text = "Desde:";
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Location = new System.Drawing.Point(635, 399);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(86, 36);
			this.btnEliminar.TabIndex = 41;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// FrmConsulta1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(809, 447);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dtpFechaHasta);
			this.Controls.Add(this.lblFechaHasta);
			this.Controls.Add(this.dtpFechaDesde);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tkbDescuento);
			this.Controls.Add(this.dgvConsulta1);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.lblFiltroDescuento);
			this.Controls.Add(this.cboFiltroObraSocial);
			this.Controls.Add(this.lblFiltroFecha);
			this.Name = "FrmConsulta1";
			this.Text = "Consulta 1";
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tkbDescuento)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvConsulta1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFiltroDescuento;
        private System.Windows.Forms.ComboBox cboFiltroObraSocial;
        private System.Windows.Forms.Label lblFiltroFecha;
        private System.Windows.Forms.TrackBar tkbDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obra_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_factura;
    }
}