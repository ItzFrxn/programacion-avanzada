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

namespace Practica_11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if(txtNombre.Text == "" || txtNumero.Text == "" || txtSalario.Text == "" || cboPosicion.Text == "")
			{
				MessageBox.Show("Campos vacios");
				return;
			}
			Jugador jugador = new Jugador(txtNombre.Text, cboPosicion.Text, Convert.ToInt32(txtNumero.Text), Convert.ToDouble(txtSalario.Text));
			jugador.RegistrarJugador();
			MostrarJugadores();

			txtNombre.Text = "";
			txtNumero.Text = "";
			txtSalario.Text = "";
			cboPosicion.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cboPosicion.Items.Add("Portero");
			cboPosicion.Items.Add("Defensa");
			cboPosicion.Items.Add("Medio");
			cboPosicion.Items.Add("Delantero");

			lstvwJugadores.Columns.Add("Nombre", 150);
			lstvwJugadores.Columns.Add("Posicion", 80);
			lstvwJugadores.Columns.Add("Numero", 80);
			lstvwJugadores.Columns.Add("Salario", 80);

			lstvwJugadores.View = View.Details;
			lstvwJugadores.GridLines = true;
			lstvwJugadores.CheckBoxes = true;

			MostrarJugadores();
		}

		public void MostrarJugadores()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\jugador.txt");
			lstvwJugadores.Items.Clear();
			string linea = archivo.ReadLine();
			while (linea != null)
			{
				string[] datos = linea.Split('|');
				ListViewItem item = new ListViewItem(datos);
				lstvwJugadores.Items.Add(item);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}
		private void ActualizarArchivo()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\jugador.txt");
			int cantidad = lstvwJugadores.Items.Count;
			for (int x = 0; x < cantidad; x++)
			{
				string nombre = lstvwJugadores.Items[x].SubItems[0].Text;
				string posicion = lstvwJugadores.Items[x].SubItems[1].Text;
				string numero = lstvwJugadores.Items[x].SubItems[2].Text;
				string salario = lstvwJugadores.Items[x].SubItems[3].Text;

				archivo.WriteLine(nombre + "|" + posicion+ "|" + numero + "|" + salario);

			}
			archivo.Flush();
			archivo.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (lstvwJugadores.CheckedIndices.Count == 0)
			{
				MessageBox.Show("No hay elementos seleccionados");
				return;
			}
			DialogResult respuesta = MessageBox.Show("Deseas eliminanr los datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				for (int i = lstvwJugadores.CheckedIndices.Count - 1; i >= 0; i--)
				{
					lstvwJugadores.Items.RemoveAt(lstvwJugadores.CheckedIndices[i]);
				}
				ActualizarArchivo();
			}
		}
	}
}
