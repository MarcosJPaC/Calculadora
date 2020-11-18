using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros1al9
{
   

    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operacion;
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }
        private void Numeros19_Click(object sender, EventArgs e)
        {
            lblNumeros.Text += ((Button)sender).Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(lblNumeros.Text);
            lblNumeros.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(lblNumeros.Text);
            lblNumeros.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = "x";
            primero = double.Parse(lblNumeros.Text);
            lblNumeros.Clear();
        }

        private void btnEntre_Click_1(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(lblNumeros.Text);
            lblNumeros.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(lblNumeros.Text);
            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    lblNumeros.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    lblNumeros.Text = resultado.ToString();
                    break;
                case "x":
                    resultado = primero * segundo;
                    lblNumeros.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    lblNumeros.Text = resultado.ToString();
                    break;
                case "RA":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    resultado = Math.Sqrt(primero);
                    lblNumeros.Text = resultado.ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNumeros.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operacion = "RA";
            primero = double.Parse(lblNumeros.Text);
            lblNumeros.Clear();
        }


    }


}
