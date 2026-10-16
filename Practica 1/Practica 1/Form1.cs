using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSumar_Click(object sender, EventArgs e)
		{
			Operacion suma = new Operacion();
			suma.AsignarValor1 = Convert.ToInt32(this.txtValor1.Text);
			suma.AsignarValor2 = Convert.ToInt32(this.txtValor2.Text);
			suma.AsignarOperador = "suma";
			MessageBox.Show("El resultado es:" + suma.RealizarOperacion);
		}

		private void btnRestar_Click(object sender, EventArgs e)
		{
			Operacion resta = new Operacion();
			resta.AsignarValor1 = Convert.ToInt32(this.txtValor1.Text);
			resta.AsignarValor2 = Convert.ToInt32(this.txtValor2.Text);
			resta.AsignarOperador = "resta";
			MessageBox.Show("El resultado es:" + resta.RealizarOperacion);
		}

		private void btnMultiplicar_Click(object sender, EventArgs e)
		{
			Operacion multiplicacion = new Operacion();
			multiplicacion.AsignarValor1 = Convert.ToInt32(this.txtValor1.Text);
			multiplicacion.AsignarValor2 = Convert.ToInt32(this.txtValor2.Text);
			multiplicacion.AsignarOperador = "multiplicacion";
			MessageBox.Show("El resultado es:" + multiplicacion.RealizarOperacion);
		}

		private void btnDividir_Click(object sender, EventArgs e)
		{
			Operacion division = new Operacion();
			division.AsignarValor1 = Convert.ToInt32(this.txtValor1.Text);
			division.AsignarValor2 = Convert.ToInt32(this.txtValor2.Text);
			division.AsignarOperador = "division";
			MessageBox.Show("El resultado es:" + division.RealizarOperacion);
		}
	}
}