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
    public partial class Restaurante : Form
    {

        string clientName, clientAddress;
        int clientPhone, ClientCard;
        int Clientres1papa = 0,Clientsubtotal =0;
        public Restaurante(string _Nombre,string _Direccion, int _Celular,int _Tarjeta)
        {
            InitializeComponent();
            clientName = _Nombre;
            clientAddress = _Direccion;
            clientPhone = _Celular;
            ClientCard = _Tarjeta;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            int Clientres1Desayuno = Int32.Parse(this.textBox6.Text);
            Clientres1Desayuno++;
            Clientsubtotal = Clientsubtotal + 120;
            this.textBox6.Text = Convert.ToString(Clientres1Desayuno);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox2.Text) > 0)
            {
                int Clientres1Hamburguesa = Int32.Parse(this.textBox2.Text);
                Clientres1Hamburguesa--;
                Clientsubtotal = Clientsubtotal - 95;
                this.textBox2.Text = Convert.ToString(Clientres1Hamburguesa);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int Clientres1Hamburguesa = Int32.Parse(this.textBox2.Text);
            Clientres1Hamburguesa++;
            Clientsubtotal = Clientsubtotal + 95;
            this.textBox2.Text = Convert.ToString(Clientres1Hamburguesa);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox3.Text) > 0)
            {
                int Clientres1pollo = Int32.Parse(this.textBox3.Text);
                Clientres1pollo--;
                Clientsubtotal = Clientsubtotal - 240;
                this.textBox3.Text = Convert.ToString(Clientres1pollo);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int Clientres1pollo = Int32.Parse(this.textBox3.Text);
            Clientres1pollo++;
            Clientsubtotal = Clientsubtotal + 240;
            this.textBox3.Text = Convert.ToString(Clientres1pollo);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox6.Text) > 0)
            {
                int Clientres1Desayuno = Int32.Parse(this.textBox6.Text);
                Clientres1Desayuno--;
                Clientsubtotal = Clientsubtotal - 120;
                this.textBox6.Text = Convert.ToString(Clientres1Desayuno);
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox5.Text) > 0)
            {
                int Clientres1CheseeBurguer = Int32.Parse(this.textBox5.Text);
                Clientres1CheseeBurguer--;
                Clientsubtotal = Clientsubtotal - 230;
                this.textBox5.Text = Convert.ToString(Clientres1CheseeBurguer);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            int Clientres1CheseeBurguer = Int32.Parse(this.textBox5.Text);
            Clientres1CheseeBurguer++;
            Clientsubtotal = Clientsubtotal + 230;
            this.textBox5.Text = Convert.ToString(Clientres1CheseeBurguer);
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            if (Int32.Parse(this.textBox4.Text) > 0)
            {
                int Clientres1ClubSandwich = Int32.Parse(this.textBox4.Text);
                Clientres1ClubSandwich--;
                Clientsubtotal = Clientsubtotal - 180;
                this.textBox4.Text = Convert.ToString(Clientres1ClubSandwich);
            }
            
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int Clientres1ClubSandwich = Int32.Parse(this.textBox4.Text);
            Clientres1ClubSandwich++;
            Clientsubtotal = Clientsubtotal + 180;
            this.textBox4.Text = Convert.ToString(Clientres1ClubSandwich);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox9.Text) > 0)
            {
                int Clientres1Suprema = Int32.Parse(this.textBox9.Text);
                Clientres1Suprema--;
                Clientsubtotal = Clientsubtotal - 315;
                this.textBox9.Text = Convert.ToString(Clientres1Suprema);
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            int Clientres1Suprema = Int32.Parse(this.textBox9.Text);
            Clientres1Suprema++;
            Clientsubtotal = Clientsubtotal + 315;
            this.textBox9.Text = Convert.ToString(Clientres1Suprema);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox8.Text) > 0)
            {
                int Clientres1Peperoni = Int32.Parse(this.textBox8.Text);
                Clientres1Peperoni--;
                Clientsubtotal = Clientsubtotal - 180;
                this.textBox8.Text = Convert.ToString(Clientres1Peperoni);
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            int Clientres1Peperoni = Int32.Parse(this.textBox8.Text);
            Clientres1Peperoni++;
            Clientsubtotal = Clientsubtotal + 180;
            this.textBox8.Text = Convert.ToString(Clientres1Peperoni);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox7.Text) > 0)
            {
                int Clientres1jamon = Int32.Parse(this.textBox7.Text);
                Clientres1jamon--;
                Clientsubtotal = Clientsubtotal - 200;
                this.textBox7.Text = Convert.ToString(Clientres1jamon);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            int Clientres1jamon = Int32.Parse(this.textBox7.Text);
            Clientres1jamon++;
            Clientsubtotal = Clientsubtotal + 200;
            this.textBox7.Text = Convert.ToString(Clientres1jamon);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int Clientres1papa = Int32.Parse(this.textBox1.Text);
            Clientres1papa++;
            Clientsubtotal = Clientsubtotal + 65;
            this.textBox1.Text = Convert.ToString(Clientres1papa);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox1.Text) > 0) { 
                int Clientres1papa = Int32.Parse(this.textBox1.Text);
                Clientres1papa--;
                Clientsubtotal = Clientsubtotal - 65;
                this.textBox1.Text = Convert.ToString(Clientres1papa);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Form fact = new factura(clientName, clientAddress, clientPhone, ClientCard, Clientsubtotal, Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text), Int32.Parse(this.textBox3.Text), Int32.Parse(this.textBox4.Text), Int32.Parse(this.textBox5.Text), Int32.Parse(this.textBox6.Text), Int32.Parse(this.textBox7.Text), Int32.Parse(this.textBox8.Text), Int32.Parse(this.textBox9.Text));
            this.Close();
            fact.Show();
            

        }
    }
}
