using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPaperNotes
{
    public partial class Splash : Form
    {
        /// <summary>
        /// Splash que aparecera al ejecutar la aplicacion
        /// </summary>
        public Splash()
        {
            InitializeComponent();
            
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1500;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ciclo while para ir desvaneciendo el splash
            while  (this.Opacity > 0)
            {
                this.Opacity-=0.00001;

            }
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            
            this.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
