using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace pjHiperShop
{
    public partial class frmHipershop : Form
    {
        public frmHipershop()
        {
            InitializeComponent();
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
            pictureBox2.Visible= false;
            pictureBox2.Visible = true;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Visible = false;
            pictureBox1.Visible = true;



        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            Application.Exit();
      
        }

       /* private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }*/
    }
}
