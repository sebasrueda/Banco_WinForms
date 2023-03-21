using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller2_SebastiánRueda
{
    public partial class Form1 : Form
    {
        Cuenta cuenta = new Cuenta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            cuenta.numero_cuenta = txtNumeroCuenta.Text;
            cuenta.nombre = txtNombreCliente.Text;
            cuenta.tipo_cuenta = cbTipoCuenta.Text;

            if (cuenta.numero_cuenta == "")
            {
                groupBoxTransacciones.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtDepositar.Text);
            cuenta.deposito(cantidad);
            listBoxCuenta.Items.Add("Número de cuenta bancaria: " + cuenta.numero_cuenta + ". Monto depositado: " + cantidad + " pesos.");
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtRetirar.Text);
            if( cuenta.retiro(cantidad) )
            {
                listBoxCuenta.Items.Add("Número de cuenta bancaria: " + cuenta.numero_cuenta + ". Monto retirado: " + cantidad + " pesos.");
            }
            else
            {
                listBoxCuenta.Items.Add("Número de cuenta bancaria: " + cuenta.numero_cuenta + ". Operación no válida, saldo insuficiente.");
            }
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Estado de cuenta:" + "\n" + "Número de cuenta: " + cuenta.numero_cuenta + "\n" + "Nombre del cliente: " + cuenta.nombre + "\n" + "Tipo de cuenta: " + cuenta.tipo_cuenta + "\n" + "\n" + "Saldo: " + cuenta.balance.ToString() + " pesos." +  "\n" + "\n" + DateTime.Now.ToString() );
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            txtNumeroCuenta.Clear();
            txtNombreCliente.Clear();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtDepositar.Clear();
        }

        private void btnLimpiar3_Click(object sender, EventArgs e)
        {
            txtRetirar.Clear();
        }
    }
}
