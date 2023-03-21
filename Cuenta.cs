using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Taller2_SebastiánRueda
{
    public class Cuenta
    {
        #region "atributos"
        private string nombreCliente;
        private double balanceCliente;
        private string cuentaCliente;
        private string tipoCuenta;
        #endregion

        #region "propiedades"
        public string nombre
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public double balance
        {
            get { return balanceCliente; }
        }

        public string numero_cuenta
        {
            get { return cuentaCliente; }
            set { cuentaCliente = value; }
        }

        public string tipo_cuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }
        #endregion

        #region "metodos"
        public void deposito(double cantidad)
        {
            balanceCliente += cantidad;
        }

        public bool retiro(double cantidad)
        {
            if(balanceCliente >= cantidad)
            {
                balanceCliente -= cantidad;
                return true;
            }
            else
            {
                MessageBox.Show("Fondos insuficuentes." + "\n" + "Operación no válida.");
                return false;
            }
        }
        #endregion
    }
}
