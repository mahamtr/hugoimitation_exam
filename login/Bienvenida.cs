using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace login
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

    
        private void Button1_Click(object sender, EventArgs e)
        {
             string _nombre, _direccion;
             int _celular, _tarjeta;

            _nombre = this.textBox1.Text;
            _direccion = this.textBox2.Text;
            _celular = Int32.Parse(this.textBox3.Text="0");
            _tarjeta = Int32.Parse(this.textBox4.Text="0");

            Form shoppingCart = new Restaurante(_nombre, _direccion, _celular, _tarjeta);

           
            shoppingCart.Show();
            
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
