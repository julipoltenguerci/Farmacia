
namespace Presentacion.Formularios
{
	partial class FrmPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.suministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem,
			this.facturaToolStripMenuItem,
			this.pedidosToolStripMenuItem,
			this.proveedoresToolStripMenuItem,
			this.sucursalesToolStripMenuItem,
			this.suministrosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// facturaToolStripMenuItem
			// 
			this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
			this.facturaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.facturaToolStripMenuItem.Text = "Facturas";
			// 
			// pedidosToolStripMenuItem
			// 
			this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
			this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.pedidosToolStripMenuItem.Text = "Pedidos";
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.proveedoresToolStripMenuItem.Text = "Proveedores";
			// 
			// sucursalesToolStripMenuItem
			// 
			this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
			this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.sucursalesToolStripMenuItem.Text = "Sucursales";
			// 
			// suministrosToolStripMenuItem
			// 
			this.suministrosToolStripMenuItem.Name = "suministrosToolStripMenuItem";
			this.suministrosToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.suministrosToolStripMenuItem.Text = "Suministros";
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.Name = "FrmPrincipal";
			this.Text = "Farmacia";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem suministrosToolStripMenuItem;
	}
}

