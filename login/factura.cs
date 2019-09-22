using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace login
{
    public partial class factura : Form
    {
        string _name, _Address;
        int _Phone, _Card,_res1papa,_subtotal=0, _res1hamburguesa, _res1pollo, _res1sandwich, _res1burger, _res1desayuno, _res1Jamon, _res1peperoni, _res1supre;

        private void Button1_Click(object sender, EventArgs e)
        {

            Form shoppingCart = new Restaurante(_name, _Address, _Phone, _Card);
           

            shoppingCart.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public factura(string name, string Address, int Phone, int Card,int subtotal ,int res1papa, int res1hamburguesa, int res1pollo, int res1sandwich, int res1burger, int res1desayuno, int res1Jamon, int res1peperoni, int res1supre)
        {
            InitializeComponent();
            _name = name;
            _Address = Address;
            _Phone = Phone;
            _Card = Card;
            _res1papa = res1papa;
            _res1hamburguesa = res1hamburguesa;
            _res1pollo = res1pollo;
            _res1sandwich = res1sandwich;
            _res1burger = res1burger;
            _res1desayuno = res1desayuno;
            _res1Jamon = res1Jamon;
            _res1peperoni = res1peperoni;
            _res1supre = res1supre;
            _subtotal = subtotal;
        }



        public class FacturaFile
        {

            private int facturaID;
            private string clientName;


            public FacturaFile(string Nombre, int factura)
            {
                clientName = Nombre;
                facturaID = factura;
            }

            public void exportBilltoFile(string listItems, string ClientAdress, int ClientSubtotal)
            {
                string path = @"C:\temp\" + this.facturaID + ".txt";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Factura #" + this.facturaID);
                        sw.WriteLine("Nombre:" + this.clientName);
                        sw.WriteLine("Direccion:" + ClientAdress);



                        sw.WriteLine("Detalles: \n " + listItems);


                        sw.WriteLine("Subtotal:" + ClientSubtotal);
                        sw.WriteLine("ISV:" + (ClientSubtotal * .15));
                        sw.WriteLine("Total:" + ((ClientSubtotal * .15) + ClientSubtotal));


                    }
                }

            }
        }

            private void Factura_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            Random randometa = new Random();
            int id = random.Next();
           

            this.labelFactura.Text = Convert.ToString(id);
            this.labelName.Text = _name;
            this.labelDireccion.Text = _Address;
            if (_res1papa != 0)
                this.listPedido.Items.Add(_res1papa + " - unidades de Papa de Kentucky Fried Chicken");
            if (_res1hamburguesa != 0)
                this.listPedido.Items.Add(_res1hamburguesa + " - unidades de Hamburguesa de Kentucky Fried Chicken");
            if (_res1pollo != 0)
                this.listPedido.Items.Add(_res1pollo + " - unidades de Pollo de Kentucky Fried Chicken");
            if (_res1sandwich != 0)
                this.listPedido.Items.Add(_res1sandwich + " - unidades de Sandwich de Dennys");
            if (_res1burger != 0)
                this.listPedido.Items.Add(_res1burger + " - unidades de Hamburguesa de Dennys");
            if (_res1desayuno != 0)
                this.listPedido.Items.Add(_res1desayuno + " - unidades de Desayuno de Dennys");
            if (_res1Jamon != 0)
                this.listPedido.Items.Add(_res1Jamon + " - unidades de Pizza de Jamon de Pizza Hut");
            if (_res1peperoni != 0)
                this.listPedido.Items.Add(_res1peperoni + " - unidades de Pizza de Pepperoni de Pizza Hut");
            if (_res1supre != 0)
                this.listPedido.Items.Add(_res1supre + " - unidades de Pizza Suprema de Pizza Hut");
            this.labelSubtotal.Text = Convert.ToString(_subtotal);
            this.labelIVA.Text = Convert.ToString(_subtotal*.15);
            this.labelTotal.Text = Convert.ToString((_subtotal * .15)+_subtotal);
            this.labelETA.Text= Convert.ToString(randometa.Next(20,45)+" Minutos");
            string items="";
            foreach (string item in listPedido.Items)
            {
                items += item.ToString() + "\n";
            }

            FacturaFile facturareport = new FacturaFile(_name, id);
            facturareport.exportBilltoFile(items, _Address, _subtotal);


            }
        }
    }

