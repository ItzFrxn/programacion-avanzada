using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_11
{
	internal class Jugador
	{
		private string nombre;
		private string posicion;
		private int numero;
		private double salario;

		public Jugador(string no, string p, int nu, double s)
		{
			nombre = no;
			posicion = p;
			numero = nu;
			salario = s;
		} 

		public void RegistrarJugador()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\Archivos\jugador.txt", true);
			archivo.WriteLine(nombre + "|" + posicion + "|" + numero + "|" + salario);
			archivo.Flush();
			archivo.Close();
		}
	}
}
