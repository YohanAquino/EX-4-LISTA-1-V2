using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_4_lista_1_V2
{
    public partial class Form1 : Form
    {
        private Triangulo triangulo = new Triangulo();
        public Form1()
        {
            InitializeComponent();
            txt_altura.Text = triangulo.getAltura().ToString();
            txt_base.Text = triangulo.getBase().ToString();
            txt_area.Text = triangulo.getArea().ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            triangulo.setAltura(double.Parse(txt_altura.Text));
            triangulo.setBase(double.Parse(txt_base.Text));
            triangulo.calcularArea();
            txt_area.Text = triangulo.getArea().ToString();
        }
    }
}
