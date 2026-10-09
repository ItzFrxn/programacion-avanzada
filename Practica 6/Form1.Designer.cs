namespace Practica_6
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtDeposito = new System.Windows.Forms.TextBox();
			this.btnDeposito = new System.Windows.Forms.Button();
			this.btnRetiro = new System.Windows.Forms.Button();
			this.txtRetiro = new System.Windows.Forms.TextBox();
			this.lstDeposito = new System.Windows.Forms.ListBox();
			this.lstRetiro = new System.Windows.Forms.ListBox();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(9, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(273, 39);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "MOVIMIENTOS";
			// 
			// txtDeposito
			// 
			this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDeposito.Location = new System.Drawing.Point(16, 92);
			this.txtDeposito.Name = "txtDeposito";
			this.txtDeposito.Size = new System.Drawing.Size(100, 29);
			this.txtDeposito.TabIndex = 1;
			this.txtDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
			// 
			// btnDeposito
			// 
			this.btnDeposito.Location = new System.Drawing.Point(16, 128);
			this.btnDeposito.Name = "btnDeposito";
			this.btnDeposito.Size = new System.Drawing.Size(100, 23);
			this.btnDeposito.TabIndex = 2;
			this.btnDeposito.Text = "Realizar Deposito";
			this.btnDeposito.UseVisualStyleBackColor = true;
			this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
			// 
			// btnRetiro
			// 
			this.btnRetiro.Location = new System.Drawing.Point(169, 128);
			this.btnRetiro.Name = "btnRetiro";
			this.btnRetiro.Size = new System.Drawing.Size(100, 23);
			this.btnRetiro.TabIndex = 4;
			this.btnRetiro.Text = "Realizar Retiro";
			this.btnRetiro.UseVisualStyleBackColor = true;
			this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
			// 
			// txtRetiro
			// 
			this.txtRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRetiro.Location = new System.Drawing.Point(169, 92);
			this.txtRetiro.Name = "txtRetiro";
			this.txtRetiro.Size = new System.Drawing.Size(100, 29);
			this.txtRetiro.TabIndex = 3;
			this.txtRetiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
			// 
			// lstDeposito
			// 
			this.lstDeposito.FormattingEnabled = true;
			this.lstDeposito.Location = new System.Drawing.Point(12, 173);
			this.lstDeposito.Name = "lstDeposito";
			this.lstDeposito.Size = new System.Drawing.Size(113, 173);
			this.lstDeposito.TabIndex = 5;
			// 
			// lstRetiro
			// 
			this.lstRetiro.FormattingEnabled = true;
			this.lstRetiro.Location = new System.Drawing.Point(158, 173);
			this.lstRetiro.Name = "lstRetiro";
			this.lstRetiro.Size = new System.Drawing.Size(120, 173);
			this.lstRetiro.TabIndex = 6;
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaldo.Location = new System.Drawing.Point(42, 374);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(63, 24);
			this.lblSaldo.TabIndex = 7;
			this.lblSaldo.Text = "Saldo";
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.ForeColor = System.Drawing.Color.Lime;
			this.lblCantidad.Location = new System.Drawing.Point(111, 374);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(20, 24);
			this.lblCantidad.TabIndex = 8;
			this.lblCantidad.Text = "$";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 450);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lblSaldo);
			this.Controls.Add(this.lstRetiro);
			this.Controls.Add(this.lstDeposito);
			this.Controls.Add(this.btnRetiro);
			this.Controls.Add(this.txtRetiro);
			this.Controls.Add(this.btnDeposito);
			this.Controls.Add(this.txtDeposito);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form1";
			this.Text = "Banco Olmeca";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtDeposito;
		private System.Windows.Forms.Button btnDeposito;
		private System.Windows.Forms.Button btnRetiro;
		private System.Windows.Forms.TextBox txtRetiro;
		private System.Windows.Forms.ListBox lstDeposito;
		private System.Windows.Forms.ListBox lstRetiro;
		private System.Windows.Forms.Label lblSaldo;
		private System.Windows.Forms.Label lblCantidad;
	}
}

