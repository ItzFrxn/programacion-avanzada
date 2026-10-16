using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Practica_10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cboCategoria.Items.Add("Basico");
			cboCategoria.Items.Add("Intermedio");
			cboCategoria.Items.Add("Avanzado");
			cboCategoria.Items.Add("Master");

			lstvwListado.Columns.Add("Nombre", 150);
			lstvwListado.Columns.Add("Categoria", 80);
			lstvwListado.Columns.Add("Costo", 80);
			lstvwListado.Columns.Add("Capacidad", 80);

			lstvwListado.View = View.Details;
			lstvwListado.GridLines = true;
			LeerArchivo();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if (txtCapacidad.Text == "" || cboCategoria.Text == "" || txtCosto.Text == "" || txtNombre.Text == "")
			{
				MessageBox.Show("Campos Vacios");
				return;
			}
			RegistraCurso registro = new RegistraCurso(txtNombre.Text, cboCategoria.Text, Convert.ToDouble(txtCosto.Text), Convert.ToInt32(txtCapacidad.Text));
			registro.GuardarInfo();
			LeerArchivo();
		}

		private void LeerArchivo()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\cursos.txt");
			lstvwListado.Items.Clear();
			string linea = archivo.ReadLine();
			while (linea != null)
			{
				string[] datos = linea.Split('|');
				ListViewItem item = new ListViewItem(datos);
				lstvwListado.Items.Add(item);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}
	}
}