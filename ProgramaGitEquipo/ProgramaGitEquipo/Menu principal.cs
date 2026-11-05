/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 04/11/2026
 * Hora: 06:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramaGitEquipo
{
	/// <summary>
	/// Description of Menu_principal.
	/// </summary>
	public partial class Menu_principal : Form
	{
		public Menu_principal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnConversionClick(object sender, EventArgs e)
		{
			
            Conversion formulario = new Conversion();
    		formulario.ShowDialog();
		}
		void BtnDistanciaClick(object sender, EventArgs e)
		{
			  MessageBox.Show("Aquí se abrirá el programa de distancia entre dos puntos.");
		}
		void BtnCuadranteClick(object sender, EventArgs e)
		{
			MessageBox.Show("Aquí se abrirá el programa para identificar el cuadrante.");
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
