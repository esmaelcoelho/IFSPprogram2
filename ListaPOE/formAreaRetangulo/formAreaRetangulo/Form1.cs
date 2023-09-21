using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formAreaRetangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btmResultado_Click(object sender, EventArgs e)
        {
            Class1 s = new Class1();
            s.setB(int.Parse(txtNum1.Text));
            s.setA(int.Parse(txtNum2.Text));
            s.calcular();
            lblResultado.Text = s.getresultado().ToString();
        }
    }
}
