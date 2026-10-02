namespace Practica_7
{
	partial class frm
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.btnRegistro = new System.Windows.Forms.Button();
			this.lstNombres = new System.Windows.Forms.ListBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(61, 54);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(126, 54);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(113, 20);
			this.txtNombres.TabIndex = 1;
			// 
			// btnRegistro
			// 
			this.btnRegistro.Location = new System.Drawing.Point(99, 93);
			this.btnRegistro.Name = "btnRegistro";
			this.btnRegistro.Size = new System.Drawing.Size(88, 24);
			this.btnRegistro.TabIndex = 2;
			this.btnRegistro.Text = "Registrar";
			this.btnRegistro.UseVisualStyleBackColor = true;
			this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
			// 
			// lstNombres
			// 
			this.lstNombres.FormattingEnabled = true;
			this.lstNombres.Location = new System.Drawing.Point(64, 130);
			this.lstNombres.Name = "lstNombres";
			this.lstNombres.Size = new System.Drawing.Size(165, 186);
			this.lstNombres.TabIndex = 3;
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Location = new System.Drawing.Point(70, 355);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(52, 13);
			this.lblCantidad.TabIndex = 4;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(129, 354);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(0, 13);
			this.lblNumero.TabIndex = 5;
			// 
			// frm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 450);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lstNombres);
			this.Controls.Add(this.btnRegistro);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.lblNombre);
			this.Name = "frm";
			this.Text = "Personas";
			this.Load += new System.EventHandler(this.frm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Button btnRegistro;
		private System.Windows.Forms.ListBox lstNombres;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblNumero;
	}
}

