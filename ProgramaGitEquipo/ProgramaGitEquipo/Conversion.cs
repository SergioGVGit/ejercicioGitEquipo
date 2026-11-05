/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 04/11/2026
 * Hora: 07:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramaGitEquipo
{
	/// <summary>
	/// Description of Conversion.
	/// </summary>
	public partial class Conversion : Form
	{
		public Conversion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnConvertirClick(object sender, EventArgs e)
		{
			double cantidad;
    		double resultado;
   	 		if (!double.TryParse(txtCantidad.Text, out cantidad))
    		{
       	 MessageBox.Show("Ingresa una cantidad válida");
        return;
    	}
    		if (cantidad < 0)
    	{
        MessageBox.Show("Ingresa una cantidad positiva");
        return;
   	 	}
    		if (cmbDireccion.SelectedIndex == 0)
    	{
        resultado = cantidad * 18;
    	}
    	else
    	{
        resultado = cantidad / 18;
    	}
    	lblResultado.Text = "Resultado: " + resultado.ToString("N2");
}
		}
	}

