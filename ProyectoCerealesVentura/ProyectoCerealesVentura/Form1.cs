using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCerealesVentura
{
    public partial class Inicio : Form
    {
        private TextBox oControls;
        private bool vacio;

        public Inicio()
        {
            InitializeComponent();
            Conexion2 ventu = new Conexion2();
            ventu.Registro();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btIngreso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A ingresado al sistema");

            Conexion2 ventu = new Conexion2();
            ventu.Registro();

            Menu FormRegister = new Menu();
            FormRegister.Show();
            this.Hide();

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //Todo es correcto, guardamos los datos
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }

        }

        private void btRegis_Click(object sender, EventArgs e)
        {
            RegistroEmpleados FormRegister = new RegistroEmpleados();
            FormRegister.Show();
            this.Hide();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtxcontra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
