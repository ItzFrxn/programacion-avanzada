using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2
{
	internal class Calificacion
	{
		private string alumno;
		private string materia;
		private double calificacion;

		public Calificacion(string alumno, string materia, double calificacion)
		{
			this.alumno = alumno;
			this.materia = materia;
			this.calificacion = calificacion;
		}

		public void RegistrarCalificaion()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\calificacion.txt", true);
			archivo.WriteLine(alumno + "|" + materia+ "|" + calificacion);
			archivo.Flush();
			archivo.Close();
		}
	}
}
