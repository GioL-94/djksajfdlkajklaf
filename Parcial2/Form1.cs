using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {

        Camisa cam = new Camisa();
        Pantalon pan = new Pantalon();
        int forma;
        int calidad;
        double PrecioF;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboTipo.Items.Add("Camisa");
            comboTipo.Items.Add("Pantalón");
            checkBermuda.Enabled = false;
            checkMcorta.Enabled = false;
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboTipo.SelectedIndex == 0)
            {
                checkBermuda.Enabled = false;
                checkMcorta.Enabled = true;
            }
            else
            {
                checkBermuda.Enabled = true;
                checkMcorta.Enabled = false;
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            
            if(comboTipo.SelectedIndex == 0)
            {
                

                cam.setPrecioBase(Convert.ToDouble(txtPrecio.Text));
                cam.setCantidad(Convert.ToInt32(txtCantidad.Text));

                if (checkMcorta.Checked)
                {
                    forma = 1;
               
                }
                else
                {
                    forma = 0;
                }

                if (radioPrem.Checked)
                {
                    calidad = 2;
                }
                else
                {
                    calidad = 1;
                }

                cam.setForma(forma);
                cam.setCalidad(calidad);
                PrecioF = Convert.ToDouble(cam.CalcularPrecio());
                MessageBox.Show("Precio Final: " + PrecioF);

                comboTipo.DataSource = null;

            }
            else{

                pan.setPrecioBase(Convert.ToDouble(txtPrecio.Text));
                pan.setCantidad(Convert.ToInt32(txtCantidad.Text));

                if (checkBermuda.Checked)
                {
                    forma = 1;
                }
                else
                {
                    forma = 0;
                }

                if (radioPrem.Checked)
                {
                    calidad = 2;
                }
                else
                {
                    calidad = 1;
                }

                pan.setForma(forma);
                pan.setCalidad(calidad);

                PrecioF = Convert.ToDouble(pan.CalcularPrecio());


                MessageBox.Show("Precio Final: " + PrecioF);

                

            }

        }


    }
}
