using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
	internal class RegistraCurso
	{
		private string curso, categoria;
		private double costo;
		private int capacidad;

		public RegistraCurso(string curso, string categoria, double costo, int capacidad)
		{
			this.curso = curso;
			this.categoria = categoria;
			this.costo = costo;
			this.capacidad = capacidad;
		}

		public void GuardarInfo()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\cursos.txt", true);
			archivo.WriteLine(curso + "|" + categoria + "|" + costo + "|" + capacidad);
			archivo.Flush();
			archivo.Close();
		}
	}
}