using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ConnectionClassL;



namespace ConexionClass
{
    public class ConexionBDD
    {
        
        static public string sql = "SELECT usuario, contraseña FROM usuarios WHERE usuario ='" + txtUser.Text + "' AND contraseña='" + txtContraseña.Text + "'";
       


    }
}
