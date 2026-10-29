namespace Evaluacion_2
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAlumno = new System.Windows.Forms.TextBox();
			this.cboMaterias = new System.Windows.Forms.ComboBox();
			this.txtCalificacion = new System.Windows.Forms.TextBox();
			this.lstvwCalificacion = new System.Windows.Forms.ListView();
			this.lstvwPromedio = new System.Windows.Forms.ListView();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpCantAlm = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpMateria = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpCantMat = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpFecha = new System.Windows.Forms.ToolStripStatusLabel();
			this.tmrFecha = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(150, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ALUMNO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(150, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "MATERIAS";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(150, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "CALIFICACIÓN";
			// 
			// txtAlumno
			// 
			this.txtAlumno.Location = new System.Drawing.Point(237, 31);
			this.txtAlumno.Name = "txtAlumno";
			this.txtAlumno.Size = new System.Drawing.Size(100, 20);
			this.txtAlumno.TabIndex = 3;
			this.txtAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloLetras);
			// 
			// cboMaterias
			// 
			this.cboMaterias.FormattingEnabled = true;
			this.cboMaterias.Location = new System.Drawing.Point(237, 77);
			this.cboMaterias.Name = "cboMaterias";
			this.cboMaterias.Size = new System.Drawing.Size(121, 21);
			this.cboMaterias.TabIndex = 4;
			// 
			// txtCalificacion
			// 
			this.txtCalificacion.Location = new System.Drawing.Point(237, 128);
			this.txtCalificacion.Name = "txtCalificacion";
			this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
			this.txtCalificacion.TabIndex = 5;
			this.txtCalificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
			// 
			// lstvwCalificacion
			// 
			this.lstvwCalificacion.HideSelection = false;
			this.lstvwCalificacion.Location = new System.Drawing.Point(88, 235);
			this.lstvwCalificacion.Name = "lstvwCalificacion";
			this.lstvwCalificacion.Size = new System.Drawing.Size(270, 140);
			this.lstvwCalificacion.TabIndex = 6;
			this.lstvwCalificacion.UseCompatibleStateImageBehavior = false;
			// 
			// lstvwPromedio
			// 
			this.lstvwPromedio.HideSelection = false;
			this.lstvwPromedio.Location = new System.Drawing.Point(439, 235);
			this.lstvwPromedio.Name = "lstvwPromedio";
			this.lstvwPromedio.Size = new System.Drawing.Size(230, 140);
			this.lstvwPromedio.TabIndex = 7;
			this.lstvwPromedio.UseCompatibleStateImageBehavior = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(508, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "PROMEDIO";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(172, 203);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "CALIFICACION";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(439, 54);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 10;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tlpCantAlm,
            this.toolStripStatusLabel2,
            this.tlpMateria,
            this.toolStripStatusLabel3,
            this.tlpCantMat,
            this.toolStripStatusLabel4,
            this.tlpFecha});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
			this.toolStripStatusLabel1.Text = "Cantidad Alumnos:";
			// 
			// tlpCantAlm
			// 
			this.tlpCantAlm.Name = "tlpCantAlm";
			this.tlpCantAlm.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(97, 17);
			this.toolStripStatusLabel2.Text = "Materia mas alta:";
			// 
			// tlpMateria
			// 
			this.tlpMateria.Name = "tlpMateria";
			this.tlpMateria.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(106, 17);
			this.toolStripStatusLabel3.Text = "Cantidad materias:";
			// 
			// tlpCantMat
			// 
			this.tlpCantMat.Name = "tlpCantMat";
			this.tlpCantMat.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(77, 17);
			this.toolStripStatusLabel4.Text = "Fecha y hora:";
			// 
			// tlpFecha
			// 
			this.tlpFecha.Name = "tlpFecha";
			this.tlpFecha.Size = new System.Drawing.Size(0, 17);
			// 
			// tmrFecha
			// 
			this.tmrFecha.Enabled = true;
			this.tmrFecha.Interval = 1000;
			this.tmrFecha.Tick += new System.EventHandler(this.tmrFecha_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lstvwPromedio);
			this.Controls.Add(this.lstvwCalificacion);
			this.Controls.Add(this.txtCalificacion);
			this.Controls.Add(this.cboMaterias);
			this.Controls.Add(this.txtAlumno);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Calificaciones";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAlumno;
		private System.Windows.Forms.ComboBox cboMaterias;
		private System.Windows.Forms.TextBox txtCalificacion;
		private System.Windows.Forms.ListView lstvwCalificacion;
		private System.Windows.Forms.ListView lstvwPromedio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel tlpCantAlm;
		private System.Windows.Forms.ToolStripStatusLabel tlpMateria;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel tlpCantMat;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel tlpFecha;
		private System.Windows.Forms.Timer tmrFecha;
	}
}

