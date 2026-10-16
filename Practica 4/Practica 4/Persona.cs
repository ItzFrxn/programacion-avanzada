using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_4
{
	internal class Persona
	{
		private string nombre;

		public string AsignarNombre
		{
			set
			{
				nombre = value;
			}
		}

		public void GuardarNombre()
		{
			// true, para no sobreescribir
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\personas.txt", true);
			archivo.WriteLine(nombre);
			archivo.Flush();  // libera memoria
			archivo.Close();
		}
	}
}