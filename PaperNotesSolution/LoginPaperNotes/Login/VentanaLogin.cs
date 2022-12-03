using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using ConnectionClassL; //importamos nuestra class library


namespace LoginPaperNotes
{
    public partial class Login : Form
    {
        /// <summary>
        /// Login principal
        /// </summary>
       
        public Login()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        /// <summary>
        /// Conexion a la base de datos mediante libreria de clases
        /// </summary>
        public void conexion() //metodo para llamar al classLibrary (ConnectionClassL)
        { 
            
            ConexionBD conexionBD = new ConexionBD(); //inicializamos la clase
            string user = txtUser.Text; //asignamos los valores de user y contraseña
            string contra = txtContraseña.Text;
            conexionBD.Conexion(user,contra); //pasamos los parametros a nuestro metodo
        }
    

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            conexion(); //ejecutamos el metodo
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Introduzca su usuario") //condicional para vaciar el textbox
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") //condicional para llenar el textbox
            {
                txtUser.Text = "Introduzca su usuario";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Introduzca su contraseña") //condicional para vaciar el textbox
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true; //ocultando los caracteres de la contraseña
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "") //condicional para llenar el textbox
            {
                txtContraseña.Text = "Introduzca su contraseña";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
