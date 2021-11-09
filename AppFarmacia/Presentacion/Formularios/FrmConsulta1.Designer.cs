
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFiltroDescuento = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.cboFiltroObraSocial = new System.Windows.Forms.ComboBox();
            this.lblFiltroFecha = new System.Windows.Forms.Label();
            this.tkbDescuento = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obra_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(576, 564);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 36);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarFiltro.FlatAppearance.BorderSize = 0;
            this.btnEliminarFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(22, 564);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(86, 36);
            this.btnEliminarFiltro.TabIndex = 32;
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = false;
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeight = 30;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsulta1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Afiliado,
            this.Obra_Social,
            this.descuento});
            this.dgvConsulta1.Location = new System.Drawing.Point(22, 160);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowHeadersVisible = false;
            this.dgvConsulta1.RowTemplate.Height = 25;
            this.dgvConsulta1.Size = new System.Drawing.Size(640, 388);
            this.dgvConsulta1.TabIndex = 31;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(544, 72);
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
            this.lblFiltroDescuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiltroDescuento.Location = new System.Drawing.Point(14, 84);
            this.lblFiltroDescuento.Name = "lblFiltroDescuento";
            this.lblFiltroDescuento.Size = new System.Drawing.Size(74, 16);
            this.lblFiltroDescuento.TabIndex = 23;
            this.lblFiltroDescuento.Text = "Descuento";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(498, 21);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(126, 23);
            this.dtpFechaFactura.TabIndex = 20;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaDesde.Location = new System.Drawing.Point(362, 24);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(124, 16);
            this.lblFechaDesde.TabIndex = 19;
            this.lblFechaDesde.Text = "Fecha de Factura:";
            // 
            // cboFiltroObraSocial
            // 
            this.cboFiltroObraSocial.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboFiltroObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroObraSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFiltroObraSocial.ForeColor = System.Drawing.Color.Black;
            this.cboFiltroObraSocial.FormattingEnabled = true;
            this.cboFiltroObraSocial.Location = new System.Drawing.Point(102, 21);
            this.cboFiltroObraSocial.Name = "cboFiltroObraSocial";
            this.cboFiltroObraSocial.Size = new System.Drawing.Size(223, 25);
            this.cboFiltroObraSocial.TabIndex = 18;
            // 
            // lblFiltroFecha
            // 
            this.lblFiltroFecha.AutoSize = true;
            this.lblFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiltroFecha.Location = new System.Drawing.Point(11, 24);
            this.lblFiltroFecha.Name = "lblFiltroFecha";
            this.lblFiltroFecha.Size = new System.Drawing.Size(85, 16);
            this.lblFiltroFecha.TabIndex = 17;
            this.lblFiltroFecha.Text = "Obra Social";
            // 
            // tkbDescuento
            // 
            this.tkbDescuento.Location = new System.Drawing.Point(96, 74);
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
            // Afiliado
            // 
            this.Afiliado.DataPropertyName = "Afiliado";
            this.Afiliado.FillWeight = 200F;
            this.Afiliado.HeaderText = "Afiliado";
            this.Afiliado.Name = "Afiliado";
            this.Afiliado.ReadOnly = true;
            this.Afiliado.Width = 200;
            // 
            // Obra_Social
            // 
            this.Obra_Social.DataPropertyName = "Obra_Social";
            this.Obra_Social.HeaderText = "Obra Social";
            this.Obra_Social.Name = "Obra_Social";
            this.Obra_Social.ReadOnly = true;
            this.Obra_Social.Width = 150;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 137;
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tkbDescuento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFiltroDescuento);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.lblFechaDesde);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.DataGridView dgvConsulta1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFiltroDescuento;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.ComboBox cboFiltroObraSocial;
        private System.Windows.Forms.Label lblFiltroFecha;
        private System.Windows.Forms.TrackBar tkbDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obra_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
    }
}