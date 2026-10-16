using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.AsignarUsuario = this.txtUsuario.Text;
			login.AsignarContrasena = this.txtContrasena.Text;
			if (login.obtenerEstatus)
			{
				MessageBox.Show("Acceso Permitido");
			}
			else
			{
				MessageBox.Show("Acceso Denegado");
			}
		}
	}
}