namespace Practica_3
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
			this.txtMate = new System.Windows.Forms.TextBox();
			this.txtFisica = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtQuimica = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEspanol = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnPromedio = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(92, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "PROMEDIO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Matematicas:";
			// 
			// txtMate
			// 
			this.txtMate.Location = new System.Drawing.Point(146, 115);
			this.txtMate.Name = "txtMate";
			this.txtMate.Size = new System.Drawing.Size(100, 20);
			this.txtMate.TabIndex = 2;
			// 
			// txtFisica
			// 
			this.txtFisica.Location = new System.Drawing.Point(146, 160);
			this.txtFisica.Name = "txtFisica";
			this.txtFisica.Size = new System.Drawing.Size(100, 20);
			this.txtFisica.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Fisica";
			// 
			// txtQuimica
			// 
			this.txtQuimica.Location = new System.Drawing.Point(146, 209);
			this.txtQuimica.Name = "txtQuimica";
			this.txtQuimica.Size = new System.Drawing.Size(100, 20);
			this.txtQuimica.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 24);
			this.label4.TabIndex = 5;
			this.label4.Text = "Quimica:";
			// 
			// txtEspanol
			// 
			this.txtEspanol.Location = new System.Drawing.Point(146, 266);
			this.txtEspanol.Name = "txtEspanol";
			this.txtEspanol.Size = new System.Drawing.Size(100, 20);
			this.txtEspanol.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 24);
			this.label5.TabIndex = 7;
			this.label5.Text = "Español:";
			// 
			// btnPromedio
			// 
			this.btnPromedio.Location = new System.Drawing.Point(110, 341);
			this.btnPromedio.Name = "btnPromedio";
			this.btnPromedio.Size = new System.Drawing.Size(75, 23);
			this.btnPromedio.TabIndex = 9;
			this.btnPromedio.Text = "PROMEDIO";
			this.btnPromedio.UseVisualStyleBackColor = true;
			this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 450);
			this.Controls.Add(this.btnPromedio);
			this.Controls.Add(this.txtEspanol);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtQuimica);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFisica);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Promedio";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMate;
		private System.Windows.Forms.TextBox txtFisica;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtQuimica;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEspanol;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPromedio;
	}
}

