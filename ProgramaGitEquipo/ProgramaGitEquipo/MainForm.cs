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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
                MessageBox.Show("Por favor llena todos los campos",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("¡Bienvenido! Has iniciado sesión correctamente",
            "Inicio exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Menu_principal menu = new Menu_principal();

            menu.FormClosed += (s, args) => Application.Exit();

            this.Hide();
            menu.Show();
        }

        void BtnSalirClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
