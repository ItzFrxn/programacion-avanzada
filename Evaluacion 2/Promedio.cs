using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2
{
	internal class Promedio
	{
		private string materia;
		private double promedio;

		public Promedio(string materia, double promedio)
		{
			this.materia = materia;
			this.promedio = promedio;
		}

		public void RegistrarPromedio()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\promedio.txt", true);
			archivo.WriteLine(materia + "|" + promedio);
			archivo.Close();
		}
	}
}
