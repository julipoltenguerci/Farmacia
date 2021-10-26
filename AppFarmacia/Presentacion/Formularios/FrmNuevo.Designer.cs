
namespace Presentacion.Formularios
{
	partial class FrmNuevo
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
			this.lblNro = new System.Windows.Forms.Label();
			this.cboSucursal = new System.Windows.Forms.ComboBox();
			this.lblSucursal = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNro
			// 
			this.lblNro.AutoSize = true;
			this.lblNro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNro.Location = new System.Drawing.Point(412, 9);
			this.lblNro.Name = "lblNro";
			this.lblNro.Size = new System.Drawing.Size(118, 28);
			this.lblNro.TabIndex = 0;
			this.lblNro.Text = "Factura Nro:";
			// 
			// cboSucursal
			// 
			this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSucursal.FormattingEnabled = true;
			this.cboSucursal.Location = new System.Drawing.Point(89, 17);
			this.cboSucursal.Name = "cboSucursal";
			this.cboSucursal.Size = new System.Drawing.Size(232, 23);
			this.cboSucursal.TabIndex = 1;
			// 
			// lblSucursal
			// 
			this.lblSucursal.AutoSize = true;
			this.lblSucursal.Location = new System.Drawing.Point(32, 21);
			this.lblSucursal.Name = "lblSucursal";
			this.lblSucursal.Size = new System.Drawing.Size(51, 15);
			this.lblSucursal.TabIndex = 2;
			this.lblSucursal.Text = "Sucursal";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(32, 88);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(44, 15);
			this.lblCliente.TabIndex = 3;
			this.lblCliente.Text = "Cliente";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(89, 85);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(232, 23);
			this.textBox1.TabIndex = 4;
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Location = new System.Drawing.Point(344, 84);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
			this.btnBuscarCliente.TabIndex = 5;
			this.btnBuscarCliente.Text = "Buscar";
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			// 
			// FrmNuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 570);
			this.Controls.Add(this.btnBuscarCliente);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.lblSucursal);
			this.Controls.Add(this.cboSucursal);
			this.Controls.Add(this.lblNro);
			this.Name = "FrmNuevo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nueva Factura";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNro;
		private System.Windows.Forms.ComboBox cboSucursal;
		private System.Windows.Forms.Label lblSucursal;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnBuscarCliente;
	}
}