using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
	internal class Operacion  //clase
	{
		private int valor1;   //encapsulamiento
		private int valor2;
		private int resultado;
		private string operador;

		public int AsignarValor1   //metodos
		{
			set
			{
				valor1 = value;
			}
		}

		public int AsignarValor2
		{
			set
			{
				valor2 = value;
			}
		}

		public string AsignarOperador
		{
			set
			{
				operador = value;
			}
		}

		public int RealizarOperacion
		{
			get
			{
				if (operador == "suma")
				{
					resultado = valor1 + valor2;
				}
				if (operador == "resta")
				{
					resultado = valor1 - valor2;
				}
				if (operador == "multiplicacion")
				{
					resultado = valor1 * valor2;
				}
				if (operador == "division")
				{
					resultado = valor1 / valor2;
				}

				return resultado;
			}
		}
	}
}