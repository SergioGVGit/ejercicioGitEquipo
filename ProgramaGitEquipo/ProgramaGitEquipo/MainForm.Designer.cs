/*
 * Creado por SharpDevelop.
 * Usuario: Moni2
 * Fecha: 04/11/2026
 * Hora: 07:22 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProgramaGitEquipo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnAcceder = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Correo";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 41);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(189, 50);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(317, 26);
			this.txtCorreo.TabIndex = 2;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(189, 101);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(317, 26);
			this.txtContraseña.TabIndex = 3;
			// 
			// btnAcceder
			// 
			this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcceder.Location = new System.Drawing.Point(106, 194);
			this.btnAcceder.Name = "btnAcceder";
			this.btnAcceder.Size = new System.Drawing.Size(120, 50);
			this.btnAcceder.TabIndex = 4;
			this.btnAcceder.Text = "Acceder";
			this.btnAcceder.UseVisualStyleBackColor = true;
			this.btnAcceder.Click += new System.EventHandler(this.BtnAccederClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(334, 194);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(111, 50);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 350);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAcceder);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnAcceder;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
