/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 04/11/2026
 * Hora: 07:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProgramaGitEquipo
{
	partial class Conversion
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.ComboBox cmbDireccion;
		private System.Windows.Forms.Button btnConvertir;
		private System.Windows.Forms.Label lblResultado;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.cmbDireccion = new System.Windows.Forms.ComboBox();
			this.btnConvertir = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "CONVERSION ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblCantidad
			// 
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(12, 64);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(100, 23);
			this.lblCantidad.TabIndex = 1;
			this.lblCantidad.Text = "CANTIDAD:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(100, 63);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(148, 20);
			this.txtCantidad.TabIndex = 2;
			// 
			// cmbDireccion
			// 
			this.cmbDireccion.FormattingEnabled = true;
			this.cmbDireccion.Items.AddRange(new object[] {
			"Dolares a pesos"});
			this.cmbDireccion.Location = new System.Drawing.Point(29, 90);
			this.cmbDireccion.Name = "cmbDireccion";
			this.cmbDireccion.Size = new System.Drawing.Size(219, 21);
			this.cmbDireccion.TabIndex = 3;
			// 
			// btnConvertir
			// 
			this.btnConvertir.Location = new System.Drawing.Point(81, 127);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(112, 36);
			this.btnConvertir.TabIndex = 4;
			this.btnConvertir.Text = "Convertir";
			this.btnConvertir.UseVisualStyleBackColor = true;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(13, 179);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(180, 23);
			this.lblResultado.TabIndex = 5;
			this.lblResultado.Text = "Resultado:";
			// 
			// Conversion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 261);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnConvertir);
			this.Controls.Add(this.cmbDireccion);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.label1);
			this.Name = "Conversion";
			this.Text = "Conversion";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
