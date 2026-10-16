using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
	internal class Promedio
	{
		private double quimica;
		private double fisica;
		private double matematicas;
		private double espanol;
		private double promedio;

		public double CalificacionQuimica
		{
			set
			{
				quimica = value;
			}
		}

		public double CalificacionFisica
		{
			set
			{
				fisica = value;
			}
		}

		public double CalificacionMatematicas
		{
			set
			{
				matematicas = value;
			}
		}

		public double CalificacionEspanol
		{
			set
			{
				espanol = value;
			}
		}

		public double obtenerPromedio
		{
			get
			{
				promedio = (matematicas + espanol + fisica + quimica) / 4;
				return promedio;
			}
		}
	}
}