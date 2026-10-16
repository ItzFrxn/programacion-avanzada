namespace Practica_5
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
			this.btnAgregar = new System.Windows.Forms.Button();
			this.lblLibros = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.lstLibros = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(240, 82);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// lblLibros
			// 
			this.lblLibros.AutoSize = true;
			this.lblLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLibros.Location = new System.Drawing.Point(90, 9);
			this.lblLibros.Name = "lblLibros";
			this.lblLibros.Size = new System.Drawing.Size(160, 42);
			this.lblLibros.TabIndex = 1;
			this.lblLibros.Text = "LIBROS";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(25, 87);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(33, 13);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Titulo";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(64, 84);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(100, 20);
			this.txtTitulo.TabIndex = 3;
			// 
			// lstLibros
			// 
			this.lstLibros.FormattingEnabled = true;
			this.lstLibros.Location = new System.Drawing.Point(28, 141);
			this.lstLibros.Name = "lstLibros";
			this.lstLibros.Size = new System.Drawing.Size(300, 251);
			this.lstLibros.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 450);
			this.Controls.Add(this.lstLibros);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblLibros);
			this.Controls.Add(this.btnAgregar);
			this.Name = "Form1";
			this.Text = "Practica 5";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label lblLibros;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.ListBox lstLibros;
	}
}

