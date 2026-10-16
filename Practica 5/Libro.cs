using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practica_5
{
	internal class Libro
	{
		private string titulo;

		public string AsignarTitutlo { 
			set { titulo = value; }
		}
		public void GuardarTitulo()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\libros.txt", true);
			archivo.WriteLine(titulo);
			archivo.Flush();
			archivo.Close();
		}
	}
}
