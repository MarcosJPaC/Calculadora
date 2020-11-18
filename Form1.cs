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
        double valor1, valor2;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Numeros19_Click(object sender, EventArgs e)
        {
            string textoboton= ((Button)sender).Text;
            switch (textoboton)
            {
                case "RA":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadolog = Math.Log(valor1);
                    lblNumeros.Text = resultadolog + "";
                    break;
                case "Sen":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadosen = Math.Sin(valor1);
                    lblNumeros.Text = resultadosen + "";
                    break;
                case "Cos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadocos = Math.Cos(valor1);
                    lblNumeros.Text = resultadocos + "";
                    break;
                case "Tan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadotan = Math.Tan(valor1);
                    lblNumeros.Text = resultadotan + "";
                    break;
                case "Log":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado = Math.Sqrt(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "+":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "X":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "=":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                        case "+":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = valor1 + valor2 + "";
                            break;
                        case "-":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = valor1 - valor2 + "";
                            break;
                        case "X":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = valor1 * valor2 + "";
                            break;
                        case "/":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = valor1 / valor2 + "";
                            break;

                    }
                    break;
                case "CE":
                    lblNumeros.Clear();
                    break;
                case ".":
                    if (lblNumeros.Text.IndexOf(".")==-1)
                    {
                        lblNumeros.Text += textoboton;
                    }
                    break;
                default:
                    lblNumeros.Text += ((Button)sender).Text;
                    break;

            }
        }
    }
}




