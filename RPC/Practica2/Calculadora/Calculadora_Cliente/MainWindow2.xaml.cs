using Calculadora_Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculadora_Cliente
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RemoteInterface obj;
        public MainWindow()
        {
            InitializeComponent();

            //MessageBox.Show("De click en aceptar cuando el servidor este iniciado.");

            try
            {
                TcpChannel chan = new TcpChannel();
                ChannelServices.RegisterChannel(chan);

                // Create an instance of the remote object
                obj = (RemoteInterface)Activator.GetObject(typeof(RemoteInterface), "tcp://localhost:8888/cincom");
            }
            catch
            {
                // localhost OR your server name
                if (obj.Equals(null))
                {
                    System.Console.WriteLine("Error: unable to locate server");
                }
            }
        }

        bool shiftstate = false;
        string operacion = "";
        string valor1 = "";
        bool recienOperado = false;

        private void limpiarOperaciones()
        {
            if (recienOperado)
            {
                recienOperado = false;
                textBox1.Text = "";
            }
        }

        private void asignarValores()
        {

            if (valor1.Equals(""))
                valor1 = textBox1.Text;
            else
            {

                switch (operacion)
                {
                    case "+":
                        textBox1.Text = obj.suma((float)double.Parse(valor1), (float)double.Parse(textBox1.Text)).ToString();
                        break;

                    case "-":
                        textBox1.Text = obj.resta((float)double.Parse(valor1), (float)double.Parse(textBox1.Text)).ToString();
                        break;

                    case "x":
                        textBox1.Text = obj.multiplicacion((float)double.Parse(valor1), (float)double.Parse(textBox1.Text)).ToString();
                        break;

                    case "/":
                        textBox1.Text = obj.division((float)double.Parse(valor1), (float)double.Parse(textBox1.Text)).ToString();
                        break;

                    case "<<":
                        textBox1.Text = obj.correrAIzquierda(textBox1.Text);
                        break;

                    case ">>":
                        textBox1.Text = obj.correrADerecha(textBox1.Text);
                        break;

                    case "%":
                        textBox1.Text = obj.porcentaje((float)double.Parse(valor1), (float)double.Parse(textBox1.Text)).ToString();
                        break;

                    case "Mod":
                        textBox1.Text = obj.modulo((float)double.Parse(valor1), (float)double.Parse(textBox1.Text)).ToString();
                        break;

                    case "Inv":
                        textBox1.Text = obj.invertir(textBox1.Text);
                        break;
                }
                valor1 = textBox1.Text;
            }
            recienOperado = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "0";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + ".";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            asignarValores();
            operacion = "";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "3";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (shiftstate)
                operacion = "Inv";
            else
                operacion = "+";
            asignarValores();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "6";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (shiftstate)
                operacion = "-";
            else
                operacion = "<<";
            asignarValores();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            limpiarOperaciones();
            textBox1.Text = textBox1.Text + "9";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (shiftstate)
                operacion = ">>";
            else
                operacion = "x";
            asignarValores();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (shiftstate)
                operacion = "Mod";
            else
                operacion = "/";
            asignarValores();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            operacion = "%";
            asignarValores();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (shiftstate == true)
                shiftstate = false;
            else
                shiftstate = true;

            if (shiftstate)
            {
                button4.Content = "Mod";
                button5.Content = ">>";
                button9.Content = "<<";
                button13.Content = "Inv";
            }
            else
            {
                button4.Content = "/";
                button5.Content = "x";
                button9.Content = "-";
                button13.Content = "+";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor1 = "";
            operacion = "";
        }
    }
}
