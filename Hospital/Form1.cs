using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Est
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap imagen = new Bitmap(Application.StartupPath + @"\img\Est.jpg");
            btnimagen.Image = imagen;

            Bitmap image = new Bitmap(Application.StartupPath + @"\img\paso.png");
            btnimagen2.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
