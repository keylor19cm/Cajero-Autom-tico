using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automático
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        Usuario usuarioActual = new Usuario();
        Usuario Saldo = new Usuario();
        
        //Esta parte es para el deposito//
        private void btndeposi_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtdeposi.Text, out decimal monto) && monto > 0)
            {
                usuarioActual.Saldo += monto;
                ActualizarSaldo();
                MessageBox.Show("Depósito exitoso. Saldo actual: $" + usuarioActual.Saldo, "Información del Sistema", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Monto de depósito inválido. Por favor, ingresa un monto válido.", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Esta parte es para el retiro//
        private void btnreti_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtretiro.Text, out decimal monto) && monto > 0 && monto <= usuarioActual.Saldo)
            {
                usuarioActual.Saldo -= monto;
                ActualizarSaldo();
                MessageBox.Show("Retiro exitoso. Saldo actual: $" + usuarioActual.Saldo, "Información del Sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Monto de retiro inválido. Asegúrate de tener saldo suficiente.", "Información del Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Es para ir actualizando el saldo//
        private void ActualizarSaldo()
        {
           
        }

        //Es para salir a la pantalla de cajero automático//
        private void btnsal_Click(object sender, EventArgs e)
        {
            txtdeposi.Text = "";
            txtretiro.Text = "";
            DialogResult resultado = MessageBox.Show("Esta Seguro que quiere salir", "Información del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }
    }

}