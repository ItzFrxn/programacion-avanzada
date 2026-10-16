using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
	internal class Login
	{
		private string usuario;
		private string contrasena;
		private bool estatus;

		public string AsignarUsuario
		{
			set
			{
				usuario = value;
			}
		}

		public string AsignarContrasena
		{
			set
			{
				contrasena = value;
			}
		}

		public bool obtenerEstatus
		{
			get
			{
				if (usuario == "admin" && contrasena == "1234")
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}
}