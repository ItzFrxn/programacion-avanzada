using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
	internal class Cuenta
	{
		private double deposito;
		private double retiro;
		private double saldo;

		public double RealizarDeposito
		{
			set
			{
				deposito = value;
				saldo = saldo + deposito;
			}
		}

		public double ObtenerSaldo
		{
			get
			{
				return saldo;
			}
		}

		public double RealizarRetiro
		{
			set
			{
				retiro = value;
				saldo = saldo - retiro;
			}
		}

		public double EstablecerSaldo
		{
			set
			{
				saldo = value;
			}
		}

		public void GuardarDeposito()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\deposito.txt", true);
			archivo.WriteLine(deposito);
			archivo.Flush();
			archivo.Close();
		}

		public void GuardarRetiro()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\retiro.txt", true);
			archivo.WriteLine(retiro);
			archivo.Flush();
			archivo.Close();
		}
	}
}