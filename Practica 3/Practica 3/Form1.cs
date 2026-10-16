using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnPromedio_Click(object sender, EventArgs e)
		{
			Promedio promedio = new Promedio();
			promedio.CalificacionEspanol = Convert.ToDouble(this.txtEspanol.Text);
			promedio.CalificacionFisica = Convert.ToDouble(this.txtFisica.Text);
			promedio.CalificacionMatematicas = Convert.ToDouble(this.txtMate.Text);
			promedio.CalificacionQuimica = Convert.ToDouble(this.txtQuimica.Text);
			MessageBox.Show("El promedio general es: " + promedio.obtenerPromedio);
		}
	}
}