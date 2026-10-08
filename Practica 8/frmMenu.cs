using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void tmrFecha_Tick(object sender, EventArgs e)
		{
			this.tlpFecha.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
		}
	}
}
