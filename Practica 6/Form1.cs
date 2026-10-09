using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Cuenta cuenta = new Cuenta();
		private int limiteMovimientos = 10;
		private int limiteDepositos = 3;

		private void btnDeposito_Click(object sender, EventArgs e)
		{
			if (limiteMovimientos == 0)
			{
				MessageBox.Show("Alcanzo el limite de 10 movimientos.");
				return;
			}
			if (limiteDepositos == 0)
			{
				MessageBox.Show("Supero el limite de 3 depositos.");
				return;
			}
			if (txtDeposito.Text == "")
			{
				MessageBox.Show("Ingrese una cantidad para depositar.");
				return;
			}
			if ((Convert.ToDouble(txtDeposito.Text) + cuenta.ObtenerSaldo) > 150000)
			{
				MessageBox.Show("No puede pasar el limite de saldo de $150,000.");
				return;
			}
			if (Convert.ToDouble(txtDeposito.Text) > 10000)
			{
				MessageBox.Show("Ingrese una cantidad menor a $10,000");
				return;
			}
			if (Convert.ToDouble(txtDeposito.Text) <= 0)
			{
				MessageBox.Show("Ingrese una cantidad mayor a $0");
				return;
			}
			cuenta.RealizarDeposito = Convert.ToDouble(txtDeposito.Text);
			cuenta.GuardarDeposito();
			txtDeposito.Clear();
			txtDeposito.Focus();
			limiteDepositos--;
			limiteMovimientos--;
			LeerDeposito();
			LeerSaldo();
		}

		private void btnRetiro_Click(object sender, EventArgs e)
		{
			if (limiteMovimientos == 0)
			{
				MessageBox.Show("Alcanzo el limite de 10 movimientos.");
				return;
			}
			if (txtRetiro.Text == "")
			{
				MessageBox.Show("Ingrese una cantidad para retirar.");
				return;
			}
			if (Convert.ToDouble(txtRetiro.Text) > cuenta.ObtenerSaldo)
			{
				MessageBox.Show("La cantidad supera su saldo");
				return;
			}
			if (Convert.ToDouble(txtRetiro.Text) > 5000)
			{
				MessageBox.Show("Ingrese una cantidad menor a $5,000.");
				return;
			}
			if (Convert.ToDouble(txtRetiro.Text) <= 0)
			{
				MessageBox.Show("Ingrese una cantidad mayor a $0");
				return;
			}
			cuenta.RealizarRetiro = Convert.ToDouble(txtRetiro.Text);
			cuenta.GuardarRetiro();
			txtRetiro.Clear();
			txtRetiro.Focus();
			limiteMovimientos--;
			LeerRetiro();
			LeerSaldo();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LeerDeposito();
			LeerRetiro();
			LeerSaldo();
		}

		private void LeerDeposito()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\deposito.txt");
			string linea = archivo.ReadLine();
			lstDeposito.Items.Clear();
			while (linea != null)
			{
				lstDeposito.Items.Add("[+] $" + linea);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}

		private void LeerRetiro()
		{
			StreamReader archivo = new StreamReader(@"..\..\Archivos\retiro.txt");
			string linea = archivo.ReadLine();
			lstRetiro.Items.Clear();
			while (linea != null)
			{
				lstRetiro.Items.Add("[-] $" + linea);
				linea = archivo.ReadLine();
			}
			archivo.Close();
		}

		private void LeerSaldo()
		{
			double saldo = 0;
			StreamReader archivoDeposito = new StreamReader(@"..\..\Archivos\deposito.txt");
			string lineaDeposito = archivoDeposito.ReadLine();
			while (lineaDeposito != null)
			{
				saldo = saldo + Convert.ToDouble(lineaDeposito);
				lineaDeposito = archivoDeposito.ReadLine();
			}
			archivoDeposito.Close();

			StreamReader archivoRetiro = new StreamReader(@"..\..\Archivos\retiro.txt");
			string lineaRetiro = archivoRetiro.ReadLine();
			while (lineaRetiro != null)
			{
				saldo = saldo - Convert.ToDouble(lineaRetiro);
				lineaRetiro = archivoRetiro.ReadLine();
			}
			archivoRetiro.Close();

			cuenta.EstablecerSaldo = saldo;
			lblCantidad.Text = cuenta.ObtenerSaldo.ToString("C2");
		}

		private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}
	}
}