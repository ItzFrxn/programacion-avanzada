namespace Practica_4
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
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.lstNombres = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(405, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Administracion de Personas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre:";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(126, 77);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(127, 20);
			this.txtNombres.TabIndex = 2;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.White;
			this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(259, 74);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(109, 23);
			this.btnRegistrar.TabIndex = 3;
			this.btnRegistrar.Text = "Registrar:";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// lstNombres
			// 
			this.lstNombres.FormattingEnabled = true;
			this.lstNombres.Location = new System.Drawing.Point(40, 132);
			this.lstNombres.Name = "lstNombres";
			this.lstNombres.Size = new System.Drawing.Size(355, 277);
			this.lstNombres.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(434, 450);
			this.Controls.Add(this.lstNombres);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Administrador de Personas";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.ListBox lstNombres;
	}
}

