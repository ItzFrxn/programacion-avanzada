using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practica_7
{
	internal class Persona
	{
		private string nombre;
		public string setNombre { set { nombre = value; } }
		
		 public void guardarNombre()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\Personas.txt", true);
			archivo.WriteLine(nombre);
			archivo.Flush();  
			archivo.Close();
		}
	}
}
