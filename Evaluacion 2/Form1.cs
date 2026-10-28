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

namespace Evaluacion_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (txtAlumno.Text == "" || cboMaterias.Text == "" || txtCalificacion.Text == "")
			{
				MessageBox.Show("Campos vacios");
			}
			else if (Convert.ToDouble(txtCalificacion.Text) > 10)

			{
				MessageBox.Show("Solo calificacion menor a 10");
			}
			else if (Convert.ToDouble(txtCalificacion.Text) <= 0)
			{
				MessageBox.Show("Solo calificaion mayor a 0");
			}
			else
			{
				Calificacion alumno = new Calificacion(txtAlumno.Text, cboMaterias.Text, Convert.ToDouble(txtCalificacion.Text));
				alumno.RegistrarCalificaion();

				MostrarCalificacion();
				Promedio();
				MostrarPromedio();

				txtAlumno.Text = "";
				cboMaterias.Text = "";
				txtCalificacion.Text = "";
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cboMaterias.Items.Add("Español");
			cboMaterias.Items.Add("Fisica");
			cboMaterias.Items.Add("Quimica");
			cboMaterias.Items.Add("Matematicas");

			lstvwCalificacion.Columns.Add("Alumno", 80);
			lstvwCalificacion.Columns.Add("Materia", 80);
			lstvwCalificacion.Columns.Add("Calificacion", 100);

			lstvwCalificacion.View = View.Details;
			lstvwCalificacion.GridLines = true;
			lstvwCalificacion.CheckBoxes = true;

			lstvwPromedio.Columns.Add("Materia", 80);
			lstvwPromedio.Columns.Add("Promedio", 90);

			lstvwPromedio.View = View.Details;
			lstvwPromedio.GridLines = true;
			lstvwPromedio.CheckBoxes = true;

			MostrarCalificacion();
			Promedio();
			MostrarPromedio();
		}

		private void MostrarCalificacion()
		{
			lstvwCalificacion.Items.Clear();
			StreamReader archivo = new StreamReader(@"..\..\Archivos\calificacion.txt");
			string linea = archivo.ReadLine();
			while (linea != null)
			{
				string[] datos = linea.Split('|');
				ListViewItem item = new ListViewItem(datos);
				lstvwCalificacion.Items.Add(item);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}
		private void MostrarPromedio()
		{
			lstvwPromedio.Items.Clear();
			StreamReader archivo = new StreamReader(@"..\..\Archivos\promedio.txt");
			string linea = archivo.ReadLine();
			this.lstvwPromedio.Items.Clear();
			while (linea != null)
			{
				string[] datos = linea.Split('|');
				ListViewItem item = new ListViewItem(datos);
				lstvwPromedio.Items.Add(item);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}

		private void Promedio()
		{
			int contadorEsp = 0, contadorMat = 0, contadorQui = 0, contadorFis = 0;
			double calificacionEsp = 0, calificacionMat = 0, calificacionQui = 0, calificacionFis = 0;
			double promedioEsp = 0, promedioMat = 0, promedioQui = 0, promedioFis = 0;

			StreamWriter txtx = new StreamWriter(@"..\..\Archivos\promedio.txt");
			txtx.Close();

			StreamReader archivo = new StreamReader(@"..\..\Archivos\calificacion.txt");
			string linea = archivo.ReadLine();
			while (linea != null)
			{
				string[] datos = linea.Split('|');
				string materia = datos[1];
				double promedio = Convert.ToDouble(datos[2]);
				if (materia == "Español")
				{
					calificacionEsp += promedio;
					contadorEsp++;
				}
				else if (materia == "Matematicas")
				{
					calificacionMat += promedio;
					contadorMat++;
				}
				else if (materia == "Fisica")
				{
					calificacionFis += promedio;
					contadorFis++;
				}
				else if (materia == "Quimica")
				{
					calificacionQui += promedio;
					contadorQui++;
				}
				linea = archivo.ReadLine();
			}
			archivo.Close();

			promedioEsp = calificacionEsp / contadorEsp;
			promedioMat = calificacionMat / contadorMat;
			promedioFis = calificacionFis / contadorFis;
			promedioQui = calificacionQui / contadorQui;

			Promedio materiaEsp = new Promedio("Español", promedioEsp);
			materiaEsp.RegistrarPromedio();
			Promedio materiaMat = new Promedio("Matematicas", promedioMat);
			materiaMat.RegistrarPromedio();
			Promedio materiaQui = new Promedio("Quimica", promedioQui);
			materiaQui.RegistrarPromedio();
			Promedio materiaFis = new Promedio("Fisica", promedioFis);
			materiaFis.RegistrarPromedio();
		}
	}
}
