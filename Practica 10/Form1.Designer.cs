namespace Practica_10
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCategoria = new System.Windows.Forms.Label();
			this.cboCategoria = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCapacidad = new System.Windows.Forms.TextBox();
			this.lstvwListado = new System.Windows.Forms.ListView();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label1.Location = new System.Drawing.Point(251, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(285, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "REGISTRO DE CURSOS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(43, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE:";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.txtNombre.Location = new System.Drawing.Point(195, 102);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(121, 29);
			this.txtNombre.TabIndex = 2;
			// 
			// txtCategoria
			// 
			this.txtCategoria.AutoSize = true;
			this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.txtCategoria.Location = new System.Drawing.Point(43, 151);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(125, 24);
			this.txtCategoria.TabIndex = 3;
			this.txtCategoria.Text = "CATEGORIA:";
			// 
			// cboCategoria
			// 
			this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.cboCategoria.FormattingEnabled = true;
			this.cboCategoria.Location = new System.Drawing.Point(195, 143);
			this.cboCategoria.Name = "cboCategoria";
			this.cboCategoria.Size = new System.Drawing.Size(121, 32);
			this.cboCategoria.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(43, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "COSTO:";
			// 
			// txtCosto
			// 
			this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.txtCosto.Location = new System.Drawing.Point(195, 192);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(121, 29);
			this.txtCosto.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label4.Location = new System.Drawing.Point(43, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "CAPACIDAD:";
			// 
			// txtCapacidad
			// 
			this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.txtCapacidad.Location = new System.Drawing.Point(195, 236);
			this.txtCapacidad.Name = "txtCapacidad";
			this.txtCapacidad.Size = new System.Drawing.Size(121, 29);
			this.txtCapacidad.TabIndex = 9;
			// 
			// lstvwListado
			// 
			this.lstvwListado.HideSelection = false;
			this.lstvwListado.Location = new System.Drawing.Point(368, 81);
			this.lstvwListado.Name = "lstvwListado";
			this.lstvwListado.Size = new System.Drawing.Size(395, 320);
			this.lstvwListado.TabIndex = 10;
			this.lstvwListado.UseCompatibleStateImageBehavior = false;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnRegistrar.Location = new System.Drawing.Point(116, 302);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(137, 39);
			this.btnRegistrar.TabIndex = 11;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnEliminar.Location = new System.Drawing.Point(116, 347);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(137, 39);
			this.btnEliminar.TabIndex = 12;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.lstvwListado);
			this.Controls.Add(this.txtCapacidad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboCategoria);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Practica 10";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label txtCategoria;
		private System.Windows.Forms.ComboBox cboCategoria;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCapacidad;
		private System.Windows.Forms.ListView lstvwListado;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnEliminar;
	}
}

