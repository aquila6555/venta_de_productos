using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

//hola bienvenido lograste entrar a mi codigo como premio te guiare por aqui
//este codigo fue realizado por JD
namespace two
{
    public partial class Form1 : MetroForm
    {
        //nombramos a los registros del usuario como item 
        ListViewItem Item;
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //boton Acerca de
            Form2 Form2 = new Form2();
            //muestra el formulario 4
            Form2.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int subTotal=0, cantidad=0, precio;
            
            cantidad = int.Parse(txtCantidad.Text);
            precio = int.Parse(txtPrecio.Text);


            subTotal = cantidad * precio;

            double descuento = 0;
            
  
            
            if (cantidad >= 10)
            {
                descuento = subTotal * 0.15;
            }
            else {
                if (cantidad >= 20)
                {
                    descuento = subTotal * 0.30;
                }
                else
                {
                    descuento = 0;
                }
            }           

            double total;            
           
            total = subTotal + descuento;

            //mostramos el total en un label oculto ;)
            this.lblPago.Text = total.ToString();





            //copiamos los datos que el usuario ingresa hacia el listView 
            ListViewItem Registrar = new ListViewItem(txtNombre.Text);
            Registrar.SubItems.Add(cboProductos.Text);
            Registrar.SubItems.Add(txtCantidad.Text);
            Registrar.SubItems.Add(txtPrecio.Text);
            Registrar.SubItems.Add(subTotal.ToString());
            Registrar.SubItems.Add(descuento.ToString());
            Registrar.SubItems.Add(total.ToString());
            //importante! para registrar todo
            lvDetalle.Items.Add(Registrar);

            //limpiamos los texbox para que el usuario pueda ingresar mas registros
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Item != null)
            {
                lvDetalle.Items.Remove(Item);

            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void btnLImpiar_Click(object sender, EventArgs e)
        {
            lvDetalle.Items.Clear();
        }
    }

}

//espero haberte ayudado si tienes dudas contactame a mi correo con gusto te respondere
//aquila6555@gmail.com
//repite: Quiero, Puedo y Lo voy a lograr.
//Que tengas un lindo dia :)
