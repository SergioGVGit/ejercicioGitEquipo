/*
 * Creado por SharpDevelop.
 * Usuario: Moni2
 * Fecha: 04/11/2026
 * Hora: 07:22 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramaGitEquipo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		void BtnAccederClick(object sender, EventArgs e)
		{
           string correo = txtCorreo.Text.Trim();
            string contraseña = txtContraseña.Text;
            if (correo == "" || contraseña == "")
            {
                MessageBox.Show("Por favor llena todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("¡Bienvenidooooooooooo" + "! Has iniciado sesión correctamente", "Inicio exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        void BtnSalirClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}