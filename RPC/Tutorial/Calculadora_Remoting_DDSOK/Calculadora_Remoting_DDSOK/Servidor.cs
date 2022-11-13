using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Security.Permissions;


namespace Calculadora_Remoting_DDSOK
{
    public partial class Servidor : Form
    {
        public Servidor()
        {
            InitializeComponent();
        }

        bool aux = false;


        private void button1_Click(object sender, EventArgs e)
        {


            if (aux)
                Application.Exit();

            InitializeComponent();
            TcpChannel channel = new TcpChannel(8888);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteClass), "cincom", WellKnownObjectMode.SingleCall);
            MessageBox.Show("El servidor esta listo...");
            System.Console.ReadLine();
            button1.Text = "Detener Servicio";

            aux = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
