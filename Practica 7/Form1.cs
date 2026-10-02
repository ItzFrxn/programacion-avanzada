using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7
{
	public partial class frm : Form
	{
		public frm()
		{
			InitializeComponent();
		}

		private void btnRegistro_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			persona.setNombre = txtNombres.Text;
			persona.guardarNombre();
			txtNombres.ResetText();
			txtNombres.Focus();
			mostrarNombre();
			contadorNombres();

		}

		private void mostrarNombre()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\Personas.txt");
			string linea = archivo.ReadLine();
			lstNombres.Items.Clear();
			while (linea != null)
			{
				lstNombres.Items.Add(linea);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}
		
		private void contadorNombres()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\Personas.txt");
			string linea = archivo.ReadLine();
			int contador = 0;
			while(linea != null)
			{
				linea = archivo.ReadLine();
				contador++;
			}
			archivo.Close();
			lblNumero.Text = contador.ToString();
		}
		
		private void frm_Load(object sender, EventArgs e)
		{
			mostrarNombre();
			contadorNombres();
		}
	}
}
