using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_14
{
    public partial class Form1 : Form
    {
                                                                                      //variables

        int ladoA, ladoB, ladoC;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton consultar

            //valida que no haya textbox vacios
            if (string.IsNullOrEmpty(medida1Tb.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }

            if (string.IsNullOrEmpty(medida2Tb.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }
            if (string.IsNullOrEmpty(medida3Tb.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }

                ladoA = int.Parse(medida1Tb.Text);
                    ladoB = int.Parse(medida2Tb.Text);
                        ladoC = int.Parse(medida3Tb.Text);
            

            // validaciones textbox

            if (ladoA == 0)
            {
                MessageBox.Show("Lado A no puede ser igual a 0");
                return;
            }

            if (ladoB == 0)
            {
                MessageBox.Show("Lado B no puede ser igual a 0");
                return;
            }



            if (ladoA + ladoB + ladoC != 180)
            {
                MessageBox.Show("Lados deben sumar 180°");
                return;
            }

            //Inicio Proceso


            //condiciones para evaluar el tipo de triangulo segun los lados ingresados

            if (ladoA == 90 || ladoB == 90 || ladoC == 90)
            {
                tipoTriangulo.Text = Convert.ToString("Rectangulo");

                Graphics papel4;//triangulo rectangulo  
                papel4 = pictureBox4.CreateGraphics();
                Pen lápiz4 = new Pen(Color.Black);

                papel4.DrawLine(lápiz4, 20, 80, 20, 10);
                papel4.DrawLine(lápiz4, 20, 10, 120, 80);
                papel4.DrawLine(lápiz4, 20, 80, 120, 80);

                MessageBox.Show("El triangulo es un Triangulo Rectangulo");
                return;
                
            }

            if (ladoA == ladoB && ladoB != ladoC || ladoB == ladoC && ladoB != ladoA || ladoC == ladoA && ladoC != ladoB)
            {
                tipoTriangulo.Text = Convert.ToString("Isosceles");

                Graphics papel2;//triangulo isosceles 
                papel2 = pictureBox2.CreateGraphics();
                Pen lápiz2 = new Pen(Color.Black);

                papel2.DrawLine(lápiz2, 50, 80, 70, 10);
                papel2.DrawLine(lápiz2, 70, 10, 90, 80);
                papel2.DrawLine(lápiz2, 50, 80, 90, 80);

                MessageBox.Show("El triangulo es un Triangulo Isosceles");
                return;
            }

            if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
            {
                tipoTriangulo.Text = Convert.ToString("Escaleno");

                Graphics papel3;//triangulo escaleno 
                papel3 = pictureBox3.CreateGraphics();
                Pen lápiz3 = new Pen(Color.Black);

                papel3.DrawLine(lápiz3, 20, 80, 40, 40);
                papel3.DrawLine(lápiz3, 40, 40, 120, 80);
                papel3.DrawLine(lápiz3, 20, 80, 120, 80);

                MessageBox.Show("El triangulo es un Triangulo Escaleno");
                return;
            }
            if (ladoA == ladoB && ladoA == ladoC)
            {
                tipoTriangulo.Text = Convert.ToString("Equilatero");

                Graphics papel;//triangulo equilatero  
                papel = pictureBox1.CreateGraphics();
                Pen lápiz = new Pen(Color.Black);

                papel.DrawLine(lápiz, 20, 80, 70, 10);
                papel.DrawLine(lápiz, 70, 10, 120, 80);
                papel.DrawLine(lápiz, 20, 80, 120, 80);

                MessageBox.Show("El triangulo es un Triangulo Equilatero");
                return;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void medida3Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void medida1Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void salirBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otraconsultaBt_Click(object sender, EventArgs e)
        {
            medida1Tb.Clear();
            medida2Tb.Clear();
            medida3Tb.Clear();
            tipoTriangulo.Text = String.Empty;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            medida1Tb.Focus();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
