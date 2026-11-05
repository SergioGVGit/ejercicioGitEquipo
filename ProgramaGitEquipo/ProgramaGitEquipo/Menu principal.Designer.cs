/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 04/11/2026
 * Hora: 06:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProgramaGitEquipo
{
	partial class Menu_principal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConversion;
		private System.Windows.Forms.Button btnDistancia;
		private System.Windows.Forms.Button btnCuadrante;
		private System.Windows.Forms.Button btnCerrar;
		
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
			this.btnConversion = new System.Windows.Forms.Button();
			this.btnDistancia = new System.Windows.Forms.Button();
			this.btnCuadrante = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU PRINCIPAL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnConversion
			// 
			this.btnConversion.Location = new System.Drawing.Point(36, 58);
			this.btnConversion.Name = "btnConversion";
			this.btnConversion.Size = new System.Drawing.Size(103, 46);
			this.btnConversion.TabIndex = 1;
			this.btnConversion.Text = "CONVERSION DE MONEDAS";
			this.btnConversion.UseVisualStyleBackColor = true;
			this.btnConversion.Click += new System.EventHandler(this.BtnConversionClick);
			// 
			// btnDistancia
			// 
			this.btnDistancia.Location = new System.Drawing.Point(155, 58);
			this.btnDistancia.Name = "btnDistancia";
			this.btnDistancia.Size = new System.Drawing.Size(117, 46);
			this.btnDistancia.TabIndex = 2;
			this.btnDistancia.Text = "DISTANCIA ENTRE DOS PUNTOS";
			this.btnDistancia.UseVisualStyleBackColor = true;
			this.btnDistancia.Click += new System.EventHandler(this.BtnDistanciaClick);
			// 
			// btnCuadrante
			// 
			this.btnCuadrante.Location = new System.Drawing.Point(36, 124);
			this.btnCuadrante.Name = "btnCuadrante";
			this.btnCuadrante.Size = new System.Drawing.Size(103, 42);
			this.btnCuadrante.TabIndex = 3;
			this.btnCuadrante.Text = "CUADRANTE DE UN PUNTO";
			this.btnCuadrante.UseVisualStyleBackColor = true;
			this.btnCuadrante.Click += new System.EventHandler(this.BtnCuadranteClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(155, 124);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(117, 42);
			this.btnCerrar.TabIndex = 4;
			this.btnCerrar.Text = "CERRAR SESION";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// Menu_principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 291);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnCuadrante);
			this.Controls.Add(this.btnDistancia);
			this.Controls.Add(this.btnConversion);
			this.Controls.Add(this.label1);
			this.Name = "Menu_principal";
			this.Text = "Menu_principal";
			this.ResumeLayout(false);

		}
	}
}
