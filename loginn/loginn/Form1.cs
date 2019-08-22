using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usuario = nombre.text;
            string contra = contraseña.text;
            if (usuario == "juancho"&&contra=="123frijoles")
            {
                MessageBox.Show("Bienvenido a Pompom Land! (●´ω｀●)");
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado. (￣□￣) ")
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Contraseña_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
