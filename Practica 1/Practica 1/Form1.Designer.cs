namespace Practica_1
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
			this.txtValor1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtValor2 = new System.Windows.Forms.TextBox();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MintCream;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Operaciones de Valores";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(87, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor 1:";
			// 
			// txtValor1
			// 
			this.txtValor1.Location = new System.Drawing.Point(164, 111);
			this.txtValor1.Name = "txtValor1";
			this.txtValor1.Size = new System.Drawing.Size(100, 20);
			this.txtValor1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(88, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Valor 2:";
			// 
			// txtValor2
			// 
			this.txtValor2.Location = new System.Drawing.Point(164, 155);
			this.txtValor2.Name = "txtValor2";
			this.txtValor2.Size = new System.Drawing.Size(100, 20);
			this.txtValor2.TabIndex = 4;
			// 
			// btnSumar
			// 
			this.btnSumar.BackColor = System.Drawing.Color.MintCream;
			this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSumar.Location = new System.Drawing.Point(89, 225);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(69, 34);
			this.btnSumar.TabIndex = 5;
			this.btnSumar.Text = "+";
			this.btnSumar.UseVisualStyleBackColor = false;
			this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
			// 
			// btnRestar
			// 
			this.btnRestar.BackColor = System.Drawing.Color.MintCream;
			this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestar.Location = new System.Drawing.Point(89, 319);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(69, 34);
			this.btnRestar.TabIndex = 6;
			this.btnRestar.Text = "-";
			this.btnRestar.UseVisualStyleBackColor = false;
			this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.BackColor = System.Drawing.Color.MintCream;
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(195, 225);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(69, 34);
			this.btnMultiplicar.TabIndex = 7;
			this.btnMultiplicar.Text = "x";
			this.btnMultiplicar.UseVisualStyleBackColor = false;
			this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
			// 
			// btnDividir
			// 
			this.btnDividir.BackColor = System.Drawing.Color.MintCream;
			this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Location = new System.Drawing.Point(195, 319);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(69, 34);
			this.btnDividir.TabIndex = 8;
			this.btnDividir.Text = "/";
			this.btnDividir.UseVisualStyleBackColor = false;
			this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(357, 450);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.txtValor2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtValor1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Operaciones";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValor1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtValor2;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnDividir;
	}
}

