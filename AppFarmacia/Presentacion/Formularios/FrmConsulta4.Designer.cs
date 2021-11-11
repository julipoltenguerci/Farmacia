
namespace Presentacion.Formularios
{
    partial class FrmConsulta4
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
			this.lblSucursal = new System.Windows.Forms.Label();
			this.lblAño = new System.Windows.Forms.Label();
			this.txtAnio = new System.Windows.Forms.TextBox();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.dgvConsulta = new System.Windows.Forms.DataGridView();
			this.cAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPromedioFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSucursal
			// 
			this.lblSucursal.AutoSize = true;
			this.lblSucursal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSucursal.Location = new System.Drawing.Point(84, 51);
			this.lblSucursal.Name = "lblSucursal";
			this.lblSucursal.Size = new System.Drawing.Size(60, 17);
			this.lblSucursal.TabIndex = 52;
			this.lblSucursal.Text = "Sucursal:";
			// 
			// lblAño
			// 
			this.lblAño.AutoSize = true;
			this.lblAño.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAño.Location = new System.Drawing.Point(471, 51);
			this.lblAño.Name = "lblAño";
			this.lblAño.Size = new System.Drawing.Size(35, 17);
			this.lblAño.TabIndex = 51;
			this.lblAño.Text = "Año:";
			// 
			// txtAnio
			// 
			this.txtAnio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAnio.Location = new System.Drawing.Point(526, 48);
			this.txtAnio.Name = "txtAnio";
			this.txtAnio.Size = new System.Drawing.Size(100, 22);
			this.txtAnio.TabIndex = 50;
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.DimGray;
			this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConsultar.Location = new System.Drawing.Point(649, 39);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(80, 41);
			this.btnConsultar.TabIndex = 49;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// txtFiltro
			// 
			this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFiltro.Location = new System.Drawing.Point(184, 48);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(261, 22);
			this.txtFiltro.TabIndex = 48;
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFiltro.Location = new System.Drawing.Point(84, 14);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(37, 17);
			this.lblFiltro.TabIndex = 47;
			this.lblFiltro.Text = "Filtro";
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
            this.cSucursal,
            this.cPromedioFactura,
            this.cTotal});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvConsulta.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvConsulta.Location = new System.Drawing.Point(12, 93);
			this.dgvConsulta.Name = "dgvConsulta";
			this.dgvConsulta.ReadOnly = true;
			this.dgvConsulta.RowHeadersVisible = false;
			this.dgvConsulta.RowTemplate.Height = 25;
			this.dgvConsulta.Size = new System.Drawing.Size(785, 342);
			this.dgvConsulta.TabIndex = 43;
			// 
			// cAnio
			// 
			this.cAnio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cAnio.FillWeight = 203.0457F;
			this.cAnio.Frozen = true;
			this.cAnio.HeaderText = "Año";
			this.cAnio.Name = "cAnio";
			this.cAnio.ReadOnly = true;
			this.cAnio.Width = 59;
			// 
			// cSucursal
			// 
			this.cSucursal.HeaderText = "Sucursal";
			this.cSucursal.Name = "cSucursal";
			this.cSucursal.ReadOnly = true;
			// 
			// cPromedioFactura
			// 
			this.cPromedioFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cPromedioFactura.HeaderText = "Promedio de Facturacion";
			this.cPromedioFactura.Name = "cPromedioFactura";
			this.cPromedioFactura.ReadOnly = true;
			this.cPromedioFactura.Width = 198;
			// 
			// cTotal
			// 
			this.cTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.cTotal.HeaderText = "Total";
			this.cTotal.Name = "cTotal";
			this.cTotal.ReadOnly = true;
			this.cTotal.Width = 64;
			// 
			// FrmConsulta4
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(809, 447);
			this.Controls.Add(this.lblSucursal);
			this.Controls.Add(this.lblAño);
			this.Controls.Add(this.txtAnio);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.dgvConsulta);
			this.Name = "FrmConsulta4";
			this.Load += new System.EventHandler(this.FrmConsulta4_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPromedioFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
    }
}