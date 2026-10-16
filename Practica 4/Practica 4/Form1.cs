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

namespace Practica_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			persona.AsignarNombre = this.txtNombres.Text;
			persona.GuardarNombre();
			LeerArchivo();
			this.txtNombres.ResetText();
			this.txtNombres.Focus(); // regresa el cursor
		}

		private void LeerArchivo()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\personas.txt"); // lee el archivo
			string linea = archivo.ReadLine();
			this.lstNombres.Items.Clear();
			while (linea != null)
			{
				this.lstNombres.Items.Add(linea); // muestra informacion en forma de lista
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