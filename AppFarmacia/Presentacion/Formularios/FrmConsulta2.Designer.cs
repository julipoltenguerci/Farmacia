
namespace Presentacion.Formularios
{
    partial class FrmConsulta2
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
			this.dgvConsultaFactura = new System.Windows.Forms.DataGridView();
			this.cNroFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAutorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFecFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cNombSuministro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTipoSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnConsultaFac = new System.Windows.Forms.Button();
			this.dtpFechaHastaf = new System.Windows.Forms.DateTimePicker();
			this.lblFechaHastaF = new System.Windows.Forms.Label();
			this.dtpFechaDesdeF = new System.Windows.Forms.DateTimePicker();
			this.lblFechaDesdeF = new System.Windows.Forms.Label();
			this.cboTipoSuministros = new System.Windows.Forms.ComboBox();
			this.chkBoxAutorizados = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFactura)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvConsultaFactura
			// 
			this.dgvConsultaFactura.AllowUserToAddRows = false;
			this.dgvConsultaFactura.AllowUserToDeleteRows = false;
			this.dgvConsultaFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvConsultaFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvConsultaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConsultaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNroFac,
            this.cTotal,
            this.cAutorizado,
            this.cFecFac,
            this.cNombSuministro,
            this.cTipoSum});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvConsultaFactura.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvConsultaFactura.Location = new System.Drawing.Point(12, 156);
			this.dgvConsultaFactura.Name = "dgvConsultaFactura";
			this.dgvConsultaFactura.ReadOnly = true;
			this.dgvConsultaFactura.RowHeadersVisible = false;
			this.dgvConsultaFactura.RowTemplate.Height = 25;
			this.dgvConsultaFactura.Size = new System.Drawing.Size(785, 270);
			this.dgvConsultaFactura.TabIndex = 0;
			// 
			// cNroFac
			// 
			this.cNroFac.HeaderText = "Nro Factura";
			this.cNroFac.Name = "cNroFac";
			this.cNroFac.ReadOnly = true;
			// 
			// cTotal
			// 
			this.cTotal.HeaderText = "Total";
			this.cTotal.Name = "cTotal";
			this.cTotal.ReadOnly = true;
			// 
			// cAutorizado
			// 
			this.cAutorizado.HeaderText = "Autorizado";
			this.cAutorizado.Name = "cAutorizado";
			this.cAutorizado.ReadOnly = true;
			// 
			// cFecFac
			// 
			this.cFecFac.HeaderText = "Fecha";
			this.cFecFac.Name = "cFecFac";
			this.cFecFac.ReadOnly = true;
			// 
			// cNombSuministro
			// 
			this.cNombSuministro.HeaderText = "Suministro";
			this.cNombSuministro.Name = "cNombSuministro";
			this.cNombSuministro.ReadOnly = true;
			// 
			// cTipoSum
			// 
			this.cTipoSum.HeaderText = "Tipo Suministro";
			this.cTipoSum.Name = "cTipoSum";
			this.cTipoSum.ReadOnly = true;
			// 
			// btnConsultaFac
			// 
			this.btnConsultaFac.BackColor = System.Drawing.Color.DimGray;
			this.btnConsultaFac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConsultaFac.Location = new System.Drawing.Point(545, 100);
			this.btnConsultaFac.Name = "btnConsultaFac";
			this.btnConsultaFac.Size = new System.Drawing.Size(80, 41);
			this.btnConsultaFac.TabIndex = 1;
			this.btnConsultaFac.Text = "Consultar";
			this.btnConsultaFac.UseVisualStyleBackColor = false;
			this.btnConsultaFac.Click += new System.EventHandler(this.btnConsultaFac_Click);
			// 
			// dtpFechaHastaf
			// 
			this.dtpFechaHastaf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHastaf.Location = new System.Drawing.Point(494, 42);
			this.dtpFechaHastaf.Name = "dtpFechaHastaf";
			this.dtpFechaHastaf.Size = new System.Drawing.Size(126, 22);
			this.dtpFechaHastaf.TabIndex = 26;
			// 
			// lblFechaHastaF
			// 
			this.lblFechaHastaF.AutoSize = true;
			this.lblFechaHastaF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFechaHastaF.Location = new System.Drawing.Point(433, 45);
			this.lblFechaHastaF.Name = "lblFechaHastaF";
			this.lblFechaHastaF.Size = new System.Drawing.Size(42, 16);
			this.lblFechaHastaF.TabIndex = 25;
			this.lblFechaHastaF.Text = "Hasta:";
			// 
			// dtpFechaDesdeF
			// 
			this.dtpFechaDesdeF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesdeF.Location = new System.Drawing.Point(190, 42);
			this.dtpFechaDesdeF.Name = "dtpFechaDesdeF";
			this.dtpFechaDesdeF.Size = new System.Drawing.Size(126, 22);
			this.dtpFechaDesdeF.TabIndex = 24;
			// 
			// lblFechaDesdeF
			// 
			this.lblFechaDesdeF.AutoSize = true;
			this.lblFechaDesdeF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFechaDesdeF.Location = new System.Drawing.Point(126, 45);
			this.lblFechaDesdeF.Name = "lblFechaDesdeF";
			this.lblFechaDesdeF.Size = new System.Drawing.Size(47, 16);
			this.lblFechaDesdeF.TabIndex = 23;
			this.lblFechaDesdeF.Text = "Desde:";
			// 
			// cboTipoSuministros
			// 
			this.cboTipoSuministros.FormattingEnabled = true;
			this.cboTipoSuministros.Location = new System.Drawing.Point(190, 110);
			this.cboTipoSuministros.Name = "cboTipoSuministros";
			this.cboTipoSuministros.Size = new System.Drawing.Size(132, 24);
			this.cboTipoSuministros.TabIndex = 27;
			// 
			// chkBoxAutorizados
			// 
			this.chkBoxAutorizados.AutoSize = true;
			this.chkBoxAutorizados.Location = new System.Drawing.Point(419, 112);
			this.chkBoxAutorizados.Name = "chkBoxAutorizados";
			this.chkBoxAutorizados.Size = new System.Drawing.Size(95, 20);
			this.chkBoxAutorizados.TabIndex = 28;
			this.chkBoxAutorizados.Text = "Autorizados";
			this.chkBoxAutorizados.UseVisualStyleBackColor = true;
			// 
			// FrmConsulta2
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(809, 447);
			this.Controls.Add(this.chkBoxAutorizados);
			this.Controls.Add(this.cboTipoSuministros);
			this.Controls.Add(this.dtpFechaHastaf);
			this.Controls.Add(this.lblFechaHastaF);
			this.Controls.Add(this.dtpFechaDesdeF);
			this.Controls.Add(this.lblFechaDesdeF);
			this.Controls.Add(this.btnConsultaFac);
			this.Controls.Add(this.dgvConsultaFactura);
			this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Name = "FrmConsulta2";
			this.Text = "FrmConsulta2";
			this.Load += new System.EventHandler(this.FrmConsulta2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFactura)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaFactura;
        private System.Windows.Forms.Button btnConsultaFac;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaf;
        private System.Windows.Forms.Label lblFechaHastaF;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeF;
        private System.Windows.Forms.Label lblFechaDesdeF;
        private System.Windows.Forms.ComboBox cboTipoSuministros;
        private System.Windows.Forms.CheckBox chkBoxAutorizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAutorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombSuministro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoSum;
    }
}