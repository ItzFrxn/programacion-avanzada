using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
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
			login.asignarUsuario = this.txtUsuario.Text;
			login.asignarContrasena = this.txtContrasena.Text;
			if (login.obtenerStatus)
			{
				//MessageBox.Show("Acceso Permitido");
				this.Hide();
				FrmMenu forma = new FrmMenu();
				forma.Show();
			}
			else
			{
				MessageBox.Show("Acceso Denegado");
			}
		}
	}
}