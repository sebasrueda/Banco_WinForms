namespace Taller2_SebastiánRueda
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTransacciones = new System.Windows.Forms.GroupBox();
            this.btnEstadoCuenta = new System.Windows.Forms.Button();
            this.listBoxCuenta = new System.Windows.Forms.ListBox();
            this.groupBoxRetirar = new System.Windows.Forms.GroupBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.groupBoxDepositar = new System.Windows.Forms.GroupBox();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.cbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.btnLimpiar3 = new System.Windows.Forms.Button();
            this.groupBoxTransacciones.SuspendLayout();
            this.groupBoxRetirar.SuspendLayout();
            this.groupBoxDepositar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(97, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(97, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de cuenta";
            // 
            // groupBoxTransacciones
            // 
            this.groupBoxTransacciones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxTransacciones.Controls.Add(this.btnEstadoCuenta);
            this.groupBoxTransacciones.Controls.Add(this.listBoxCuenta);
            this.groupBoxTransacciones.Controls.Add(this.groupBoxRetirar);
            this.groupBoxTransacciones.Controls.Add(this.groupBoxDepositar);
            this.groupBoxTransacciones.Location = new System.Drawing.Point(24, 184);
            this.groupBoxTransacciones.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxTransacciones.Name = "groupBoxTransacciones";
            this.groupBoxTransacciones.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxTransacciones.Size = new System.Drawing.Size(1079, 338);
            this.groupBoxTransacciones.TabIndex = 3;
            this.groupBoxTransacciones.TabStop = false;
            this.groupBoxTransacciones.Text = "Transacciones";
            // 
            // btnEstadoCuenta
            // 
            this.btnEstadoCuenta.Location = new System.Drawing.Point(596, 248);
            this.btnEstadoCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.Size = new System.Drawing.Size(155, 32);
            this.btnEstadoCuenta.TabIndex = 3;
            this.btnEstadoCuenta.Text = "Estado de cuenta";
            this.btnEstadoCuenta.UseVisualStyleBackColor = true;
            this.btnEstadoCuenta.Click += new System.EventHandler(this.btnEstadoCuenta_Click);
            // 
            // listBoxCuenta
            // 
            this.listBoxCuenta.FormattingEnabled = true;
            this.listBoxCuenta.ItemHeight = 18;
            this.listBoxCuenta.Location = new System.Drawing.Point(369, 42);
            this.listBoxCuenta.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.listBoxCuenta.Name = "listBoxCuenta";
            this.listBoxCuenta.Size = new System.Drawing.Size(662, 184);
            this.listBoxCuenta.TabIndex = 2;
            // 
            // groupBoxRetirar
            // 
            this.groupBoxRetirar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxRetirar.Controls.Add(this.btnLimpiar3);
            this.groupBoxRetirar.Controls.Add(this.btnRetirar);
            this.groupBoxRetirar.Controls.Add(this.txtRetirar);
            this.groupBoxRetirar.Location = new System.Drawing.Point(34, 184);
            this.groupBoxRetirar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxRetirar.Name = "groupBoxRetirar";
            this.groupBoxRetirar.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxRetirar.Size = new System.Drawing.Size(299, 122);
            this.groupBoxRetirar.TabIndex = 1;
            this.groupBoxRetirar.TabStop = false;
            this.groupBoxRetirar.Text = "Retirar";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(34, 74);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(114, 32);
            this.btnRetirar.TabIndex = 1;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(34, 40);
            this.txtRetirar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(227, 26);
            this.txtRetirar.TabIndex = 0;
            // 
            // groupBoxDepositar
            // 
            this.groupBoxDepositar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxDepositar.Controls.Add(this.btnLimpiar2);
            this.groupBoxDepositar.Controls.Add(this.txtDepositar);
            this.groupBoxDepositar.Controls.Add(this.btnDepositar);
            this.groupBoxDepositar.Location = new System.Drawing.Point(34, 42);
            this.groupBoxDepositar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxDepositar.Name = "groupBoxDepositar";
            this.groupBoxDepositar.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxDepositar.Size = new System.Drawing.Size(299, 134);
            this.groupBoxDepositar.TabIndex = 0;
            this.groupBoxDepositar.TabStop = false;
            this.groupBoxDepositar.Text = "Depositar";
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(37, 47);
            this.txtDepositar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(227, 26);
            this.txtDepositar.TabIndex = 1;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(34, 81);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(114, 32);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(271, 28);
            this.txtNumeroCuenta.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(355, 26);
            this.txtNumeroCuenta.TabIndex = 4;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(271, 64);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(355, 26);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(676, 43);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(114, 32);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(512, 550);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 32);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.Location = new System.Drawing.Point(676, 82);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(114, 32);
            this.btnLimpiar1.TabIndex = 2;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = true;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(157, 81);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(107, 32);
            this.btnLimpiar2.TabIndex = 3;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Items.AddRange(new object[] {
            "Ahorros",
            "Corriente"});
            this.cbTipoCuenta.Location = new System.Drawing.Point(271, 104);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(357, 26);
            this.cbTipoCuenta.TabIndex = 9;
            // 
            // btnLimpiar3
            // 
            this.btnLimpiar3.Location = new System.Drawing.Point(157, 73);
            this.btnLimpiar3.Name = "btnLimpiar3";
            this.btnLimpiar3.Size = new System.Drawing.Size(107, 32);
            this.btnLimpiar3.TabIndex = 4;
            this.btnLimpiar3.Text = "Limpiar";
            this.btnLimpiar3.UseVisualStyleBackColor = true;
            this.btnLimpiar3.Click += new System.EventHandler(this.btnLimpiar3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1136, 617);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar1);
            this.Controls.Add(this.cbTipoCuenta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.groupBoxTransacciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de cuenta bancaria";
            this.groupBoxTransacciones.ResumeLayout(false);
            this.groupBoxRetirar.ResumeLayout(false);
            this.groupBoxRetirar.PerformLayout();
            this.groupBoxDepositar.ResumeLayout(false);
            this.groupBoxDepositar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxTransacciones;
        private System.Windows.Forms.Button btnEstadoCuenta;
        private System.Windows.Forms.ListBox listBoxCuenta;
        private System.Windows.Forms.GroupBox groupBoxRetirar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.GroupBox groupBoxDepositar;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.ComboBox cbTipoCuenta;
        private System.Windows.Forms.Button btnLimpiar3;
    }
}

