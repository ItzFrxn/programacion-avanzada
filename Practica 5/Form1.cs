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

namespace Practica_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Libro tltLibro = new Libro();

			tltLibro.AsignarTitutlo = this.txtTitulo.Text;
			tltLibro.GuardarTitulo();
			LeerArchivo();
			this.txtTitulo.ResetText();
			this.txtTitulo.Focus();
		}
		private void LeerArchivo()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\libros.txt");
			string linea = archivo.ReadLine();
			this.lstLibros.Items.Clear();
			while (linea != null)
			{

				this.lstLibros.Items.Add(linea);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LeerArchivo();
		}
	}
}
