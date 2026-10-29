using System;
using System.Collections;
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
			else if (Convert.ToDouble(txtCalificacion.Text) > 10 || Convert.ToDouble(txtCalificacion.Text) < 0)

			{
				MessageBox.Show("Solo calificacion mayor a 0 y menor a 10");
			}
			else
			{
				Calificacion alumno = new Calificacion(txtAlumno.Text, cboMaterias.Text, Convert.ToDouble(txtCalificacion.Text));
				alumno.RegistrarCalificaion();

				MostrarCalificacion();
				Promedio();
				MostrarPromedio();
				CantidadAlumnos();
				MateriaAlta();

				txtAlumno.Text = "";
				cboMaterias.Text = "";
				txtCalificacion.Text = "";
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\materias.txt");
			string linea = archivo.ReadLine();
			while (linea != null)
			{
				cboMaterias.Items.Add(linea);
				linea = archivo.ReadLine();
			}
			archivo.Close();

			lstvwCalificacion.Columns.Add("Alumno", 80);
			lstvwCalificacion.Columns.Add("Materia", 80);
			lstvwCalificacion.Columns.Add("Calificacion", 100);

			lstvwCalificacion.View = View.Details;
			lstvwCalificacion.GridLines = true;

			lstvwPromedio.Columns.Add("Materia", 80);
			lstvwPromedio.Columns.Add("Promedio", 90);

			lstvwPromedio.View = View.Details;
			lstvwPromedio.GridLines = true;

			MostrarCalificacion();
			Promedio();
			MostrarPromedio();
			CantidadAlumnos();
			CantidadMaterias();
			MateriaAlta();
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

		private void soloNumeros(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&	e.KeyChar != '.')
			{
				MessageBox.Show("Solo se permiten numeros.");
				e.Handled = true;
			}
			if (e.KeyChar == '.' && txtCalificacion.Text.Contains("."))
			{
				e.Handled = true;
			}
		}

		private void soloLetras(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
			{
				MessageBox.Show("Solo se permiten letras.");
				e.Handled = true;
			}
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


			Promedio materiaMat = new Promedio("Matematicas", promedioMat);
			materiaMat.RegistrarPromedio();
			Promedio materiaEsp = new Promedio("Español", promedioEsp);
			materiaEsp.RegistrarPromedio();
			Promedio materiaQui = new Promedio("Quimica", promedioQui);
			materiaQui.RegistrarPromedio();
			Promedio materiaFis = new Promedio("Fisica", promedioFis);
			materiaFis.RegistrarPromedio();
		}

		private void tmrFecha_Tick(object sender, EventArgs e)
		{
			tlpFecha.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
		}

		private void CantidadAlumnos()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\calificacion.txt");
			string linea = archivo.ReadLine();
			int ContadorAlumnos = 0;
			while (linea != null)
			{
				ContadorAlumnos++;
				linea = archivo.ReadLine();
			}
			archivo.Close();
			tlpCantAlm.Text = ContadorAlumnos.ToString();
		}

		private void CantidadMaterias()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\materias.txt");
			string linea = archivo.ReadLine();
			int ContadorMaterias = 0;
			while (linea != null)
			{
				ContadorMaterias++;
				linea = archivo.ReadLine();
			}
			archivo.Close();
			tlpCantMat.Text = ContadorMaterias.ToString();
		}

		private void MateriaAlta()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\promedio.txt");
			string linea = archivo.ReadLine();
			string materiaAlta = "";
			double promedioAlto = 0.0;

			while (linea != null)
			{

				string[] datos = linea.Split('|');
				string datoMateria = datos[0];
				double datoPromedio = Convert.ToDouble(datos[1]);

				if (datoPromedio > promedioAlto)
				{
					materiaAlta = datoMateria;
					promedioAlto = datoPromedio;
				}
				linea = archivo.ReadLine();
			}
			archivo.Close();
			tlpMateria.Text = materiaAlta + ": " + promedioAlto;
		}
	}
}
