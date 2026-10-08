using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_8
{
	internal class Login
	{
		private string usuario;
		private string contrasena;
		private bool estatus;

		public string asignarUsuario
		{
			set
			{
				usuario = value;
			}
		}

		public string asignarContrasena
		{
			set
			{
				contrasena = value;
			}
		}

		public bool obtenerStatus
		{
			get
			{
				StreamReader archivo = new StreamReader(@"..\..\Archivos\usuarios.txt");
				string linea = archivo.ReadLine();
				while (linea != null)
				{
					string[] datos = linea.Split('.');
					if (usuario == datos[0] && contrasena == datos[1])
					{
						estatus = true;
					}
					linea = archivo.ReadLine();
				}
				archivo.Close();
				return estatus;
			}
		}
	}
}